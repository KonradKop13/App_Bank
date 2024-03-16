using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;


namespace APPbank
{
    [Serializable]

    internal class FileHandler<T>
    {
        
     // Funkcja zapisująca dane sesji do pliku
  
        public static void WriteToJsonFile(string filePath, T objectToWrite, bool append = false)
        {
            TextWriter writer = null;
            try
            {
                var contentsToWriteToFile = JsonSerializer.Serialize(objectToWrite);
                writer = new StreamWriter(filePath, append);
                writer.Write(contentsToWriteToFile);
            }
            finally
            {
                writer?.Close();
            }
        }

        
         // Funkcja odczytująca dane sesji z pliku
        
        public static T? ReadFromJsonFile<TA>(string filePath) where TA : new()
        {
            TextReader reader = null;
            try
            {
                reader = new StreamReader(filePath);
                var fileContents = reader.ReadToEnd();
                return JsonSerializer.Deserialize<T>(fileContents);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }
}
