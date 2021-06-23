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

    public partial class BasePage : Form
    {
        public BasePage()
        {
            InitializeComponent();
            txtAlignment.Items.AddRange(CharacterDTO.Alignment.ToArray());
            txtAlignment.SelectedIndex = 0;
            txtGender.Items.AddRange(CharacterDTO.Gender.ToArray());
            txtGender.SelectedIndex = 0;
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are your sure?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //Nothing
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SetallText();
            SqLiteDataAccess.Update();
        }
        public void SetallText()
        {
            BasePage page2 = new BasePage();
            CharacterDTO.SetCName(page2.txtCName.Text);
            CharacterDTO.SetPName(page2.txtPName.Text);
            CharacterDTO.SetCLvl(Convert.ToInt32(page2.txtLvl.Value));
            CharacterDTO.SetCAge(Convert.ToInt32(page2.txtAge.Value));
            CharacterDTO.SetCWeight(Convert.ToInt32(page2.txtWeight.Value));
            CharacterDTO.SetCHeight(Convert.ToInt32(page2.txtHeight.Value));
            CharacterDTO.SetCGender(page2.txtGender.Text);
            CharacterDTO.SetCAlignment(page2.txtAlignment.Text);
        }

        
    }   
}
