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
    public partial class ProficienciesPage : Form
    {
        public static bool load = true;
        public static List<string> ChosedSkillProf = new List<string>();
        public ProficienciesPage()
        {
            InitializeComponent();

            foreach (string item in SqLiteDataAccess.SkillProf())
            {
                Skills.Items.Add(item);
            }
            
            if (load == true)
            {
                load = false;
                for (int i = 0; i < Skills.Items.Count; i++)
                {
                    if (ChosedSkillProf.Contains(Skills.Items[i]))
                    {
                        Skills.SetItemChecked(i, true);
                    }
                }
                load = true;
            }           
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Skills_SelectedIndexChanged(object sender, EventArgs e)
        {            
            richTextBoxProfDetail.ResetText();
            richTextBoxProfDetail.Text = SqLiteDataAccess.ImportOneThing("SELECT SkillDetail FROM Skills WHERE SkillName = @SkillName", "SkillName", Skills.SelectedItem).ToString();           
        }

        private void Skills_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (load ==true)
            {
                if (e.NewValue == CheckState.Checked && Skills.CheckedItems.Count >= ClassDTO.ClassSkillnum)
                {
                    e.NewValue = CheckState.Unchecked;
                }
                else if (e.NewValue == CheckState.Unchecked)
                {
                    ChosedSkillProf.Remove(Skills.SelectedItem.ToString());
                }
                else if (e.NewValue == CheckState.Checked)
                {
                    ChosedSkillProf.Add(Skills.SelectedItem.ToString());
                }
            }            
        }

        private void BtnSaveProf_Click(object sender, EventArgs e)
        {
            Method.Save();
        }
    }
}
