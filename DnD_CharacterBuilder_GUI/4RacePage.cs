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
    public partial class Race : Form
    {
        public static int selected = 0;
        public Race()
        {
            InitializeComponent();
            foreach (string item in CharacterDTO.Race)
            {
                listBoxRace.Items.Add(item);
            }
            if (CharacterDTO.GetCRace() == null)
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
            switch (listBoxRace.SelectedIndex)
            {
                case 0:
                   //RaceSwitch(DataBase.Barbarian.ClassDetails);
                   break;
                case 1:
                   //RaceSwitch(DataBase.Barbarian.ClassDetails);
                   break;
                case 2:
                   //RaceSwitch(DataBase.Barbarian.ClassDetails);
                   break;
                case 3:
                   //RaceSwitch(DataBase.Barbarian.ClassDetails);
                   break;
                case 4:
                   //RaceSwitch(DataBase.Barbarian.ClassDetails);
                   break;
                case 5:
                   //RaceSwitch(DataBase.Barbarian.ClassDetails);
                   break;
                case 6:
                   //RaceSwitch(DataBase.Barbarian.ClassDetails);
                   break;
                case 7:
                   //RaceSwitch(DataBase.Barbarian.ClassDetails);
                   break;
                case 8:
                   //RaceSwitch(DataBase.Barbarian.ClassDetails);
                   break;
            }
            
            selected = listBoxRace.SelectedIndex;


        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Class f2 = new Class();
            this.Hide();
            f2.Show();
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            Ability f4 = new Ability();
            this.Hide();
            f4.Show();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExit2_Click(object sender, EventArgs e)
        {
            CharacterDTO.SetCRace(null);
            listBoxRace.Visible = true;
            ChoosedPRace.Visible = false;
            btnExit2.Visible = false;
        }

        private void ListBoxRace_DoubleClick(object sender, EventArgs e)
        {
            CharacterDTO.SetCRace(listBoxRace.SelectedItem.ToString());
            if (CharacterDTO.GetCRace() != null)
            {
                listBoxRace.Visible = false;
                ChoosedPRace.Visible = true;
                btnExit2.Visible = true;
                ChoosedPRace.Text = CharacterDTO.GetCRace();
            }
            
        }
        public static void RaceSwitch(string db)
        {
            Race page4 = new Race();
            page4.richTextBoxRace.Text = db;
            CharacterDTO.SetCRace(CharacterDTO.Race[page4.listBoxRace.SelectedIndex]);
        }
    }
}
