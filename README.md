# Elevens-Project1-

Course: CSC350H
Professor: Hao Tang

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