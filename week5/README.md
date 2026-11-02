# Chapter 4: Files
---

## Topics

- **5** Using Files for Data Storage
- **6** The OpenFileDialog and SaveFileDialog Controls

---

## 5 Using Files for Data Storage

A program writes data to a **file** when it needs to save information for later use.

### Three Steps in File Processing

1. **Open the file:** Connect the program to the file.
2. **Process the file:** Read information from it or write information to it.
3. **Close the file:** Disconnect the program from the file.

### Types of Files

| File Type | Description |
|---|---|
| **Text file** | Stores text data using an encoding such as Unicode |
| **Binary file** | Stores data that is not represented as ordinary readable text |

This chapter focuses on **text files**.

### File Objects and Classes

A **file object** is associated with a file and allows a program to work with it.

| Class or Method | Purpose |
|---|---|
| **StreamWriter** | Writes data to text files |
| **StreamReader** | Reads data from text files |
| **File.CreateText** | Creates a text file; replaces its existing contents if it already exists |
| **File.AppendText** | Adds text to an existing file without erasing its contents |
| **File.OpenText** | Opens a text file for reading |
| **Write** | Writes data without adding a new line |
| **WriteLine** | Writes data followed by a new line |
| **Read** | Reads a character or characters from a stream |
| **ReadLine** | Reads one line and returns it as text |
| **ReadToEnd** | Reads the remaining text to the end of a stream |
| **File.ReadAllText** | Reads the contents of a text file |
| **Close** | Closes the file connection |

### File Paths

A **file path** identifies where a file is stored. 
A program can specify a file name alone 

### Example

```csharp 
StreamWriter outputFile;

outputFile = File.CreateText("Student.txt");

outputFile.WriteLine("Hello Student");

outputFile.Close();
```

or a full path when the file is in a different location.

### Example

```csharp
StreamWriter outputFile;

outputFile = File.CreateText(@"C:\Users\Student\Documents\Student.txt");

outputFile.WriteLine("Hello Student");

outputFile.Close();
```

### Reading a File with a Loop

**EndOfStream** is a Boolean property of StreamReader that indicates whether the end of the file has been reached. A loop can use this property to continue reading until no more data remains.

---

## 5.6 The OpenFileDialog and SaveFileDialog Controls

These controls display standard Windows dialog boxes to help users choose files to open or locations to save files. They are **invisible controls**, meaning they appear in the Designer's component tray rather than directly on the form.

| Control | Purpose |
|---|---|
| **OpenFileDialog** | Lets the user browse for and select a file to open |
| **SaveFileDialog** | Lets the user choose a file name and location for saving |

### Important Properties and Results

| Term | Meaning |
|---|---|
| **ShowDialog** | Displays the dialog box |
| **DialogResult.OK** | The user confirmed the selection |
| **DialogResult.Cancel** | The user canceled the dialog |
| **FileName** | Stores the selected file name and path |
| **InitialDirectory** | Specifies the folder shown when the dialog first opens |

