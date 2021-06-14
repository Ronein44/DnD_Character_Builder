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
    public partial class Class : Form
    {
        public static int selected = 0;
        public Class()
        {           
            InitializeComponent();
            foreach (string item in CharacterDTO.Class)
            {
                listBoxClass.Items.Add(item);
            }
            if (CharacterDTO.GetCClass() == null )
            {
                listBoxClass.SelectedIndex = -1;
                listBoxClass.Visible = true;
                ChoosedPClass.Visible = false;
                btnExit2.Visible = false;                
            }
            else
            {
                listBoxClass.SetSelected(selected, true);
                ChoosedPClass.Text = CharacterDTO.GetCClass();
                listBoxClass.Visible = false;
                ChoosedPClass.Visible = true;
                btnExit2.Visible = true;                
            }         
        }

        private void ListBoxClass_SelectedValueChanged(object sender, EventArgs e)
        {
            richTextBoxClass.ResetText();
            switch (listBoxClass.SelectedIndex)
            {
                case 0:                      
                    //ClassSwitch(DataBase.Barbarian.ClassDetails);
                    break;
                case 1:
                    //ClassSwitch(DataBase.Barbarian.ClassDetails);
                    break;
                case 2:
                    //ClassSwitch(DataBase.Barbarian.ClassDetails);
                    break;
                case 3:
                    //ClassSwitch(DataBase.Barbarian.ClassDetails);
                    break;
                case 4:
                    //ClassSwitch(DataBase.Barbarian.ClassDetails);
                    break;
                case 5:
                   //ClassSwitch(DataBase.Barbarian.ClassDetails);
                    break;
                case 6:
                    //ClassSwitch(DataBase.Barbarian.ClassDetails);
                    break;
                case 7:
                    //ClassSwitch(DataBase.Barbarian.ClassDetails);
                    break;
                case 8:
                    //ClassSwitch(DataBase.Barbarian.ClassDetails);
                    break;
                case 9:
                   // ClassSwitch(DataBase.Barbarian.ClassDetails);
                    break;
                case 10:
                   // ClassSwitch(DataBase.Barbarian.ClassDetails);
                    break;
                case 11:
                    //ClassSwitch(DataBase.Barbarian.ClassDetails);
                    break;

            }
            selected = listBoxClass.SelectedIndex;
                
        }
        private void ListBoxClass_DoubleClick(object sender, EventArgs e)
        {
            CharacterDTO.SetCClass(listBoxClass.SelectedItem.ToString());
            if (CharacterDTO.GetCClass() != null)
            {
                listBoxClass.Visible = false;
                ChoosedPClass.Visible = true;
                btnExit2.Visible = true;
                ChoosedPClass.Text = CharacterDTO.GetCClass();
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnExit2_Click(object sender, EventArgs e)
        {
            CharacterDTO.SetCClass(null);
            listBoxClass.Visible = true;
            ChoosedPClass.Visible = false;
            btnExit2.Visible = false;
        }
        public static void ClassSwitch(string db)
        {
            Class page3 = new Class();
            page3.richTextBoxClass.Text = db;
            CharacterDTO.SetCClass(CharacterDTO.Class[page3.listBoxClass.SelectedIndex]);
            //ClassDTO.SetClassSkillnum();
        }
    }
}
