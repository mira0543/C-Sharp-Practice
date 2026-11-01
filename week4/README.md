# Chapter 4: Loops

## Topics

- **1** The while Loop
- **2** The ++ and -- Operators
- **3** The for Loop
- **4** The do-while Loop

---

## The while Loop

A **while loop** repeats one or more statements as long as a Boolean condition is **true**. It is useful when a task needs to be repeated until a condition changes.

- **Boolean expression:** The true-or-false condition controlling the loop.
- **Loop body:** The statements repeated by the loop.
- **Iteration:** One complete execution of the loop body.
- **Counter variable:** Tracks how many times the loop runs.
- **Pretest loop:** The condition is checked **before** each iteration. If it starts false, the loop does not run.
- **Infinite loop:** A loop that continues without stopping, often because its condition never becomes false.

**Lesson example:** The *Ending Balance* form calculates a balance over several months, adding interest during each repetition. A modified version shows the balance for each month in a ListBox.

---

## The ++ and -- Operators

**Increment** means increasing a variable's value; **decrement** means decreasing it. C# provides two operators for changing a number by one.

| Operator | Meaning |
|---|---|
| `++` | Increase a variable by 1 |
| `--` | Decrease a variable by 1 |

### Prefix and Postfix

| Mode | Meaning |
|---|---|
| **Prefix** | Change the value first, then use it |
| **Postfix** | Use the old value first, then change it |

These operators are especially useful for loop counters.

---

## The for Loop

A **for loop** is designed for situations where a counter controls the number of repetitions. It is a **pretest loop**, so it checks its condition before running the body.

A for loop has three main actions:

| Part | Purpose |
|---|---|
| **Initialization** | Sets the counter's starting value once |
| **Test** | Checks whether the loop should continue |
| **Update** | Increases or decreases the counter after each iteration |

The counter does not have to increase by one. It can increase by larger amounts or count backward.

**Lesson example:** The *Squares* application displays the squares of numbers from 1 through 10.

---

## The do-while Loop

A **do-while loop** is a **posttest loop**: it performs the statements **before** checking the Boolean expression. This means its body runs **at least once**, even when the condition is initially false.

| Feature | while Loop | do-while Loop |
|---|---|---|
| Condition checked | Before the loop body | After the loop body |
| Loop type | Pretest | Posttest |
| Minimum iterations | 0 | 1 |

---
