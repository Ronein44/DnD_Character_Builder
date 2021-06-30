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
            AbilityDTO.SetStrength(stats[0]);
            AbilityDTO.SetDexterity(stats[1]);
            AbilityDTO.SetConstitution(stats[2]);
            AbilityDTO.SetIntelligence(stats[3]);
            AbilityDTO.SetWisdom(stats[4]);
            AbilityDTO.SetCharisma(stats[5]);

            return stats;
        }
        public static int PHp(int Lvl, int ClassHp) //HP Roll
        {
            int hp2;
            if (Lvl != 1)
            {
                List<int> hp1 = new List<int>();
                hp1.AddRange(Diceroll(Lvl - 1, ClassHp, AbilityDTO.GetConMod()));
                hp2 = (hp1.Sum() + ClassHp + AbilityDTO.GetConMod());
            }
            else
            {
                hp2 = (ClassHp + AbilityDTO.GetConMod());
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
            if (CharacterDTO.GetCharacterID() != 0)
            {
                SqLiteDataAccess.Update();
            }
            else
            {
                SqLiteDataAccess.Insert();
            }
        }
        public static void NewCha()
        {           
            AbilityDTO.SetStrength(1);
            AbilityDTO.SetDexterity(1);
            AbilityDTO.SetConstitution(1);
            AbilityDTO.SetIntelligence(1);
            AbilityDTO.SetWisdom(1);
            AbilityDTO.SetCharisma(1);
            AbilityDTO.SetStrMod(-5);
            AbilityDTO.SetDexMod(-5);
            AbilityDTO.SetConMod(-5);
            AbilityDTO.SetIntMod(-5);
            AbilityDTO.SetWisMod(-5);
            AbilityDTO.SetChaMod(-5);
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
