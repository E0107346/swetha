namespace Winformworkshop2
{
    partial class icecream3
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
            this.gbTopping = new System.Windows.Forms.GroupBox();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbBig = new System.Windows.Forms.RadioButton();
            this.rbChocolate = new System.Windows.Forms.RadioButton();
            this.rbStrawberry = new System.Windows.Forms.RadioButton();
            this.rbNuts = new System.Windows.Forms.RadioButton();
            this.rbRaisins = new System.Windows.Forms.RadioButton();
            this.rbtChocolate = new System.Windows.Forms.RadioButton();
            this.gbSize.SuspendLayout();
            this.gbFlavour.SuspendLayout();
            this.gbTopping.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbBig);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Location = new System.Drawing.Point(12, 13);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(252, 138);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // gbFlavour
            // 
            this.gbFlavour.Controls.Add(this.rbStrawberry);
            this.gbFlavour.Controls.Add(this.rbChocolate);
            this.gbFlavour.Location = new System.Drawing.Point(12, 182);
            this.gbFlavour.Name = "gbFlavour";
            this.gbFlavour.Size = new System.Drawing.Size(252, 111);
            this.gbFlavour.TabIndex = 2;
            this.gbFlavour.TabStop = false;
            this.gbFlavour.Text = "Flavour";
            // 
            // gbTopping
            // 
            this.gbTopping.Controls.Add(this.rbtChocolate);
            this.gbTopping.Controls.Add(this.rbRaisins);
            this.gbTopping.Controls.Add(this.rbNuts);
            this.gbTopping.Location = new System.Drawing.Point(12, 326);
            this.gbTopping.Name = "gbTopping";
            this.gbTopping.Size = new System.Drawing.Size(252, 129);
            this.gbTopping.TabIndex = 3;
            this.gbTopping.TabStop = false;
            this.gbTopping.Text = "Topping";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(11, 26);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(73, 24);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(11, 57);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(90, 24);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbBig
            // 
            this.rbBig.AutoSize = true;
            this.rbBig.Location = new System.Drawing.Point(11, 87);
            this.rbBig.Name = "rbBig";
            this.rbBig.Size = new System.Drawing.Size(57, 24);
            this.rbBig.TabIndex = 2;
            this.rbBig.TabStop = true;
            this.rbBig.Text = "Big";
            this.rbBig.UseVisualStyleBackColor = true;
            // 
            // rbChocolate
            // 
            this.rbChocolate.AutoSize = true;
            this.rbChocolate.Location = new System.Drawing.Point(11, 39);
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
            this.rbStrawberry.Location = new System.Drawing.Point(11, 70);
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
            this.rbNuts.Location = new System.Drawing.Point(11, 26);
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
            this.rbRaisins.Location = new System.Drawing.Point(11, 57);
            this.rbRaisins.Name = "rbRaisins";
            this.rbRaisins.Size = new System.Drawing.Size(86, 24);
            this.rbRaisins.TabIndex = 1;
            this.rbRaisins.TabStop = true;
            this.rbRaisins.Text = "Raisins";
            this.rbRaisins.UseVisualStyleBackColor = true;
            // 
            // rbtChocolate
            // 
            this.rbtChocolate.AutoSize = true;
            this.rbtChocolate.Location = new System.Drawing.Point(11, 87);
            this.rbtChocolate.Name = "rbtChocolate";
            this.rbtChocolate.Size = new System.Drawing.Size(106, 24);
            this.rbtChocolate.TabIndex = 2;
            this.rbtChocolate.TabStop = true;
            this.rbtChocolate.Text = "Chocolate";
            this.rbtChocolate.UseVisualStyleBackColor = true;
            // 
            // icecream3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 527);
            this.Controls.Add(this.gbTopping);
            this.Controls.Add(this.gbFlavour);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.button1);
            this.Name = "icecream3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "icecream3";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbFlavour.ResumeLayout(false);
            this.gbFlavour.PerformLayout();
            this.gbTopping.ResumeLayout(false);
            this.gbTopping.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbBig;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbFlavour;
        private System.Windows.Forms.RadioButton rbStrawberry;
        private System.Windows.Forms.RadioButton rbChocolate;
        private System.Windows.Forms.GroupBox gbTopping;
        private System.Windows.Forms.RadioButton rbtChocolate;
        private System.Windows.Forms.RadioButton rbRaisins;
        private System.Windows.Forms.RadioButton rbNuts;
    }
}