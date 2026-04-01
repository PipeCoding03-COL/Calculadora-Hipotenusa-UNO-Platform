namespace Calculadora_Hipotenusa.Presentation;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    private void calcularHipotenusa(object sender, RoutedEventArgs e) {
        try {
            if (!double.TryParse(txtCatetoA.Text, out double a)||!double.TryParse(txtCatetoB.Text, out double b)) {
                lblAns.Text="Error: Ingresa números válidos.";
                return;
            }

            if (a<=0||b<=0) {
                lblAns.Text="Error: Los catetos deben ser números positivos.";
                return;
            }

            double hipotenusa = Math.Sqrt((a*a)+(b*b));
            lblAns.Text=$"Hipotenusa: {hipotenusa:F2}";
        } catch (Exception ex) {
            lblAns.Text=$"Error: {ex.Message}";
        }
    }
}
