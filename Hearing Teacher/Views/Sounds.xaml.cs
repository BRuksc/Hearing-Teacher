using HearingTeacher.ViewModels;
using HearingTeacher.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace HearingTeacher.Views
{
    /// <summary>
    /// Logika interakcji dla klasy Sounds.xaml
    /// </summary>
    public partial class Sounds : Window
    {
        public Sounds(bool sounds, bool majorchords, bool minorchords)
        {
            InitializeComponent();

            DataContext = new SoundsViewModel(this, sounds, majorchords, minorchords);

            if (sounds)
            {
                SoundComboBox.Items.Add("C");
                SoundComboBox.Items.Add("C#");
                SoundComboBox.Items.Add("D");
                SoundComboBox.Items.Add("D#");
                SoundComboBox.Items.Add("E");
                SoundComboBox.Items.Add("F");
                SoundComboBox.Items.Add("F#");
                SoundComboBox.Items.Add("G");
                SoundComboBox.Items.Add("G#");
                SoundComboBox.Items.Add("A");
                SoundComboBox.Items.Add("Bb");
                SoundComboBox.Items.Add("B");
            }

            if (majorchords)
            {
                SoundComboBox.Items.Add("C major");
                SoundComboBox.Items.Add("C# major");
                SoundComboBox.Items.Add("D major");
                SoundComboBox.Items.Add("D# major");
                SoundComboBox.Items.Add("E major");
                SoundComboBox.Items.Add("F major");
                SoundComboBox.Items.Add("F# major");
                SoundComboBox.Items.Add("G major");
                SoundComboBox.Items.Add("G# major");
                SoundComboBox.Items.Add("A major");
                SoundComboBox.Items.Add("Bb major");
                SoundComboBox.Items.Add("B major");
            }

            if (minorchords)
            {
                SoundComboBox.Items.Add("C minor");
                SoundComboBox.Items.Add("C# minor");
                SoundComboBox.Items.Add("D minor");
                SoundComboBox.Items.Add("D# minor");
                SoundComboBox.Items.Add("E minor");
                SoundComboBox.Items.Add("F minor");
                SoundComboBox.Items.Add("F# minor");
                SoundComboBox.Items.Add("G minor");
                SoundComboBox.Items.Add("G# minor");
                SoundComboBox.Items.Add("A minor ");
                SoundComboBox.Items.Add("Bb minor");
                SoundComboBox.Items.Add("B minor");
            }
        }
    }
}
