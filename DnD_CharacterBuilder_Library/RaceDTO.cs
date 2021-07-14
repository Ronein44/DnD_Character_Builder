using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace DnD_CharacterBuilder_Library
{
    public class RaceDTO
    {
        public static string RaceName { get; set; }
        public static int RaceSpeed { get; set; }
        public static bool Darkvision { get; set; }
        public static List<string> RaceabilityIncrease = new List<string>();
        public static List<string> Language = new List<string>();
        public static string RaceDetail { get; set; }

    }
}
