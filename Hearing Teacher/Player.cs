using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows;

namespace HearingTeacher
{
// VIRTUALPIANO.NET
    internal static class Player
    {
        private const string cpath = @"D:\Bogumił\Hearing Teacher\sounds\soundC.wav";
        private const string cispath = @"D:\Bogumił\Hearing Teacher\sounds\soundCis.wav";
        private const string dpath = @"D:\Bogumił\Hearing Teacher\sounds\soundD.wav";
        private const string dispath = @"D:\Bogumił\Hearing Teacher\sounds\soundDis.wav";
        private const string epath = @"D:\Bogumił\Hearing Teacher\sounds\soundE.wav";
        private const string fpath = @"D:\Bogumił\Hearing Teacher\sounds\soundF.wav";
        private const string fispath = @"D:\Bogumił\Hearing Teacher\sounds\soundFis.wav";
        private const string gpath = @"D:\Bogumił\Hearing Teacher\sounds\soundG.wav";
        private const string gispath = @"D:\Bogumił\Hearing Teacher\sounds\soundGis.wav";
        private const string apath = @"D:\Bogumił\Hearing Teacher\sounds\soundA.wav";
        private const string bbpath = @"D:\Bogumił\Hearing Teacher\sounds\soundBb.wav";
        private const string bpath = @"D:\Bogumił\Hearing Teacher\sounds\soundB.wav";

        private const string cmajorpath = @"D:\Bogumił\Hearing Teacher\chords\Cmajor.wav";
        private const string cminorpath = @"D:\Bogumił\Hearing Teacher\chords\Cminor.wav";

        private const string cismajorpath = @"D:\Bogumił\Hearing Teacher\chords\Cismajor.wav";
        private const string cisminorpath = @"D:\Bogumił\Hearing Teacher\chords\Cisminor.wav";

        private const string dmajorpath = @"D:\Bogumił\Hearing Teacher\chords\Dmajor.wav";
        private const string dminorpath = @"D:\Bogumił\Hearing Teacher\chords\Dminor.wav";

        private const string dismajorpath = @"D:\Bogumił\Hearing Teacher\chords\Dismajor.wav";
        private const string disminorpath = @"D:\Bogumił\Hearing Teacher\chords\Disminor.wav";

        private const string emajorpath = @"D:\Bogumił\Hearing Teacher\chords\Emajor.wav";
        private const string eminorpath = @"D:\Bogumił\Hearing Teacher\chords\Eminor.wav";

        private const string fmajorpath = @"D:\Bogumił\Hearing Teacher\chords\Fmajor.wav";
        private const string fminorpath = @"D:\Bogumił\Hearing Teacher\chords\Fminor.wav";

        private const string fismajorpath = @"D:\Bogumił\Hearing Teacher\chords\Fismajor.wav";
        private const string fisminorpath = @"D:\Bogumił\Hearing Teacher\chords\Fisminor.wav";

        private const string gmajorpath = @"D:\Bogumił\Hearing Teacher\chords\Gmajor.wav";
        private const string gminorpath = @"D:\Bogumił\Hearing Teacher\chords\Gminor.wav";

        private const string gismajorpath = @"D:\Bogumił\Hearing Teacher\chords\Gismajor.wav";
        private const string gisminorpath = @"D:\Bogumił\Hearing Teacher\chords\Gisminor.wav";

        private const string amajorpath = @"D:\Bogumił\Hearing Teacher\chords\Amajor.wav";
        private const string aminorpath = @"D:\Bogumił\Hearing Teacher\chords\Aminor.wav";

        private const string bbmajorpath = @"D:\Bogumił\Hearing Teacher\chords\Bbmajor.wav";
        private const string bbminorpath = @"D:\Bogumił\Hearing Teacher\chords\Bbminor.wav";

        private const string bmajorpath = @"D:\Bogumił\Hearing Teacher\chords\Bmajor.wav";
        private const string bminorpath = @"D:\Bogumił\Hearing Teacher\chords\Bminor.wav";

        private static void Play(string path)
        {
            try
            {
                using (var sp = new SoundPlayer(path)) sp.Play();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void PlayC()
        {
            Play(cpath);
        }

        public static void PlayCis()
        {
            Play(cispath);
        }
        public static void PlayD()
        {
            Play(dpath);
        }
        public static void PlayDis()
        {
            Play(dispath);
        }
        public static void PlayE()
        {
            Play(epath);
        }
        public static void PlayF()
        {
            Play(fpath);
        }
        public static void PlayFis()
        {
            Play(fispath);
        }
        public static void PlayG()
        {
            Play(gpath);
        }

        public static void PlayGis()
        {
            Play(gispath);
        }
        public static void PlayA()
        {
            Play(apath);
        }
        public static void PlayBb()
        {
            Play(bbpath);
        }
        public static void PlayB()
        {
            Play(bpath);
        }

        public static void PlayCmajor()
        {
            Play(cmajorpath);
        }

        public static void PlayCminor()
        {
            Play(cminorpath);
        }

        public static void PlayCismajor()
        {
            Play(cismajorpath);
        }

        public static void PlayCisminor()
        {
            Play(cisminorpath);
        }

        public static void PlayDmajor()
        {
            Play(dmajorpath);
        }

        public static void PlayDminor()
        {
            Play(dminorpath);
        }

        public static void PlayDismajor()
        {
            Play(dismajorpath);
        }

        public static void PlayDisminor()
        {
            Play(disminorpath);
        }

        public static void PlayEmajor()
        {
            Play(emajorpath);
        }

        public static void PlayEminor()
        {
            Play(eminorpath);
        }

        public static void PlayFmajor()
        {
            Play(fmajorpath);
        }

        public static void PlayFminor()
        {
            Play(fminorpath);
        }

        public static void PlayFismajor()
        {
            Play(fismajorpath);
        }

        public static void PlayFisminor()
        {
            Play(fisminorpath);
        }

        public static void PlayGmajor()
        {
            Play(gmajorpath);
        }

        public static void PlayGminor()
        {
            Play(gminorpath);
        }

        public static void PlayGismajor()
        {
            Play(gismajorpath);
        }

        public static void PlayGisminor()
        {
            Play(gisminorpath);
        }

        public static void PlayAmajor()
        {
            Play(amajorpath);
        }

        public static void PlayAminor()
        {
            Play(aminorpath);
        }

        public static void PlayBbmajor()
        {
            Play(bbmajorpath);
        }

        public static void PlayBbminor()
        {
            Play(bbminorpath);
        }

        public static void PlayBmajor()
        {
            Play(bmajorpath);
        }

        public static void PlayBminor()
        {
            Play(bminorpath);
        }
    }
}
