using System;
using System.Collections.Generic;
using System.Text;

namespace DnD_CharacterBuilder_Library
{
    public class CharacterDTO
    {
        public static int CharacterID { get; set; }
        public static string CName { get; set; }
        public static string PName { get; set; }
        public static int CLvl { get; set; }
        public static string CGender { get; set; }
        public static string CClass { get; set; }
        public static string CRace { get; set; }
        public static int CWeight { get; set; }
        public static int CHeight { get; set; }
        public static int CAge { get; set; }
        public static string CAlignment { get; set; }
        public static int CAbilityID { get; set; }
        public static List<string> CProficiencies { get; set; }

    }
}
