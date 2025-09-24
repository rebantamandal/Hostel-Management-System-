
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace HostelManagementSystem
{
    public static class Utilities
    {
        public static void ExportStudentsCsv(string path)
        {
            var lines = new List<string> { "Id,Name,RoomNumber,Contact" };
            lines.AddRange(DataStore.Data.Students.Select(s => $"{Escape(s.Id)},{Escape(s.Name)},{Escape(s.RoomNumber)},{Escape(s.Contact)}"));
            File.WriteAllLines(path, lines, Encoding.UTF8);
        }

        public static void ImportStudentsCsv(string path)
        {
            var lines = File.ReadAllLines(path);
            foreach (var ln in lines.Skip(1))
            {
                var parts = SplitCsv(ln);
                if (parts.Length >= 4)
                {
                    if (!DataStore.Data.Students.Any(x => x.Id == parts[0]))
                    {
                        DataStore.Data.Students.Add(new Student { Id = parts[0], Name = parts[1], RoomNumber = parts[2], Contact = parts[3] });
                    }
                }
            }
            DataStore.Save();
        }

        private static string Escape(string s) => '"' + (s ?? "").Replace(""", """") + '"';
        private static string[] SplitCsv(string line)
        {
            var list = new List<string>();
            bool inQuotes = false;
            var cur = new System.Text.StringBuilder();
            for (int i=0;i<line.Length;i++)
            {
                var c = line[i];
                if (c=='"') { inQuotes = !inQuotes; continue; }
                if (c==',' && !inQuotes) { list.Add(cur.ToString()); cur.Clear(); continue; }
                cur.Append(c);
            }
            list.Add(cur.ToString());
            return list.ToArray();
        }
    }
}
