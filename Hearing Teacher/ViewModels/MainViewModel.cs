using HearingTeacher.Commands;
using HearingTeacher.Models;
using HearingTeacher.Views;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HearingTeacher.ViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private MainModel model = new MainModel();

        private MainWindow mainWindow;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel(MainWindow mw)
        {
            mainWindow = mw;
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool OpenSoundsWindow
        {
            get { return model.OpenSoundsWindow; }

            set
            {
                model.OpenSoundsWindow = value;
                OnPropertyChanged(nameof(OpenSoundsWindow));
            }
        }

        public bool OpenChordsWindow
        {
            get { return model.OpenChordsWindow; }

            set
            {
                model.OpenChordsWindow = value;
                OnPropertyChanged(nameof(OpenChordsWindow));
            }
        }

        public bool IsClosedMainWindow
        {
            get { return model.IsClosedMainWindow; }
            set { OnPropertyChanged(nameof(IsClosedMainWindow)); }
        }

        private ICommand openSounds = null;
        private ICommand openChords = null;

        public ICommand OpenSounds
        {
            get
            {
                if (openSounds == null)
                {
                    openSounds = new RelayCommand(
                       (object o) =>
                       {
                           model.OpenSounds();
                           model.CloseMainView();

                           OnPropertyChanged(nameof(OpenSoundsWindow));
                           var newSoundsWindow = new Sounds(true, false, false);
                           newSoundsWindow.Show();
                           mainWindow.Close();
                       },
                       (object o) =>
                       {
                            return model.OpenSoundsWindow != null;
                       });
                }

                return openSounds;
            }
        }
        public ICommand OpenChords
        {
            get
            {
                if (openChords == null)
                {
                    openChords = new RelayCommand(
                        (object o) =>
                        {
                            model.OpenChords();
                            model.CloseMainView();

                            OnPropertyChanged(nameof(OpenChordsWindow));
                            var newChordsWindow = new Sounds(false, true, true);
                            newChordsWindow.Show();
                            mainWindow.Close();
                        },
                        (object o) =>
                        {
                            return model.OpenChordsWindow != null;
                        });
                }

                return openChords;
            }
        }
    }
}
