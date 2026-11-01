# Chapter 3: Making Decisions

## Topics

1.  Decision Structures and the if Statement
2.  The if-else Statement
3.  Nested Decision Structures
4.  Logical Operators
5.  bool Variables and Flags
6.  Comparing Strings
7.  Preventing Data Conversion Exceptions with the TryParse Method
8.  Input Validation
9.  Radio Buttons and Check Boxes
10. The switch Statement
11. Introduction to List Boxes

## Decision Structures and the if Statement

A **control structure** determines the order in which a program's statements run. A **sequence structure** runs statements in order, while a **decision structure** runs particular statements only when a condition is met. Decision structures are also called **selection structures**.

The **if statement** is a single-alternative decision: it checks a Boolean condition, which is either `true` or `false`. If the condition is true, an action runs; otherwise, that action is skipped. For example, a program might award a bonus only when sales exceed a target.

### Relational Operators

| Operator | Meaning |
|---|---|
| `>` | Greater than |
| `<` | Less than |
| `>=` | Greater than or equal to |
| `<=` | Less than or equal to |
| `==` | Equal to |
| `!=` | Not equal to |

These operators compare two values and produce a true-or-false result.

---

## The if-else Statement

An **if-else statement** offers two possible paths. The program performs one action when the condition is true and a different action when it is false. It contains an **if clause** and an **else clause**.

**Chapter practice:** The test-score application calculates the average of three scores and can display a congratulatory message for a high average. The payroll-with-overtime form is included as a home assignment.

---

## Nested Decision Structures

A **nested decision structure** places one decision inside another, allowing the program to test several conditions in sequence.

**Chapter example:** A loan application first checks whether annual salary meets the minimum requirement of **40,000**. If it does, the program checks whether the applicant has worked at the current job for at least **2 years**. The result explains whether the applicant qualifies or which requirement was not met.

### The if-else-if Statement

An **if-else-if** structure checks multiple conditions in order. It is useful when the program must choose one result from several possibilities, such as assigning letter grades based on a test score.

---

## Logical Operators

Logical operators combine or reverse Boolean conditions, helping a program make decisions based on more than one requirement.

| Operator | Name | Meaning |
|---|---|---|
| `&&` | AND | True only when both conditions are true |
| `||` | OR | True when at least one condition is true |
| `!` | NOT | Reverses true to false, or false to true |

### Truth Tables

| First condition | Second condition | AND (`&&`) | OR (`||`) |
|---|---|---|---|
| true | true | true | true |
| true | false | false | true |
| false | true | false | true |
| false | false | false | false |

**NOT:** `!true` is false, and `!false` is true.

**Chapter practice:** A range-checker application checks whether an entered integer falls between **1 and 10**.

---

## bool Variables and Flags

A **bool variable** stores only `true` or `false`. It is often used as a **flag**, which signals whether a condition exists in a program.

- **true:** The condition exists.
- **false:** The condition does not exist.

**Chapter example:** A flag can indicate whether a person's points qualify them for a grandmaster status.

---

## Comparing Strings

Programs can compare text values using relational operators and string comparison methods.

| Method or operator | Purpose |
|---|---|
| `==` | Checks whether two strings are equal |
| `!=` | Checks whether two strings are different |
| `String.Compare()` | Compares two strings; a result of zero indicates equality |
| `CompareTo()` | Compares one string with another |

Strings can be compared with other string variables or with fixed text values.

---

## Preventing Data Conversion Exceptions with TryParse

A **data conversion exception** can happen when a program attempts to convert invalid text into a number. **TryParse** methods help prevent these exceptions by checking whether conversion succeeds.

| Method | Converts input to |
|---|---|
| `int.TryParse()` | Integer |
| `double.TryParse()` | Double-precision number |
| `decimal.TryParse()` | Decimal number |

TryParse reports whether conversion succeeded and uses the **out** keyword to provide the converted value.

---

## Input Validation

**Input validation** checks whether entered information is acceptable before a program uses it. Successful number conversion does not guarantee that the number makes sense.

For example, **999** is a valid integer, but it is not a reasonable number of hours worked in one week. A payroll program might allow hours greater than **0** and no more than **168**, while a test-score program might allow scores from **0 to 100**.

**Key distinction:** TryParse checks the *data type*; input validation checks whether the *value is acceptable*.

---

## Radio Buttons and Check Boxes

**Radio buttons** allow the user to choose one option from a group. Selecting one automatically deselects the others in that group. This is called **mutually exclusive selection**.

**Check boxes** allow the user to choose multiple options independently.

| Control | Typical use | Selection |
|---|---|---|
| RadioButton | Choose a favorite sport | One option in a group |
| CheckBox | Choose pizza toppings | Multiple options |

### Common Properties

| Property | Meaning |
|---|---|
| `Text` | The label displayed next to the control |
| `Checked` | A Boolean value indicating whether the control is selected |

### CheckedChanged Event

The **CheckedChanged** event occurs when a radio button's or check box's `Checked` property changes. An event handler can respond to that change.

---

## The switch Statement

A **switch statement** is a multiple-alternative decision structure. It selects an action based on the value of a variable or expression. It can replace an if-else-if structure when several choices depend on the same value.

| Part | Purpose |
|---|---|
| `switch` | Starts the multiple-choice decision |
| `case` | Defines a possible matching value and its actions |
| `break` | Ends a case's execution |
| `default` | Handles values that do not match any case; optional |

---

## Introduction to List Boxes

A **ListBox** displays a list of items and lets the user select an item.

### Common Properties

| Property | Purpose |
|---|---|
| `Text` | Gets the displayed text of the selected item |
| `Items` | Contains the items in the ListBox |
| `Items.Count` | Gives the total number of items |
| `SelectedItem` | Gets or sets the selected item |
| `SelectedIndex` | Gets or sets the selected item's position |

ListBox positions start at **0**, so the first item has index **0**. When nothing is selected, **SelectedIndex is -1**. Checking for a selection helps avoid errors when accessing SelectedItem.

### Text vs. SelectedItem

| Feature | `Text` | `SelectedItem` |
|---|---|---|
| Data type | string | object |
| Best for | Reading displayed text | Working with the selected item itself |
| No selection | May be empty | May be null |

### Managing ListBox Items

| Method | Purpose |
|---|---|
| `Items.Add()` | Adds an item |
| `Items.Remove()` | Removes a specified item |
| `Items.RemoveAt()` | Removes an item at a specified index |
| `Items.Clear()` | Removes all items |

**Important:** Removing an item by index requires a valid index. An invalid index causes an exception.
