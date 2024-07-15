# BMI calculator
BMI calculator made in C# and Windows Presentation Foundation (WPF application). The application allows users to input their height and weight, select their gender, and calculate their Body Mass Index (BMI). The application then categorizes the user's BMI and displays a message indicating their weight category.

# Screenshot of BMI calculator
<img width="300" alt="BMI_calculator" src="https://github.com/user-attachments/assets/39cc21e2-2ec4-4316-8211-a541aad44a97">

# Documentation
## The layout
The application's user interface includes text boxes for height and weight input, a combo box for gender selection, a button to trigger the BMI calculation, and various text blocks to display information and results.

### Key UI Elements
- tbHoejde: TextBox for user to input height in meters.
- tbVaegt: TextBox for user to input weight in kilograms.
- tbKoen: ComboBox for user to select gender.
- tbResultat: Button to trigger the BMI calculation.
- Various TextBlock elements for displaying instructions, labels, and weight categories for both men and women.

## Code behind
The C# contains the logic for the application, including the event handler for the button click that performs the BMI calculation and displays the appropriate message based on the user's input.

### Key Methods
- MainWindow(): Constructor that initializes the components of the window.
- btn_resultat(object sender, RoutedEventArgs e): Event handler for the button click event that performs the BMI calculation.

### Error Handling
The try-catch block within btn_resultat method attempts to convert user input to double values for height and weight. An error message is displayed if conversion fails (e.g., due to non-numeric input).

### BMI Calculation Logic
The user's BMI is compared against predefined thresholds to determine their weight category based on their gender.
