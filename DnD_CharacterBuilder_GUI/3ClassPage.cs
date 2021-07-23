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
        public ClassPage()
        {           
            InitializeComponent();
            foreach (DataRow dr in SqLiteDataAccess.Select("SELECT * FROM Class").Rows)
            {
                listBoxClass.Items.Add(dr["ClassName"].ToString());
            }
            if (CharacterDTO.CClass == "" )
            {
                listBoxClass.SelectedIndex = -1;
                listBoxClass.Visible = true;
                ChoosedPClass.Visible = false;
                btnExit2.Visible = false;                
            }
            else
            {
                listBoxClass.SelectedItem = CharacterDTO.CClass;
                ChoosedPClass.Text = CharacterDTO.CClass;
                listBoxClass.Visible = false;
                ChoosedPClass.Visible = true;
                btnExit2.Visible = true;                
            }         
        }

        private void ListBoxClass_SelectedValueChanged(object sender, EventArgs e)
        {
            richTextBoxClass.ResetText();
            if (listBoxClass.SelectedItem !=null)
            {
                CharacterDTO.CClass = listBoxClass.SelectedItem.ToString();
                ClassDTO.ClassDetail = SqLiteDataAccess.ImportOneThing("SELECT ClassDetail FROM Class WHERE ClassName = @ClassName", "ClassName", CharacterDTO.CClass).ToString();
                richTextBoxClass.Text = ClassDTO.ClassDetail;
            }
                        
        }
        private void ListBoxClass_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxClass.SelectedItem != null)
            {
                CharacterDTO.CClass = listBoxClass.SelectedItem.ToString();
            }
            if (CharacterDTO.CClass != "")
            {
                listBoxClass.Visible = false;
                ChoosedPClass.Visible = true;
                btnExit2.Visible = true;
                ChoosedPClass.Text = CharacterDTO.CClass;
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnExit2_Click(object sender, EventArgs e)
        {
            CharacterDTO.CClass = "";
            listBoxClass.Visible = true;
            ChoosedPClass.Visible = false;
            btnExit2.Visible = false;
            ClassDTO.ClassSkillnum = 0;
            ProficienciesPage.ChosedSkillProf.Clear();
        }

        private void BtnSaveClass_Click(object sender, EventArgs e)
        {
            BasePage.Save();
        }
    }
}
