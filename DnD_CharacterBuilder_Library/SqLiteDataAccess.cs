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
        public static bool Insert()
        {
            bool Succes = false;
            try
            {
                SqlConOpen("INSERT INTO CHARACTER (CharacterName, PlayerName, CharacterLvl, CharacterGender, CharacterAge, CharacterWeight, CharacterHeight, CharacterAlignment) " +
                "VALUES (@CharacterName, @PlayerName, @CharacterLvl, @CharacterGender, @CharacterAge, @CharacterWeight, @CharacterHeight, @CharacterAlignment)");
                Parameters();
                int rows = cmd.ExecuteNonQuery();
                CharacterDTO.SetCharacterID(Lastid());
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
                    "CharacterAge=@CharacterAge, CharacterWeight=@CharacterWeight, CharacterHeight=@CharacterHeight, CharacterAlignment=@CharacterAlignment, CharacterRace=@CharacterRace, CharacterClass=@CharacterClass WHERE CharacterID=@CharacterID");
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
        public static int ImportSkillNum()
        {           
            SqlConOpen("SELECT NumberofSkill FROM Class WHERE ClassName = @ClassName");
            cmd.Parameters.AddWithValue("ClassName", CharacterDTO.GetCClass());
            int skillnum = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return skillnum;
        }
        public static DataTable CharacterLoad(string sqlcommand)
        {
            DataTable dt = new DataTable();
            SqlConOpen(sqlcommand);
            cmd.Parameters.AddWithValue("CharacterID", CharacterDTO.GetCharacterID());
            adapt.Fill(dt);
            con.Close();
            return dt;
            
        }

        private static void Parameters()
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
        }
        private static void Parameters(int characterid, bool needparameters)
        {
            if (needparameters == true)
            {
                Parameters();
            }
            cmd.Parameters.AddWithValue("CharacterID", characterid);
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
