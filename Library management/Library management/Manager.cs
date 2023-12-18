using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Library_management
{
    public class Manager
    {
        public string? Name { get; set; }
        public string? Lastname { get; set; }
        public string? Phone { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }

    public class FileWriter
    {
        public void WriteManagerToFile(Manager manager, string path)
        {
            string json = JsonSerializer.Serialize(manager);

            using (StreamWriter file = new StreamWriter(path))
            {
                file.WriteLine(json);
            }
        }

        public Manager ReadManagerFromFile(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                string json = file.ReadToEnd();
                Manager manager = JsonSerializer.Deserialize<Manager>(json);
                return manager;
            }
        }
    }
}
