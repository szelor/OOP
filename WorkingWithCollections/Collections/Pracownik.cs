using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Pracownik : Osoba
    {
        private string _haslo;
        public new string Haslo
        {
            get { return _haslo; }
            set
            {
                if (value.Length >= 6)
                {
                    _haslo = value;
                }
                else
                {
                    throw (new Exception("Hasło pracownika musi być dłuższe niż 6 znaków."));
                }

            }
        }
        public string Departament { get; set; }
        public Pracownik() { }

        public static Pracownik DodajPracownika(string login, string haslo, string nazwisko, string departament)
        {
            return new Pracownik
            {
                Login = login,
                Haslo = haslo,
                Nazwisko = nazwisko,
                Departament = departament
            };
                
        }

    }

}
