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
        static SQLiteConnection con = new SQLiteConnection("Data Source=DnD_Character_Builder_db.db;Version=3;");
        static SQLiteCommand cmd;
        static SQLiteDataAdapter adapt;
        public static DataTable Select()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SQLiteDataAdapter("SELECT * FROM Character", con);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }
        public static bool Insert()
        {
            bool Succes = false;
            try
            { 
                string sql = "INSERT INTO CHARACTER (CharacterName, PlayerName, CharacterLvl, CharacterGender, CharacterAge, CharacterWeight, CharacterHeight, CharacterAlignment) " +
                "VALUES (@CharacterName, @PlayerName, @CharacterLvl, @CharacterGender, @CharacterAge, @CharacterWeight, @CharacterHeight, @CharacterAlignment)";
                cmd = new SQLiteCommand(sql, con);
                con.Open();
                ParametersBase();
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
            try { 
            string sql = "UPDATE CHARACTER SET CharacterName=@CharacterName, PlayerName=@PlayerName, CharacterLvl=@CharacterLvl, CharacterGender=@CharacterGender, " +
                "CharacterAge=@CharacterAge, CharacterWeight=@CharacterWeight, CharacterHeight=@CharacterHeight, CharacterAlignment=@CharacterAlignment WHERE CharacterID=@CharacterID";
            cmd = new SQLiteCommand(sql, con);
            con.Open();
            ParametersBase();
            cmd.Parameters.AddWithValue("@CharacterID", CharacterDTO.GetCharacterID());
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
                string sql = "DELETE FROM Character WHERE CharacterID=@CharacterID";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.Parameters.AddWithValue("CharacterID", CharacterDTO.GetCharacterID());
                con.Open();
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
        
        private static void ParametersBase()
        {
            cmd.Parameters.AddWithValue("@CharacterName", CharacterDTO.GetCName());
            cmd.Parameters.AddWithValue("@PlayerName", CharacterDTO.GetPName());
            cmd.Parameters.AddWithValue("@CharacterLvl", CharacterDTO.GetCLvl());
            cmd.Parameters.AddWithValue("@CharacterAge", CharacterDTO.GetCAge());
            cmd.Parameters.AddWithValue("@CharacterGender", CharacterDTO.GetCGender());
            cmd.Parameters.AddWithValue("@CharacterWeight", CharacterDTO.GetCWeight());
            cmd.Parameters.AddWithValue("@CharacterHeight", CharacterDTO.GetCHeight());
            cmd.Parameters.AddWithValue("@CharacterAlignment", CharacterDTO.GetCAlignment());
        }
        public static int Lastid()
        {
             string sql = "SELECT last_insert_rowid()";
             cmd = new SQLiteCommand(sql, con);
             Int64 id64 = Convert.ToInt64(cmd.ExecuteScalar());        
             int id = (int)id64; 
             return id;   
        }
    }
}
