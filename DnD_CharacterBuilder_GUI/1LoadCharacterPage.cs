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
            DataSource();
            btnExit2.Visible = false;

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
                    CharacterDTO.CharacterID = Convert.ToInt32(CharacterLoad.CurrentRow.Cells[0].Value);
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
            CharacterDTO.CharacterID = Convert.ToInt32(CharacterLoad.CurrentRow.Cells[0].Value);
            CharacterDTO.CAbilityID = Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT CharacterAbilityID FROM Character WHERE CharacterID = @CharacterID", "CharacterID", CharacterDTO.CharacterID));
            CharacterDTO.CProficienciesID = Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT CharacterProficienciesID FROM Character WHERE CharacterID = @CharacterID", "CharacterID", CharacterDTO.CharacterID));
            ProficienciesPage.ChosedSkillProf = SqLiteDataAccess.LoadSkillProf();
            CharacterDTO.CName = CharacterLoad.CurrentRow.Cells[1].Value.ToString();
            CharacterDTO.PName = CharacterLoad.CurrentRow.Cells[2].Value.ToString();
            CharacterDTO.CLvl = Convert.ToInt32(CharacterLoad.CurrentRow.Cells[3].Value);
            CharacterDTO.CAge = Convert.ToInt32(CharacterLoad.CurrentRow.Cells[4].Value);
            CharacterDTO.CGender = CharacterLoad.CurrentRow.Cells[5].Value.ToString();
            CharacterDTO.CWeight = Convert.ToInt32(CharacterLoad.CurrentRow.Cells[6].Value);
            CharacterDTO.CHeight = Convert.ToInt32((CharacterLoad.CurrentRow.Cells[7].Value));
            CharacterDTO.CAlignment = CharacterLoad.CurrentRow.Cells[8].Value.ToString();
            CharacterDTO.CClass = CharacterLoad.CurrentRow.Cells[9].Value.ToString();
            CharacterDTO.CRace = CharacterLoad.CurrentRow.Cells[10].Value.ToString();
            CharacterDTO.HP = Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT CharacterHP FROM Character WHERE CharacterID = @CharacterID", "CharacterID", CharacterDTO.CharacterID));
            AbilityDTO.Strength = Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT Strength FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.CAbilityID));
            AbilityDTO.StrMod = Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT StrengthMod FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.CAbilityID));
            AbilityDTO.Dexterity = Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT Dexterity FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.CAbilityID));
            AbilityDTO.DexMod = Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT DexterityMod FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.CAbilityID));
            AbilityDTO.Constitution = Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT Constitution FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.CAbilityID));
            AbilityDTO.ConMod = Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT ConstitutionMod FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.CAbilityID));
            AbilityDTO.Intelligence = Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT Intelligence FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.CAbilityID));
            AbilityDTO.IntMod = Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT IntelligenceMod FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.CAbilityID));
            AbilityDTO.Wisdom = Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT Wisdom FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.CAbilityID));
            AbilityDTO.WisMod = Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT WisdomMod FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.CAbilityID));
            AbilityDTO.Charisma = Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT Charisma FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.CAbilityID));
            AbilityDTO.ChaMod = Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT CharismaMod FROM Ability WHERE AbilityID = @AbilityID", "AbilityID", CharacterDTO.CAbilityID));
            MessageBox.Show($"{CharacterDTO.CName} \nCharacter Load Success!");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            CharacterLoad.DataSource = SqLiteDataAccess.Search(txtSearch.Text);
            btnExit2.Visible = true;
        }
        private void DataSource()
        {
            CharacterLoad.DataSource = SqLiteDataAccess.Select("SELECT CharacterID as 'ID', CharacterName, PlayerName, CharacterLvl  as 'Lvl'," +
                " CharacterAge as 'Age', CharacterGender as 'Gender', CharacterWeight as 'Weight', CharacterHeight as 'Height', CharacterAlignment as 'Alignment', CharacterClass as 'Class', CharacterRace as 'Race' FROM Character");
        }

        private void BtnExit2_Click(object sender, EventArgs e)
        {
            DataSource();
            btnExit2.Visible = false;
            txtSearch.Text = "";
        }
    }
}
