using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesctopApp.BL
{
    public class Country : INotifyPropertyChanged
    {
        private string name = "";
        private string city = "";
        private int levelSignal = 0;
        private string flag = "";

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string City
        {
            get { return city; }
            set
            {
                city = value;
                OnPropertyChanged("City");
            }
        }
        public int LevelSignal
        {
            get { return levelSignal; }
            set
            {
                levelSignal = value;
                OnPropertyChanged("LevelSignal");
            }
        }
        public string Flag
        {
            get { return flag; }
            set
            {
                flag = value;
                OnPropertyChanged("Flag");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
