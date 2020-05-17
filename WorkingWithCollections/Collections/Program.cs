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


            osoby.Add(new Osoba() { Login = "grazyna", Haslo = "1234", Nazwisko = "Hasiok" });
            osoby.Add(new Osoba() { Login = "janusz", Haslo = "qwerty", Nazwisko = "Hasiok" });

            pracownicy.Add(new Pracownik() { Login = "kamnsk", Haslo = "password", Nazwisko = "Kamiński", Departament = "IT" });
            pracownicy.Add(new Pracownik() { Login = "kulczyk", Haslo = "dolary$$$", Nazwisko = "Kulczyk", Departament = "HR" });

            // Instantiate Pracownik using method
            pracownicy.Add(Pracownik.DodajPracownika("wycislot", "supersecretpass", "Wycisło", "RND"));


            Console.WriteLine("Pracownicy:");

            foreach (Pracownik p in pracownicy)
            {
                Console.WriteLine($"P.{p.Nazwisko}, pracuje w {p.Departament} ma Login {p.Login} i hasło {p.Haslo} przechowywane jako jawny tekst, a co.");
            }


            Console.WriteLine("Po prostu osoby:");
            foreach (Osoba o in osoby)
            {
                Console.WriteLine($"Osoba, o nazwisku {o.Nazwisko} ma Login {o.Login} i hasło {o.Haslo} przechowywane jako jawny tekst, a co.");
            }

            // If we try to set weak password for Pracownik it should error out.
            pracownicy.Add(new Pracownik() { Login = "nowak", Haslo = "wsb", Nazwisko = "Nowak", Departament = "HR" });

            Console.WriteLine("Naciśnij dowolny klawisz, żeby zakończyć program");
            Console.ReadKey();

        }
    }
}
