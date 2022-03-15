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
        private string speed = "";
        private string flag = "";
        private string ip = "";

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
        public string Speed
        {
            get { return speed; }
            set
            {
                speed = value;
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
        public string Ip
        {
            get { return ip; }
            set
            {
                ip = value;
                OnPropertyChanged("Ip");
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
