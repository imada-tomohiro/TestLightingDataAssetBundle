## 概要

サブシーンをAssetBundleにしてLightingが読み込めるかの検証

## 検証結果

- AssetBundleを使わずメインシーンとして読み込んだ場合
  - 問題なし
- AssetBundleを使ってメインシーンとして読み込んだ場合
  - LightingDataAsset以外は適用される
  - オブジェクトのstatic設定が適用されない
- AssetBundleを使わずサブシーンとして読み込んだ場合
  - ライティング関係が適用されない
- AssetBundleを使ってサブシーンとして読み込んだ場合
  - ライティング関係が適用されない
  - オブジェクトのstatic設定が適用されない

## 推測

- LightingDataAssetはUnityEditor上でしかいじれない？
- staticの設定はサブシーンで読み込むと適用されない？
