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
            ["Imię"] = new string[] { "ImięNazwisko", "FormatListy" },
            ["Nazwisko"] = new string[] { "ImięNazwisko", "FormatListy" },
            ["DataUrodzenia"] = new string[] { "Wiek", "FormatListy" },
            ["DataŚmierci"] = new string[] { "Wiek", "FormatListy" }
        };
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            if(relatedProperties.ContainsKey(propertyName))
                foreach(string relatedProperty in relatedProperties[propertyName])
                    OnPropertyChanged(relatedProperty);
            //śledzenie zapobiegające stack overflow?
        }

        static uint następneID = 0;
        /*uint wiek = 0;*/
        string
            imię,
            nazwisko
            ;
        DateTime?
            dataUrodzenia = null,
            dataŚmierci = null
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
        public string Wiek { 
            get
            {
                if (dataUrodzenia != null)
                {
                    DateTime koniec;
                    if (dataŚmierci != null)
                        koniec = (DateTime)dataŚmierci;
                    else
                        koniec = DateTime.Now;
                    return ((koniec - (DateTime)dataUrodzenia).Days / 365).ToString();
                }
                else
                    return "BD";
            }
        }
        public DateTime? DataUrodzenia
        {
            get => dataUrodzenia;
            set
            {
                dataUrodzenia = value;
                OnPropertyChanged();
            }
        }
        public DateTime? DataŚmierci
        {
            get => dataŚmierci;
            set
            {
                dataŚmierci = value;
                OnPropertyChanged();
            }
        }
        public string ImięNazwisko { get => $"{imię} {nazwisko}"; }
        public string FormatListy { get => $"{imię} {nazwisko}, {Wiek} lat(a)"; }
        public uint ID { get; } = następneID++;
        public string FormatID { get => "ID: " + ID; }
    }
}
