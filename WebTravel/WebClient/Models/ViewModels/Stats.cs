using System;

namespace WebClient.Models.ViewModels
{
    public class Stats
    {
        public DateTime Time { get; set; }
        public TypeStats Type { get; set; }
        public int Quater { get; set; }
    }
    public enum TypeStats
    {
        Day = 0,
        Month = 1,
        Year = 2,
        Quater =3
    }
}
