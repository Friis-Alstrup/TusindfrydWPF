using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TusindfrydWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<FlowerSort> flowerSorts;
        public MainWindow()
        {
            InitializeComponent();
            flowerSorts = new List<FlowerSort>();
        }

        private void CreateFlower_Click(object sender, RoutedEventArgs e)
        {
            CreateFlowerSortDialog inputDialog = new CreateFlowerSortDialog();
            
            if (inputDialog.ShowDialog() == true)
            {
                flowerSorts.Add(new FlowerSort(inputDialog.Name, inputDialog.Picture, inputDialog.ProductionTime, inputDialog.HalfLifeTime, inputDialog.Size));

                TextBlock.Text = string.Empty;

                foreach (FlowerSort flower in flowerSorts)
                {
                    TextBlock.Inlines.Add($"Navn: {flower.Name}, Produktionstid: {flower.ProductionTime}, Halveringstid: {flower.HalfLifeTime}, Størrelse: {flower.Size}\n");
                }
            }
            
        }
    }
}
