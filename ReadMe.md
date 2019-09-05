# Commanding the Console

## Tips and Tricks

- Making Commits:
    - Commit messages should be short and meaningful 
    - Make frequent commits
- VS Code Keyboard Shortcuts
    - **ctrl** + **`** for toggling the terminal window
    - **ctrl** + **k** followed by **s** to "Save All"

![Commit Messages](https://imgs.xkcd.com/comics/git_commit.png)

- 'git init' - This command is used to initalize (set up) a git repository in the current directory.
When a git repository is set up, there will be a hideen folder named ".git" that contains all the history of commits for that
repository.
- 'git add' - This command is used to stage un-tracked and modified files for a commit. If a file is not being tracked 
(and is not listed in .gitignore), this command will mark the file as a new item for the repository to track.
If a file has been modified, then this command will mark it as ready to be committed
- 'git status' - This command is used to give you the status of your code repository
- 'git commit' -m "message" - The commit command is used to save staged files to the repository. When a commit occurs, 
all of the files staged for comittal are compared against the last commit, and the changes between them becomes the new commit.
Additionally, the user is identified for the commit (typically by a username and e-mail) - this is called blame
- 'git pull' This command is used to get a remote repository and merge it with the local repository.
Remote repositories are typically hosted online
- 'git push' - This command is used to take the local repository and send/merge it with a remote repository.

## hopefully this works 
- wararsdaf