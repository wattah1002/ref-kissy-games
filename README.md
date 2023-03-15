# Git で開発する準備 (Mac)

## 0. Github のアカウント作成とリポジトリの権限付与
- github のアカウントを作る（まだ持ってない人のみ）
  - https://github.co.jp/
- LINEグループのノートにアカウントを送る
  - Git リポジトリの管理者がわったーなので、順次権限を与えていきます

## 1.homebrewインストール後に、このコマンドを１つずつ入れてそれぞれエンターする

【M1の場合】

```
echo '# Set PATH, MANPATH, etc., for Homebrew.' >> /Users/r/.zprofile
echo 'eval "$(/opt/homebrew/bin/brew shellenv)"' >> /Users/r/.zprofile
eval "$(/opt/homebrew/bin/brew shellenv)"
```

【M2の場合】
```
    (echo; echo 'eval "$(/opt/homebrew/bin/brew shellenv)"') >> /Users/hikari/.zprofile
    eval "$(/opt/homebrew/bin/brew shellenv)"
```

「brew -v」のコマンドを入れてみて、「Homebrew 4.0.5」のように表示されたら設定完了。


## 2.Githubをダウンロードする
「brew install gh」のコマンドを入れる


## 3.ターミナル上でGithubにログインする
「gh auth login」のコマンドを入れる

```
? What account do you want to log into?  [Use arrows to move, type to filter]
> GitHub.com
  GitHub Enterprise Server
```

のように表示されるので、エンターをおす。

```
? What is your preferred protocol for Git operations?  [Use arrows to move, type to filter]
> HTTPS
  SSH
```

のように表示されるので、エンターをおす。

```
？　Authenticate Git with your GitHub credentials? (Y/n)
```

と聞かれるので、「Y」と打って、エンターをおす。

```
? How would you like to authenticate GitHub CLI?  [Use arrows to move, type to filter]
> Login with a web browser
  Paste an authentication token
```

のように表示されるので、エンターをおす。


```
! First copy your one-time code: AAAA-AAAA
Press Enter to open github.com in your browser... 
```

エンターをおすと、ブラウザが開くので、上の「AAAA-AAAA」に表示されている認証コードを打つ。

出てきたページで「Authorize github」のボタンを押して、パスワードを入れて認証する。

```
Congratulations, you're all set!
Your device is now connected.
```

が出てきたら、終了！

## 4.Githubからデータをダウンロードする

ダウンロードしたいフォルダを右クリックして、コピーを押す

ターミナルで、
```
cd /Users/hikari/Desktop
```

のように書いて、エンターを押す（「cd」が開くという命令文で、その後に半角スペースがあって、その後にはりつける）

```
git clone https://github.com/wattah1002/ref-kissy-games.git
```

を書いて、エンターを押す

すると、PC内のフォルダにデータがダウンロードされる

## 5.作ったファイルをアップロードする

「ref-kissy-games」のフォルダを右クリックして、コピーを押す

ターミナルで、
```
cd /Users/hikari/Desktop
```

のように書いて、エンターを押す（「cd」が開くという命令文で、その後に半角スペースがあって、その後にはりつける）


その後、１行ずつ入力する

```
git checkout shiba-game
git add .
git commit -m “（何を編集したかをここにメモとして書く）”
git push
```

# Git で開発する準備 (Windows)
- wsl をインストール（gitが使える環境が他にあれば，それでもOK）
  - https://learn.microsoft.com/ja-jp/windows/wsl/install
- wsl 上で git の環境構築
  - https://learn.microsoft.com/ja-jp/windows/wsl/tutorials/wsl-git
- repository（みんなで共有するUnity プロジェクト）を任意のディレクトリ内にダウンロード
  - `git clone https://github.com/wattah1002/ref-kissy-games.git` をたたく

# Unity の準備
- バージョン：2020.3.36f1 

# Git 補足
Git にはブランチという概念があります。知らない人は↓を見たり調べたりしてみてください
- https://backlog.com/ja/git-tutorial/stepup/01/

## branch ルール
基本的にシーンごとにブランチを切る
- master: 最終的にみんなのミニゲームを集める本番環境です
- home: みんなのゲームを選ぶホーム画面の開発ブランチ
- ebichan-game: えびちゃんの開発ブランチ
- keichan-game: けいちゃんの開発ブランチ
- holyy-game: ほりーの開発ブランチ
- shiba-game: しばの開発ブランチ
- kirari-game: きらりの開発ブランチ
- hiroppe-game: ひろっぺの開発ブランチ

## ブランチ関連のコマンド
```shell
// branch リストを見れます。今いる branch がハイライトされるので確認できます
git branch
// branch の移動ができます
git checkout ブランチ名
// 新しいブランチを作れます
git checkout -b ブランチ名
```

## branch を切って開発をする例
たとえば README を編集したいときは，master ブランチから readme 編集用のブランチを新しく切って，編集後 master に merge します．

```
// master ブランチからスタート
git checkout -b fix-readme
// readme を編集後
git add .
git commit -m "readmeを編集"
git push origin fix-readme
// master ブランチに移動
git checkout master
// master ブランチに fix-readme ブランチ をマージ
git merge fix-readme
// master ブランチのローカルで変更した分をリモートにアップロード
git push origin master
```

master ブランチが更新されたら，他の人は自分のブランチに変更分を取り込む．
```
// master ブランチに移動
git checkout master
// 更新分をダウンロード
git pull
// 自分のブランチに移動
git checkout shiba-game
// master ブランチの変更分を自分のブランチに取り込む
git merge master
```

# その他気をつけること
- 他の人のシーンを触らない．触る必要がある場合は，触っていそうな人に確認する．
- 他の人と同じ名前にならないようにシーンの命名を気をつける．
- master ブランチで作業しない．自分のブランチで作業する．必要に応じて新しくブランチを切る．
- Git に関して分からないことがあったら遠慮なくわったーに聞く
