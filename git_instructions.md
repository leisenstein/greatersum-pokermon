# Getting Started in Git

> These are instructions to start the project using GitHub.
<br /><br />

1. ```D:```
2. ```mkdir greatersum```
3. ```cd mkdir```
4. ```mkdir pokermon```
5. ```cd pokermon```
6. ```git init```
  * ```ls -la``` or ```git status```
7. ```touch .gitignore``` or ```notepad .gitignore```
  * Update the .gitignore file
8. ```git add .```
9. ```git commit -m "Initial .gitignore commit"```
10. Create Repo on GitHub.com called greatersum-pokermon
11. ```git remote add origin http://github.com/username/greatersum-pokermon.git```
12. ```git push -u origin master```
  * ```ls -la``` or ```git status```
13. ```touch README.md``` or ```notepad README.md```
14. ```git add .```
15. ```git commit -m "Add README"```
16. ```git push -u origin master```
17. Modify README.md directly from the GitHub.com website
18. ```git pull``` (to pull the changes down you made on the site)

----

Git Create Branches
<br /><br />

1. ```git checkout -b newBranchName``` // Create and Checkout new branch
2. ```git push -u origin newBranchName```  // Push new branch to remote repo

<br /><br /><br />
[Notes on git remote](http://stackoverflow.com/questions/5617211/what-is-git-remote-add-and-git-push-origin-master)
[Create remote branch](http://stackoverflow.com/questions/1519006/how-do-you-create-a-remote-git-branch)
