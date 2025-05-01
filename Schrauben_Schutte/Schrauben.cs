using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schrauben_Schutte
{
    class Schrauben
    {
        public string schraubenName;
        public int schraubenNr;
        public string schraubenMaterial;
        public string schraubenLaenge;
        public string schraubenLieferant;
        public string schraubenBild;
        public double schraubenPreis;
        public string schraubenVerdrillung;
        public double schraubenDurchmesser;
        public Schrauben()
        {
      
        }
        public string GetName
        {
            get { return schraubenName; }
        }
        public int GetNr
        {
            get { return schraubenNr; }
        }
        public string GetLieferant
        {
            get { return schraubenLieferant; }
        }
        public string GetMaterial
        {
            get { return schraubenMaterial; }
        }
        public string GetLaenge
        {
            get { return schraubenLaenge; }
        }
        public string GetBild
        {
            get { return schraubenBild; }
        }
        public double GetPreis
        {
            get { return schraubenPreis; }
        }
        public string GetVerdrillung
        {
            get { return schraubenVerdrillung; }
        }
        public double GetDurchmesser
        {
            get { return schraubenDurchmesser; }
        } 

    }
}
