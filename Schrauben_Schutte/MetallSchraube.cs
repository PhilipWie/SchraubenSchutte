using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schrauben_Schutte
{
    class MetallSchraube : Schrauben
    {
        public MetallSchraube(string n,string a,string l,string b,double m,double p,string v) : base()
        {
            schraubenName = n;
            schraubenMasse = m;
            schraubenPreis = p;
            schraubenArt = a;
            schraubenLaenge = l;
            schraubenBild = b;
            schraubenVerdrillung = v;
        }
    }
}
