
namespace DnD_CharacterBuilder_GUI.Forms
{
    partial class ProficienciesPage
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
        public void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveProf = new System.Windows.Forms.Button();
            this.Skills = new System.Windows.Forms.CheckedListBox();
            this.richTextBoxProfDetail = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.LightGray;
            this.btnExit.Location = new System.Drawing.Point(1388, 3);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 28);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnSaveProf
            // 
            this.btnSaveProf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveProf.Location = new System.Drawing.Point(97, 3);
            this.btnSaveProf.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveProf.Name = "btnSaveProf";
            this.btnSaveProf.Size = new System.Drawing.Size(88, 23);
            this.btnSaveProf.TabIndex = 43;
            this.btnSaveProf.Text = "Save";
            this.btnSaveProf.UseVisualStyleBackColor = true;
            this.btnSaveProf.Click += new System.EventHandler(this.BtnSaveProf_Click);
            // 
            // Skills
            // 
            this.Skills.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Skills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Skills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Skills.FormattingEnabled = true;
            this.Skills.Location = new System.Drawing.Point(4, 73);
            this.Skills.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Skills.Name = "Skills";
            this.Skills.Size = new System.Drawing.Size(702, 722);
            this.Skills.TabIndex = 45;
            this.Skills.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Skills_ItemCheck);
            this.Skills.SelectedIndexChanged += new System.EventHandler(this.Skills_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBoxProfDetail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.richTextBoxProfDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxProfDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxProfDetail.Location = new System.Drawing.Point(714, 73);
            this.richTextBoxProfDetail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBoxProfDetail.Name = "richTextBox1";
            this.richTextBoxProfDetail.ReadOnly = true;
            this.richTextBoxProfDetail.Size = new System.Drawing.Size(703, 722);
            this.richTextBoxProfDetail.TabIndex = 0;
            this.richTextBoxProfDetail.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxProfDetail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Skills, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1421, 833);
            this.tableLayoutPanel1.TabIndex = 47;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnSaveProf, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1230, 801);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(187, 28);
            this.tableLayoutPanel2.TabIndex = 46;
            // 
            // ProficienciesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1421, 833);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProficienciesPage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Skills";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveProf;
        private System.Windows.Forms.RichTextBox richTextBoxProfDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.CheckedListBox Skills;
    }
}