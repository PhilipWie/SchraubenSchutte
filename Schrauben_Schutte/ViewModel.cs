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
            schraubenListe.Add(new MetallSchraube("M1", "Metall", "10mm", "Bild1", 0.1, 0.1, "Verdrillung1"));
            schraubenListe.Add(new MetallSchraube("M2", "Metall", "10mm", "Bild1", 0.1, 0.1, "Verdrillung1"));
            schraubenListe.Add(new MetallSchraube("M3", "Metall", "10mm", "Bild1", 0.1, 0.1, "Verdrillung1"));
            schraubenListe.Add(new MetallSchraube("M4", "Metall", "10mm", "Bild1", 0.1, 0.1, "Verdrillung1"));
        }
        public List<Schrauben> getListe
        {
            get { return schraubenListe; }
        }
    }
}
