# れふときっしーの卒業お祝いゲーム

## Gitの準備
- github のアカウントを作る
  - https://github.co.jp/
- LINEグループのノートにアカウントを送る
  - Git リポジトリの管理者がわったーなので、順次権限を与えていきます
- PCにGitの環境構築をする
  - macの人：
    - homebrewのインストール（やってなければ）
      - https://brew.sh/index_ja
    - gh のインストール（terminal から github に気持ちよくログインするために）
    - brew install gh をたたく
    - gh で github にログイン
      - gh auth login をたたく
    - repository（みんなで共有するUnity プロジェクト）を任意のディレクトリ内にダウンロード
      - git clone https://github.com/wattah1002/ref-kissy-games.git をたたく
  - windowsの人：
    - wsl をインストール
      - https://learn.microsoft.com/ja-jp/windows/wsl/install
    - wsl 上で git の環境構築
      - https://learn.microsoft.com/ja-jp/windows/wsl/tutorials/wsl-git
    - repository（みんなで共有するUnity プロジェクト）を任意のディレクトリ内にダウンロード
      - git clone https://github.com/wattah1002/ref-kissy-games.git をたたく

##　Unity の準備
- バージョン：2020.3.36f1 
なければインストール．シーン名は他の人とかぶらないように分ましょう．

## Git の取り扱い方
Git にはブランチという概念があります。知らない人は↓を見たり調べたりしてみてください
- https://backlog.com/ja/git-tutorial/stepup/01/

### branch ルール
基本的にシーンごとにブランチを切る
- master: 最終的にみんなのミニゲームを集める本番環境です
- home: みんなのゲームを選ぶホーム画面の開発ブランチ
- ebichan: えびちゃんの開発ブランチ
- keichan: けいちゃんの開発ブランチ
- holly: ほりーの開発ブランチ
- shiba: しばの開発ブランチ
- kirari: きらりの開発ブランチ

### ブランチ関連のコマンド
```shell
// branch リストを見れます。今いる branch がハイライトされるので確認できます
git branch
// branch の移動ができます
git checkout ブランチ名
// 新しいブランチを作れます
git checkout -b ブランチ名
```

### 魔法のコマンド
```shell
git add .
git commit -m “コミットメッセージ”
git push origin ブランチ名
```

### 見本（けいちゃんが開発をするとすると）
```shell
repository を clone
git checkout keichan
Unity 上で編集
git add .
git commit -m “アセットを追加などをした（何を編集したかをここで書く）”
git push
また何か編集したら魔法のコマンドを繰り返す
```

## 気をつけること
- 他の人のシーンを触らない．触る必要がある場合は，他にそのシーンを触っている人がいるかどうかを確認する．
- master ブランチで作業しない．自分のブランチで作業する．必要に応じて新しくブランチを切る．
- Git に関して分からないことがあったら遠慮なくわったーに聞く


