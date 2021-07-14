using System;
using System.Collections.Generic;
using System.Text;

namespace DnD_CharacterBuilder_Library
{
    public class ClassDTO
    {
        public static string ClassName { get; set; }
        public static int ClassHitDice { get; set; }
        public static List<string> ClassArmorProf { get; set; }
        public static List<string> ClassWeaponProf { get; set; }
        public static List<string> ClassToolProf { get; set; }
        public static List<string> ClassSavingThrow = new List<string>();
        public static List<string> ClassSkillProf = new List<string>();
        public static int ClassSkillnum { get; set; }
        public static string ClassDetail { get; set; }

        
    }
}
