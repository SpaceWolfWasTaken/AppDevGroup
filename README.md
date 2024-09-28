## Guide
This is the main branch. You do not push any commits to this branch.
This one acts more of a guideline on what to do.

### Workflow
- Select an issue you want to handle.
- Go to the specific week's branch if it exists```git checkout week{n}``` OR go to development ```git checkout development``` and branch out from there ```git checkout -b week{n}``` if the week branch does not exist.
- Create a new branch for your issue ```git checkout -b {issue}.```, branching off from the specific week. E.g. ```git checkout -b modal/user```.
- Write code for the issue, and push to your respective issue branch.
- Create a pull request (weel <- issue) to merge your code into the week branch. Delete the issue branch.
  ![image](https://github.com/user-attachments/assets/76ca699a-1460-4d9d-b970-7819abba4fc7)
- Once all week tasks are done, the branch will be merged to development branch. Do not delete the week branch.
- Profit?
