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
        public static int selected = 0;
        public RacePage()
        {
            InitializeComponent();
            foreach (DataRow dr in SqLiteDataAccess.Select("SELECT * FROM Race").Rows)
            {
                listBoxRace.Items.Add(dr["RaceName"].ToString());
            }
            if (CharacterDTO.GetCRace() == "")
            {
                listBoxRace.SelectedIndex = -1;
                listBoxRace.Visible = true;
                ChoosedPRace.Visible = false;
                btnExit2.Visible = false;
            }
            else
            {
                listBoxRace.SetSelected(selected, true);
                ChoosedPRace.Text = CharacterDTO.GetCRace();
                listBoxRace.Visible = false;
                ChoosedPRace.Visible = true;
                btnExit2.Visible = true;
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            richTextBoxRace.ResetText();
            CharacterDTO.SetCRace(listBoxRace.SelectedItem.ToString());
            RaceDTO.SetRaceDetail(SqLiteDataAccess.ImportString("SELECT RaceDetail FROM Race WHERE RaceName = @RaceName", "RaceName", CharacterDTO.GetCRace()));
            richTextBoxRace.Text = RaceDTO.GetRaceDetail();
            selected = listBoxRace.SelectedIndex;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnExit2_Click(object sender, EventArgs e)
        {
            CharacterDTO.SetCRace("");
            listBoxRace.Visible = true;
            ChoosedPRace.Visible = false;
            btnExit2.Visible = false;
        }

        private void ListBoxRace_DoubleClick(object sender, EventArgs e)
        {
            CharacterDTO.SetCRace(listBoxRace.SelectedItem.ToString());
            if (CharacterDTO.GetCRace() != "")
            {
                listBoxRace.Visible = false;
                ChoosedPRace.Visible = true;
                btnExit2.Visible = true;
                ChoosedPRace.Text = CharacterDTO.GetCRace();
            }
        }

        private void BtnSaveRace_Click(object sender, EventArgs e)
        {
            Method.Save();
        }
    }
}
