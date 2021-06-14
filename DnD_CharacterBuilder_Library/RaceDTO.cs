using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace DnD_CharacterBuilder_Library
{
    public class RaceDTO
    {
        private static string raceName;
        private static int raceSpeed;
        private static bool darkvision;
        private static List<string> raceabilityIncrease = new List<string>();
        private static List<string> language = new List<string>();
        private static string raceDetail;

        public static string GetRaceName()
        {
            return raceName;
        }
        public static void SetRaceName(string value)
        {
            raceName = value;
        }

        public static int GetRaceSpeed()
        {
            return raceSpeed;
        }
        public static void SetRaceSpeed(int value)
        {
            raceSpeed = value;
        }

        public static bool GetDarkvision()
        {
            return darkvision;
        }
        public static void SetDarkvision(bool value)
        {
            darkvision = value;
        }

        public static List<string> GetRaceabilityIncrease()
        {
            return raceabilityIncrease;
        }
        public static void SetRaceabilityIncrease(List<string> value)
        {
            raceabilityIncrease = value;
        }

        public static List<string> GetLanguage()
        {
            return language;
        }
        public static void SetLanguage(List<string> value)
        {
            language = value;
        }

        public static string GetRaceDetail()
        {
            return raceDetail;
        }
        public static void SetRaceDetail(string value)
        {
            raceDetail = value;
        }
    }
}
