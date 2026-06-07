<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Object Storage ALiYun OSS

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.objectstorage.aliyun)](https://github.com/GameFrameX/com.gameframex.unity.objectstorage.aliyun/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.objectstorage.aliyun)](https://github.com/GameFrameX/com.gameframex.unity.objectstorage.aliyun/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援

<br />

[ドキュメント](https://gameframex.doc.alianblank.com) · [クイックスタート](#クイックスタート) · QQグループ: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)

</div>

## プロジェクト概要

**Object Storage ALiYun OSS コンポーネント** - Object Storage コンポーネントの Alibaba Cloud（ALiYun）オブジェクトストレージサービス（OSS）実装を提供します。このパッケージは ALiYun OSS のアップロードマネージャーを実装し、ファイルやディレクトリの ALiYun OSS バケットへのアップロードを可能にします。

## クイックスタート

### インストール

以下のいずれかの方法を選択してください：

1. Unity プロジェクトの `Packages/manifest.json` を編集し、`scopedRegistries` セクションを追加してください：
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

   `scopes` は、どのパッケージをこのレジストリから解決するかを制御します。`com.gameframex` で始まるパッケージのみがこのレジストリから取得されます。

2. `manifest.json` の `dependencies` に直接追加：
   ```json
   {
      "com.gameframex.unity.objectstorage.aliyun": "https://github.com/gameframex/com.gameframex.unity.objectstorage.aliyun.git"
   }
   ```
3. Unity の **Package Manager** で **Git URL** を使用して追加：`https://github.com/gameframex/com.gameframex.unity.objectstorage.aliyun.git`
4. リポジトリを Unity プロジェクトの `Packages` ディレクトリにクローンしてください。自動的に読み込まれます。
## プラットフォーム対応

| プラットフォーム | 対応 |
|-----------------|------|
| Windows | はい |
| macOS | はい |
| Linux | はい |
| Android | はい |
| iOS | はい |

## ドキュメントとリソース

- [ドキュメント](https://gameframex.doc.alianblank.com)
- [GitHub リポジトリ](https://github.com/GameFrameX/com.gameframex.unity.objectstorage.aliyun)

## コミュニティとサポート

- QQグループ：[QRコード](https://qm.qq.com/cgi-bin/qm/qr?k=ikT9gA5m2sKwOyNOfYmQvSAPK_c3GmD6)から参加


## 依存関係

| パッケージ | 説明 |
|----------|------|
| (无) | - |


## 変更履歴

[Releases](https://github.com/GameFrameX/gameframex/com.gameframex.unity.objectstorage.aliyun/releases) で変更履歴を確認してください。
## ライセンス

このプロジェクトは [LICENSE](LICENSE) ファイルに定義された条件に基づいてライセンスされています。
