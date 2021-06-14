using System;
using System.Collections.Generic;
using System.Text;

namespace DnD_CharacterBuilder_Library
{
    public class ClassDTO
    {
        private static string className;
        private static int classHitDice;
        private static List<string> classArmorProf;
        private static List<string> classWeaponProf;
        private static List<string> classToolProf;
        private static List<string> classSavingThrow = new List<string>();
        private static List<string> classSkillProf = new List<string>();
        private static int classSkillnum;
        private static string classDetail;

        public static string GetClassName()
        {
            return className;
        }
        public static void SetClassName(string value)
        {
            className = value;
        }

        public static int GetClassHitDice()
        {
            return classHitDice;
        }
        public static void SetClassHitDice(int value)
        {
            classHitDice = value;
        }

        public static List<string> GetClassArmorProf()
        {
            return classArmorProf;
        }
        public static void SetClassArmorProf(List<string> value)
        {
            classArmorProf = value;
        }

        public static List<string> GetClassWeaponProf()
        {
            return classWeaponProf;
        }
        public static void SetClassWeaponProf(List<string> value)
        {
            classWeaponProf = value;
        }

        public static List<string> GetClassToolProf()
        {
            return classToolProf;
        }
        public static void SetClassToolProf(List<string> value)
        {
            classToolProf = value;
        }

        public static List<string> GetClassSavingThrow()
        {
            return classSavingThrow;
        }
        public static void SetClassSavingThrow(List<string> value)
        {
            classSavingThrow = value;
        }

        public static List<string> GetClassSkillProfe()
        {
            return classSkillProf;
        }
        public static void SetClassSkillProf(List<string> value)
        {
            classSkillProf = value;
        }

        public static int GetClassSkillnum()
        {
            return classSkillnum;
        }
        public static void SetClassSkillnum(int value)
        {
            classSkillnum = value;
        }

        public static string GetClassDetail()
        {
            return classDetail;
        }
        public static void SetClassDetail(string value)
        {
            classDetail = value;
        }
    }
}
