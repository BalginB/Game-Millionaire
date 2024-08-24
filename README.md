# Millionaire WinForm Application

This project is a Windows Forms application that simulates the popular game show "Who Wants to Be a Millionaire?". The game challenges players with a series of multiple-choice questions, where each correct answer brings them closer to winning one million dollars. 

## Features

- **Question Bank**: The game includes a set of predefined questions, each with four possible answers. Only one answer is correct for each question.
  
- **Game Progression**: Players answer questions sequentially, progressing up a win table that represents their potential earnings. Each correct answer advances the player to the next level of the win table.

- **Lifelines**: The game includes a "50:50" lifeline, which removes two incorrect answers from the current question, making it easier to choose the correct one.

- **Milestone Levels**: Certain levels in the win table are designated as milestones. If a player reaches a milestone, they are guaranteed to leave with at least that amount of money, even if they answer a later question incorrectly.

- **End Game**: The game ends when the player either answers a question incorrectly or successfully answers all questions, winning one million dollars.

## Gameplay

1. The player is presented with a question and four possible answers.
2. The player selects an answer.
3. If the answer is correct, the player advances to the next question and their potential winnings increase.
4. If the answer is incorrect, the game ends, and the player leaves with the amount from the last milestone they reached.
5. The player can use a "50:50" lifeline once per game, which eliminates two incorrect answers from the current question.

## Code Structure

- **Game Class**: Manages the game logic, including question progression, answer checking, and win table management.
- **WinTable Class**: Manages the win levels and milestones, tracks the player's current progress, and determines the final prize in case of a loss.
- **Question Class**: Represents individual questions, each containing the question text and a list of possible answers.
- **Answer Class**: Represents an individual answer with a text and a boolean flag indicating whether it is correct.
- **GameForm Class**: Manages the user interface and handles interactions with the player.

## Getting Started

To run the application:
1. Clone the repository.
2. Open the solution in Visual Studio.
3. Build the solution.
4. Run the application.

## Screenshots
![image](https://github.com/user-attachments/assets/87a3f513-2bb1-4f87-adff-f8f71ea52fa4)

