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
    public partial class ClassPage : Form
    {
        public static int selected = 0;
        public ClassPage()
        {           
            InitializeComponent();
            foreach (DataRow dr in SqLiteDataAccess.Select("SELECT * FROM Class").Rows)
            {
                listBoxClass.Items.Add(dr["ClassName"].ToString());
            }
            if (CharacterDTO.GetCClass() == "" )
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
            CharacterDTO.SetCClass(listBoxClass.SelectedItem.ToString());            
            
            selected = listBoxClass.SelectedIndex;             
        }
        private void ListBoxClass_DoubleClick(object sender, EventArgs e)
        {
            CharacterDTO.SetCClass(listBoxClass.SelectedItem.ToString());
            if (CharacterDTO.GetCClass() != "")
            {
                listBoxClass.Visible = false;
                ChoosedPClass.Visible = true;
                btnExit2.Visible = true;
                ChoosedPClass.Text = CharacterDTO.GetCClass();
                ClassDTO.SetClassSkillnum(SqLiteDataAccess.ImportSkillNum());
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnExit2_Click(object sender, EventArgs e)
        {
            CharacterDTO.SetCClass("");
            listBoxClass.Visible = true;
            ChoosedPClass.Visible = false;
            btnExit2.Visible = false;
            ClassDTO.SetClassSkillnum(0);
        }

        private void BtnSaveClass_Click(object sender, EventArgs e)
        {
            SqLiteDataAccess.Update();
        }
    }
}
