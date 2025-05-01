using Raven.Database.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Schrauben_Schutte
{
    class ViewModel
    {

        private List<Schrauben> schraubenListe;
        private bool isImgLarge = false;
        private Sql_Lite_conn dbHelper = new Sql_Lite_conn();

        public ObservableCollection<Schrauben> getListe { get; private set; }
        public ICommand OpenImageCommand { get; }
        public ICommand SpeichernCommand { get; }
        public ICommand LöschenCommand { get; }
        public ICommand HinzufügenCommand { get; }

        private void ExecuteOpenImage(object parameter)
        {
            if (parameter is string imagePath && !string.IsNullOrEmpty(imagePath))
            {
                var imageWindow = new ImageWindow(imagePath);
                imageWindow.Show();
            }
        }
        public ViewModel()
        {
            var dbHelper = new Sql_Lite_conn();
            getListe = new ObservableCollection<Schrauben>(dbHelper.GetSchraubenListe());
            var schrauben = dbHelper.GetSchraubenListe();
            Console.WriteLine($"Anzahl der geladenen Schrauben: {schrauben.Count}");
            SpeichernCommand = new RelayCommand(ExecuteSpeichern, CanExecuteSpeichern);
            LöschenCommand = new RelayCommand(ExecuteLöschen, CanExecuteLöschen);
            //HinzufügenCommand = new RelayCommand(ExecuteHinzufügen);
            OpenImageCommand = new RelayCommand(ExecuteOpenImage);
            /*
            schraubenListe = new List<Schrauben>
                {
                    new MetallSchraube("M1", "Metall", "10mm", "pack://application:,,,/Resources/Schraube1.jpg", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5.4),
                    new MetallSchraube("M2", "Metall", "10mm", "pack://application:,,,/Resources/Schraube2.jpg", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5),
                    new MetallSchraube("M3", "Metall", "10mm", "pack://application:,,,/Resources/Schraube3.jpg", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5),
                    new MetallSchraube("M4", "Metall", "10mm", "pack://application:,,,/Resources/Schraube4.jpg", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5),
                    new MetallSchraube("M5", "Metall", "10mm", "pack://application:,,,/Resources/Schraube5.jpg", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5),
                    new MetallSchraube("M6", "Metall", "10mm", "pack://application:,,,/Resources/Schraube6.jpg", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5),
                    new MetallSchraube("M7", "Metall", "10mm", "pack://application:,,,/Resources/Schraube7.jpg", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5),
                    new MetallSchraube("M8", "Metall", "10mm", "pack://application:,,,/Resources/Schraube8.jpg", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5),
                    new MetallSchraube("M9", "Metall", "10mm", "Bild1", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5),
                    new MetallSchraube("M10", "Metall", "10mm", "Bild1", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5),
                    new MetallSchraube("M11", "Metall", "10mm", "Bild1", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5)
                };
        }
            */


        }
        // Speichern-Logik
        private void ExecuteSpeichern(object parameter)
        {
            try
            {
                foreach (var schraube in getListe)
                {
                    dbHelper.SaveSchraube(schraube); // Speichere jede Schraube
                }
                MessageBox.Show("Änderungen wurden erfolgreich gespeichert.", "Speichern", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern: {ex.Message}", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool CanExecuteSpeichern(object parameter)
        {
            return getListe != null && getListe.Any();
        }

        // Löschen-Logik
        private void ExecuteLöschen(object parameter)
        {
            if (parameter is Schrauben schraube)
            {
                try
                {
                    getListe.Remove(schraube); // Entferne aus der Liste
                    dbHelper.DeleteSchraube(schraube); // Entferne aus der Datenbank
                    MessageBox.Show("Schraube wurde erfolgreich gelöscht.", "Löschen", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Löschen: {ex.Message}", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private bool CanExecuteLöschen(object parameter)
        {
            return parameter is Schrauben schraube && getListe.Contains(schraube);
        }

    }
}
        /*
        List<Schrauben> schraubenListe = new List<Schrauben>();
        public ViewModel()
        {
            //public MetallSchraube(string name, string material, string laenge, string bild, double preis, string lieferant, string verdrillung, int nummer, double durchmesser)
            schraubenListe.Add(new MetallSchraube("M1", "Metall", "10mm", "pack://application:,,,/Resources/Schraube1.jpg", 0.1, "Yaro-Gmbh", "Verdrillung1",11111,5.4));
            schraubenListe.Add(new MetallSchraube("M2", "Metall", "10mm", "pack://application:,,,/Resources/Schraube2.jpg", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5));
            schraubenListe.Add(new MetallSchraube("M3", "Metall", "10mm", "pack://application:,,,/Resources/Schraube3.jpg", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5));
            schraubenListe.Add(new MetallSchraube("M4", "Metall", "10mm", "pack://application:,,,/Resources/Schraube4.jpg", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5));
            schraubenListe.Add(new MetallSchraube("M5", "Metall", "10mm", "pack://application:,,,/Resources/Schraube5.jpg", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5));
            schraubenListe.Add(new MetallSchraube("M6", "Metall", "10mm", "pack://application:,,,/Resources/Schraube6.jpg", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5));
            schraubenListe.Add(new MetallSchraube("M7", "Metall", "10mm", "pack://application:,,,/Resources/Schraube7.jpg", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5));
            schraubenListe.Add(new MetallSchraube("M8", "Metall", "10mm", "pack://application:,,,/Resources/Schraube8.jpg", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5));
            schraubenListe.Add(new MetallSchraube("M9", "Metall", "10mm", "Bild1", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5));
            schraubenListe.Add(new MetallSchraube("M10", "Metall", "10mm", "Bild1", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5));
            schraubenListe.Add(new MetallSchraube("M11", "Metall", "10mm", "Bild1", 0.1, "Yaro-Gmbh", "Verdrillung1", 11111, 5));
        }
        public List<Schrauben> getListe
        {
            get { return schraubenListe; }
        }

    }
}
        */
