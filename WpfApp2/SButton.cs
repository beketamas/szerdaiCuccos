using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp2
{
    internal class SButton : Button
    {
        static Random random  = new Random();
        public SButton(string alap)
        {
            this.Content = $"{alap} : [{random.Next(1000, 10000)}]";
            this.Background = Brushes.LightCoral;
        }

    }
}
