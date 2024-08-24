Coffee Machine

## Overview

The Coffee Machine is a simple C# console application that simulates the process of making different types of coffee. The user can select from a list of coffee options, and the program will simulate brewing the selected coffee.

## Features

- **User Input**: The user is prompted to choose from four types of coffee: Espresso, Americano, Cappuccino, and Latte.
- **Simulated Brewing Process**: The application simulates the time it takes to brew the coffee, adding a fun, interactive element.
- **Console Output**: The program provides feedback in the console, informing the user when the coffee is ready.

## Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) (Version 6.0 or later)

## Getting Started

### 1. Clone the Repository

First, clone the repository to your local machine:

```bash
git clone https://github.com/yourusername/CoffeeMachine.git
cd CoffeeMachine
```

### 2. Build and Run the Application

To build and run the Coffee Machine application:

```bash
dotnet build
dotnet run
```

### 3. Using the Coffee Machine

After running the application, you'll be prompted to select a type of coffee:

```plaintext
Welcome to the Coffee Machine!
Please select a coffee type:
1. Espresso
2. Americano
3. Cappuccino
4. Latte
Enter your choice (1-4):
```

Enter a number between 1 and 4 to select your coffee. The program will then simulate the brewing process, and after a short wait, your coffee will be "ready."

## Code Structure

- **CoffeeInstruction.cs**: The main file containing all the logic for the Coffee Machine simulation.

### Methods

- **`GetUserChoice()`**: Prompts the user for input and validates the choice.
- **`BrewCoffee(int choice)`**: Outputs a message based on the selected coffee type and starts the brewing simulation.
- **`SimulateBrewingProcess()`**: Simulates the brewing process with a simple delay and console output.

## Contributing

If you'd like to contribute to this project, please fork the repository and submit a pull request. Contributions for additional features or improvements are welcome!

## License

This project is licensed under the MIT License.
