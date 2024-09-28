## Guide
This is the main branch. You do not push any commits to this branch.
This one acts more of a guideline on what to do.

### Workflow
- Select an issue you want to handle.
- Go to the specific week's branch if it exists```git checkout week{n}``` OR go to development ```git checkout development``` and branch out from there ```git checkout -b week{n}``` if the week branch does not exist.
- Create a new branch for your issue ```git checkout -b {issue}.```, branching off from the specific week.
- Write code for the issue, and push to your respective issue branch.
- Create a pull request (issue -> week) to merge your code into the week branch.
- Once all week tasks are done, the branch will be merged to development branch.
- Profit?
