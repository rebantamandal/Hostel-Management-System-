
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Security.Cryptography;
using System.Text;

namespace HostelManagementSystem
{
    public static class DataStore
    {
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "hostel_data.xml");
        public static HostelData Data { get; private set; } = new HostelData();

        public static void Load()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(HostelData));
                    using (FileStream fs = new FileStream(FilePath, FileMode.Open))
                    {
                        Data = (HostelData)xs.Deserialize(fs);
                    }
                }
                else
                {
                    Data.Rooms.Add(new Room { RoomNumber = "A101", Capacity = 2 });
                    Data.Rooms.Add(new Room { RoomNumber = "A102", Capacity = 2 });
                    Data.Rooms.Add(new Room { RoomNumber = "B201", Capacity = 3 });
                    Data.AdminPasswordHash = ComputeHash("admin");
                    Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data: " + ex.Message);
                Data = new HostelData();
            }
        }

        public static void Save()
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(HostelData));
                using (FileStream fs = new FileStream(FilePath, FileMode.Create))
                {
                    xs.Serialize(fs, Data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save data: " + ex.Message);
            }
        }

        public static string ComputeHash(string input)
        {
            using (SHA256 sha = SHA256.Create())
            {
                var b = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                return Convert.ToBase64String(b);
            }
        }

        public static bool VerifyAdminPassword(string password)
        {
            if (string.IsNullOrEmpty(Data.AdminPasswordHash)) return false;
            return ComputeHash(password) == Data.AdminPasswordHash;
        }
    }
}
