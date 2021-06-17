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
    public partial class Proficiencies : Form
    {
        public static bool load = true;
        public static List<string> ChosedSkillProf = new List<string>();
        public Proficiencies()
        {
            InitializeComponent();
            ClassDTO.GetClassSkillnum();
                       
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
            richTextBox1.ResetText();
            richTextBox1.Text = Skills.SelectedItem.ToString();
            
        }

        private void Skills_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (load ==true)
            {
                if (e.NewValue == CheckState.Checked && Skills.CheckedItems.Count >= ClassDTO.GetClassSkillnum())
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
        public void AddSkill(List<string> Base)
        {
            foreach (string item in Base)
            {
                Skills.Items.Add(item);
            }
        }
    }
}
