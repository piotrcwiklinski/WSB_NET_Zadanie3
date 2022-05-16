using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WSB_NET_Zadanie3
{
    public class Film : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        private readonly static Dictionary<string, string[]> relatedProperties = new Dictionary<string, string[]>()
        {
            ["Tytul"] = new string[] { "TytulRezyser", "FormatListy" },
            ["Rezyser"] = new string[] { "TytulRezyser", "FormatListy" }
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
        string
            tytul,
            rezyser,
            studio,
            nosnik
            ;
        DateTime?
            dataWydania
            ;

        public string Tytul {
            get => tytul;
            set
            {
                tytul = value;
                OnPropertyChanged();
            }
        }
        public string Rezyser {
            get => rezyser;
            set
            {
                rezyser = value;
                OnPropertyChanged();
            }
        }
        public string Studio
        {
            get => studio;
            set
            {
                studio = value;
                OnPropertyChanged();
            }
        }
        public string Nosnik
        {
            get => nosnik;
            set
            {
                nosnik = value;
                OnPropertyChanged();
            }
        }
        public DateTime? DataWydania
        {
            get => dataWydania;
            set
            {
                dataWydania = value;
                OnPropertyChanged();
            }
        }
        public string TytulRezyser { get => $"{tytul}"; }
        public string FormatListy { get => $"\"{tytul}\", (reż. {rezyser})"; }
        public uint ID { get; } = następneID++;
        public string FormatID { get => "ID: " + ID; }
    }
}
