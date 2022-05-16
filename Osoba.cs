using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NET_INIS4_PR2._2_z4
{
    public class Osoba : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly static Dictionary<string, string[]> relatedProperties = new Dictionary<string, string[]>()
        {
            ["Imię"] = new string[] {"ImięNazwisko", "FormatListy" },
            ["Nazwisko"] = new string[] {"ImięNazwisko", "FormatListy" },
            ["Wiek"] = new string[] {"FormatListy"}
        };
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            foreach(string relatedProperty in relatedProperties[propertyName])
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(relatedProperty));
        }

        static uint następneID = 0;
        uint wiek = 0;
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
            }
        }
        public string Nazwisko {
            get => nazwisko;
            set
            {
                nazwisko = value;
                OnPropertyChanged();
            }
        }
        public uint Wiek { 
            get => wiek;
            set
            {
                wiek = value;
                OnPropertyChanged();
            }
        }
        public string ImięNazwisko { get => $"{imię} {nazwisko}"; }
        public string FormatListy { get => $"{imię} {nazwisko}, {Wiek} lat(a)"; }
        public uint ID { get; } = następneID++;
        public string FormatID { get => "ID: " + ID; }
    }
}
