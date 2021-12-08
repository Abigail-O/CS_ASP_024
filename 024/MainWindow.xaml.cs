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

namespace _024
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

        private void button_Click(object sender, RoutedEventArgs e)
        {   
            //establish variables
            int pos = int.Parse(posPoints.Text);
            double points1 = double.Parse(box1.Text);
            double points2 = double.Parse(box2.Text);
            double points3 = double.Parse(box3.Text);
            double points4 = double.Parse(box4.Text);
            double points5 = double.Parse(box5.Text);
            int avg;

            //figure grades
            grade1.Content = ((points1 / pos) * 100) + " %";
            grade2.Content = ((points2 / pos) * 100) + " %";
            grade3.Content = ((points3 / pos) * 100) + " %";
            grade4.Content = ((points4 / pos) * 100) + " %";
            grade5.Content = ((points5 / pos) * 100) + " %";

            average.Content = (points1 + points2 + points3 + points4 + points5) / (pos * 5) * 100 +" %";



        }
    }
}
