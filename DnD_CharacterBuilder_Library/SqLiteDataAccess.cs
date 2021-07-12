using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;

namespace DnD_CharacterBuilder_Library
{
    public class SqLiteDataAccess
    {
        private static readonly SQLiteConnection con = new SQLiteConnection("Data Source=DnD_Character_Builder_db.db;Version=3;");
        static SQLiteCommand cmd;
        static SQLiteDataAdapter adapt;
        public static DataTable Select(string sqlcommand)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SQLiteDataAdapter(sqlcommand, con);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }
        public static bool Insert(string sqlcomm, Action<int> setter, Action parameters)
        {
            bool Succes = false;
            try
            {
                SqlConOpen(sqlcomm);
                parameters();
                int rows = cmd.ExecuteNonQuery();
                setter(Lastid());
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
        public static bool Update()
        {
            bool Succes = false;
            try 
            {
                SqlConOpen("UPDATE CHARACTER SET CharacterName=@CharacterName, PlayerName=@PlayerName, CharacterLvl=@CharacterLvl, CharacterGender=@CharacterGender, " +
                    "CharacterAge=@CharacterAge, CharacterWeight=@CharacterWeight, CharacterHeight=@CharacterHeight, CharacterAlignment=@CharacterAlignment, CharacterRace=@CharacterRace, CharacterClass=@CharacterClass, CharacterAbilityID=@CharacterAbilityID WHERE CharacterID=@CharacterID");
                Parameters(CharacterDTO.GetCharacterID(), true);
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
        public static bool Delete()
        {
            bool isSucces = false;
            try
            {
                SqlConOpen("DELETE FROM Character WHERE CharacterID=@CharacterID");
                Parameters(CharacterDTO.GetCharacterID(), false);                
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

        public static void Parameters()
        {
            cmd.Parameters.AddWithValue("@CharacterName", CharacterDTO.GetCName());
            cmd.Parameters.AddWithValue("@PlayerName", CharacterDTO.GetPName());
            cmd.Parameters.AddWithValue("@CharacterLvl", CharacterDTO.GetCLvl());
            cmd.Parameters.AddWithValue("@CharacterAge", CharacterDTO.GetCAge());
            cmd.Parameters.AddWithValue("@CharacterGender", CharacterDTO.GetCGender());
            cmd.Parameters.AddWithValue("@CharacterWeight", CharacterDTO.GetCWeight());
            cmd.Parameters.AddWithValue("@CharacterHeight", CharacterDTO.GetCHeight());
            cmd.Parameters.AddWithValue("@CharacterAlignment", CharacterDTO.GetCAlignment());
            cmd.Parameters.AddWithValue("@CharacterClass", CharacterDTO.GetCClass());
            cmd.Parameters.AddWithValue("@CharacterRace", CharacterDTO.GetCRace());
            cmd.Parameters.AddWithValue("@CharacterAbilityID", CharacterDTO.GetCAbilityID());
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
            cmd.Parameters.AddWithValue("AbilityID", CharacterDTO.GetCAbilityID());
            cmd.Parameters.AddWithValue("@Strength", AbilityDTO.GetStrength());
            cmd.Parameters.AddWithValue("@StrengthMod", AbilityDTO.GetStrMod());
            cmd.Parameters.AddWithValue("@Dexterity", AbilityDTO.GetDexterity());
            cmd.Parameters.AddWithValue("@DexterityMod", AbilityDTO.GetDexMod());
            cmd.Parameters.AddWithValue("@Constitution", AbilityDTO.GetConstitution());
            cmd.Parameters.AddWithValue("@ConstitutionMod", AbilityDTO.GetConMod());
            cmd.Parameters.AddWithValue("@Intelligence", AbilityDTO.GetIntelligence());
            cmd.Parameters.AddWithValue("@IntelligenceMod", AbilityDTO.GetIntMod());
            cmd.Parameters.AddWithValue("@Wisdom", AbilityDTO.GetWisdom());
            cmd.Parameters.AddWithValue("@WisdomMod", AbilityDTO.GetWisMod());
            cmd.Parameters.AddWithValue("@Charisma", AbilityDTO.GetCharisma());
            cmd.Parameters.AddWithValue("@CharismaMod", AbilityDTO.GetChaMod());
        }
        public static int Lastid()
        {
             string sql = "SELECT last_insert_rowid()";
             cmd = new SQLiteCommand(sql, con);
             Int64 id64 = Convert.ToInt64(cmd.ExecuteScalar());        
             int id = (int)id64; 
             return id;   
        }

        public static void SqlConOpen(string sqlcommand)
        {           
            cmd = new SQLiteCommand(sqlcommand, con);
            con.Open();
        }
    }
}
