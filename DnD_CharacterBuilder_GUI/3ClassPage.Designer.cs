
namespace DnD_CharacterBuilder_GUI.Forms
{
    partial class ClassPage
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
            this.listBoxClass = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.ChoosedPClass = new System.Windows.Forms.TextBox();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Back = new System.Windows.Forms.Button();
            this.NextButton1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxClass
            // 
            this.listBoxClass.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listBoxClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxClass.FormattingEnabled = true;
            this.listBoxClass.ItemHeight = 15;
            this.listBoxClass.Location = new System.Drawing.Point(4, 73);
            this.listBoxClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxClass.Name = "listBoxClass";
            this.listBoxClass.Size = new System.Drawing.Size(702, 722);
            this.listBoxClass.TabIndex = 32;
            this.listBoxClass.SelectedValueChanged += new System.EventHandler(this.ListBoxClass_SelectedValueChanged);
            this.listBoxClass.DoubleClick += new System.EventHandler(this.ListBoxClass_DoubleClick);
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
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ChoosedPClass
            // 
            this.ChoosedPClass.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ChoosedPClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChoosedPClass.Location = new System.Drawing.Point(4, 3);
            this.ChoosedPClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChoosedPClass.Name = "ChoosedPClass";
            this.ChoosedPClass.ReadOnly = true;
            this.ChoosedPClass.Size = new System.Drawing.Size(619, 23);
            this.ChoosedPClass.TabIndex = 37;
            // 
            // btnExit2
            // 
            this.btnExit2.FlatAppearance.BorderSize = 0;
            this.btnExit2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnExit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit2.ForeColor = System.Drawing.Color.LightGray;
            this.btnExit2.Location = new System.Drawing.Point(631, 3);
            this.btnExit2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(21, 21);
            this.btnExit2.TabIndex = 38;
            this.btnExit2.Text = "X";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.BtnExit2_Click);
            // 
            // richTextBoxClass
            // 
            this.richTextBoxClass.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.richTextBoxClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxClass.Location = new System.Drawing.Point(714, 73);
            this.richTextBoxClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBoxClass.Name = "richTextBoxClass";
            this.richTextBoxClass.ReadOnly = true;
            this.richTextBoxClass.Size = new System.Drawing.Size(703, 722);
            this.richTextBoxClass.TabIndex = 32;
            this.richTextBoxClass.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxClass, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxClass, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 3);
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
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Controls.Add(this.ChoosedPClass, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnExit2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 38);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(656, 28);
            this.tableLayoutPanel2.TabIndex = 35;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.Back, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.NextButton1, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1230, 801);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(187, 28);
            this.tableLayoutPanel3.TabIndex = 47;
            // 
            // Back
            // 
            this.Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Back.Location = new System.Drawing.Point(3, 3);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(88, 23);
            this.Back.TabIndex = 34;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // NextButton1
            // 
            this.NextButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton1.Location = new System.Drawing.Point(97, 3);
            this.NextButton1.Margin = new System.Windows.Forms.Padding(2);
            this.NextButton1.Name = "NextButton1";
            this.NextButton1.Size = new System.Drawing.Size(88, 23);
            this.NextButton1.TabIndex = 27;
            this.NextButton1.Text = "Next";
            this.NextButton1.UseVisualStyleBackColor = true;
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1421, 833);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Class";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DnD_Character";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBoxClass;
        private System.Windows.Forms.TextBox ChoosedPClass;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button NextButton1;
    }
}