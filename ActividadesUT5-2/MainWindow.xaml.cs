using System.Collections.Generic;
using System.Windows;

namespace ActividadesUT5_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> comida = new List<string> {"China","Mexicana","Americana" };
            comboBox.ItemsSource = comida;
        }
    }
}
