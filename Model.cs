using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSB_NET_Zadanie3

{
    class Model
    {
        public ObservableCollection<Film> Lista { get; set; } = new ObservableCollection<Film>(new Film[] {
            new Film() {
                Tytul = "Killer",
                Rezyser = "Machulski, J.",
                Studio = "Canal+",
                Nosnik = "VHS",
                DataWydania = DateTime.Parse("17.11.1997")
            },
            new Film() {
                Tytul = "Chłopaki nie Płaczą",
                Rezyser = "Lubaszenko, O.",
                Studio = "Studio BestFilm",
                Nosnik = "CD-ROM",
                DataWydania = DateTime.Parse("25.02.2000")
            },
            new Film() {
                Tytul = "Poranek Kojota",
                Rezyser = "Lubaszenko, O.",
                Studio = "Studio BestFilm",
                Nosnik = "CD-ROM",
                DataWydania = DateTime.Parse("24.08.2001")
            },
            new Film() {
                Tytul = "Nic Śmiesznego",
                Rezyser = "Koterski, M.",
                Studio= "Studio Filmowe Zebra",
                Nosnik = "VHS",
                DataWydania = DateTime.Parse("2.02.1996")
            },
        });

        internal void OtwórzSzczegóły(Film wybrany)
        {
            Szczegóły szczegóły = new Szczegóły(wybrany);
            szczegóły.Show();
        }
        internal void DodajNowy()
        {
            Film nowa = new Film();
            Lista.Add(nowa);
            Szczegóły szczegóły = new Szczegóły(nowa);
            szczegóły.Show();
        }
    }
}
