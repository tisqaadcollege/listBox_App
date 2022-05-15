namespace ListBox_App
{
    partial class Demo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstMyListBox = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMyListBox
            // 
            this.lstMyListBox.FormattingEnabled = true;
            this.lstMyListBox.ItemHeight = 15;
            this.lstMyListBox.Items.AddRange(new object[] {
            "Hargeisa",
            "Burao",
            "Borama",
            "Berbera"});
            this.lstMyListBox.Location = new System.Drawing.Point(9, 20);
            this.lstMyListBox.Name = "lstMyListBox";
            this.lstMyListBox.Size = new System.Drawing.Size(322, 364);
            this.lstMyListBox.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(128, 406);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 441);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lstMyListBox);
            this.Name = "Demo";
            this.Text = "Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstMyListBox;
        private Button btnSelect;
    }
}