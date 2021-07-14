using System;
using System.Collections.Generic;
using System.Text;

namespace DnD_CharacterBuilder_Library
{
    public class AbilityDTO
    {
        private static int strength;

        public static int Strength { get => strength; set => strength = value; }
        public static int Dexterity { get; set; }
        public static int Constitution { get; set; }
        public static int Intelligence { get; set; }
        public static int Wisdom { get; set; }
        public static int Charisma { get; set; }
        public static int StrMod { get; set; }
        public static int DexMod { get; set; }
        public static int ConMod { get; set; }
        public static int IntMod { get; set; }
        public static int WisMod { get; set; }
        public static int ChaMod { get; set; }
    }
}
