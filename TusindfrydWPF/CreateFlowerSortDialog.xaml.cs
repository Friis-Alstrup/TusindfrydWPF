using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TusindfrydWPF
{
    /// <summary>
    /// Interaction logic for CreateFlowerSortDialog.xaml
    /// </summary>
    public partial class CreateFlowerSortDialog : Window
    {
        public CreateFlowerSortDialog()
        {
            InitializeComponent();
            CreateFlower.IsEnabled = false;
        }

        private void CreateFlower_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public new string Name
        {
            get { return NameField.Text; }
        }

        public string Picture
        {
            get { return PictureField.Text; }
        }

        public int ProductionTime
        {
            get { return int.Parse(ProductionTimeField.Text); }
        }

        public int HalfLifeTime
        {
            get { return int.Parse(HalfLifeField.Text); }
        }

        public int Size
        {
            get { return int.Parse(SizeField.Text);  }
        }

        private void PictureUpdate(object sender, RoutedEventArgs e)
        {
            ImageSourceConverter converter = new ImageSourceConverter();
            PictureBox.Source = (ImageSource)converter.ConvertFromString(PictureField.Text);
        }

        private void IsFilled(object sender, TextChangedEventArgs e)
        {
            if (NameField.Text != string.Empty && PictureField.Text != string.Empty && ProductionTimeField.Text != string.Empty && HalfLifeField.Text != string.Empty && SizeField.Text != string.Empty)
            {
                CreateFlower.IsEnabled = true;
            } else
            {
                CreateFlower.IsEnabled = false;
            }
        }
    }
}
