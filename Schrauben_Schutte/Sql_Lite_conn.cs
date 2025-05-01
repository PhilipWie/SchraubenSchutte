using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schrauben_Schutte
{
     class Sql_Lite_conn
    {
        private const string ConnectionString = "Data Source=Resources/Schrauben.db;Version=3;";

        public List<Schrauben> GetSchraubenListe() 
        {
            Console.WriteLine("Methode GetSchraubenListe wurde aufgerufen."); 
            var schraubenListe = new List<Schrauben>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "select * from Schrauben";
                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                    
                        schraubenListe.Add(new Schrauben
                        {

                            schraubenName = reader["S_Name"].ToString(),
                            schraubenMaterial = reader["S_Material"].ToString(),
                            schraubenLaenge = reader["S_Laenge"].ToString(),
                            schraubenBild = reader["S_Bild"].ToString(),
                            schraubenPreis = Convert.ToDouble(reader["S_Preis"]),
                            schraubenLieferant = reader["S_Lieferant"].ToString(),
                            schraubenVerdrillung = reader["S_Verdrillung"].ToString(),
                            schraubenNr = Convert.ToInt32(reader["S_Nr"]),
                            //schraubenDurchmesser = Convert.ToDouble(reader["S_Durchmesser"])
                        });
                    }
                }
            }

           
            return schraubenListe;
        }
        public void SaveSchraube(Schrauben schraube)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = @"
                UPDATE Schrauben
                SET 
                    S_Name = @Name,
                    S_Material = @Material,
                    S_Laenge = @Laenge,
                    S_Bild = @Bild,
                    S_Preis = @Preis,
                    S_Lieferant = @Lieferant,
                    S_Verdrillung = @Verdrillung,
                    S_Durchmesser = @Durchmesser
                WHERE S_Nr = @Nr";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", schraube.schraubenName);
                    command.Parameters.AddWithValue("@Material", schraube.schraubenMaterial);
                    command.Parameters.AddWithValue("@Laenge", schraube.schraubenLaenge);
                    command.Parameters.AddWithValue("@Bild", schraube.schraubenBild);
                    command.Parameters.AddWithValue("@Preis", schraube.schraubenPreis);
                    command.Parameters.AddWithValue("@Lieferant", schraube.schraubenLieferant);
                    command.Parameters.AddWithValue("@Verdrillung", schraube.schraubenVerdrillung);
                    command.Parameters.AddWithValue("@Durchmesser", schraube.schraubenDurchmesser);
                    command.Parameters.AddWithValue("@Nr", schraube.schraubenNr);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteSchraube(Schrauben schraube)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "DELETE FROM Schrauben WHERE S_Nr = @Nr";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nr", schraube.schraubenNr);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
