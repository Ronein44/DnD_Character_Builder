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

    public partial class Base : Form
    {
        public Base()
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
            CharacterDTO.SetCName(txtCName.Text);
            CharacterDTO.SetPName(txtPName.Text);
            CharacterDTO.SetCLvl(Convert.ToInt32(txtLvl.Value));
            CharacterDTO.SetCAge(Convert.ToInt32(txtAge.Value));
            CharacterDTO.SetCWeight(Convert.ToInt32(txtWeight.Value));
            CharacterDTO.SetCHeight(Convert.ToInt32(txtHeight.Value));
            CharacterDTO.SetCGender(txtGender.Text);
            CharacterDTO.SetCAlignment(txtAlignment.Text);
            SqLiteDataAccess.Insert();
        }
    }   
}
