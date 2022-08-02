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
using System.Windows.Shapes;

namespace Hearing_Teacher.Views
{
    /// <summary>
    /// Interaction logic for SummaryWindow.xaml
    /// </summary>
    public partial class SummaryWindow : Window
    {

        public SummaryWindow(List<string> correctAnswers, List<string> choosenAnswers)
        {
            InitializeComponent();

            foreach (var i in choosenAnswers)
                this.yourAnswers.Items.Add(i);

            foreach (var i in correctAnswers)
                this.correctAnswers.Items.Add(i);
        }
    }
}
