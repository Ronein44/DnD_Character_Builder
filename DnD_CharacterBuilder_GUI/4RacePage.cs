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
    public partial class RacePage : Form
    {
        public RacePage()
        {
            InitializeComponent();
            foreach (DataRow dr in SqLiteDataAccess.Select("SELECT * FROM Race").Rows)
            {
                listBoxRace.Items.Add(dr["RaceName"].ToString());
            }
            if (CharacterDTO.CRace == "")
            {
                listBoxRace.SelectedIndex = -1;
                listBoxRace.Visible = true;
                ChoosedPRace.Visible = false;
                btnExit2.Visible = false;
                RaceDTO.RaceSpeed = 0;
            }
            else
            {
                listBoxRace.SelectedItem = CharacterDTO.CRace;
                ChoosedPRace.Text = CharacterDTO.CRace;
                listBoxRace.Visible = false;
                ChoosedPRace.Visible = true;
                btnExit2.Visible = true;
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            richTextBoxRace.ResetText();
            if (listBoxRace.SelectedItem != null)
            {
                CharacterDTO.CRace = listBoxRace.SelectedItem.ToString();
                RaceDTO.RaceDetail = SqLiteDataAccess.ImportOneThing("SELECT RaceDetail FROM Race WHERE RaceName = @RaceName", "RaceName", CharacterDTO.CRace).ToString();
                RaceDTO.RaceSpeed = Convert.ToInt32(SqLiteDataAccess.ImportOneThing("SELECT Speed FROM Race WHERE RaceName = @RaceName", "RaceName", CharacterDTO.CRace));
                richTextBoxRace.Text = RaceDTO.RaceDetail;
            }
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnExit2_Click(object sender, EventArgs e)
        {
            CharacterDTO.CRace = "";
            RaceDTO.RaceSpeed = 0;
            listBoxRace.Visible = true;
            ChoosedPRace.Visible = false;
            btnExit2.Visible = false;
        }

        private void ListBoxRace_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxRace.SelectedItem !=null)
            {
                CharacterDTO.CRace = listBoxRace.SelectedItem.ToString();
            }
            if (CharacterDTO.CRace != "")
            {
                listBoxRace.Visible = false;
                ChoosedPRace.Visible = true;
                btnExit2.Visible = true;
                ChoosedPRace.Text = CharacterDTO.CRace;
            }
        }

        private void BtnSaveRace_Click(object sender, EventArgs e)
        {
            BasePage.Save();
        }
    }
}
