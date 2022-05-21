namespace ListBox_App
{
    partial class frmListboxandCombobox
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lstCountry = new System.Windows.Forms.ListBox();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.btnDelCountry = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoppies = new System.Windows.Forms.TextBox();
            this.btnAddHoppies = new System.Windows.Forms.Button();
            this.cmbHoppies = new System.Windows.Forms.ComboBox();
            this.btnDelHoppies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Country:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(108, 42);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(280, 23);
            this.txtCountry.TabIndex = 1;
            // 
            // lstCountry
            // 
            this.lstCountry.FormattingEnabled = true;
            this.lstCountry.ItemHeight = 15;
            this.lstCountry.Location = new System.Drawing.Point(108, 110);
            this.lstCountry.Name = "lstCountry";
            this.lstCountry.Size = new System.Drawing.Size(280, 334);
            this.lstCountry.TabIndex = 2;
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.Location = new System.Drawing.Point(219, 81);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(75, 23);
            this.btnAddCountry.TabIndex = 3;
            this.btnAddCountry.Text = "Add";
            this.btnAddCountry.UseVisualStyleBackColor = true;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // btnDelCountry
            // 
            this.btnDelCountry.Location = new System.Drawing.Point(219, 455);
            this.btnDelCountry.Name = "btnDelCountry";
            this.btnDelCountry.Size = new System.Drawing.Size(75, 23);
            this.btnDelCountry.TabIndex = 3;
            this.btnDelCountry.Text = "Delete";
            this.btnDelCountry.UseVisualStyleBackColor = true;
            this.btnDelCountry.Click += new System.EventHandler(this.btnDelCountry_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Hoppies";
            // 
            // txtHoppies
            // 
            this.txtHoppies.Location = new System.Drawing.Point(531, 134);
            this.txtHoppies.Name = "txtHoppies";
            this.txtHoppies.Size = new System.Drawing.Size(289, 23);
            this.txtHoppies.TabIndex = 5;
            // 
            // btnAddHoppies
            // 
            this.btnAddHoppies.Location = new System.Drawing.Point(637, 187);
            this.btnAddHoppies.Name = "btnAddHoppies";
            this.btnAddHoppies.Size = new System.Drawing.Size(75, 23);
            this.btnAddHoppies.TabIndex = 6;
            this.btnAddHoppies.Text = "Add";
            this.btnAddHoppies.UseVisualStyleBackColor = true;
            this.btnAddHoppies.Click += new System.EventHandler(this.btnAddHoppies_Click);
            // 
            // cmbHoppies
            // 
            this.cmbHoppies.FormattingEnabled = true;
            this.cmbHoppies.Location = new System.Drawing.Point(529, 249);
            this.cmbHoppies.Name = "cmbHoppies";
            this.cmbHoppies.Size = new System.Drawing.Size(291, 23);
            this.cmbHoppies.TabIndex = 7;
            // 
            // btnDelHoppies
            // 
            this.btnDelHoppies.Location = new System.Drawing.Point(637, 316);
            this.btnDelHoppies.Name = "btnDelHoppies";
            this.btnDelHoppies.Size = new System.Drawing.Size(75, 23);
            this.btnDelHoppies.TabIndex = 6;
            this.btnDelHoppies.Text = "Delete";
            this.btnDelHoppies.UseVisualStyleBackColor = true;
            this.btnDelHoppies.Click += new System.EventHandler(this.btnDelHoppies_Click);
            // 
            // frmListboxandCombobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 490);
            this.Controls.Add(this.cmbHoppies);
            this.Controls.Add(this.btnDelHoppies);
            this.Controls.Add(this.btnAddHoppies);
            this.Controls.Add(this.txtHoppies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelCountry);
            this.Controls.Add(this.btnAddCountry);
            this.Controls.Add(this.lstCountry);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label1);
            this.Name = "frmListboxandCombobox";
            this.Text = "Listbox and Combobox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtCountry;
        private ListBox lstCountry;
        private Button btnAddCountry;
        private Button btnDelCountry;
        private Label label2;
        private TextBox txtHoppies;
        private Button btnAddHoppies;
        private ComboBox cmbHoppies;
        private Button btnDelHoppies;
    }
}