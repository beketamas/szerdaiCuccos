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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //lbGombok
        }

        private void lbGombok_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var gomb = new SButton("Kezdő szó");
            gomb.Click += (s,e) => 
            {
                if (s is SButton)
                {
                    var seged = (s as SButton).Content.ToString();
                    this.Title = seged.Substring(seged.IndexOf("[") +1,4);
                    
                }
                else
                {
                    this.Title = "Ez nem SButton-tól jött";
                }
            };
            lbGombok.Items.Add(gomb);
        }
    }
}
