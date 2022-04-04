using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NET_INIS4_PR2._2_z4
{
    class Osoba : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly static Dictionary<string, string[]> relatedProperties = new Dictionary<string, string[]>()
        {
            ["Imię"] = new string[] {"ImięNazwisko"},
            ["Nazwisko"] = new string[] {"ImięNazwisko"}
        };
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            foreach(string relatedProperty in relatedProperties[propertyName])
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(relatedProperty));
        }

        static uint następneID = 0;
        string
            imię,
            nazwisko
            ;

        public string Imię {
            get => imię;
            set
            {
                imię = value;
                OnPropertyChanged();
                OnPropertyChanged("ImięNazwisko");
            }
        }

        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string ImięNazwisko { get => $"{imię} {nazwisko}"; }
        public uint Wiek { get; set; } = 0;
        public uint ID { get; } = następneID++;
    }
}
