using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DnD_CharacterBuilder_Library
{
    public class SqLiteDataAccess
    {
        private static readonly SQLiteConnection con = new SQLiteConnection("Data Source=DnD_Character_Builder_db.db;Version=3;");
        public static SQLiteCommand cmd;
        public static SQLiteDataAdapter adapt;
        public static DataTable Select(string sqlcommand)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SQLiteDataAdapter(sqlcommand, con);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }
        public static int Insert(string sqlcomm, Action parameters)
        {           
            SqlConOpen(sqlcomm);
            parameters();
            cmd.ExecuteNonQuery();
            string sql = "SELECT last_insert_rowid()";
            cmd = new SQLiteCommand(sql, con);
            Int64 id64 = Convert.ToInt64(cmd.ExecuteScalar());
            int id = (int)id64;
            con.Close();
            return id;
        }
        public static bool Update()
        {
            bool Succes = false;
            try 
            {
                SqlConOpen("UPDATE CHARACTER SET CharacterName=@CharacterName, PlayerName=@PlayerName, CharacterLvl=@CharacterLvl, CharacterGender=@CharacterGender, " +
                    "CharacterAge=@CharacterAge, CharacterWeight=@CharacterWeight, CharacterHeight=@CharacterHeight, CharacterAlignment=@CharacterAlignment, CharacterRace=@CharacterRace, CharacterClass=@CharacterClass, CharacterAbilityID=@CharacterAbilityID, CharacterProficiencies=@CharacterProficiencies WHERE CharacterID=@CharacterID");
                Parameters(CharacterDTO.CharacterID, true);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                 Succes = true;
                }
            }
            catch (Exception) { ; }
            finally
            {
                con.Close();
            }
            return Succes;
        }
        public static bool UpdateAbility()
        {
            bool Succes = false;
            try
            {
                SqlConOpen("UPDATE Ability SET Strength=@Strength, StrengthMod=@StrengthMod, Dexterity=@Dexterity, DexterityMod=@DexterityMod, Constitution=@Constitution," +
                "ConstitutionMod=@ConstitutionMod, Intelligence=@Intelligence, IntelligenceMod=@IntelligenceMod, Wisdom=@Wisdom, WisdomMod=@WisdomMod, Charisma=@Charisma, CharismaMod=@CharismaMod " +
                "WHERE AbilityID=@AbilityID");
                ParametersAbility();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    Succes = true;
                }
            }
            catch (Exception) {; }
            finally
            {
                con.Close();
            }
            return Succes;
        }
        public static bool UpdateSkills()
        {
            bool Succes = false;
            try
            {
                SqlConOpen("UPDATE ClassSkillProf SET Acrobatics=@Acrobatics, AnimalHandling=@AnimalHandling, Arcana=@Arcana, Athletics=@Athletics, Deception=@Deception," +
                "History=@History, Insight=@Insight, Intimidation=@Intimidation, Investigation=@Investigation, Medicine=@Medicine, Nature=@Nature, Perception=@Perception," +
                "Performance=@Performance, Persuasion=@Persuasion, Religion=@Religion, SleightofHand=@SleightofHand, Stealth=@Stealth, Survival=@Survival " +
                "WHERE CProficienciesID=@CProficienciesID");
                ParametersSkills();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    Succes = true;
                }
            }
            catch (Exception) {; }
            finally
            {
                con.Close();
            }
            return Succes;
        }
        public static bool Delete()
        {
            bool isSucces = false;
            try
            {
                SqlConOpen("DELETE FROM Character WHERE CharacterID=@CharacterID");
                Parameters(CharacterDTO.CharacterID, false);                
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSucces = true;
                }
            }
            catch (Exception) { ; }
            finally
            {
                con.Close();
            }
            return isSucces;
        }
        public static object ImportOneThing(string sqlcomm, string parameter, object getter)
        {
            SqlConOpen(sqlcomm);
            cmd.Parameters.AddWithValue(parameter, getter);
            object output = cmd.ExecuteScalar();
            con.Close();
            return output;
        }
        public static List<string> SkillProf()
        {
            List<string> prof = new List<string>();
            DataTable dt = new DataTable();           
            cmd = new SQLiteCommand($"SELECT SkillName FROM Skills WHERE {CharacterDTO.CClass} NOT NULL", con);
            con.Open();
            adapt = new SQLiteDataAdapter(cmd);
            adapt.Fill(dt);
            con.Close();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                prof.Add(dt.Rows[i]["SkillName"].ToString());
            }
            return prof;
        }
        public static DataTable Search(string label)
        {
            con.Open();
            DataTable dt = new DataTable();
            cmd = new SQLiteCommand("SELECT CharacterID as 'ID', CharacterName, PlayerName, CharacterLvl  as 'Lvl'," +
                " CharacterAge as 'Age', CharacterGender as 'Gender', CharacterWeight as 'Weight', CharacterHeight as 'Height', CharacterAlignment as 'Alignment', CharacterClass as 'Class', CharacterRace as 'Race'" +
                " FROM Character WHERE CharacterName LIKE @CharacterName OR PlayerName LIKE @PlayerName OR CharacterLvl LIKE @CharacterLvl OR CharacterAge LIKE @CharacterAge OR CharacterGender LIKE @CharacterGender" +
                " OR CharacterWeight LIKE @CharacterWeight OR CharacterHeight LIKE @CharacterHeight OR CharacterAlignment LIKE @CharacterAlignment OR CharacterClass LIKE @CharacterClass OR CharacterRace LIKE @CharacterRace", con);           
            cmd.Parameters.AddWithValue("CharacterName", string.Format("%{0}%", label));
            cmd.Parameters.AddWithValue("PlayerName", string.Format("%{0}%", label));
            cmd.Parameters.AddWithValue("CharacterLvl", string.Format("%{0}%", label));
            cmd.Parameters.AddWithValue("CharacterAge", string.Format("%{0}%", label));
            cmd.Parameters.AddWithValue("CharacterGender", string.Format("%{0}%", label));
            cmd.Parameters.AddWithValue("CharacterWeight", string.Format("%{0}%", label));
            cmd.Parameters.AddWithValue("CharacterHeight", string.Format("%{0}%", label));
            cmd.Parameters.AddWithValue("CharacterAlignment", string.Format("%{0}%", label));
            cmd.Parameters.AddWithValue("CharacterClass", string.Format("%{0}%", label));
            cmd.Parameters.AddWithValue("CharacterRace", string.Format("%{0}%", label));
            adapt = new SQLiteDataAdapter(cmd);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }

        public static void Parameters()
        {
            cmd.Parameters.AddWithValue("@CharacterName", CharacterDTO.CName);
            cmd.Parameters.AddWithValue("@PlayerName", CharacterDTO.PName);
            cmd.Parameters.AddWithValue("@CharacterLvl", CharacterDTO.CLvl);
            cmd.Parameters.AddWithValue("@CharacterAge", CharacterDTO.CAge);
            cmd.Parameters.AddWithValue("@CharacterGender", CharacterDTO.CGender);
            cmd.Parameters.AddWithValue("@CharacterWeight", CharacterDTO.CWeight);
            cmd.Parameters.AddWithValue("@CharacterHeight", CharacterDTO.CHeight);
            cmd.Parameters.AddWithValue("@CharacterAlignment", CharacterDTO.CAlignment);
            cmd.Parameters.AddWithValue("@CharacterClass", CharacterDTO.CClass);
            cmd.Parameters.AddWithValue("@CharacterRace", CharacterDTO.CRace);
            cmd.Parameters.AddWithValue("@CharacterAbilityID", CharacterDTO.CAbilityID);
            cmd.Parameters.AddWithValue("@CharacterProficiencies", CharacterDTO.CProficienciesID);


        }
        public static void Parameters(int characterid, bool needparameters)
        {
            if (needparameters == true)
            {
                Parameters();
            }
            cmd.Parameters.AddWithValue("CharacterID", characterid);
        }
        public static void ParametersAbility()
        {
            cmd.Parameters.AddWithValue("AbilityID", CharacterDTO.CAbilityID);
            cmd.Parameters.AddWithValue("@Strength", AbilityDTO.Strength);
            cmd.Parameters.AddWithValue("@StrengthMod", AbilityDTO.StrMod);
            cmd.Parameters.AddWithValue("@Dexterity", AbilityDTO.Dexterity);
            cmd.Parameters.AddWithValue("@DexterityMod", AbilityDTO.DexMod);
            cmd.Parameters.AddWithValue("@Constitution", AbilityDTO.Constitution);
            cmd.Parameters.AddWithValue("@ConstitutionMod", AbilityDTO.ConMod);
            cmd.Parameters.AddWithValue("@Intelligence", AbilityDTO.Intelligence);
            cmd.Parameters.AddWithValue("@IntelligenceMod", AbilityDTO.IntMod);
            cmd.Parameters.AddWithValue("@Wisdom", AbilityDTO.Wisdom);
            cmd.Parameters.AddWithValue("@WisdomMod", AbilityDTO.WisMod);
            cmd.Parameters.AddWithValue("@Charisma", AbilityDTO.Charisma);
            cmd.Parameters.AddWithValue("@CharismaMod", AbilityDTO.ChaMod);
        }
        public static void ParametersSkills()
        {
            cmd.Parameters.AddWithValue("CProficienciesID", CharacterDTO.CProficienciesID);
            cmd.Parameters.AddWithValue("@Acrobatics", SkillsDTO.Acrobatics);
            cmd.Parameters.AddWithValue("@AnimalHandling", SkillsDTO.AnimalHandling);
            cmd.Parameters.AddWithValue("@Arcana", SkillsDTO.Arcana);
            cmd.Parameters.AddWithValue("@Athletics", SkillsDTO.Athletics);
            cmd.Parameters.AddWithValue("@Deception", SkillsDTO.Deception);
            cmd.Parameters.AddWithValue("@History", SkillsDTO.History);
            cmd.Parameters.AddWithValue("@Insight", SkillsDTO.Insight);
            cmd.Parameters.AddWithValue("@Intimidation", SkillsDTO.Intimidation);
            cmd.Parameters.AddWithValue("@Investigation", SkillsDTO.Investigation);
            cmd.Parameters.AddWithValue("@Medicine", SkillsDTO.Medicine);
            cmd.Parameters.AddWithValue("@Nature", SkillsDTO.Nature);
            cmd.Parameters.AddWithValue("@Perception", SkillsDTO.Perception);
            cmd.Parameters.AddWithValue("@Performance", SkillsDTO.Performance);
            cmd.Parameters.AddWithValue("@Persuasion", SkillsDTO.Persuasion);
            cmd.Parameters.AddWithValue("@Religion", SkillsDTO.Religion);
            cmd.Parameters.AddWithValue("@SleightofHand", SkillsDTO.SleightofHand);
            cmd.Parameters.AddWithValue("@Stealth", SkillsDTO.Stealth);
            cmd.Parameters.AddWithValue("@Survival", SkillsDTO.Survival);

    }
        public static void SqlConOpen(string sqlcommand)
        {                       
            con.Open();
            cmd = new SQLiteCommand(sqlcommand, con);
        }
    }
}
