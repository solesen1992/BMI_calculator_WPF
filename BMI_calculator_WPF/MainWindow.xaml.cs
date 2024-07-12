using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BMI_calculator_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_resultat(object sender, RoutedEventArgs e)
        {

            double hoejde = 0;
            double vaegt = 0;
            double BMI = 0;

            try
            {
                //Konverterer til en double. Tager tal fra tbHoejde og tbVaegt, som er tekst og smider over i variabler som en double.
                hoejde = Convert.ToDouble(tbHoejde.Text);
                vaegt = Convert.ToDouble(tbVaegt.Text);
                BMI = vaegt / (hoejde * hoejde);
            }
            catch (Exception exc)
            {
                //Hvis der opstår en fejl, så vises denne besked. Fx ved andet end tal.
                MessageBox.Show(exc.Message, "How! Der er opstået en fejl...");
            }
            if (tbKoen.Text == "Mand")
            {
                if (BMI < 20)
                {
                    MessageBox.Show("Du er en undervægtig mand");
                }
                else if (BMI >= 20.0 && BMI <= 25.0)
                {
                    MessageBox.Show("Du er en normalvægtig mand");
                }
                else if (BMI >= 25 && BMI <= 30)
                {
                    MessageBox.Show("Du er en overvægtig mand");
                }
                else if (BMI > 30)
                {
                    MessageBox.Show("Du er en stærkt overvægtig mand");
                }
            }
            else if (tbKoen.Text != "Mand")
            {
                if (BMI < 18.6)
                {
                    MessageBox.Show("Du er en slank kvinde");
                }
                else if (BMI >= 18.6 && BMI <= 23.8)
                {
                    MessageBox.Show("Du er en slank kvinde");
                }
                else if (BMI >= 23.8 && BMI <= 28.6)
                {
                    MessageBox.Show("Du er en slank kvinde");
                }
                else if (BMI > 28.6)
                {
                    MessageBox.Show("Du er en slank kvinde");
                }
            }

        }

    }

}