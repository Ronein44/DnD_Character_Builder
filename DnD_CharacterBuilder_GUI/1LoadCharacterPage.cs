using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnD_CharacterBuilder_Library;

namespace DnD_CharacterBuilder_GUI.Forms
{
    public partial class LoadCharacterPage : Form
    {
        
        public LoadCharacterPage()
        {
            InitializeComponent();            
            CharacterLoad.DataSource = SqLiteDataAccess.Select("SELECT CharacterID as 'ID', CharacterName, PlayerName, CharacterLvl  as 'Lvl'," +
                " CharacterAge as 'Age', CharacterGender as 'Gender', CharacterWeight as 'Weight', CharacterHeight as 'Height', CharacterAlignment as 'Alignment', CharacterClass as 'Class', CharacterRace as 'Race' FROM Character");
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (CharacterLoad.RowCount > 1)
            {
                DialogResult dialogResult = MessageBox.Show("Are your sure?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CharacterDTO.SetCharacterID(Convert.ToInt32(CharacterLoad.CurrentRow.Cells[0].Value));
                    bool succes = SqLiteDataAccess.Delete();
                    if (succes == true)
                    {
                        MessageBox.Show("Deleted!");
                        DataTable dt = SqLiteDataAccess.Select("SELECT * FROM Character");
                        CharacterLoad.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Not Deleted!");
                    }                    
                }
                else if (dialogResult == DialogResult.No) 
                {
                    //Nothing
                }
            }
            else
            {
                MessageBox.Show("There is nothing to delete!");
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {

            CharacterDTO.SetCharacterID(Convert.ToInt32(CharacterLoad.CurrentRow.Cells[0].Value));
            try
            {
                CharacterDTO.SetCAbilityID(Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT CharacterAbilityID FROM Character WHERE CharacterID = @CharacterID", "CharacterID", CharacterDTO.GetCharacterID())));
            }
            catch (Exception)
            {
                //Nothing
            }            
            CharacterDTO.SetCName(CharacterLoad.CurrentRow.Cells[1].Value.ToString());
            CharacterDTO.SetPName(CharacterLoad.CurrentRow.Cells[2].Value.ToString());
            CharacterDTO.SetCLvl(Convert.ToInt32(CharacterLoad.CurrentRow.Cells[3].Value));
            CharacterDTO.SetCAge(Convert.ToInt32(CharacterLoad.CurrentRow.Cells[4].Value));
            CharacterDTO.SetCGender(CharacterLoad.CurrentRow.Cells[5].Value.ToString());
            CharacterDTO.SetCWeight(Convert.ToInt32(CharacterLoad.CurrentRow.Cells[6].Value));
            CharacterDTO.SetCHeight(Convert.ToInt32((CharacterLoad.CurrentRow.Cells[7].Value)));
            CharacterDTO.SetCAlignment(CharacterLoad.CurrentRow.Cells[8].Value.ToString());
            CharacterDTO.SetCClass(CharacterLoad.CurrentRow.Cells[9].Value.ToString());
            CharacterDTO.SetCRace(CharacterLoad.CurrentRow.Cells[10].Value.ToString());
            AbilityDTO.SetStrength(Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT Strength FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.GetCAbilityID())));
            AbilityDTO.SetStrMod(Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT StrengthMod FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.GetCAbilityID())));
            AbilityDTO.SetDexterity(Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT Dexterity FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.GetCAbilityID())));
            AbilityDTO.SetDexMod(Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT DexterityMod FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.GetCAbilityID())));
            AbilityDTO.SetConstitution(Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT Constitution FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.GetCAbilityID())));
            AbilityDTO.SetConMod(Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT ConstitutionMod FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.GetCAbilityID())));
            AbilityDTO.SetIntelligence(Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT Intelligence FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.GetCAbilityID())));
            AbilityDTO.SetIntMod(Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT IntelligenceMod FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.GetCAbilityID())));
            AbilityDTO.SetWisdom(Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT Wisdom FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.GetCAbilityID())));
            AbilityDTO.SetWisMod(Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT WisdomMod FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.GetCAbilityID())));
            AbilityDTO.SetCharisma(Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT Charisma FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.GetCAbilityID())));
            AbilityDTO.SetChaMod(Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT CharismaMod FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.GetCAbilityID())));


        }
    }
}
