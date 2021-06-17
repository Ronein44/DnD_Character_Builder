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

            ChangeLabel(LStrMod, AbilityDTO.GetStrMod(), LStr, AbilityDTO.GetStrength());

            ChangeLabel(LDexMod, AbilityDTO.GetDexMod(), LDex, AbilityDTO.GetDexterity());

            ChangeLabel(LConMod, AbilityDTO.GetConMod(), LCon, AbilityDTO.GetConstitution());

            ChangeLabel(LIntMod, AbilityDTO.GetIntMod(), LInt, AbilityDTO.GetIntelligence());

            ChangeLabel(LWisMod, AbilityDTO.GetWisMod(), LWis, AbilityDTO.GetWisdom());

            ChangeLabel(LChaMod, AbilityDTO.GetChaMod(), LCha, AbilityDTO.GetCharisma());
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
            ChangeLabel(LStrMod, AbilityDTO.GetStrMod());

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
        // End Up Down

        private void BtnMore20_Click(object sender, EventArgs e)
        {
            More20(false);
        }
        private void ChangeLabel(Label abilitymodlabel, int abilitymod)
        {
            if (abilitymod > 0)
            {
                abilitymodlabel.Text = $"+{abilitymod}";
            }
            else
            {
                abilitymodlabel.Text = abilitymod.ToString();
            }
        }
        private void ChangeLabel(Label abilitymodlabel, int abilitymod, Label abilitylabel, int getability)
        {
            abilitylabel.Text = getability.ToString();
            if (abilitymod > 0)
            {
                abilitymodlabel.Text = $"+{abilitymod}";
            }
            else
            {
                abilitymodlabel.Text = abilitymod.ToString();
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
            ChangeLabel(abilitymodlabel, tempabilitymod,abilitylabel, tempability);
        }
    }
}
