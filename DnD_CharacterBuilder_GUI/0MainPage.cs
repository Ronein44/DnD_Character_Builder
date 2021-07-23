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
    public partial class MainPage : Form
    {
        public bool NewCharacter = false;
        
        public MainPage()
        {
            InitializeComponent();
            HideSubMenu();
            BtnEnable(false);
        }
        
        private void BtnCharacter_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelCharacterSubMenu);          
        }

        //region CharacterSubMenu
        private void BtnNewCha_Click(object sender, EventArgs e)
        {        
            if (NewCharacter == true)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to create a new character?", "New Character", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DialogResult dialogResult2 = MessageBox.Show("Do you want to save your progress", "New Character", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        SqLiteDataAccess.UpdateBase();
                        Method.NewCha();
                    }
                    else if (dialogResult2 == DialogResult.No)
                    {
                        Method.NewCha();
                    }                    
                }
                else if (dialogResult == DialogResult.No){ ; }
            }
            else
            {                
                Method.NewCha();               
            }                       
            OpenChildForm(new BasePage());
            NewCharacter = true;            
            BtnEnable(true);
        }
        private void BtnLoadCharacter_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LoadCharacterPage());
        }
        private void BtnBase_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BasePage());
        }
        private void BtnClass_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClassPage());
        }
        private void BtnRace_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RacePage());
        }
        private void BtnAbility_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AbilityPage());
        }
        private void BtnProficiencies_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProficienciesPage());
        }
        private void btnReview_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OverviewPage());
        }
        //endregion

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are your sure?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //Go back
            }
        }

        public static Form activeForm = null;
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;            
            childForm.Show();
            childForm.BringToFront();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void BtnEnable(bool input)
        {            
            btnBase.Enabled = input;
            btnClass.Enabled = input;
            btnRace.Enabled = input;
            btnAbility.Enabled = input;
            btnProficiencies.Enabled = input;
            btnReview.Enabled = input;
        }
        
        private void HideSubMenu()
        {
            panelCharacterSubMenu.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        
    }
}
