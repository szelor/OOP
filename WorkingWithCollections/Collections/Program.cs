using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Osoba> osoby = new List<Osoba>();
            List<Pracownik> pracownicy = new List<Pracownik>();


            osoby.Add(new Osoba() { login = "grazyna", haslo = "1234", nazwisko = "Hasiok" });
            osoby.Add(new Osoba() { login = "janusz", haslo = "qwerty", nazwisko = "Hasiok" });

            pracownicy.Add(new Pracownik() { login = "kamnsk", haslo = "password", nazwisko = "Kamiński", departament = "IT" });
            pracownicy.Add(new Pracownik() { login = "kulczyk", haslo = "dolary$$$", nazwisko = "Kulczyk", departament = "HR" });


            Console.WriteLine("Pracownicy:");

            foreach (Pracownik p in pracownicy)
            {
                Console.WriteLine($"P.{p.nazwisko}, pracuje w {p.departament} ma login {p.login} i hasło {p.haslo} przechowywane jako jawny tekst, a co.");
            }


            Console.WriteLine("Po prostu osoby:");
            foreach (Osoba o in osoby)
            {
                Console.WriteLine($"Osoba, o nazwisku {o.nazwisko} ma login {o.login} i hasło {o.haslo} przechowywane jako jawny tekst, a co.");
            }

            // If we try to set weak password for Pracownik it should error out.
            pracownicy.Add(new Pracownik() { login = "nowak", haslo = "wsb", nazwisko = "Nowak", departament = "HR" });

            Console.ReadKey();

        }
    }
}
