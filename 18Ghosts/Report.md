# 18 Ghosts

#### Miguel Feliciano a22002782

## Authorship

All code in this project was made by Miguel Feliciano.

## Code Arquitecture

For this project, I started by planning how to approach this game. I created the classes that I felt were necessary for the game, even tho I ended up creating more down the line.

I started by making the board, ghosts, dungeon, mirrors, portals and the instructions visible. I started by making them similarly to how I did them in previous projects but ended up optimizing them. 

When starting the game the class Program.cs will give the players the instructions for the game before calling the class Board.cs. This class runs the entire game, form creating the board to the movement of the pieces. This class will call upon other classes tho perform certain actions like calling the class Portal to check if the portal that the piece is trying to enter is facing the correct way.

I decided to take advantage of the "Variant for shorter play" and of being allowed to place the ghosts at random to facilitate the process since doing the placement manually would be a big task.


### Conclusion
To summarize, I believe this project pushed me to the limits of my knowledge, and even tho I'm not fully satisfied with the final product, I feel it shows an improvement in my knowledge of object oriented programming even tho there is much room for improvement.

## UML


## References

1- Class Powerpoints

2- http://www.codinghomework.com C# How To Program: Almost Chess





