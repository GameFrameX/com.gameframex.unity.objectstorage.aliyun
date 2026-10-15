using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Aliyun.OSS;
using Aliyun.OSS.Common;
using Aliyun.OSS.Util;
using GameFrameX.ObjectStorage.Runtime;
using UnityEngine;

namespace GameFrameX.ObjectStorage.ALiYun.Runtime
{
    /// <summary>
    /// 阿里云的对象存储实现。支持上传、下载与列举对象。
    /// 示例文档：https://help.aliyun.com/zh/oss/developer-reference/preface-4
    /// SDK：https://github.com/aliyun/aliyun-oss-csharp-sdk
    /// </summary>
    public sealed class ALiYunObjectStorageManager : BaseObjectStorageManager
    {
        private OssClient _client;

        /// <summary>
        /// 使用阿里云凭证初始化。Endpoint 必填（如 oss-cn-shenzhen.aliyuncs.com），重复调用会被忽略。
        /// </summary>
        /// <param name="options">初始化参数</param>
        public override void Init(ObjectStorageOptions options)
        {
            if (options == null)
            {
                throw new ArgumentNullException("options");
            }

            if (string.IsNullOrEmpty(options.Endpoint))
            {
                throw new ArgumentException("阿里云对象存储的 endpoint 不能为空", "options");
            }

            if (_client != null)
            {
                return;
            }

            base.Init(options);

            ClientConfiguration clientConfiguration = new ClientConfiguration();
            clientConfiguration.ConnectionTimeout = 10000;
            clientConfiguration.EnalbeMD5Check = true;
            _client = new OssClient(options.Endpoint, options.AccessKey, options.SecretKey, clientConfiguration);
        }

        protected override bool UploadFileInternal(string objectKey, string localFilePath)
        {
            string contentMd5;
            using (FileStream fileStream = File.OpenRead(localFilePath))
            {
                contentMd5 = OssUtils.ComputeContentMd5(fileStream, fileStream.Length);
            }

            ObjectMetadata metadata = new ObjectMetadata { ContentMd5 = contentMd5 };
            PutObjectResult result = _client.PutObject(Options.BucketName, objectKey, localFilePath, metadata);
            if (result.HttpStatusCode != HttpStatusCode.OK)
            {
                Debug.LogError("上传文件失败，本地文件路径：" + localFilePath + " 对象键：" + objectKey + "\n" + result);
                return false;
            }

            return true;
        }

        protected override bool DownloadFileInternal(string objectKey, string localFilePath)
        {
            using (OssObject ossObject = _client.GetObject(Options.BucketName, objectKey))
            {
                using (Stream responseStream = ossObject.Content)
                using (FileStream fileStream = File.Create(localFilePath))
                {
                    responseStream.CopyTo(fileStream);
                }
            }

            return true;
        }

        protected override IEnumerable<string> ListObjectKeys(string prefix)
        {
            List<string> objectKeys = new List<string>();
            string marker = null;
            do
            {
                ListObjectsRequest request = new ListObjectsRequest(Options.BucketName)
                {
                    Prefix = prefix,
                    Marker = marker,
                    MaxKeys = 100
                };
                ObjectListing objectListing = _client.ListObjects(request);
                foreach (OssObjectSummary objectSummary in objectListing.ObjectSummaries)
                {
                    if (!string.IsNullOrEmpty(objectSummary.Key) && !objectSummary.Key.EndsWith("/"))
                    {
                        objectKeys.Add(objectSummary.Key);
                    }
                }

                marker = objectListing.IsTruncated ? objectListing.NextMarker : null;
            } while (marker != null);

            return objectKeys;
        }
    }
}
