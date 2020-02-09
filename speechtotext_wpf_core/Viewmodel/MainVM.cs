using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace speechtotext_wpf_core.Viewmodel
{
    public class MainVM : INotifyPropertyChanged
    {
        private string _speech = "";
        public string Speech
        {
            get { return _speech; }
            set
            {
                _speech = value;
                OnPropertyChanged("Speech");
            }
        }

        private string _transcribed = "";
        public string Transcribed
        {
            get { return _transcribed; }
            set
            {
                _transcribed = value;
                OnPropertyChanged("Transcribed");
            }
        }

        private string _startstop = "Start";
        public string StartStop
        {
            get { return _startstop; }
            set
            {
                _startstop = value;
                OnPropertyChanged("StartStop");
            }
        }

        private string _status = "";
        public string Status
        {
            get { return _status; }
            set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }

        #region INotifyPropertyChanged Members  

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
