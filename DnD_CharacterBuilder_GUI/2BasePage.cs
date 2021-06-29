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

            foreach (DataRow dr in SqLiteDataAccess.Select("SELECT * FROM Gender").Rows)
            {
                txtGender.Items.Add(dr["Gender"].ToString());
            }
            foreach (DataRow dr in SqLiteDataAccess.Select("SELECT * FROM Alignment").Rows)
            {
                txtAlignment.Items.Add(dr["AlignmentName"].ToString());
            }            
            txtCName.Text = CharacterDTO.GetCName();
            txtPName.Text = CharacterDTO.GetPName();
            txtLvl.Value = CharacterDTO.GetCLvl();
            txtAge.Value = CharacterDTO.GetCAge();
            txtWeight.Value = CharacterDTO.GetCWeight();
            txtHeight.Value = CharacterDTO.GetCHeight();
            txtGender.SelectedItem = CharacterDTO.GetCGender();
            txtAlignment.SelectedItem = CharacterDTO.GetCAlignment();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqLiteDataAccess.Update();
        }

        private void TxtCName_TextChanged(object sender, EventArgs e)
        {
            CharacterDTO.SetCName(txtCName.Text);           
        }
        private void TxtPName_TextChanged(object sender, EventArgs e)
        {
            CharacterDTO.SetPName(txtPName.Text);
        }
        private void TxtLvl_ValueChanged(object sender, EventArgs e)
        {
            CharacterDTO.SetCLvl(Convert.ToInt32(txtLvl.Value));
        }
        private void TxtWeight_ValueChanged(object sender, EventArgs e)
        {
            CharacterDTO.SetCWeight(Convert.ToInt32(txtWeight.Value));
        }
        private void TxtGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterDTO.SetCGender(txtGender.Text);
        }
        private void TxtHeight_ValueChanged(object sender, EventArgs e)
        {
            CharacterDTO.SetCHeight(Convert.ToInt32(txtHeight.Value));
        }
        private void TxtAge_ValueChanged(object sender, EventArgs e)
        {
            CharacterDTO.SetCAge(Convert.ToInt32(txtAge.Value));
        }
        private void TxtAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterDTO.SetCAlignment(txtAlignment.Text);
        }
    }   
}
