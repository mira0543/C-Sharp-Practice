
## Joining Strings with Concatenation
 
Concatenation means joining strings with the `+` operator. This code joins the first name, a space, and the last name, and shows the result in a Label. For example, `Mohamed` and `Abdullahi` become `Mohamed Abdullahi`.

## Code
```csharp
private void showNameButton_Click(object sender, EventArgs e)
{
    //joining String using concatination
    string fullName;
    fullName = firstNameTextBox.Text + " " + lastNameTextBox.Text;
    fullNameLabel.Text = fullName;
}
```
##  Output

![concatenations](concatenation.png)

---

## Parse and ToString
 
A TextBox always gives a string, so we use `int.Parse` and `decimal.Parse` to convert it to numbers before calculating. After the calculation, `ToString("c")` converts the number back to a currency string so the Label can show it. For example, 40 hours × 28.75 = `$1,150.00` (with US currency formatting).

```csharp
private void calculateButton_Click(object sender, EventArgs e)
{
    //conerting string using Parse
    int hoursWorked = int.Parse(hoursWorkedTextBox.Text);
    decimal payRate = decimal.Parse(payRateTextBox.Text);

    decimal grossPay = hoursWorked * payRate;

    grossPayLabel.Text = grossPay.ToString("c");
}
```
## Output

![parseinputs](parseinput.png)

---

## Eception Handling : try-catch

Code that may cause an error goes inside `try`. If the user types something that is not a number, `Parse` throws an exception, and the program jumps to `catch` and shows the error message. This way the input error is handled instead of causing an unhandled exception.


```csharp
private void calculateButton_Click(object sender, EventArgs e)
{
    //Eception Handling using try-catch
    try
    {
        double miles = double.Parse(milesTextBox.Text);
        double gallons = double.Parse(gallonsTextBox.Text);
        double mpg = miles / gallons;

        mpgLabel.Text = mpg.ToString();
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
}
```
## Output

![tryCatch](try_Catch.png)
