using Hearing_Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearingTeacher.Models
{
    internal class SoundsModel
    {
        private readonly bool majorChords;
        private readonly bool minorChords;
        private readonly bool sounds;

        private List<string> choosenAnswers = new List<string>();
        private List<string> correctAnswers = new List<string>();

        public List<string> ChoosenAnswers
        {
            get { return choosenAnswers; }
        }

        public List<string> CorrectAnswers
        {
            get { return correctAnswers; }
        }

        private int valueOfCorrectAnswers;
        private int valueOfIncorrectAnswers;

        private string choosen;
        private string correct;

        public string Choosen
        {
            get { return choosen; }
            set { choosen = value; }
        }

        public string Correct
        {
            get { return correct; }
            private set { correct = value; }
        }

        public int ValueOfCorrectAnswers
        {
            get { return valueOfCorrectAnswers; }
            private set { valueOfCorrectAnswers = value; }
        }

        public int ValueOfIncorrectAnswers
        {
            get { return valueOfIncorrectAnswers; }
            private set { valueOfIncorrectAnswers = value; }
        }

        public bool MajorChords
        {
            get { return majorChords; }
        }

        public bool MinorChords
        {
            get { return minorChords; }
        }

        public bool Sounds
        {
            get { return sounds; }
        }

        public SoundsModel(bool sounds, bool majorchords, bool minorchords)
        {
            this.valueOfCorrectAnswers = 0;
            this.valueOfIncorrectAnswers = 0;
            this.choosen = "--Select--";
            this.correct = String.Empty;

            this.sounds = sounds;
            this.majorChords = majorchords;
            this.minorChords = minorchords;
        }

        public void RndSound()
        {
            var rnd = new Random();
            
            if (sounds && (!majorChords) && (!minorChords))
            {
                int randomValue = rnd.Next(1,12);

                switch (randomValue)
                {
                    case 1:
                        correct = "C";
                        break;

                    case 2:
                        correct = "C#";
                        break;

                    case 3:
                        correct = "D";
                        break;

                    case 4:
                        correct = "D#";
                        break;

                    case 5:
                        correct = "E";
                        break;

                    case 6:
                        correct = "F";
                        break;

                    case 7:
                        correct = "F#";
                        break;

                    case 8:
                        correct = "G";
                        break;

                    case 9:
                        correct = "G#";
                        break;

                    case 10:
                        correct = "A";
                        break;

                    case 11:
                        correct = "Bb";
                        break;

                    case 12:
                        correct = "B";
                        break;
                }
            }

            else if ((!sounds) && majorChords && (!minorChords))
            {
                int randomValue = rnd.Next(1, 12);

                switch (randomValue)
                {
                    case 1:
                        correct = "C major";
                        break;

                    case 2:
                        correct = "C# major";
                        break;

                    case 3:
                        correct = "D major";
                        break;

                    case 4:
                        correct = "D# major";
                        break;

                    case 5:
                        correct = "E major";
                        break;

                    case 6:
                        correct = "F major";
                        break;

                    case 7:
                        correct = "F# major";
                        break;

                    case 8:
                        correct = "G major";
                        break;

                    case 9:
                        correct = "G# major";
                        break;

                    case 10:
                        correct = "A major";
                        break;

                    case 11:
                        correct = "Bb major";
                        break;

                    case 12:
                        correct = "B";
                        break;
                }
            }

            else if ((!sounds) && (!majorChords) && minorChords)
            {
                int randomValue = rnd.Next(1, 12);

                switch (randomValue)
                {
                    case 1:
                        correct = "C minor";
                        break;

                    case 2:
                        correct = "C# minor";
                        break;

                    case 3:
                        correct = "D minor";
                        break;

                    case 4:
                        correct = "D# minor";
                        break;

                    case 5:
                        correct = "E minor";
                        break;

                    case 6:
                        correct = "F minor";
                        break;

                    case 7:
                        correct = "F# minor";
                        break;

                    case 8:
                        correct = "G minor";
                        break;

                    case 9:
                        correct = "G# minor";
                        break;

                    case 10:
                        correct = "A minor";
                        break;

                    case 11:
                        correct = "Bb minor";
                        break;

                    case 12:
                        correct = "B minor";
                        break;
                }
            }

            else if ((!sounds) && majorChords && minorChords)
            {
                int randomValue = rnd.Next(1, 24);

                switch (randomValue)
                {
                    case 1:
                        correct = "C major";
                        break;

                    case 2:
                        correct = "C# major";
                        break;

                    case 3:
                        correct = "D major";
                        break;

                    case 4:
                        correct = "D# major";
                        break;

                    case 5:
                        correct = "E major";
                        break;

                    case 6:
                        correct = "F major";
                        break;

                    case 7:
                        correct = "F# major";
                        break;

                    case 8:
                        correct = "G major";
                        break;

                    case 9:
                        correct = "G# major";
                        break;

                    case 10:
                        correct = "A major";
                        break;

                    case 11:
                        correct = "Bb major";
                        break;

                    case 12:
                        correct = "B";
                        break;

                    case 13:
                        correct = "C minor";
                        break;

                    case 14:
                        correct = "C# minor";
                        break;

                    case 15:
                        correct = "D minor";
                        break;

                    case 16:
                        correct = "D# minor";
                        break;

                    case 17:
                        correct = "E minor";
                        break;

                    case 18:
                        correct = "F minor";
                        break;

                    case 19:
                        correct = "F# minor";
                        break;

                    case 20:
                        correct = "G minor";
                        break;

                    case 21:
                        correct = "G# minor";
                        break;

                    case 22:
                        correct = "A minor";
                        break;

                    case 23:
                        correct = "Bb minor";
                        break;

                    case 24:
                        correct = "B minor";
                        break;
                }
            }
        }

        public void Play()
        {
             if (correct == "C") Player.PlayC();
             else if (correct == "C#") Player.PlayCis();
             else if (correct == "D") Player.PlayD();
             else if (correct == "D#") Player.PlayDis();
             else if (correct == "E") Player.PlayE();
             else if (correct == "F") Player.PlayF();
             else if (correct == "F#") Player.PlayFis();
             else if (correct == "G") Player.PlayG();
             else if (correct == "G#") Player.PlayGis();
             else if (correct == "A") Player.PlayA();
             else if (correct == "Bb") Player.PlayBb();
             else if (correct == "B") Player.PlayB();

            else if (correct == "C major") Player.PlayCmajor();
            else if (correct == "C# major") Player.PlayCismajor();
            else if (correct == "D major") Player.PlayDmajor();
            else if (correct == "D# major") Player.PlayDismajor();
            else if (correct == "E major") Player.PlayEmajor();
            else if (correct == "F major") Player.PlayFmajor();
            else if (correct == "F# major") Player.PlayFismajor();
            else if (correct == "G major") Player.PlayGmajor();
            else if (correct == "G# major") Player.PlayGismajor();
            else if (correct == "A major") Player.PlayAmajor();
            else if (correct == "Bb major") Player.PlayBbmajor();
            else if (correct == "B major") Player.PlayBmajor();

            else if (correct == "C minor") Player.PlayCminor();
            else if (correct == "C# minor") Player.PlayCisminor();
            else if (correct == "D minor") Player.PlayDminor();
            else if (correct == "D# minor") Player.PlayDisminor();
            else if (correct == "E minor") Player.PlayEminor();
            else if (correct == "F minor") Player.PlayFminor();
            else if (correct == "F# minor") Player.PlayFisminor();
            else if (correct == "G minor") Player.PlayGminor();
            else if (correct == "G# minor") Player.PlayGisminor();
            else if (correct == "A minor") Player.PlayAminor();
            else if (correct == "Bb minor") Player.PlayBbminor();
            else if (correct == "B minor") Player.PlayBminor();
        }

        public void Check()
        {
           choosenAnswers.Add(choosen);
           correctAnswers.Add(correct);

            if (choosen == correct)
                ValueOfCorrectAnswers++;
            

            else ValueOfIncorrectAnswers++;

            choosen = "--Select a sound--";
        }
    }
}
