using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schrauben_Schutte
{
    class MetallSchraube : Schrauben
    {
        public MetallSchraube(string name,string material,string laenge,string bild,double masse,double preis,string verdrillung,int nummer,double durchmesser) : base()
        {
            schraubenName = name;
            schraubenMaterial = material;
            schraubenLaenge = laenge;
            schraubenMasse = masse;
            schraubenPreis = preis;
            schraubenBild = bild;
            schraubenVerdrillung = verdrillung;
            schraubenNr = nummer;
            schraubenDurchmesser = durchmesser;
        }
    }
}
