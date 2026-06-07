<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Object Storage ALiYun OSS

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.objectstorage.aliyun)](https://github.com/GameFrameX/com.gameframex.unity.objectstorage.aliyun/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.objectstorage.aliyun)](https://github.com/GameFrameX/com.gameframex.unity.objectstorage.aliyun/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현

<br />

[문서](https://gameframex.doc.alianblank.com) · [빠른 시작](#빠른-시작) · QQ 그룹: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**

</div>

## 프로젝트 개요

**Object Storage ALiYun OSS 컴포넌트** - Object Storage 컴포넌트의 Alibaba Cloud(ALiYun) 오브젝트 스토리지 서비스(OSS) 구현을 제공합니다. 이 패키지는 ALiYun OSS 업로드 매니저를 구현하여 파일 및 디렉토리를 ALiYun OSS 버킷에 업로드할 수 있게 합니다.

## 빠른 시작

### 설치

Unity 프로젝트의 `Packages/manifest.json`을 편집하여 `scopedRegistries` 섹션을 추가하세요:

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

`scopes`는 이 레지스트리를 통해 어떤 패키지를 해석할지 제어합니다. `com.gameframex`로 시작하는 패키지만 이 레지스트리에서 가져옵니다.

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.objectstorage.aliyun": "1.1.0"
  }
}
```


## 플랫폼 지원

| 플랫폼 | 지원 |
|--------|------|
| Windows | 예 |
| macOS | 예 |
| Linux | 예 |
| Android | 예 |
| iOS | 예 |

## 문서 및 자료

- [문서](https://gameframex.doc.alianblank.com)
- [GitHub 리포지토리](https://github.com/GameFrameX/com.gameframex.unity.objectstorage.aliyun)

## 커뮤니티 및 지원

- QQ 그룹: [QR 코드](https://qm.qq.com/cgi-bin/qm/qr?k=ikT9gA5m2sKwOyNOfYmQvSAPK_c3GmD6)에서 가입

## 라이선스

이 프로젝트는 [LICENSE](LICENSE) 파일에 정의된 조건에 따라 라이선스가 부여됩니다.
