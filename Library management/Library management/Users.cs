using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;

namespace Library_management
{
    public class Users
    {
        public string? Name { get; set; }
        public string? Lastname { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Nationalid { get; set; }
        public string? id { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }
        public string? Age { get; set; }
        public string? Gender { get; set; }
        public string? DateOfMembership { get; set; }
        public string? Update { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }

    public class FileWriterFromUsers
    {
        public void WriteUserInfoToFile(Users users, string path)
        {
            string json = JsonSerializer.Serialize(users);

            using (StreamWriter file = new StreamWriter(path, append: true))
            {
                file.WriteLine(json);
            }
        }

        public void WriteUsersInfoToFile(List<Users> users, string path)
        {
            using (StreamWriter file = new StreamWriter(path, append: false))
            {
                foreach (Users user in users)
                {
                    string json = JsonSerializer.Serialize(user);
                    file.WriteLine(json);
                }
            }
        }


        public List<Users> ReadUserInfoFromFile(string path)
        {
            List<Users> users = new List<Users>();

            using (StreamReader file = new StreamReader(path))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    Users user = JsonSerializer.Deserialize<Users>(line);
                    users.Add(user);
                }
            }

            return users;
        }

        public void DeleteUser(string userId, string path)
        {
            string json = File.ReadAllText(path);
            List<Users> users = new List<Users>();

            foreach (string line in File.ReadLines(path))
            {
                Users user = JsonSerializer.Deserialize<Users>(line);
                users.Add(user);
            }


            users.RemoveAll(user => user.id == userId);


            using (StreamWriter file = new StreamWriter(path, append: false))
            {
                foreach (Users user in users)
                {
                    json = JsonSerializer.Serialize(user);
                    file.WriteLine(json);
                }
            }

        }
    }
}
