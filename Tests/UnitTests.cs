using System;
using GameFrameX.ObjectStorage.ALiYun.Runtime;
using GameFrameX.ObjectStorage.Runtime;
using NUnit.Framework;

namespace GameFrameX.ObjectStorage.ALiYun.Tests
{
    internal class UnitTests
    {
        IObjectStorageUploadManager _manager;

        [SetUp]
        public void Setup()
        {
            _manager = ObjectStorageUploadFactory.Create<ALiYunObjectStorageUploadManager>("LTAI5z自己的KEY", "xhjzjj自己的秘钥", "存储桶名称", "oss-cn-shenzhen.aliyuncs.com");
            _manager.SetSavePath("test/aa/zz");
        }

        [Test]
        public void TestUpload()
        {
            _manager.UploadDirectory("./");
        }
    }
}