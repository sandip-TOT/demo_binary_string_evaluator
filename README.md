# Binary String Evaluator

## Overview

The **Binary String Evaluator** is a C# console application designed to evaluate binary strings based on specific criteria. A binary string is considered "good" if it satisfies the following conditions:
1. It contains an equal number of `0`s and `1`s.
2. For every prefix of the string, the number of `1`s is not less than the number of `0`s.

## Features

- Validates input to ensure it consists only of binary digits (`0`s and `1`s).
- Checks if the binary string meets the defined criteria for being "good".
- Outputs the evaluation result for a set of predefined test cases.

## Installation

To run this application, you need to have the .NET SDK installed on your machine. You can download it from the [.NET official website](https://dotnet.microsoft.com/download).

### Steps to Run

1. **Clone the Repository** (if applicable):
    ```bash
    git clone https://github.com/sandip-TOT/demo_binary_string_evaluator.git
    cd demo_binary_string_evaluator
    ```

2. **Open the Project**:
    Open the project in your preferred C# development environment (e.g., Visual Studio, Visual Studio Code).

3. **Build the Project**:
    Use the following command to build the project:
    ```bash
    dotnet build
    ```

4. **Run the Application**:
    Use the following command to run the application:
    ```bash
    dotnet run
    ```

## Code Explanation

The main class, `BinaryStringEvaluator`, contains the logic to evaluate whether the input binary string is "good".

### Method: `IsGoodBinaryString`

- **Parameters**: 
  - `string binaryString`: A string consisting of `0`s and `1`s.
- **Returns**: 
  - `bool`: Returns `true` if the string is "good"; otherwise, returns `false`.
- **Logic**:
  - Counts the number of `0`s and `1`s.
  - Checks the prefix condition while iterating through the string.
  - Finally checks if the counts of `0`s and `1`s are equal.

### Main Method

The `Main` method includes a set of predefined test cases to demonstrate the functionality of the evaluator.

## Test Cases

The following test cases are used in the `Main` method:

```csharp
string[] testCases = { 
    "1100",   // Good: Equal number of 0's and 1's, prefix condition met
    "1010",   // Good: Equal number of 0's and 1's, prefix condition met
    "111000", // Not Good: More 1's than 0's initially
    "000111", // Good: Equal number of 0's and 1's, prefix condition met
    "1001",   // Not Good: Prefix has more 0's
    "010101", // Good: Equal number of 0's and 1's, prefix condition met
    "0011"    // Good: Equal number of 0's and 1's, prefix condition met
};
```

### Expected Output

When the application is run, the output will indicate whether each binary string is "good":

```
Binary string: 1100, is good: True
Binary string: 1010, is good: True
Binary string: 111000, is good: False
Binary string: 000111, is good: True
Binary string: 1001, is good: False
Binary string: 010101, is good: True
Binary string: 0011, is good: True
```

## Exception Handling

The application handles invalid input by throwing an `ArgumentException` if the input string contains characters other than `0` or `1`.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue to discuss improvements.

## Acknowledgments

- This application uses C# and the .NET framework.
