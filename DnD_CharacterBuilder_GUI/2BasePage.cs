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
            txtCName.Text = CharacterDTO.CName;
            txtPName.Text = CharacterDTO.PName;
            txtLvl.Value = CharacterDTO.CLvl;
            txtAge.Value = CharacterDTO.CAge;
            txtWeight.Value = CharacterDTO.CWeight;
            txtHeight.Value = CharacterDTO.CHeight;
            txtGender.SelectedItem = CharacterDTO.CGender;
            txtAlignment.SelectedItem = CharacterDTO.CAlignment;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Method.Save();
        }

        private void TxtCName_TextChanged(object sender, EventArgs e)
        {
            CharacterDTO.CName = txtCName.Text;           
        }
        private void TxtPName_TextChanged(object sender, EventArgs e)
        {
            CharacterDTO.PName = txtPName.Text;
        }
        private void TxtLvl_ValueChanged(object sender, EventArgs e)
        {
            CharacterDTO.CLvl = Convert.ToInt32(txtLvl.Value);
        }
        private void TxtWeight_ValueChanged(object sender, EventArgs e)
        {
            CharacterDTO.CWeight = Convert.ToInt32(txtWeight.Value);
        }
        private void TxtGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterDTO.CGender = txtGender.Text;
        }
        private void TxtHeight_ValueChanged(object sender, EventArgs e)
        {
            CharacterDTO.CHeight = Convert.ToInt32(txtHeight.Value);
        }
        private void TxtAge_ValueChanged(object sender, EventArgs e)
        {
            CharacterDTO.CAge = Convert.ToInt32(txtAge.Value);
        }
        private void TxtAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterDTO.CAlignment = txtAlignment.Text;
        }
        
    }   
}
