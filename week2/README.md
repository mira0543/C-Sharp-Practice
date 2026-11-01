# Chapter 2 — Processing Data


## Topics

1. ## Reading Input with TextBox Controls
2. ## A First Look at Variables
3. ## Numeric Data Types and Variables
4. ## Performing Calculations
5. ## Inputting and Outputting Numeric Values
6. ## Formatting Numbers with the ToString Method
7. ## Simple Exception Handling
8. ## Using Named Constants

---

##  Reading Input with TextBox Controls

A **TextBox** is a rectangular control that accepts keyboard input. You can find it under **Common Controls** in the Toolbox. Its default name is `textBox1`, `textBox2`, etc.

### The Text Property

The **Text** property stores the user's input as a **string**, even when the user types a number.

The Text property stores what the user types. The content can be cleared by assigning an empty string or using the Clear method.

## 3.2 A First Look at Variables

A **variable** is a storage location in memory. Its name identifies that location. A variable must be **declared** with a data type before it is used.

A variable declaration specifies a data type and a variable name.

### Data Types

A **data type** specifies the kind of data a variable can hold. The slides group types into primitive/basic types (including integral, floating-point, `char`, `bool`, and `string`) and non-primitive types (including collections and user-defined types).

### Variable Names

Choose meaningful names. A name must begin with a letter or underscore, cannot contain spaces, and cannot be a reserved keyword.

### String Variables and Concatenation

A **string** contains characters, such as names and phone numbers. String values are enclosed in double quotation marks. **Concatenation** joins strings using `+`, including strings combined with numbers.

Concatenation can join text with numeric values.

### Declaring, Initializing, and Using Variables

- You may declare a variable first and assign a value later, but a local variable must have a value before it is read.
- You can declare multiple variables of the same type in one statement, in one declaration.
- **Local variable:** declared inside a method and accessible only within its scope. Its lifetime ends when the method finishes.
- **Duplicate names:** two variables cannot have the same name in the same scope; the same name may appear in different methods.
- **Assignment compatibility:** the assigned value must be compatible with the variable's data type.

**Example from the chapter:** The *String Variable Demo* combines a first name and last name and displays the full name in a Label. The *Birth Date String* form is a home assignment.

## Numeric Data Types and Variables

Use numeric data types when numbers will be used in calculations.

| Type | Description |
|---|---|
| `int` | Stores whole numbers |
| `double` | Stores real numbers, including fractional parts |
| `decimal` | Stores real numbers with greater precision; often used in financial applications |

### Numeric Literals

A **numeric literal** is a number written directly in code. Whole-number literals are treated as `int`, decimal-point literals as `double`, and a suffix `m` or `M` marks a `decimal` literal.

### Assignment Compatibility and Casting

- An `int` variable accepts `int` values, not `double` or `decimal` values directly.
- A `double` variable accepts `double` and `int` values, not `decimal` directly.
- A `decimal` variable accepts `decimal` and `int` values, not `double` directly.
- **Casting** explicitly converts a value to another type, using a type name in parentheses, using a type name in parentheses.

### The `var` Keyword

`var` lets the compiler determine a **local variable's type** from its initial value. A `var` declaration must include an initialization value.

## Performing Calculations

C# uses arithmetic operators to perform calculations.

| Operator | Operation |
|---|---|
| `+` | Addition |
| `-` | Subtraction |
| `*` | Multiplication |
| `/` | Division |
| `%` | Modulus (remainder) |

### Calculation Rules

Use the **order of operations** and parentheses to group calculations. When combining `int` with `double`, the result is `double`; combining `int` with `decimal` produces `decimal`. Direct calculations between `double` and `decimal` are not allowed.

### Integer Division

Dividing one `int` by another `int` gives an integer result. The chapter illustrates how the fractional part is discarded in integer division. To obtain a fractional result, use a `double` value or cast an operand to `double`.

## Inputting and Outputting Numeric Values

A TextBox stores keyboard input as **text**, so numeric input must be converted before calculations.

| Method | Purpose |
|---|---|
| `int.Parse()` | Converts a numeric string to `int` |
| `double.Parse()` | Converts a numeric string to `double` |
| `decimal.Parse()` | Converts a numeric string to `decimal` |
| `ToString()` | Converts a value to a string for display |

Numeric input is converted before calculations, and numeric results are converted to strings for display.

The chapter also shows culture-specific number formatting, and the **Fuel Economy** form as a home assignment.

## Formatting Numbers with the ToString Method

`ToString()` can format a number for display.
Format Purpose Example "N" Number format 12.300 "F" Fixed-point format 123456.00 "E" Exponential format 1.235e+005 "C" Currency format $1,234.56 "P" Percentage format 23.40%

## Simple Exception Handling

An **exception** is an unexpected runtime error, such as invalid input, dividing by zero, or attempting to open a missing file. Unhandled exceptions can stop a program.

### `try` and `catch`

- **`try` block:** contains statements that might cause an exception.
- **`catch` block:** contains statements that respond when an exception occurs.
- **Throwing:** an error occurs or is raised.
- **Catching:** the program handles the error.
- **`Exception.Message`:** provides the exception's default error description; the chapter displays it using `ex.Message`.

The chapter demonstrates exception handling with a **fuel economy calculation** and a classroom practice exercise.

## Named Constants

A **named constant** represents a value that **cannot change** while the program runs. Declare one with the `const` keyword.

The chapter uses an interest-rate constant as an example.

Uppercase constant names are traditional, but not required.


---
