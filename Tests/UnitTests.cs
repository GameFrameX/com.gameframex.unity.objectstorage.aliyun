using GameFrameX.ObjectStorage.ALiYun.Runtime;
using GameFrameX.ObjectStorage.Runtime;
using NUnit.Framework;

namespace GameFrameX.ObjectStorage.ALiYun.Tests
{
    internal class UnitTests
    {
        IObjectStorageManager _manager;

        [SetUp]
        public void Setup()
        {
            _manager = ObjectStorageManagerFactory.Create<ALiYunObjectStorageManager>(new ObjectStorageOptions
            {
                AccessKey = "LTAI5z自己的KEY",
                SecretKey = "xhjzjj自己的秘钥",
                BucketName = "存储桶名称",
                Endpoint = "oss-cn-shenzhen.aliyuncs.com",
                SavePath = "test/aa/zz",
            });
        }

        [Test]
        public void Create_ReturnsAliyunManager()
        {
            // 工厂按类型参数创建阿里云管理器：本地凭证构造，无网络 I/O。
            Assert.IsNotNull(_manager);
            Assert.IsInstanceOf<ALiYunObjectStorageManager>(_manager);
        }
    }
}
