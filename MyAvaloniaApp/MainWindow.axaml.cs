using Avalonia.Controls;
using System;

namespace MyAvaloniaApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Daftarkan event handler untuk tombol CalculateButton
            CalculateButton.Click += OnCalculateClick;
        }

        private void OnCalculateClick(object? sender, EventArgs e)
        {
            Console.WriteLine("Tombol dihitung telah diklik."); // Debugging output

            // Mendapatkan nilai panjang dan lebar dari input
            if (double.TryParse(LengthInput.Text, out double length) &&
                double.TryParse(WidthInput.Text, out double width))
            {
                double area = length * width;
                ResultText.Text = $"Luas: {area}";
                Console.WriteLine($"Luas dihitung: {area}"); // Debugging output
            }
            else
            {
                ResultText.Text = "Masukkan nilai yang valid untuk panjang dan lebar.";
                Console.WriteLine("Input tidak valid."); // Debugging output
            }
        }

    }
}
