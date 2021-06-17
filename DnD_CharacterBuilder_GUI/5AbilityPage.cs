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
            UpandDown(AbilityDTO.GetStrength(), AbilityDTO.SetStrength, AbilityDTO.SetStrMod, LStr, LStrMod, "Up");
            
        }
        private void StrDown_Click(object sender, EventArgs e)
        {
            UpandDown(AbilityDTO.GetStrength(), AbilityDTO.SetStrength, AbilityDTO.SetStrMod, LStr, LStrMod, "Down");
        }

        private void DexUp_Click(object sender, EventArgs e)
        {
            UpandDown(AbilityDTO.GetDexterity(), AbilityDTO.SetDexterity, AbilityDTO.SetDexMod, LDex, LDexMod, "Up");
        }
        private void DexDown_Click(object sender, EventArgs e)
        {
            UpandDown(AbilityDTO.GetDexterity(), AbilityDTO.SetDexterity, AbilityDTO.SetDexMod, LDex, LDexMod, "Down");
        }

        private void ConUp_Click(object sender, EventArgs e)
        {
            UpandDown(AbilityDTO.GetConstitution(), AbilityDTO.SetConstitution, AbilityDTO.SetConMod, LCon, LConMod, "Up");
        }
        private void ConDown_Click(object sender, EventArgs e)
        {
            UpandDown(AbilityDTO.GetConstitution(), AbilityDTO.SetConstitution, AbilityDTO.SetConMod, LCon, LConMod, "Down");
        }

        private void IntUp_Click(object sender, EventArgs e)
        {
            UpandDown(AbilityDTO.GetIntelligence(), AbilityDTO.SetIntelligence, AbilityDTO.SetIntMod, LInt, LIntMod, "Up");
        }
        private void IntDown_Click(object sender, EventArgs e)
        {
            UpandDown(AbilityDTO.GetIntelligence(), AbilityDTO.SetIntelligence, AbilityDTO.SetIntMod, LInt, LIntMod, "Down");
        }

        private void WisUp_Click(object sender, EventArgs e)
        {
            UpandDown(AbilityDTO.GetWisdom(), AbilityDTO.SetWisdom, AbilityDTO.SetWisMod, LWis, LWisMod, "Up");
        }
        private void WisDown_Click(object sender, EventArgs e)
        {
            UpandDown(AbilityDTO.GetWisdom(), AbilityDTO.SetWisdom, AbilityDTO.SetWisMod, LWis, LWisMod, "Down");
        }

        private void ChaUp_Click(object sender, EventArgs e)
        {
            UpandDown(AbilityDTO.GetCharisma(), AbilityDTO.SetCharisma, AbilityDTO.SetChaMod, LCha, LChaMod, "Up");
        }
        private void ChaDown_Click(object sender, EventArgs e)
        {
            UpandDown(AbilityDTO.GetCharisma(), AbilityDTO.SetCharisma, AbilityDTO.SetChaMod, LCha, LChaMod, "Down");
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
        private void UpandDown(int getability, Action<int> setability, Action<int> setabilitymod, Label abilitylabel, Label abilitymodlabel, string upordown)
        {
            int tempability = getability;
            int tempabilitymod;
            if (upordown =="Up")
            {
                if (getability == 20)
                {
                    More20(true);
                }
                else
                {                    
                    tempability = getability + 1;
                }
            }
            else
            {
                if (getability > 1)
                {
                    if (getability == 20)
                    {
                        More20(false);
                    }
                    tempability = getability - 1;                   
                }
            }
            tempabilitymod = Method.PcModif(tempability);
            setability(tempability);
            setabilitymod(tempabilitymod);
            abilitylabel.Text = tempability.ToString();
            ChangeLabel(abilitymodlabel, tempabilitymod);
        }
    }
}
