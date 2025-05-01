using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schrauben_Schutte
{
    class MetallSchraube : Schrauben
    {
        public MetallSchraube(string name,string material,string laenge,string bild,double preis, string lieferant,string verdrillung,int nummer,double durchmesser) : base()
        {
            schraubenName = name;
            schraubenMaterial = material;
            schraubenLaenge = laenge;
            schraubenLieferant = lieferant;
            schraubenPreis = preis;
            schraubenBild = bild;
            schraubenVerdrillung = verdrillung;
            schraubenNr = nummer;
            schraubenDurchmesser = durchmesser;
        }
    }
}
