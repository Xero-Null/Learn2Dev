# Learn2Dev
This repository will be used to upload my YouTube channel Learn2Dev's source code. The channel is located at: https://www.youtube.com/user/Learn2Dev



1) Download and install git from: https://git-scm.com/downloads (I'm currently using version 2.17.1.2)
2) Download and install Visual Studio from: https://visualstudio.microsoft.com/ (I'm currently using VS2017)

3) Create a new folder on your C:/ drive, name it Learn2Dev

4) Launch Git Bash

5) Type: cd C:/Learn2Dev

6) Type: git init

7) Type: git remote add https://github.com/Xero-Null/Learn2Dev.git

8) Type: git pull origin master

Now you have the most up to date version of the Learn2Dev repository.

To go to the beginning of the tutorial series, type:
1) git reset --hard f6649a14903abe8adfa8328acf1625b60c37dc2d
2) git clean -f

Note: You can replace f6649a14903abe8adfa8328acf1625b60c37dc2d with another commit, if you want to reset to a different version.

When at a lower commit version and you want to navigate forward by one commit type:
git reset HEAD@{1}

If you have a repository that you need to bring up to the current commit version, type:
git pull origin master

If you made changes to the files and need to reset, type: git reset --hard HEAD
