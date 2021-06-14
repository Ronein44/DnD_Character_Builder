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
    public partial class LoadCharacter : Form
    {
        public LoadCharacter()
        {
            InitializeComponent();
            CharacterLoad.DataSource = SqLiteDataAccess.Select();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (CharacterLoad.RowCount > 1)
            {
                DialogResult dialogResult = MessageBox.Show("Are your sure?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    CharacterDTO.SetCharacterID(Convert.ToInt32(CharacterLoad.CurrentRow.Cells[0].Value));
                    bool succes = SqLiteDataAccess.Delete();
                    if (succes == true)
                    {
                        MessageBox.Show("Deleted!");
                        DataTable dt = SqLiteDataAccess.Select();
                        CharacterLoad.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Not Deleted!");
                    }
                    
                }
                else if (dialogResult == DialogResult.No) {; }
            }
            else
            {
                MessageBox.Show("There is nothing to delete!");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }
    }
}
