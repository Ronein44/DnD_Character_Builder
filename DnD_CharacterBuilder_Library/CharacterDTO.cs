using System;
using System.Collections.Generic;
using System.Text;

namespace DnD_CharacterBuilder_Library
{
    public class CharacterDTO
    {
        private static int characterID;
        private static string cName;
        private static string pName;
        private static int cLvl;
        private static string cGender;
        private static string cClass;
        private static string cRace;
        private static int cWeight;
        private static int cHeight;
        private static int cAge;
        private static string cAlignment;
        private static int cAbilityID;
        private static List<string> cProficiencies;

        //Getter Setter
        public static int GetCharacterID()
        {
            return characterID;
        }
        public static void SetCharacterID(int value)
        {
            characterID = value;
        }

        public static string GetCName()
        {
            return cName;
        }
        public static void SetCName(string value)
        {
            cName = value;
        }

        public static string GetPName()
        {
            return pName;
        }
        public static void SetPName(string value)
        {
            pName = value;
        }

        public static int GetCLvl()
        {
            return cLvl;
        }
        public static void SetCLvl(int value)
        {
            cLvl = value;
        }

        public static string GetCGender()
        {
            return cGender;
        }
        public static void SetCGender(string value)
        {
            cGender = value;
        }

        public static string GetCClass()
        {
            return cClass;
        }
        public static void SetCClass(string value)
        {
            cClass = value;
        }

        public static string GetCRace()
        {
            return cRace;
        }
        public static void SetCRace(string value)
        {
            cRace = value;
        }

        public static int GetCWeight()
        {
            return cWeight;
        }
        public static void SetCWeight(int value)
        {
            cWeight = value;
        }

        public static int GetCHeight()
        {
            return cHeight;
        }
        public static void SetCHeight(int value)
        {
            cHeight = value;
        }

        public static int GetCAge()
        {
            return cAge;
        }
        public static void SetCAge(int value)
        {
            cAge = value;
        }

        public static string GetCAlignment()
        {
            return cAlignment;
        }
        public static void SetCAlignment(string value)
        {
            cAlignment = value;
        }

        public static int GetCAbilityID()
        {
            return cAbilityID;
        }
        public static void SetCAbilityID(int value)
        {
            cAbilityID = value;
        }

        public static List<string> GetCProficiencies()
        {
            return cProficiencies;
        }
        public static void SetCProficiencies(List<string> value)
        {
            cProficiencies = value;
        }        
    }
}
