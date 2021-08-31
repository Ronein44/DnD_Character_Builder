using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Aspose.Pdf;
using DnD_CharacterBuilder_Library;

namespace DnD_CharacterBuilder_GUI
{
    public partial class OverviewPage : Form
    {
        public OverviewPage()
        {
            InitializeComponent();

            txtPName.Text = CharacterDTO.PName;
            txtCName.Text = CharacterDTO.CName;
            txtGender.Text = CharacterDTO.CGender;
            txtLvl.Text = CharacterDTO.CLvl.ToString();
            txtClass.Text = CharacterDTO.CClass;
            txtRace.Text = CharacterDTO.CRace;
            txtAlignment.Text = CharacterDTO.CAlignment;
            txtAge.Text = CharacterDTO.CAge.ToString();
            txtWeight.Text = CharacterDTO.CWeight.ToString();
            txtHeight.Text = CharacterDTO.CHeight.ToString();
            txtStr.Text = AbilityDTO.Strength.ToString();
            MoreThanZero(AbilityDTO.StrMod, txtStrMod);
            txtDex.Text = AbilityDTO.Dexterity.ToString();
            MoreThanZero(AbilityDTO.DexMod, txtDexMod);
            txtCon.Text = AbilityDTO.Constitution.ToString();
            MoreThanZero(AbilityDTO.ConMod, txtConMod);
            txtInt.Text = AbilityDTO.Intelligence.ToString();
            MoreThanZero(AbilityDTO.IntMod, txtIntMod);
            txtWis.Text = AbilityDTO.Wisdom.ToString();
            MoreThanZero(AbilityDTO.WisMod, txtWisMod);
            txtCha.Text = AbilityDTO.Charisma.ToString();
            MoreThanZero(AbilityDTO.ChaMod, txtChaMod);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Forms.BasePage.Save();
        }
        private static void MoreThanZero(int number, Label label)
        {
            if (number > 0)
            {
                label.ForeColor = System.Drawing.Color.Green;
                label.Text = $"+{number}".ToString();
            }
            else if (number < 0)
            {
                label.ForeColor = System.Drawing.Color.Red;
                label.Text = number.ToString();
            }
            else
            {
                label.Text = number.ToString();
            }
        }     
        private void btnPrint_Click(object sender, EventArgs e)
        {
            string filename = $"{CharacterDTO.CName}_the_{CharacterDTO.CRace}";

            PDFLayout pdflayout = new PDFLayout();
            File.WriteAllText(filename + ".html", pdflayout.htmlCode);

            Document pdf = new Document(filename + ".html");
            pdf.Save(filename + ".PDF");

        }        
    }
    
}
