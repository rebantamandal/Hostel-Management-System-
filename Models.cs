
using System;
using System.Collections.Generic;

namespace HostelManagementSystem
{
    [Serializable]
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string RoomNumber { get; set; }
        public string Contact { get; set; }
    }

    [Serializable]
    public class Staff
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Contact { get; set; }
    }

    [Serializable]
    public class Room
    {
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }
        public List<string> Occupants { get; set; } = new List<string>();
    }

    [Serializable]
    public class FineRecord
    {
        public string Id { get; set; }
        public string StudentId { get; set; }
        public string Reason { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public bool Paid { get; set; }
    }

    [Serializable]
    public class HostelData
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Staff> Staffs { get; set; } = new List<Staff>();
        public List<Room> Rooms { get; set; } = new List<Room>();
        public List<FineRecord> Fines { get; set; } = new List<FineRecord>();
        public string AdminPasswordHash { get; set; } = "";
    }
}
