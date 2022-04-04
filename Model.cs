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
            new Osoba() {Imię = "Adam", Nazwisko = "Wiśniewski", Wiek = 30},
            new Osoba() {Imię = "Marian", Nazwisko = "Dąbrowski", Wiek = 29},
            new Osoba() {Imię = "Julia", Nazwisko = "Jabłońska", Wiek = 15},
            new Osoba() {Imię = "Sylwia", Nazwisko = "Sosnowska", Wiek = 25},
        });

        internal void OtwórzSzczegóły(Osoba wybrany)
        {
            Szczegóły szczegóły = new Szczegóły(wybrany);
            szczegóły.Show();
        }
    }
}
