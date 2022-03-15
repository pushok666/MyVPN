using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesctopApp.BL
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private Country selectedCountry;

        public ObservableCollection<Country> Countres { get; set; }
        public Country SelectedCountry
        {
            get { return selectedCountry; }
            set
            {
                selectedCountry = value;
                OnPropertyChanged("SelectedCountry");
            }
        }

        public ApplicationViewModel()
        {
            Countres = new ObservableCollection<Country>
            {
                new Country { Name = "USA", City ="New York", Flag = "/country/usa.la.png", Speed = "3 Мбит/с", Ip= "123.123.123.132"},
                new Country { Name = "USA", City ="Los Angeles", Flag = "/country/usa.la.png", Speed = "3 Мбит/с", Ip = "192.56.90.100"}
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
