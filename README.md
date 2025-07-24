# F# Lab Assignment and Salary Processing

This project contains two F# programs demonstrating various functional programming concepts and practical applications.

## Programs Overview

### LabAssignment.fsx

This script includes solutions to several F# programming tasks as part of a lab assignment, covering:

- Partial application with exponentiation functions (square, cube)
- Tail recursion examples for:
  - Product of all elements in a list
  - Product of all odd numbers from a given odd number down to 1
- Using the `map` function to trim whitespace from strings in a list
- Using `filter` and `reduce` (fold) functions with collections of integers and strings, including:
  - Filtering multiples of numbers
  - Summing filtered collections
  - Concatenating filtered strings

### test1.fsx

This script demonstrates practical data processing with salary data, including:

- Filtering high-income salaries (above 100,000)
- Calculating tax for salaries based on 2021 Federal Income Tax Brackets
- Incrementing salaries below a threshold using `map`
- Summing salaries within a specified range using `fold`
- Tail recursive function to sum multiples of 3 up to a given number

## Usage

To run the programs, execute the scripts using an F# interactive environment or compiler:

```bash
fsi LabAssignment.fsx
fsi test1.fsx
```

## Contributing

Contributions are welcome. Please fork the repository and submit pull requests for improvements or additional tasks.
