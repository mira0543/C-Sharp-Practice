## Files Code Examples


## Creating and Writing to a Text File

A **`StreamWriter`** writes text to a file. `File.CreateText()` creates a file or replaces its existing contents, and `WriteLine()` writes each value on a new line.

### Code

```csharp
//Create the file
StreamWriter outputFile;
outputFile = File.CreateText("Student.txt");
//Write data
outputFile.WriteLine("Welcome to C#");
outputFile.WriteLine("C# is Very hard");
outputFile.WriteLine("Hello World");
//Close the file
outputFile.Close();
```

[Creating and Writing to a text Files](createWrite.png)

---

## Appending Data to a File

**`File.AppendText()`** adds new text to a file without deleting the existing contents. If the file does not exist, it creates one.

### Code

```csharp
StreamWriter outputFile;
outputFile = File.AppendText("Names.txt");

outputFile.WriteLine("Lynn");
outputFile.WriteLine("Jamal");
outputFile.WriteLine("Alex");

outputFile.Close();
```

[Apppend Data](Append.png)

---

## Specifying a File Path

A **file path** tells the program where to find or save a file. The `@` symbol makes a Windows path easier to write because backslashes do not need to be doubled.

### Code

```csharp
StreamWriter outputFile;
outputFile = File.AppendText(@"C:\Data\Names.txt");

outputFile.WriteLine("Alex");
outputFile.Close();
```

[File Path](Path.png)

---

## Reading Data from a File

A **`StreamReader`** reads text from a file. `File.OpenText()` opens the file, and `ReadLine()` reads one line of text.

### Code

```csharp
StreamReader inputFile;
inputFile = File.OpenText("students.txt");

string studentName = inputFile.ReadLine();
MessageBox.Show(studentName);

inputFile.Close();
```
[Reading Data](readingData.png)

---

## Reading a File with `EndOfStream`

**`EndOfStream`** indicates whether the reader has reached the end of a file. A `while` loop can keep reading lines until no more text remains.

### Code

```csharp
StreamReader inputFile;
inputFile = File.OpenText("students.txt");

while (!inputFile.EndOfStream)
{
    string studentName = inputFile.ReadLine();
    MessageBox.Show(studentName);
}

inputFile.Close();
```
[Read file with EndOfStrem](EndOfStream.png)
---

## Displaying an `OpenFileDialog`

An **`OpenFileDialog`** displays the standard Windows file-selection window so a user can choose a file.

### Code

```csharp
private void openButton_Click(object sender, EventArgs e)
{
    openFileDialog.ShowDialog();
}
```

[Display an `OpenFileDialog`](OpenFileDialog.png)
---

## Checking the Dialog Result

**`DialogResult.OK`** means the user confirmed a file selection. **`DialogResult.Cancel`** means the user canceled the dialog.

### Code

```csharp
DialogResult result = openFileDialog.ShowDialog();

if (result == DialogResult.OK)
{
    MessageBox.Show("File selected");
}
else if (result == DialogResult.Cancel)
{
    MessageBox.Show("Selection canceled");
}
```

[Cheching the dialog result](Dialog.png)
---

## Code 8: Opening the Selected File

The **`FileName`** property contains the path of the file chosen by the user. **`InitialDirectory`** sets the folder initially shown in the dialog.

### Code

```csharp
openFileDialog.InitialDirectory = @"C:\Data";

if (openFileDialog.ShowDialog() == DialogResult.OK)
{
    StreamReader inputFile;
    inputFile = File.OpenText(openFileDialog.FileName);

    MessageBox.Show(inputFile.ReadToEnd());
    inputFile.Close();
}
```
[Opening Selected File](InitialDirectory.png)
---

## Saving a File with `SaveFileDialog`

A **`SaveFileDialog`** lets the user choose a file name and location. After the user confirms, `File.CreateText()` can create the selected text file.

### Code

```csharp
if (saveFileDialog.ShowDialog() == DialogResult.OK)
{
    StreamWriter outputFile;
    outputFile = File.CreateText(saveFileDialog.FileName);

    outputFile.WriteLine("Hello from C#");
    outputFile.Close();
}
```
[Save File With `SaveFileDialog`](SaveDialog.png)