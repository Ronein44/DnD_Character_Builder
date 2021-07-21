﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DnD_CharacterBuilder_Library
{
    public class Method
    {
        public static Random rnd = new Random();


        public static List<int> Diceroll(int amount, int side) //Dice Roll
        {
            List<int> rollvalue = new List<int>();
            for (int i = 0; i < amount; i++)
            {
                rollvalue.Add(rnd.Next(1, side));
            }

            return rollvalue;
        }
        public static List<int> Diceroll(int amount, int side, int modif)//Dice Roll + modifier
        {
            List<int> rollvalue = new List<int>();
            for (int i = 0; i < amount; i++)
            {
                rollvalue.Add(rnd.Next(1, side) + modif);
            }

            return rollvalue;
        }
        public static List<int> StatRoll()//Stat rolls
        {
            List<int> stats = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                List<int> SortStats = new List<int>();
                SortStats.AddRange(Diceroll(4, 7));
                SortStats.Sort();
                SortStats.RemoveAt(0);
                stats.Add(SortStats.Sum());

            }
            AbilityDTO.Strength = stats[0];
            AbilityDTO.Dexterity = stats[1];
            AbilityDTO.Constitution = stats[2];
            AbilityDTO.Intelligence = stats[3];
            AbilityDTO.Wisdom = stats[4];
            AbilityDTO.Charisma = stats[5];

            return stats;
        }
        public static int PHp(int Lvl, int ClassHp) //HP Roll
        {
            int hp2;
            if (Lvl != 1)
            {
                List<int> hp1 = new List<int>();
                hp1.AddRange(Diceroll(Lvl - 1, ClassHp, AbilityDTO.ConMod));
                hp2 = hp1.Sum() + ClassHp + AbilityDTO.ConMod;
            }
            else
            {
                hp2 = ClassHp + AbilityDTO.ConMod;
            }
            return hp2;
        }
        public static int PcModif(int stat) //Modifier
        {
            int i = 1;
            int mod = -5;
            while (i < stat)
            {
                mod++;
                i += 2;
            }
            return mod;
        }
        public static void Save()
        {
            if (CharacterDTO.CharacterID == 0)
            {
                CharacterDTO.CharacterID = SqLiteDataAccess.Insert("INSERT INTO Character (CharacterName, PlayerName, CharacterLvl, CharacterGender, CharacterAge, CharacterWeight, CharacterHeight, CharacterAlignment) " +
                "VALUES (@CharacterName, @PlayerName, @CharacterLvl, @CharacterGender, @CharacterAge, @CharacterWeight, @CharacterHeight, @CharacterAlignment)", SqLiteDataAccess.Parameters);                
                CharacterDTO.CAbilityID = SqLiteDataAccess.Insert("INSERT INTO Ability (Strength, StrengthMod, Dexterity, DexterityMod, Constitution, ConstitutionMod, Intelligence, IntelligenceMod, Wisdom, WisdomMod, Charisma, CharismaMod) " +
                "VALUES (@Strength, @StrengthMod, @Dexterity, @DexterityMod, @Constitution, @ConstitutionMod, @Intelligence, @IntelligenceMod, @Wisdom, @WisdomMod, @Charisma, @CharismaMod)", SqLiteDataAccess.ParametersAbility);
                CharacterDTO.CProficienciesID = SqLiteDataAccess.Insert("INSERT INTO ClassSkillProf (Acrobatics, AnimalHandling, Arcana, Athletics, Deception, History, Insight, Intimidation, Investigation, Medicine, " +
                    "Nature, Perception, Performance, Persuasion, Religion, SleightofHand, Stealth, Survival) VALUES (@Acrobatics, @AnimalHandling, @Arcana, @Athletics, @Deception, @History, @Insight, @Intimidation, @Investigation, @Medicine, " +
                    "@Nature, @Perception, @Performance, @Persuasion, @Religion, @SleightofHand, @Stealth, @Survival)", SqLiteDataAccess.ParametersSkills) ;
            }
            SqLiteDataAccess.UpdateBase();
            SqLiteDataAccess.UpdateAbility();
            SqLiteDataAccess.UpdateSkills();
        }
        public static void NewCha()
        {           
            AbilityDTO.Strength = 1;
            AbilityDTO.Dexterity = 1;
            AbilityDTO.Constitution = 1;
            AbilityDTO.Intelligence = 1;
            AbilityDTO.Wisdom = 1;
            AbilityDTO.Charisma = 1;
            AbilityDTO.StrMod = -5;
            AbilityDTO.DexMod = -5;
            AbilityDTO.ConMod = -5;
            AbilityDTO.IntMod = -5;
            AbilityDTO.WisMod = -5;
            AbilityDTO.ChaMod= -5;
            CharacterDTO.CharacterID = 0;
            CharacterDTO.CName = "";
            CharacterDTO.PName = "";
            CharacterDTO.CLvl = 1;
            CharacterDTO.CAge = 1;
            CharacterDTO.CWeight = 1;
            CharacterDTO.CHeight = 1;
            CharacterDTO.CGender = "";
            CharacterDTO.CAlignment = "";
            CharacterDTO.CClass = "";
            CharacterDTO.CRace = "";
        }
        

    }
}
