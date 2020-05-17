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
        public new string haslo
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
        public string departament { get; set; }
        }
}
