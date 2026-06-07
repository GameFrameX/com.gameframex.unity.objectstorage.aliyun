<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Object Storage ALiYun OSS

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.objectstorage.aliyun)](https://github.com/GameFrameX/com.gameframex.unity.objectstorage.aliyun/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.objectstorage.aliyun)](https://github.com/GameFrameX/com.gameframex.unity.objectstorage.aliyun/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使

<br />

[文檔](https://gameframex.doc.alianblank.com) · [快速開始](#快速開始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## 項目簡介

**Object Storage 阿里雲 OSS 組件** - 提供 Object Storage 組件的阿里雲物件儲存服務（OSS）實作。本套件實作了阿里雲 OSS 的上傳管理器，允許您上傳檔案和目錄到阿里雲 OSS 儲存桶。

## 快速開始

### 安裝

編輯 Unity 專案的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：

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
  ]
}
```

`scopes` 控制哪些套件透過此註冊表解析。只有以 `com.gameframex` 開頭的套件才會從這個註冊表取得。

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.objectstorage.aliyun": "1.1.0"
  }
}
```


## 平台支援

| 平台 | 支援 |
|------|------|
| Windows | 是 |
| macOS | 是 |
| Linux | 是 |
| Android | 是 |
| iOS | 是 |

## 文檔與資源

- [文檔](https://gameframex.doc.alianblank.com)
- [GitHub 倉庫](https://github.com/GameFrameX/com.gameframex.unity.objectstorage.aliyun)

## 社區與支援

- QQ群：透過 [二維碼](https://qm.qq.com/cgi-bin/qm/qr?k=ikT9gA5m2sKwOyNOfYmQvSAPK_c3GmD6) 加入


## 依賴

| 套件 | 說明 |
|------|------|
| (无) | - |


## 更新日誌

查看 [Releases](https://github.com/GameFrameX/gameframex/com.gameframex.unity.objectstorage.aliyun/releases) 了解更新日誌。
## 開源協議

本專案基於 [LICENSE](LICENSE) 文件中定義的條款授權。
