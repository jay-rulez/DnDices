namespace DnDices
{
    partial class DnDices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DnDices));
            this.numericNumberDices = new System.Windows.Forms.NumericUpDown();
            this.cmbDices = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.lblNumberDices = new System.Windows.Forms.Label();
            this.lblSides = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberDices)).BeginInit();
            this.SuspendLayout();
            // 
            // numericNumberDices
            // 
            this.numericNumberDices.BackColor = System.Drawing.SystemColors.Window;
            this.numericNumberDices.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericNumberDices.Location = new System.Drawing.Point(77, 123);
            this.numericNumberDices.Name = "numericNumberDices";
            this.numericNumberDices.ReadOnly = true;
            this.numericNumberDices.Size = new System.Drawing.Size(150, 63);
            this.numericNumberDices.TabIndex = 0;
            this.numericNumberDices.TabStop = false;
            this.numericNumberDices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericNumberDices.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbDices
            // 
            this.cmbDices.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbDices.FormattingEnabled = true;
            this.cmbDices.Items.AddRange(new object[] {
            "20",
            "4",
            "6",
            "8",
            "10",
            "12"});
            this.cmbDices.Location = new System.Drawing.Point(370, 123);
            this.cmbDices.Name = "cmbDices";
            this.cmbDices.Size = new System.Drawing.Size(151, 65);
            this.cmbDices.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(370, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 92);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dice!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 57;
            this.listBoxResult.Location = new System.Drawing.Point(721, 123);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(150, 346);
            this.listBoxResult.TabIndex = 4;
            // 
            // lblNumberDices
            // 
            this.lblNumberDices.AutoSize = true;
            this.lblNumberDices.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberDices.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumberDices.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNumberDices.Location = new System.Drawing.Point(77, 62);
            this.lblNumberDices.Name = "lblNumberDices";
            this.lblNumberDices.Size = new System.Drawing.Size(113, 35);
            this.lblNumberDices.TabIndex = 5;
            this.lblNumberDices.Text = "Number";
            // 
            // lblSides
            // 
            this.lblSides.AutoSize = true;
            this.lblSides.BackColor = System.Drawing.Color.Transparent;
            this.lblSides.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSides.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSides.Location = new System.Drawing.Point(370, 62);
            this.lblSides.Name = "lblSides";
            this.lblSides.Size = new System.Drawing.Size(76, 35);
            this.lblSides.TabIndex = 6;
            this.lblSides.Text = "Sides";
            // 
            // DnDices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.lblSides);
            this.Controls.Add(this.lblNumberDices);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbDices);
            this.Controls.Add(this.numericNumberDices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DnDices";
            this.Text = "DnDices";
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberDices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numericNumberDices;
        private ComboBox cmbDices;
        private Button button1;
        private ListBox listBoxResult;
        private Label lblNumberDices;
        private Label lblSides;
    }
}