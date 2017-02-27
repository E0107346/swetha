namespace Winformworkshop2
{
    partial class Icecream4
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
            this.btnGetorder = new System.Windows.Forms.Button();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.gbFlavour = new System.Windows.Forms.GroupBox();
            this.gbTopping = new System.Windows.Forms.GroupBox();
            this.rbChocolate = new System.Windows.Forms.RadioButton();
            this.rbStrawberry = new System.Windows.Forms.RadioButton();
            this.rbNuts = new System.Windows.Forms.RadioButton();
            this.rbRaisins = new System.Windows.Forms.RadioButton();
            this.rbChocolatechips = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbSize.SuspendLayout();
            this.gbFlavour.SuspendLayout();
            this.gbTopping.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetorder
            // 
            this.btnGetorder.Location = new System.Drawing.Point(140, 475);
            this.btnGetorder.Name = "btnGetorder";
            this.btnGetorder.Size = new System.Drawing.Size(112, 38);
            this.btnGetorder.TabIndex = 0;
            this.btnGetorder.Text = "Get Order";
            this.btnGetorder.UseVisualStyleBackColor = true;
            this.btnGetorder.Click += new System.EventHandler(this.btnGetorder_Click);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.comboBox1);
            this.gbSize.Location = new System.Drawing.Point(35, 13);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(300, 120);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // gbFlavour
            // 
            this.gbFlavour.Controls.Add(this.rbStrawberry);
            this.gbFlavour.Controls.Add(this.rbChocolate);
            this.gbFlavour.Location = new System.Drawing.Point(35, 166);
            this.gbFlavour.Name = "gbFlavour";
            this.gbFlavour.Size = new System.Drawing.Size(300, 100);
            this.gbFlavour.TabIndex = 2;
            this.gbFlavour.TabStop = false;
            this.gbFlavour.Text = "Flavour";
            // 
            // gbTopping
            // 
            this.gbTopping.Controls.Add(this.rbChocolatechips);
            this.gbTopping.Controls.Add(this.rbRaisins);
            this.gbTopping.Controls.Add(this.rbNuts);
            this.gbTopping.Location = new System.Drawing.Point(35, 311);
            this.gbTopping.Name = "gbTopping";
            this.gbTopping.Size = new System.Drawing.Size(300, 139);
            this.gbTopping.TabIndex = 3;
            this.gbTopping.TabStop = false;
            this.gbTopping.Text = "Topping";
            // 
            // rbChocolate
            // 
            this.rbChocolate.AutoSize = true;
            this.rbChocolate.Location = new System.Drawing.Point(7, 26);
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
            this.rbStrawberry.Location = new System.Drawing.Point(7, 57);
            this.rbStrawberry.Name = "rbStrawberry";
            this.rbStrawberry.Size = new System.Drawing.Size(110, 24);
            this.rbStrawberry.TabIndex = 1;
            this.rbStrawberry.TabStop = true;
            this.rbStrawberry.Text = "Strawberry";
            this.rbStrawberry.UseVisualStyleBackColor = true;
            // 
            // rbNuts
            // 
            this.rbNuts.AutoSize = true;
            this.rbNuts.Location = new System.Drawing.Point(7, 26);
            this.rbNuts.Name = "rbNuts";
            this.rbNuts.Size = new System.Drawing.Size(67, 24);
            this.rbNuts.TabIndex = 0;
            this.rbNuts.TabStop = true;
            this.rbNuts.Text = "Nuts";
            this.rbNuts.UseVisualStyleBackColor = true;
            // 
            // rbRaisins
            // 
            this.rbRaisins.AutoSize = true;
            this.rbRaisins.Location = new System.Drawing.Point(7, 57);
            this.rbRaisins.Name = "rbRaisins";
            this.rbRaisins.Size = new System.Drawing.Size(86, 24);
            this.rbRaisins.TabIndex = 1;
            this.rbRaisins.TabStop = true;
            this.rbRaisins.Text = "Raisins";
            this.rbRaisins.UseVisualStyleBackColor = true;
            // 
            // rbChocolatechips
            // 
            this.rbChocolatechips.AutoSize = true;
            this.rbChocolatechips.Location = new System.Drawing.Point(7, 87);
            this.rbChocolatechips.Name = "rbChocolatechips";
            this.rbChocolatechips.Size = new System.Drawing.Size(146, 24);
            this.rbChocolatechips.TabIndex = 2;
            this.rbChocolatechips.TabStop = true;
            this.rbChocolatechips.Text = "ChocolateChips";
            this.rbChocolatechips.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Big"});
            this.comboBox1.Location = new System.Drawing.Point(16, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // Icecream4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 525);
            this.Controls.Add(this.gbTopping);
            this.Controls.Add(this.gbFlavour);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.btnGetorder);
            this.Name = "Icecream4";
            this.Text = "Icecream4";
            this.gbSize.ResumeLayout(false);
            this.gbFlavour.ResumeLayout(false);
            this.gbFlavour.PerformLayout();
            this.gbTopping.ResumeLayout(false);
            this.gbTopping.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetorder;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbFlavour;
        private System.Windows.Forms.RadioButton rbStrawberry;
        private System.Windows.Forms.RadioButton rbChocolate;
        private System.Windows.Forms.GroupBox gbTopping;
        private System.Windows.Forms.RadioButton rbChocolatechips;
        private System.Windows.Forms.RadioButton rbRaisins;
        private System.Windows.Forms.RadioButton rbNuts;
    }
}