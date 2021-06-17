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
    public partial class Ability : Form
    {
        public Ability()
        {
            InitializeComponent();
            More20(false);
                
            LStr.Text = AbilityDTO.GetStrength().ToString();
            ChangeLabel(LStrMod, AbilityDTO.GetStrMod());

            LDex.Text = AbilityDTO.GetDexterity().ToString();
            ChangeLabel(LDexMod, AbilityDTO.GetDexMod());

            LCon.Text = AbilityDTO.GetConstitution().ToString();
            ChangeLabel(LConMod, AbilityDTO.GetConMod());

            LInt.Text = AbilityDTO.GetIntelligence().ToString();
            ChangeLabel(LIntMod, AbilityDTO.GetIntMod());

            LWis.Text = AbilityDTO.GetWisdom().ToString();
            ChangeLabel(LWisMod, AbilityDTO.GetWisMod());

            LCha.Text = AbilityDTO.GetCharisma().ToString();
            ChangeLabel(LChaMod, AbilityDTO.GetChaMod());
            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Race f3 = new Race();
            this.Hide();
            f3.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {

        }

        private void BtnStats_Click(object sender, EventArgs e)
        {
            Method.StatRoll();
            more20.Visible = false;
            btnMore20.Visible = false;

            Texts(LStr, AbilityDTO.GetStrength(), AbilityDTO.SetStrMod);          
            ChangeLabel(LStrMod, AbilityDTO.GetStrMod()) ;

            Texts(LDex, AbilityDTO.GetDexterity(), AbilityDTO.SetDexMod);
            ChangeLabel(LDexMod, AbilityDTO.GetDexMod());

            Texts(LCon, AbilityDTO.GetConstitution(), AbilityDTO.SetConMod);
            ChangeLabel(LConMod, AbilityDTO.GetConMod());

            Texts(LInt, AbilityDTO.GetIntelligence(), AbilityDTO.SetConMod);
            ChangeLabel(LIntMod, AbilityDTO.GetIntMod());

            Texts(LWis, AbilityDTO.GetWisdom(), AbilityDTO.SetWisMod);
            ChangeLabel(LWisMod, AbilityDTO.GetWisMod());

            Texts(LCha, AbilityDTO.GetCharisma(), AbilityDTO.SetChaMod);
            ChangeLabel(LChaMod, AbilityDTO.GetChaMod());

        }

        // Up Down Buttons
        private void StrUp_Click(object sender, EventArgs e)
        {
            if (AbilityDTO.GetStrength() == 20)
            {
                More20(true);
            }
            else
            {
                AbilityDTO.SetStrength(AbilityDTO.GetStrength() + 1);
                LStr.Text = AbilityDTO.GetStrength().ToString();
                AbilityDTO.SetStrMod(Method.PcModif(AbilityDTO.GetStrength()));
                ChangeLabel(LStrMod, AbilityDTO.GetStrMod());
            }
        }
        private void StrDown_Click(object sender, EventArgs e)
        {
            if (AbilityDTO.GetStrength() > 1 && AbilityDTO.GetStrength() <= 20)
            {
                if (AbilityDTO.GetStrength() == 20)
                {
                    More20(false);
                }
                AbilityDTO.SetStrength(AbilityDTO.GetStrength() - 1);
                LStr.Text = AbilityDTO.GetStrength().ToString();
                AbilityDTO.SetStrMod(Method.PcModif(AbilityDTO.GetStrength()));
                ChangeLabel(LStrMod, AbilityDTO.GetStrMod());
            }
        }

        private void DexUp_Click(object sender, EventArgs e)
        {
            if (AbilityDTO.GetDexterity() == 20)
            {
                More20(true);
            }
            else
            {
                AbilityDTO.SetDexterity(AbilityDTO.GetDexterity() + 1);
                LDex.Text = AbilityDTO.GetDexterity().ToString();
                AbilityDTO.SetDexMod(Method.PcModif(AbilityDTO.GetDexterity()));
                ChangeLabel(LDexMod, AbilityDTO.GetDexMod());
            }
        }
        private void DexDown_Click(object sender, EventArgs e)
        {
            if (AbilityDTO.GetDexterity() > 1 && AbilityDTO.GetDexterity() <= 20)
            {
                if (AbilityDTO.GetDexterity() == 20)
                {
                    More20(false);
                }              
                AbilityDTO.SetDexterity(AbilityDTO.GetDexterity() - 1);
                LDex.Text = AbilityDTO.GetDexterity().ToString();
                AbilityDTO.SetDexMod(Method.PcModif(AbilityDTO.GetDexterity()));
                ChangeLabel(LDexMod, AbilityDTO.GetDexMod());
                
            }
        }

        private void ConUp_Click(object sender, EventArgs e)
        {
            if (AbilityDTO.GetConstitution() == 20)
            {
                More20(true);
            }
            else
            {
                AbilityDTO.SetConstitution(AbilityDTO.GetConstitution() + 1);
                LCon.Text = AbilityDTO.GetConstitution().ToString();
                AbilityDTO.SetConMod(Method.PcModif(AbilityDTO.GetConstitution()));
                ChangeLabel(LConMod, AbilityDTO.GetConMod());
            }
        }
        private void ConDown_Click(object sender, EventArgs e)
        {
            if (AbilityDTO.GetConstitution() > 1 && AbilityDTO.GetConstitution() <= 20)
            {
                if (AbilityDTO.GetConstitution() == 20)
                {
                    More20(false);
                }
                AbilityDTO.SetConstitution(AbilityDTO.GetConstitution() - 1);
                LCon.Text = AbilityDTO.GetConstitution().ToString();
                AbilityDTO.SetConMod(Method.PcModif(AbilityDTO.GetConstitution()));
                ChangeLabel(LConMod, AbilityDTO.GetConMod());

            }
        }

        private void IntUp_Click(object sender, EventArgs e)
        {
            if (AbilityDTO.GetIntelligence() == 20)
            {
                More20(true);
            }
            else
            {
                AbilityDTO.SetIntelligence(AbilityDTO.GetIntelligence() + 1);
                LInt.Text = AbilityDTO.GetIntelligence().ToString();
                AbilityDTO.SetIntMod(Method.PcModif(AbilityDTO.GetIntelligence()));
                ChangeLabel(LIntMod, AbilityDTO.GetIntMod());
            }
        }
        private void IntDown_Click(object sender, EventArgs e)
        {
            if (AbilityDTO.GetIntelligence() > 1 && AbilityDTO.GetIntelligence() <= 20)
            {
                if (AbilityDTO.GetIntelligence() == 20)
                {
                    More20(false);
                }
                AbilityDTO.SetIntelligence(AbilityDTO.GetIntelligence() - 1);
                LInt.Text = AbilityDTO.GetIntelligence().ToString();
                AbilityDTO.SetIntMod(Method.PcModif(AbilityDTO.GetIntelligence()));
                ChangeLabel(LIntMod, AbilityDTO.GetIntMod());
            }
        }

        private void WisUp_Click(object sender, EventArgs e)
        {
            if (AbilityDTO.GetWisdom() == 20)
            {
                More20(true);
            }
            else
            {
                AbilityDTO.SetWisdom(AbilityDTO.GetWisdom() + 1);
                LWis.Text = AbilityDTO.GetWisdom().ToString();
                AbilityDTO.SetWisMod(Method.PcModif(AbilityDTO.GetWisdom()));
                ChangeLabel(LWisMod, AbilityDTO.GetWisMod());
            }
        }
        private void WisDown_Click(object sender, EventArgs e)
        {
            if (AbilityDTO.GetWisdom() > 1 && AbilityDTO.GetWisdom() <= 20)
            {
                if (AbilityDTO.GetWisdom() == 20)
                {
                    More20(false);
                }
                AbilityDTO.SetWisdom(AbilityDTO.GetWisdom() - 1);
                LWis.Text = AbilityDTO.GetWisdom().ToString();
                AbilityDTO.SetWisMod(Method.PcModif(AbilityDTO.GetWisdom()));
                ChangeLabel(LWisMod, AbilityDTO.GetWisMod());
            }
        }

        private void ChaUp_Click(object sender, EventArgs e)
        {
            if (AbilityDTO.GetCharisma() == 20)
            {
                More20(true);
            }
            else
            {
                AbilityDTO.SetCharisma(AbilityDTO.GetCharisma() + 1);
                LCha.Text = AbilityDTO.GetCharisma().ToString();
                AbilityDTO.SetChaMod(Method.PcModif(AbilityDTO.GetCharisma()));
                ChangeLabel(LChaMod, AbilityDTO.GetChaMod());
            }
        }
        private void ChaDown_Click(object sender, EventArgs e)
        {
            if (AbilityDTO.GetCharisma() > 1 && AbilityDTO.GetCharisma() <= 20)
            {
                if (AbilityDTO.GetCharisma() == 20)
                {
                    More20(false);
                }
                AbilityDTO.SetCharisma(AbilityDTO.GetCharisma() - 1);
                LCha.Text = AbilityDTO.GetCharisma().ToString();
                AbilityDTO.SetChaMod(Method.PcModif(AbilityDTO.GetCharisma()));
                ChangeLabel(LChaMod, AbilityDTO.GetChaMod());
            }
        }

        private void BtnMore20_Click(object sender, EventArgs e)
        {
            More20(false);
        }
        private void ChangeLabel(Label Label, int Mod)
        {           
            if (Mod > 0)
            {
                Label.Text = $"+{Mod}";
            }
            else
            {
                Label.Text = Mod.ToString();
            }        
        }
        private void More20(bool input)
        {
            more20.Visible = input;
            btnMore20.Visible = input;
        }        
        private void Texts(Label label, int ability,Action<int> settermod)
        {
            label.Text = ability.ToString();
            settermod(Method.PcModif(ability));
            /*
            LStr.Text = AbilityDTO.GetStrength().ToString();
            AbilityDTO.SetStrMod(Method.PcModif(AbilityDTO.GetStrength()));
            */
        }
    }
}
