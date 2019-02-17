# Learn2Dev
This repository will used to upload my YouTube channel Learn2Dev's source code. The channel is located at: https://www.youtube.com/user/Learn2Dev



1) Download and install git from: https://git-scm.com/downloads (I'm currently using version 2.17.1.2)

2) Create a new folder on your C:/ drive, name it Learn2Dev

3) Launch Git Bash

4) Type: cd C:/Learn2Dev

5) Type: git init

6) Type: git remote add https://github.com/Xero-Null/Learn2Dev.git

7) Type: git pull origin master

Now you have the most up to date version of the Learn2Dev repository.

To go to the beginning of the tutorial series, type:
1) git reset --hard f6649a14903abe8adfa8328acf1625b60c37dc2d

and then type:
2) git clean -f

Note: You can replace f6649a14903abe8adfa8328acf1625b60c37dc2d with another commit, if you reset to a different version.

When at a lower commit version and you want to navigate forward by one commit type:
git reset HEAD@{1}

If you have a repository that you need to bring up to the current commit version, type:
git pull origin master
