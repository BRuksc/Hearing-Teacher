using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Hearing_Teacher.Views;
using HearingTeacher.Commands;
using HearingTeacher.Models;
using HearingTeacher.Views;

namespace HearingTeacher.ViewModels
{
    internal class SoundsViewModel : INotifyPropertyChanged
    {
        private SoundsModel model;

        public event PropertyChangedEventHandler? PropertyChanged;

        private Sounds view;

        public int ValueOfCorrectAnswers
        {
            get { return model.ValueOfCorrectAnswers; }
        }

        public int ValueOfIncorrectAnswers
        {
            get { return model.ValueOfIncorrectAnswers; }
        }

        public string Correct
        {
            get { return model.Correct; }
        }

        public string Choosen
        {
            get { return model.Choosen; }
            set 
            {
                model.Choosen = value;
                OnPropertyChanged(nameof(Choosen)); 
            }
        }

        public SoundsViewModel(Sounds v, bool sounds, bool majorchords, bool minorchords)
        {
            view = v;

            model = new SoundsModel(sounds, majorchords, minorchords);

            model.RndSound();
            model.Play();
        }
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ICommand repeat = null;
        private ICommand next = null;
        private ICommand finishCommand = null;


        public ICommand Repeat
        {
            get
            {
                if (repeat == null)
                    repeat = new RelayCommand((object o) => { model.Play(); }, null);

                return repeat;
            }
        }

        public ICommand Next
        {
            get
            {
                if (next == null)
                {
                    next = new RelayCommand(
                        (object o) =>
                        {
                            if (Correct != Choosen)
                                MessageBox.Show("Incorrect answer. That was " + Correct);

                            model.Check();

                            OnPropertyChanged(nameof(ValueOfCorrectAnswers));
                            OnPropertyChanged(nameof(ValueOfIncorrectAnswers));
                            OnPropertyChanged(nameof(Choosen));

                            model.RndSound();
                            OnPropertyChanged(nameof(Correct));

                            model.Play();
                            
                        },
                        (object o) =>
                        {
                            return model.Choosen != null;
                        });
                }

                return next;
            }
        }

        public ICommand FinishCommand
        {
            get
            {
                if (finishCommand == null)
                {
                    finishCommand = new RelayCommand(
                        (object o) =>
                        {
                            var sw = new SummaryWindow(model.CorrectAnswers, model.ChoosenAnswers);
                            sw.Show();

                            view.Close();
                        }, null);
                }

                return finishCommand;
            }
        }
    }
}
