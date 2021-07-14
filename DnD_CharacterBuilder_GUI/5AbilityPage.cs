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
    public partial class AbilityPage : Form
    {
        public AbilityPage()
        {
            InitializeComponent();
            More20(false);

            ChangeLabel(LStrMod, AbilityDTO.StrMod, LStr, AbilityDTO.Strength);

            ChangeLabel(LDexMod, AbilityDTO.DexMod, LDex, AbilityDTO.Dexterity);

            ChangeLabel(LConMod, AbilityDTO.ConMod, LCon, AbilityDTO.Constitution);

            ChangeLabel(LIntMod, AbilityDTO.IntMod, LInt, AbilityDTO.Intelligence);

            ChangeLabel(LWisMod, AbilityDTO.WisMod, LWis, AbilityDTO.Wisdom);

            ChangeLabel(LChaMod, AbilityDTO.ChaMod, LCha, AbilityDTO.Charisma);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnStats_Click(object sender, EventArgs e)
        {
            Method.StatRoll();
            more20.Visible = false;
            btnMore20.Visible = false;

            AbilityDTO.StrMod = Texts(LStr, AbilityDTO.Strength);
            ChangeLabel(LStrMod, AbilityDTO.StrMod);

            AbilityDTO.DexMod = Texts(LDex, AbilityDTO.Dexterity);
            ChangeLabel(LDexMod, AbilityDTO.DexMod);

            AbilityDTO.ConMod = Texts(LCon, AbilityDTO.Constitution);
            ChangeLabel(LConMod, AbilityDTO.ConMod);

            AbilityDTO.IntMod = Texts(LInt, AbilityDTO.Intelligence);
            ChangeLabel(LIntMod, AbilityDTO.IntMod);

            AbilityDTO.WisMod = Texts(LWis, AbilityDTO.Wisdom);
            ChangeLabel(LWisMod, AbilityDTO.WisMod);

            AbilityDTO.ChaMod = Texts(LCha, AbilityDTO.Charisma);
            ChangeLabel(LChaMod, AbilityDTO.ChaMod);

        }

        // Up Down Buttons
        private void StrUp_Click(object sender, EventArgs e)
        {
            AbilityDTO.Strength = UpAbility(AbilityDTO.Strength);
            AbilityDTO.StrMod = AbilityMod(AbilityDTO.Strength);
            ChangeLabel(LStrMod, AbilityDTO.StrMod, LStr, AbilityDTO.Strength);
        }
        private void StrDown_Click(object sender, EventArgs e)
        {
            AbilityDTO.Strength = DownAbility(AbilityDTO.Strength);
            AbilityDTO.StrMod = AbilityMod(AbilityDTO.Strength);
            ChangeLabel(LStrMod, AbilityDTO.StrMod, LStr, AbilityDTO.Strength);
        }

        private void DexUp_Click(object sender, EventArgs e)
        {
            AbilityDTO.Dexterity = UpAbility(AbilityDTO.Dexterity);
            AbilityDTO.DexMod = AbilityMod(AbilityDTO.Dexterity);
            ChangeLabel(LDexMod, AbilityDTO.DexMod, LDex, AbilityDTO.Dexterity);
        }
        private void DexDown_Click(object sender, EventArgs e)
        {
            AbilityDTO.Dexterity = DownAbility(AbilityDTO.Dexterity);
            AbilityDTO.DexMod = AbilityMod(AbilityDTO.Dexterity);
            ChangeLabel(LDexMod, AbilityDTO.DexMod, LDex, AbilityDTO.Dexterity);
        }

        private void ConUp_Click(object sender, EventArgs e)
        {
            AbilityDTO.Constitution = UpAbility(AbilityDTO.Constitution);
            AbilityDTO.ConMod = AbilityMod(AbilityDTO.Constitution);
            ChangeLabel(LConMod, AbilityDTO.ConMod, LCon, AbilityDTO.Constitution);
        }
        private void ConDown_Click(object sender, EventArgs e)
        {
            AbilityDTO.Constitution = DownAbility(AbilityDTO.Constitution);
            AbilityDTO.ConMod = AbilityMod(AbilityDTO.Constitution);
            ChangeLabel(LConMod, AbilityDTO.ConMod, LCon, AbilityDTO.Constitution);
        }

        private void IntUp_Click(object sender, EventArgs e)
        {
            AbilityDTO.Intelligence = UpAbility(AbilityDTO.Intelligence);
            AbilityDTO.IntMod = AbilityMod(AbilityDTO.Intelligence);
            ChangeLabel(LIntMod, AbilityDTO.IntMod, LInt, AbilityDTO.Intelligence);
        }
        private void IntDown_Click(object sender, EventArgs e)
        {
            AbilityDTO.Intelligence = DownAbility(AbilityDTO.Intelligence);
            AbilityDTO.IntMod = AbilityMod(AbilityDTO.Intelligence);
            ChangeLabel(LIntMod, AbilityDTO.IntMod, LInt, AbilityDTO.Intelligence);
        }

        private void WisUp_Click(object sender, EventArgs e)
        {
            AbilityDTO.Wisdom = UpAbility(AbilityDTO.Wisdom);
            AbilityDTO.WisMod = AbilityMod(AbilityDTO.Wisdom);
            ChangeLabel(LWisMod, AbilityDTO.WisMod, LWis, AbilityDTO.Wisdom);
        }
        private void WisDown_Click(object sender, EventArgs e)
        {
            AbilityDTO.Wisdom = DownAbility(AbilityDTO.Wisdom);
            AbilityDTO.WisMod = AbilityMod(AbilityDTO.Wisdom);
            ChangeLabel(LWisMod, AbilityDTO.WisMod, LWis, AbilityDTO.Wisdom);
        }

        private void ChaUp_Click(object sender, EventArgs e)
        {
            AbilityDTO.Charisma = UpAbility(AbilityDTO.Charisma);
            AbilityDTO.ChaMod = AbilityMod(AbilityDTO.Charisma);
            ChangeLabel(LChaMod, AbilityDTO.ChaMod, LCha, AbilityDTO.Charisma);
        }
        private void ChaDown_Click(object sender, EventArgs e)
        {
            AbilityDTO.Charisma = DownAbility(AbilityDTO.Charisma);
            AbilityDTO.ChaMod = AbilityMod(AbilityDTO.Charisma);
            ChangeLabel(LChaMod, AbilityDTO.ChaMod, LCha, AbilityDTO.Charisma);
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
        private void ChangeLabel(Label abilitymodlabel, int abilitymod, Label abilitylabel, int ability)
        {
            abilitylabel.Text = ability.ToString();
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
        private int Texts(Label label, int ability)
        {
            label.Text = ability.ToString();
            return Method.PcModif(ability);
        }

        private int UpAbility(int ability)
        {
            int temporaryability = ability;

            if (ability == 20)
            {
                More20(true);
            }
            else
            {
                temporaryability = ability + 1;
            }           
            return temporaryability;
        }
        private int DownAbility(int ability)
        {
            int temporaryability = ability;
            if (ability > 1)
            {
                if (ability == 20)
                {
                    More20(false);
                }
                temporaryability = ability - 1;
            }
            return temporaryability;
        }
        private int AbilityMod(int ability)
        {
            return Method.PcModif(ability); 
        }

        private void BtnSaveAbility_Click(object sender, EventArgs e)
        {
            Method.Save();
        }
    }
}
