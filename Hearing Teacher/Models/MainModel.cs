using HearingTeacher.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearingTeacher.Models
{
    internal class MainModel
    {
        private bool openSoundsWindow;
        private bool openChordsWindow;
        private bool isClosedMainWindow;

        public MainModel()
        {
            openSoundsWindow = false;
            openChordsWindow = false;
            isClosedMainWindow = false;
        }

        public bool OpenSoundsWindow
        {
            get { return openSoundsWindow; }
            set { openSoundsWindow = value; }
        }

        public bool OpenChordsWindow
        { 
            get { return openChordsWindow; }
            set { openChordsWindow = value; }
        }

        public bool IsClosedMainWindow
        {
            get { return isClosedMainWindow; }
            set { isClosedMainWindow = value; }
        }

        public void OpenSounds()
        {
            openSoundsWindow = true;
        }

        public void OpenChords()
        {
            OpenChordsWindow = true;
        }

        public void CloseMainView()
        {
            isClosedMainWindow = true;
        }
    }
}
