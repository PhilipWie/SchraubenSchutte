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
        public string getName
        {
            get { return schraubenName; }
        }
        public string getArt
        {
            get { return schraubenArt; }
        }
        public string getLaenge
        {
            get { return schraubenLaenge; }
        }
        public double getMasse
        {
            get { return schraubenMasse; }
        }
        public string getBild
        {
            get { return schraubenBild; }
        }
        public double getPreis
        {
            get { return schraubenPreis; }
        }
        public string getVerdrillung
        {
            get { return schraubenVerdrillung; }
        }


    }
}
