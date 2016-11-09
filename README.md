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
  - currentSceneを更新したら問題なし
- AssetBundleを使ってサブシーンとして読み込んだ場合
  - ライティング関係が適用されない
    - currentSceneを更新したら適用されるようになった
  - オブジェクトのstatic設定が適用されない

## 推測

- staticの設定はAssetBundle化すると読み込めなくなる？

## 追加

currentSceneを更新するとLightingウィンドウ上ではskyboxが適用されるようになったが、ゲーム上ではシェーダエラーのような状態に見える。
