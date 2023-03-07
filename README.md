# ref-kissy-games

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
