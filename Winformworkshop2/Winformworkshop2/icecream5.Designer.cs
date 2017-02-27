namespace Winformworkshop2
{
    partial class icecream5
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
            this.button1 = new System.Windows.Forms.Button();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.gbFlavour = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbTopping = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbChocolate = new System.Windows.Forms.RadioButton();
            this.rbStrawberry = new System.Windows.Forms.RadioButton();
            this.gbSize.SuspendLayout();
            this.gbFlavour.SuspendLayout();
            this.gbTopping.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.comboBox1);
            this.gbSize.Location = new System.Drawing.Point(13, 13);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(267, 100);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "size";
            // 
            // gbFlavour
            // 
            this.gbFlavour.Controls.Add(this.rbStrawberry);
            this.gbFlavour.Controls.Add(this.rbChocolate);
            this.gbFlavour.Location = new System.Drawing.Point(13, 146);
            this.gbFlavour.Name = "gbFlavour";
            this.gbFlavour.Size = new System.Drawing.Size(267, 100);
            this.gbFlavour.TabIndex = 2;
            this.gbFlavour.TabStop = false;
            this.gbFlavour.Text = "Flavour";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Nuts",
            "Raisins",
            "Chocolate Chips"});
            this.listBox1.Location = new System.Drawing.Point(17, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(228, 84);
            this.listBox1.TabIndex = 3;
            // 
            // gbTopping
            // 
            this.gbTopping.Controls.Add(this.listBox1);
            this.gbTopping.Location = new System.Drawing.Point(13, 284);
            this.gbTopping.Name = "gbTopping";
            this.gbTopping.Size = new System.Drawing.Size(290, 150);
            this.gbTopping.TabIndex = 4;
            this.gbTopping.TabStop = false;
            this.gbTopping.Text = "Topping";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Big"});
            this.comboBox1.Location = new System.Drawing.Point(17, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // rbChocolate
            // 
            this.rbChocolate.AutoSize = true;
            this.rbChocolate.Location = new System.Drawing.Point(17, 26);
            this.rbChocolate.Name = "rbChocolate";
            this.rbChocolate.Size = new System.Drawing.Size(106, 24);
            this.rbChocolate.TabIndex = 0;
            this.rbChocolate.TabStop = true;
            this.rbChocolate.Text = "Chocolate";
            this.rbChocolate.UseVisualStyleBackColor = true;
            // 
            // rbStrawberry
            // 
            this.rbStrawberry.AutoSize = true;
            this.rbStrawberry.Location = new System.Drawing.Point(17, 57);
            this.rbStrawberry.Name = "rbStrawberry";
            this.rbStrawberry.Size = new System.Drawing.Size(110, 24);
            this.rbStrawberry.TabIndex = 1;
            this.rbStrawberry.TabStop = true;
            this.rbStrawberry.Text = "Strawberry";
            this.rbStrawberry.UseVisualStyleBackColor = true;
            // 
            // icecream5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 512);
            this.Controls.Add(this.gbTopping);
            this.Controls.Add(this.gbFlavour);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.button1);
            this.Name = "icecream5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "icecream5";
            this.Load += new System.EventHandler(this.icecream5_Load);
            this.gbSize.ResumeLayout(false);
            this.gbFlavour.ResumeLayout(false);
            this.gbFlavour.PerformLayout();
            this.gbTopping.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbFlavour;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rbStrawberry;
        private System.Windows.Forms.RadioButton rbChocolate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox gbTopping;
    }
}