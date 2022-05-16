using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_INIS4_PR2._2_z4
{
    class Model
    {
        public IEnumerable<Osoba> Lista { get; set; } = new LinkedList<Osoba>(new Osoba[] {
            new Osoba() {
                Imię = "Adam",
                Nazwisko = "Wiśniewski",
                DataUrodzenia = DateTime.Parse("1.01.1990")
            },
            new Osoba() {
                Imię = "Marian",
                Nazwisko = "Dąbrowski",
                DataUrodzenia = DateTime.Parse("2.02.2000")
            },
            new Osoba() {
                Imię = "Julia",
                Nazwisko = "Jabłońska",
                DataUrodzenia = DateTime.Parse("3.03.2010")
            },
            new Osoba() {
                Imię = "Sylwia",
                Nazwisko = "Sosnowska",
                DataUrodzenia = DateTime.Parse("4.04.2020")
            },
        });

        internal void OtwórzSzczegóły(Osoba wybrany)
        {
            Szczegóły szczegóły = new Szczegóły(wybrany);
            szczegóły.Show();
        }
    }
}
