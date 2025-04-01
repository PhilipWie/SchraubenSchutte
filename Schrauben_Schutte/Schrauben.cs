using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schrauben_Schutte
{
    class Schrauben
    {
        protected string schraubenName;
        protected string schraubenArt;
        protected string schraubenLaenge;
        protected double schraubenMasse;
        protected string schraubenBild;
        protected double schraubenPreis;
        protected string schraubenVerdrillung;
        protected Schrauben()
        {
     
        }
        public string GetName
        {
            get { return schraubenName; }
        }
        public string GetArt
        {
            get { return schraubenArt; }
        }
        public string GetLaenge
        {
            get { return schraubenLaenge; }
        }
        public double GetMasse
        {
            get { return schraubenMasse; }
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


    }
}
