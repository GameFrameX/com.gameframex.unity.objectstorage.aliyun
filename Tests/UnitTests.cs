using GameFrameX.ObjectStorage.ALiYun.Runtime;
using GameFrameX.ObjectStorage.Editor;
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
        public void Create_ReturnsAliyunUploadManager()
        {
            // 工厂按类型参数创建阿里云上传管理器：本地凭证构造，无网络 I/O。
            Assert.IsNotNull(_manager);
            Assert.IsInstanceOf<ALiYunObjectStorageUploadManager>(_manager);
        }
    }
}