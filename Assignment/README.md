# C# Windows Forms – File Handling Assignment

## 1. Explain the Function

This application is created using C# Windows Forms. It allows the user to create, write, read, append, and delete text files.

The program uses two important classes:

- **StreamWriter:** Used to write information into a file.
- **StreamReader:** Used to read information from a file.

There are three main steps when working with files:

1. **Open the file:** Connect the file to the program.
2. **Process the file:** Read or write information.
3. **Close the file:** Close the connection after finishing.

### Creating a New File

`File.CreateText()` creates a new text file and allows us to write information into it. If the file already exists, its old contents are deleted.

### Creating a New File Using Path

This function creates a file in a specific location on the computer by using its file path.

### Append Function

`File.AppendText()` adds new information to an existing file without deleting the previous information.

---

## 2. Function Using Reading the File

The reading functions allow us to get information from a text file and display it in the ListBox.

### ReadLine()

`ReadLine()` reads one line from a file at a time. We can use a while loop to read all the lines.

### Read()

`Read()` reads one character from the file.

### ReadToEnd()

`ReadToEnd()` reads all the remaining text in the file.

### ReadAllLines()

`File.ReadAllLines()` reads all lines from a text file and stores them in a string array.

### ReadAllText()

`File.ReadAllText()` reads all the information from a file and returns it as one string.

### File.OpenText()

`File.OpenText()` opens an existing text file so we can read its contents using StreamReader.

### EndOfStream

`EndOfStream` checks whether the reader has reached the end of the file. It is useful when reading a file using a while loop.

---

## 3. Function Used to Delete the File or Item File

### Delete File

`File.Delete()` is used to delete a file from the computer.

We can use `File.Exists()` to check whether the file exists before deleting it.

### Delete Item

`listBox1.Items.RemoveAt()` removes a selected item from the ListBox.

In this application, this function only removes the selected item from the ListBox. It does not delete the information from the saved text file.

### Clear Items

`listBox1.Items.Clear()` removes all items displayed in the ListBox.

---

## Conclusion

This assignment helped me understand how to work with text files in C#. I learned how to create files, save information, read information, add new data, and delete files using StreamWriter, StreamReader, and File methods.