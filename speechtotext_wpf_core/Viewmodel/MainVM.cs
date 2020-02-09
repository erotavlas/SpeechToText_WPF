using System;
using System.Collections.Generic;
using System.Text;

namespace speechtotext_wpf_core.Viewmodel
{
    public class MainVM : BindableBase
    {
        private string _speech = "";
        public string Speech
        {
            get { return _speech; }
            set
            {
                SetProperty(ref _speech, value);
            }
        }

        private string _transcribed = "";
        public string Transcribed
        {
            get { return _transcribed; }
            set
            {
                SetProperty(ref _transcribed, value);
            }
        }

        private string _startstop = "Start";
        public string StartStop
        {
            get { return _startstop; }
            set
            {
                SetProperty(ref _startstop, value);
            }
        }

        private string _status = "";
        public string Status
        {
            get { return _status; }
            set
            {
                SetProperty(ref _status, value);
            }
        }
    }
}
