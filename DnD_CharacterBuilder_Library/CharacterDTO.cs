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
        private static List<string> cAbility;
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

        public static List<string> GetCAbility()
        {
            return cAbility;
        }
        public static void SetCAbility(List<string> value)
        {
            cAbility = value;
        }

        public static List<string> GetCProficiencies()
        {
            return cProficiencies;
        }
        public static void SetCProficiencies(List<string> value)
        {
            cProficiencies = value;
        }


        public static List<string> Race = new List<string> { "Dragonborn", "Dwarf", "Elf", "Gnome", "Half-Elf", "Halfling", "Half-Orc", "Human", "Tiefling" };
        public static List<string> Class = new List<string> { "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard" };
        public static List<string> Stat = new List<string> { "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma" };
        public static List<string> Skills = new List<string> { "Athletics", "Acrobatics", "Sleight of Hand", "Stealth", "Arcana", "History", "Investigation", "Nature", "Religion", "Animal Handling", "Insight", "Medicine", "Perception", "Survival", "Deception", "Intimidation", "Performance", "Persuasion" };
        public static List<string> Armor = new List<string> { "Light Armor", "Medium Armor", "Heavy Armor", "Shield" };
        public static List<string> Weapontype = new List<string> { "Simple weapon", "Simple Melee Weapon", "Simple Ranged Weapon", "Martial weapon", "Martial Melee weapon", "Martial Ranged weapon" };
        public static List<string> Alignment = new List<string> { "Lawful Good", "Neutral Good", "Chaotic Good", "Lawful Neutral", "Neutral", "Chaotic Neutral", "Lawful Evil", "Neutral Evil", "Chaotic Evil" };
        public static List<string> Gender = new List<string> { "Male", "Female", "Construct" };

    }
}
