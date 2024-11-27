using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xml_vozila
{
    internal class Vozilo
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int GodinaProizvodnje { get; set; }
        public int Kilometraza { get; set; }

        public override string ToString()
        {
            return $"{Marka} - {Model} - {GodinaProizvodnje} - {Kilometraza}";
        }
    }
}
