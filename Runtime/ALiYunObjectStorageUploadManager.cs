using System;
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
    /// 阿里云的对象存储
    /// 示例文档：  https://help.aliyun.com/zh/oss/developer-reference/preface-4?spm=a2c4g.11186623.0.i1#section-alq-mv2-lfb
    /// SDK：https://github.com/aliyun/aliyun-oss-csharp-sdk
    /// </summary>
    public sealed class ALiYunObjectStorageUploadManager : BaseObjectStorageUploadManager
    {
        private bool _isInit = false;
        private string _token;
        private OssClient _client;
        private string _bucketName;

        public override void Init(string accessKey, string secretKey, string bucketName, string endpoint)
        {
            if (string.IsNullOrEmpty(endpoint))
            {
                throw new Exception("endpoint 不能为空");
            }

            if (_isInit)
            {
                return;
            }

            ClientConfiguration clientConfiguration = new ClientConfiguration();
            clientConfiguration.ConnectionTimeout = 10000;
            clientConfiguration.EnalbeMD5Check = true;
            _client = new OssClient(endpoint, accessKey, secretKey);
            _bucketName = bucketName;
            _isInit = true;
        }


        protected override void UploadDirectoryInternal(string localDirectory)
        {
            var directoryInfo = new DirectoryInfo(localDirectory);
            var files = directoryInfo.GetFiles();
            foreach (var fileInfo in files)
            {
                var savePath = BucketSavePath + fileInfo.FullName.Substring(UploadRootPath.Length);
                string md5;
                using (var fs = File.Open(fileInfo.FullName, FileMode.Open))
                {
                    md5 = OssUtils.ComputeContentMd5(fs, fs.Length);
                }

                var meta = new ObjectMetadata() { ContentMd5 = md5 };
                var result = _client.PutObject(_bucketName, savePath, fileInfo.FullName, meta);
                if (result.HttpStatusCode != HttpStatusCode.OK)
                {
                    Debug.LogError($"上传文件失败,本地文件路径：{fileInfo.FullName}\n 目标存储路径:{savePath}");
                    Debug.LogError(result.ToString());
                }
            }

            var directories = directoryInfo.GetDirectories();
            foreach (var directory in directories)
            {
                if (directory.Name.StartsWith("."))
                {
                    continue;
                }

                UploadDirectoryInternal(directory.FullName);
            }
        }
    }
}