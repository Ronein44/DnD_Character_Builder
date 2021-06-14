using System;
using System.Collections.Generic;
using System.Text;

namespace DnD_CharacterBuilder_Library
{
    public class AbilityDTO
    {
        private static int strength;
        private static int dexterity;
        private static int constitution;
        private static int intelligence;
        private static int wisdom;
        private static int charisma;
        private static int strMod;
        private static int dexMod;
        private static int conMod;
        private static int intMod;
        private static int wisMod;
        private static int chaMod;

        public static int GetStrength()
        {
            return strength;
        }
        public static void SetStrength(int value)
        {
            strength = value;
        }

        public static int GetDexterity()
        {
            return dexterity;
        }
        public static void SetDexterity(int value)
        {
            dexterity = value;
        }

        public static int GetConstitution()
        {
            return constitution;
        }
        public static void SetConstitution(int value)
        {
            constitution = value;
        }

        public static int GetIntelligence()
        {
            return intelligence;
        }
        public static void SetIntelligence(int value)
        {
            intelligence = value;
        }

        public static int GetWisdom()
        {
            return wisdom;
        }
        public static void SetWisdom(int value)
        {
            wisdom = value;
        }

        public static int GetCharisma()
        {
            return charisma;
        }
        public static void SetCharisma(int value)
        {
            charisma = value;
        }

        public static int GetStrMod()
        {
            return strMod;
        }
        public static void SetStrMod(int value)
        {
            strMod = value;
        }

        public static int GetDexMod()
        {
            return dexMod;
        }
        public static void SetDexMod(int value)
        {
            dexMod = value;
        }

        public static int GetConMod()
        {
            return conMod;
        }
        public static void SetConMod(int value)
        {
            conMod = value;
        }

        public static int GetIntMod()
        {
            return intMod;
        }
        public static void SetIntMod(int value)
        {
            intMod = value;
        }

        public static int GetWisMod()
        {
            return wisMod;
        }
        public static void SetWisMod(int value)
        {
            wisMod = value;
        }

        public static int GetChaMod()
        {
            return chaMod;
        }
        public static void SetChaMod(int value)
        {
            chaMod = value;
        }
    }
}
