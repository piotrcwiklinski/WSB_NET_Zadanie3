using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_INIS4_PR2._2_z4
{
    class Model
    {
        /*Prawdopodobnie brakuje jawnego pola z listą, właściwości jawnie zaimplementowanej i notyfikacji o zmianie*/
        public LinkedList<Osoba> Lista { get; set; } = new LinkedList<Osoba>(new Osoba[] {
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
        internal void DodajNowy()
        {
            Osoba nowa = new Osoba();
            Lista.AddLast(nowa);
            Szczegóły szczegóły = new Szczegóły(nowa);
            szczegóły.Show();
            /*aktualizowanie widoku samej listy*/
        }
    }
}
