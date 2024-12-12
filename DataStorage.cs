using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace BazaDanychPojazdow
{
    public class DataStorage
    {
        private const string FilePath = "data.json";

        public void SaveData(Date date)
        {
            try
            {
                string json = JsonConvert.SerializeObject(date);
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd podczas zapisu danych: " + ex.Message);
            }
        }

        // public Date LoadData()
        // {
        //     string json = File.ReadAllText(FilePath);
        //     return JsonConvert.DeserializeObject<Date>(json);
        // }
    }
}
