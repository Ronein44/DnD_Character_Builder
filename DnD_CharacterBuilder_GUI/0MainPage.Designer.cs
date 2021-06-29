
namespace DnD_CharacterBuilder_GUI.Forms
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panelCharacterSubMenu = new System.Windows.Forms.Panel();
            this.btnProficiencies = new System.Windows.Forms.Button();
            this.btnAbility = new System.Windows.Forms.Button();
            this.btnRace = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnBase = new System.Windows.Forms.Button();
            this.btnLoadCharacter = new System.Windows.Forms.Button();
            this.btnNewCha = new System.Windows.Forms.Button();
            this.btnCharacter = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelCharacterSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.panelCharacterSubMenu);
            this.panelSideMenu.Controls.Add(this.btnCharacter);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 761);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 716);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(250, 45);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "  Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.Silver;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 428);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(250, 45);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "  Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // panelCharacterSubMenu
            // 
            this.panelCharacterSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelCharacterSubMenu.Controls.Add(this.btnProficiencies);
            this.panelCharacterSubMenu.Controls.Add(this.btnAbility);
            this.panelCharacterSubMenu.Controls.Add(this.btnRace);
            this.panelCharacterSubMenu.Controls.Add(this.btnClass);
            this.panelCharacterSubMenu.Controls.Add(this.btnBase);
            this.panelCharacterSubMenu.Controls.Add(this.btnLoadCharacter);
            this.panelCharacterSubMenu.Controls.Add(this.btnNewCha);
            this.panelCharacterSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCharacterSubMenu.Location = new System.Drawing.Point(0, 137);
            this.panelCharacterSubMenu.Name = "panelCharacterSubMenu";
            this.panelCharacterSubMenu.Size = new System.Drawing.Size(250, 291);
            this.panelCharacterSubMenu.TabIndex = 2;
            // 
            // btnProficiencies
            // 
            this.btnProficiencies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProficiencies.FlatAppearance.BorderSize = 0;
            this.btnProficiencies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnProficiencies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnProficiencies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProficiencies.ForeColor = System.Drawing.Color.Silver;
            this.btnProficiencies.Location = new System.Drawing.Point(0, 244);
            this.btnProficiencies.Name = "btnProficiencies";
            this.btnProficiencies.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProficiencies.Size = new System.Drawing.Size(250, 40);
            this.btnProficiencies.TabIndex = 6;
            this.btnProficiencies.Text = "Proficiencies";
            this.btnProficiencies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProficiencies.UseVisualStyleBackColor = true;
            this.btnProficiencies.Click += new System.EventHandler(this.BtnProficiencies_Click);
            // 
            // btnAbility
            // 
            this.btnAbility.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbility.FlatAppearance.BorderSize = 0;
            this.btnAbility.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAbility.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAbility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbility.ForeColor = System.Drawing.Color.Silver;
            this.btnAbility.Location = new System.Drawing.Point(0, 200);
            this.btnAbility.Name = "btnAbility";
            this.btnAbility.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAbility.Size = new System.Drawing.Size(250, 44);
            this.btnAbility.TabIndex = 5;
            this.btnAbility.Text = "Ability scores";
            this.btnAbility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbility.UseVisualStyleBackColor = true;
            this.btnAbility.Click += new System.EventHandler(this.BtnAbility_Click);
            // 
            // btnRace
            // 
            this.btnRace.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRace.FlatAppearance.BorderSize = 0;
            this.btnRace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnRace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnRace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRace.ForeColor = System.Drawing.Color.Silver;
            this.btnRace.Location = new System.Drawing.Point(0, 160);
            this.btnRace.Name = "btnRace";
            this.btnRace.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRace.Size = new System.Drawing.Size(250, 40);
            this.btnRace.TabIndex = 4;
            this.btnRace.Text = "Race";
            this.btnRace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.BtnRace_Click);
            // 
            // btnClass
            // 
            this.btnClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.ForeColor = System.Drawing.Color.Silver;
            this.btnClass.Location = new System.Drawing.Point(0, 120);
            this.btnClass.Name = "btnClass";
            this.btnClass.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnClass.Size = new System.Drawing.Size(250, 40);
            this.btnClass.TabIndex = 3;
            this.btnClass.Text = "Class";
            this.btnClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.BtnClass_Click);
            // 
            // btnBase
            // 
            this.btnBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBase.FlatAppearance.BorderSize = 0;
            this.btnBase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnBase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBase.ForeColor = System.Drawing.Color.Silver;
            this.btnBase.Location = new System.Drawing.Point(0, 80);
            this.btnBase.Name = "btnBase";
            this.btnBase.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBase.Size = new System.Drawing.Size(250, 40);
            this.btnBase.TabIndex = 2;
            this.btnBase.Text = "Base";
            this.btnBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBase.UseVisualStyleBackColor = true;
            this.btnBase.Click += new System.EventHandler(this.BtnBase_Click);
            // 
            // btnLoadCharacter
            // 
            this.btnLoadCharacter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoadCharacter.FlatAppearance.BorderSize = 0;
            this.btnLoadCharacter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnLoadCharacter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnLoadCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadCharacter.ForeColor = System.Drawing.Color.Silver;
            this.btnLoadCharacter.Location = new System.Drawing.Point(0, 40);
            this.btnLoadCharacter.Name = "btnLoadCharacter";
            this.btnLoadCharacter.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLoadCharacter.Size = new System.Drawing.Size(250, 40);
            this.btnLoadCharacter.TabIndex = 1;
            this.btnLoadCharacter.Text = "Load Character";
            this.btnLoadCharacter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadCharacter.UseVisualStyleBackColor = true;
            this.btnLoadCharacter.Click += new System.EventHandler(this.BtnLoadCharacter_Click);
            // 
            // btnNewCha
            // 
            this.btnNewCha.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewCha.FlatAppearance.BorderSize = 0;
            this.btnNewCha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnNewCha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnNewCha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCha.ForeColor = System.Drawing.Color.Silver;
            this.btnNewCha.Location = new System.Drawing.Point(0, 0);
            this.btnNewCha.Name = "btnNewCha";
            this.btnNewCha.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNewCha.Size = new System.Drawing.Size(250, 40);
            this.btnNewCha.TabIndex = 0;
            this.btnNewCha.Text = "New Character";
            this.btnNewCha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewCha.UseVisualStyleBackColor = true;
            this.btnNewCha.Click += new System.EventHandler(this.BtnNewCha_Click);
            // 
            // btnCharacter
            // 
            this.btnCharacter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCharacter.FlatAppearance.BorderSize = 0;
            this.btnCharacter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnCharacter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharacter.ForeColor = System.Drawing.Color.Silver;
            this.btnCharacter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCharacter.Location = new System.Drawing.Point(0, 92);
            this.btnCharacter.Name = "btnCharacter";
            this.btnCharacter.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCharacter.Size = new System.Drawing.Size(250, 45);
            this.btnCharacter.TabIndex = 1;
            this.btnCharacter.Text = "Character";
            this.btnCharacter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCharacter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCharacter.UseVisualStyleBackColor = true;
            this.btnCharacter.Click += new System.EventHandler(this.BtnCharacter_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 92);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1234, 761);
            this.panelChildForm.TabIndex = 2;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.panelSideMenu.ResumeLayout(false);
            this.panelCharacterSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelCharacterSubMenu;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnNewCha;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbility;
        private System.Windows.Forms.Button btnRace;
        public System.Windows.Forms.Button btnLoadCharacter;
        public System.Windows.Forms.Button btnCharacter;
        private System.Windows.Forms.Button btnProficiencies;
        public System.Windows.Forms.Button btnBase;
        public System.Windows.Forms.Panel panelChildForm;
    }
}