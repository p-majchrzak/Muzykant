using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzykant
{
    public class Muzyka
    {
        public string ?Artysta { get; set; }
        public string ?Album { get; set; }
        public int IloscPiosenek { get; set; }
        public int Rok { get; set; }
        public int IloscPobran { get; set; }
        public Muzyka() { }
        public Muzyka(string? artysta, string? album, int iloscPiosenek, int rok, int iloscPobran)
        {
            Artysta = artysta;
            Album = album;
            IloscPiosenek = iloscPiosenek;
            Rok = rok;
            IloscPobran = iloscPobran;
        }
    }
}
