<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Object Storage ALiYun OSS

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.objectstorage.aliyun)](https://github.com/GameFrameX/com.gameframex.unity.objectstorage.aliyun/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.objectstorage.aliyun)](https://github.com/GameFrameX/com.gameframex.unity.objectstorage.aliyun/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使

<br />

[文档](https://gameframex.doc.alianblank.com) · [快速开始](#快速开始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## 项目简介

**Object Storage 阿里云 OSS 组件** - 提供 Object Storage 组件的阿里云对象存储服务（OSS）实现。本包实现了 `ALiYunObjectStorageManager`，运行时与编辑器均支持上传、下载文件和目录到/从阿里云 OSS 存储桶，阿里云 OSS SDK 位于 Plugins 目录。

## 使用示例

```csharp
using GameFrameX.ObjectStorage.Runtime;
using GameFrameX.ObjectStorage.ALiYun.Runtime;

// 通过工厂创建并初始化管理器
IObjectStorageManager manager = ObjectStorageManagerFactory.Create<ALiYunObjectStorageManager>(new ObjectStorageOptions
{
    AccessKey = "your-access-key",
    SecretKey = "your-secret-key",
    BucketName = "your-bucket",
    Endpoint = "oss-cn-shenzhen.aliyuncs.com",  // 阿里云必填
    SavePath = "bundles/android",
});

// 上传单个文件（对象键 = SavePath + 文件名）
manager.UploadFile(new ObjectStorageUploadOptions { LocalPath = "local/file.bundle" });

// 下载单个对象（自动创建本地目录）
manager.DownloadFile(new ObjectStorageDownloadOptions
{
    ObjectKey = "bundles/android/file.bundle",
    LocalPath = "downloads/file.bundle",
});
```

## 快速开始

### 安装

选择以下任一方式：

1. 编辑 Unity 项目的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：
   ```json
   {
     "scopedRegistries": [
       {
         "name": "GameFrameX",
         "url": "https://gameframex.upm.alianblank.uk",
         "scopes": [
           "com.gameframex"
         ]
       }
     ],
     "dependencies": {
       "com.gameframex.unity.objectstorage.aliyun": "1.1.0"
     }
   }
   ```

   `scopes` 控制哪些包通过此注册表解析。只有以 `com.gameframex` 开头的包才会从这个注册表获取。

2. 直接在 `manifest.json` 的 `dependencies` 节点下添加以下内容：
   ```json
   {
      "com.gameframex.unity.objectstorage.aliyun": "https://github.com/gameframex/com.gameframex.unity.objectstorage.aliyun.git"
   }
   ```
3. 在 Unity 的 `Package Manager` 中使用 `Git URL` 的方式添加库，地址为：`https://github.com/gameframex/com.gameframex.unity.objectstorage.aliyun.git`
4. 直接下载仓库放置到 Unity 项目的 `Packages` 目录下，会自动加载识别。
## 平台支持

| 平台 | 支持 |
|------|------|
| Windows | 是 |
| macOS | 是 |
| Linux | 是 |
| Android | 是 |
| iOS | 是 |

## 文档与资源

- [文档](https://gameframex.doc.alianblank.com)
- [GitHub 仓库](https://github.com/GameFrameX/com.gameframex.unity.objectstorage.aliyun)

## 社区与支持

- QQ群：通过 [二维码](https://qm.qq.com/cgi-bin/qm/qr?k=ikT9gA5m2sKwOyNOfYmQvSAPK_c3GmD6) 加入


## 依赖

| 包 | 说明 |
|----|------|
| (无) | - |


## 更新日志

查看 [Releases](https://github.com/GameFrameX/gameframex/com.gameframex.unity.objectstorage.aliyun/releases) 了解更新日志。
## 开源协议

详见 [LICENSE.md](LICENSE.md) 文件。
