#  Game Development lab 04

From **Assignment 1**, I chose **Level 02**:

* **Path Navigation**: The player navigates through the path clearly highlighted with **purple neon** lighting and black area is just used for jumping nothing else.
* **Goal Detection**: Upon reaching the end of the path and touching the goal object, the goal's material color dynamically turns **Green**.
* **Scripting**: A custom script (`Goal.cs`) with the `OnTriggerEnter` function was used to detect the player collision and trigger the color change.
##  Gameplay Video link
https://drive.google.com/file/d/1Tm5KEq-SAy9AvlYtOGyTFtOZIYLRo8Ux/view?usp=sharing










##  Additional Feature: Goal Detection & Color Change

I have added an additional script, generated with AI assistance, to handle the goal interaction mechanism:

* *Functionality: When the player touches the goal object, the OnTriggerEnter trigger detects the collision, changes the goal's material color to **Green*, and logs "GAME COMPLETE!" in the console.
