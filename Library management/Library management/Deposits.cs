using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Library_management
{
    public class Deposits
    {
        public string UsernameAndUserId { get; set; }
        public string BookNameAndBookCode { get; set; }
        public string BorrowDate { get; set; }
        public string ReturnDate { get; set; }
    }

    public class FileWriterFromDeposits
    {
        public void WriteDepositsInfoToFile(Deposits deposits, string path)
        {
            string json = JsonSerializer.Serialize(deposits);

            using (StreamWriter file = new StreamWriter(path, append: true))
            {
                file.WriteLine(json);
            }
        }

        public void WriteDepositssInfoToFile(List<Deposits> depositss, string path)
        {
            using (StreamWriter file = new StreamWriter(path, append: false))
            {
                foreach (Deposits deposits in depositss)
                {
                    string json = JsonSerializer.Serialize(deposits);
                    file.WriteLine(json);
                }
            }
        }


        public List<Deposits> ReadDepositsInfoFromFile(string path)
        {
            List<Deposits> depositss = new List<Deposits>();

            using (StreamReader file = new StreamReader(path))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    Deposits deposits = JsonSerializer.Deserialize<Deposits>(line);
                    depositss.Add(deposits);
                }
            }

            return depositss;
        }

    }
}
