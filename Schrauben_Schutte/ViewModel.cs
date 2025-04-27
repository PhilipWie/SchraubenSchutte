using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schrauben_Schutte
{
    class ViewModel
    {
        List<Schrauben> schraubenListe = new List<Schrauben>();
        public ViewModel()
        {
            //public MetallSchraube(string name,string material,string laenge,string bild,double masse,double preis,string verdrillung,int nummer,double durchmesser)
            schraubenListe.Add(new MetallSchraube("M1", "Metall", "10mm", "Bild1", 0.1, 0.1, "Verdrillung1",11111,5.4));
            schraubenListe.Add(new MetallSchraube("M2", "Metall", "10mm", "Bild1", 0.1, 0.1, "Verdrillung1", 11111, 5));
            schraubenListe.Add(new MetallSchraube("M3", "Metall", "10mm", "Bild1", 0.1, 0.1, "Verdrillung1", 11111, 5));
            schraubenListe.Add(new MetallSchraube("M4", "Metall", "10mm", "Bild1", 0.1, 0.1, "Verdrillung1", 11111, 5));
            schraubenListe.Add(new MetallSchraube("M5", "Metall", "10mm", "Bild1", 0.1, 0.1, "Verdrillung1", 11111, 5));
            schraubenListe.Add(new MetallSchraube("M6", "Metall", "10mm", "Bild1", 0.1, 0.1, "Verdrillung1", 11111, 5));
            schraubenListe.Add(new MetallSchraube("M7", "Metall", "10mm", "Bild1", 0.1, 0.1, "Verdrillung1", 11111, 5));
            schraubenListe.Add(new MetallSchraube("M8", "Metall", "10mm", "Bild1", 0.1, 0.1, "Verdrillung1", 11111, 5));
            schraubenListe.Add(new MetallSchraube("M9", "Metall", "10mm", "Bild1", 0.1, 0.1, "Verdrillung1", 11111, 5));
            schraubenListe.Add(new MetallSchraube("M10", "Metall", "10mm", "Bild1", 0.1, 0.1, "Verdrillung1", 11111, 5));
            schraubenListe.Add(new MetallSchraube("M11", "Metall", "10mm", "Bild1", 0.1, 0.1, "Verdrillung1", 11111, 5));
        }
        public List<Schrauben> getListe
        {
            get { return schraubenListe; }
        }
    }
}
