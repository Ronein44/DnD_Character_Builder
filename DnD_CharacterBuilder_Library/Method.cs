using System;
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
            if (CharacterDTO.GetCharacterID() == 0)
            {
                SqLiteDataAccess.Insert("INSERT INTO Character (CharacterName, PlayerName, CharacterLvl, CharacterGender, CharacterAge, CharacterWeight, CharacterHeight, CharacterAlignment) " +
                "VALUES (@CharacterName, @PlayerName, @CharacterLvl, @CharacterGender, @CharacterAge, @CharacterWeight, @CharacterHeight, @CharacterAlignment)", CharacterDTO.SetCharacterID, SqLiteDataAccess.Parameters);
                SqLiteDataAccess.Insert("INSERT INTO Ability (Strength, StrengthMod, Dexterity, DexterityMod, Constitution, ConstitutionMod, Intelligence, IntelligenceMod, Wisdom, WisdomMod, Charisma, CharismaMod) " +
                "VALUES (@Strength, @StrengthMod, @Dexterity, @DexterityMod, @Constitution, @ConstitutionMod, @Intelligence, @IntelligenceMod, @Wisdom, @WisdomMod, @Charisma, @CharismaMod)", CharacterDTO.SetCAbilityID, SqLiteDataAccess.ParametersAbility);            
            }
            SqLiteDataAccess.Update();
            SqLiteDataAccess.UpdateAbility();
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
            CharacterDTO.SetCharacterID(0);
            CharacterDTO.SetCName("");
            CharacterDTO.SetPName("");
            CharacterDTO.SetCLvl(1);
            CharacterDTO.SetCAge(1);
            CharacterDTO.SetCWeight(1);
            CharacterDTO.SetCHeight(1);
            CharacterDTO.SetCGender("");
            CharacterDTO.SetCAlignment("");
            CharacterDTO.SetCClass("");
            CharacterDTO.SetCRace("");
        }
        

    }
}
