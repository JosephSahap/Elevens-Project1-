# Elevens-Project1-

Course: CSC350H
Professor: Hao Tang
Student: Joseph Sahap

[First Submission – Class Design & Partial Implementation]

The goal of this was to design the (Card, Board and Deck) classes and do partial implementation based on the UML.

What has been completed?

Card Class

Stores card suit and rank
Includes IsFaceCard() method and ToString() override

Deck Class

Initializes a full 52-card deck
Includes methods for shuffling and drawing cards


/////////
UML Design

Full UML is shown in uml.txt for (Card, Deck, Board, Game, and Player) classes
Includes attributes and method signatures

Partial Board Class

Class created with constructor
Some methods partially written

Next Steps:

Complete Board, Game, and Player class logic
Add move validation (sum to 11 or J, Q, K combo)
Implement game loop with win/loss check
Add user interaction (console-based for now)

////////////////////////////////////

[Second Submission – Progress Update]
After the first submission, these are the updates that have been made:

Completed the Board class:
    Implemented ReplaceCards() and HasValidMove()
    Cards can now be removed and replaced based on rules

Added Game class:
    Handles the main game loop
    Checks player moves for correctness
    Detects win/loss conditions

Added Player class:
    Tracks selected cards
    Handles card selection logic

Added move validation:
    Checks if 2 cards sum to 11
    Checks if 3 selected cards form a valid JQK set

Next Steps:
    Finish console-based user interaction in Program.cs
    Clean up code for edge cases and invalid inputs
    Prepare final README with compile/run instructions for final submission

////////////////////////////////////////////////////////////////////////////

[Final Submission – Full Implementation]
These are the final updates:

Added Program.cs to run the game in the console
The game now shows the current board with 9 face-up cards
Player can input card indexes to select and remove cards
Game checks for valid moves, and shows win/loss result
Restart logic is included when needed

/////////////////////////////////////////////////////////

### Summary (For Extra Credit)

It seemed very scary at first, but one thing that was a bit tricky was checking if 3 cards were J, Q, and K, and making sure they actually got removed and replaced correctly. I also had to figure out how to let the user interact with the game through the console by selecting card indexes. Since we didn’t go over classes much last semester because our professor changed, I had to review some class concepts on my own. I went to tutoring and also watched a few videos online to refresh my memory. This project helped me understand how to connect different classes and make them work together in one program. It also made me feel a bit more comfortable for writing and organizing code with multiple files. It seemed very scary at first but I'm glad that I was able to do it while having my job on the side.

Thank you for extending the time for us professor!

///////////////////////////////////////////////////

How to compile this?
Make sure u have the correct version of dotnet like [.NET 6.0 or later], I have [.NET 9.0.2] something...

Go to terminal and enter: 

cd ElevensGame
dotnet run

Then you can test it.