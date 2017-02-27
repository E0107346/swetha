namespace Winformworkshop2
{
    partial class icecream2
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
            this.GetOrder = new System.Windows.Forms.Button();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.gbFlavour = new System.Windows.Forms.GroupBox();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.rdMedium = new System.Windows.Forms.RadioButton();
            this.rdBig = new System.Windows.Forms.RadioButton();
            this.rdChocolate = new System.Windows.Forms.RadioButton();
            this.rdstrawberry = new System.Windows.Forms.RadioButton();
            this.gbSize.SuspendLayout();
            this.gbFlavour.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetOrder
            // 
            this.GetOrder.Location = new System.Drawing.Point(90, 363);
            this.GetOrder.Name = "GetOrder";
            this.GetOrder.Size = new System.Drawing.Size(107, 32);
            this.GetOrder.TabIndex = 0;
            this.GetOrder.Text = "GetOrder";
            this.GetOrder.UseVisualStyleBackColor = true;
            this.GetOrder.Click += new System.EventHandler(this.GetOrder_Click);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rdBig);
            this.gbSize.Controls.Add(this.rdMedium);
            this.gbSize.Controls.Add(this.rdSmall);
            this.gbSize.Location = new System.Drawing.Point(31, 25);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(270, 162);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // gbFlavour
            // 
            this.gbFlavour.Controls.Add(this.rdstrawberry);
            this.gbFlavour.Controls.Add(this.rdChocolate);
            this.gbFlavour.Location = new System.Drawing.Point(31, 205);
            this.gbFlavour.Name = "gbFlavour";
            this.gbFlavour.Size = new System.Drawing.Size(270, 132);
            this.gbFlavour.TabIndex = 2;
            this.gbFlavour.TabStop = false;
            this.gbFlavour.Text = "Flavour";
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Location = new System.Drawing.Point(21, 37);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(73, 24);
            this.rdSmall.TabIndex = 0;
            this.rdSmall.TabStop = true;
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            // 
            // rdMedium
            // 
            this.rdMedium.AutoSize = true;
            this.rdMedium.Location = new System.Drawing.Point(21, 78);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Size = new System.Drawing.Size(90, 24);
            this.rdMedium.TabIndex = 1;
            this.rdMedium.TabStop = true;
            this.rdMedium.Text = "Medium";
            this.rdMedium.UseVisualStyleBackColor = true;
            // 
            // rdBig
            // 
            this.rdBig.AutoSize = true;
            this.rdBig.Location = new System.Drawing.Point(21, 118);
            this.rdBig.Name = "rdBig";
            this.rdBig.Size = new System.Drawing.Size(57, 24);
            this.rdBig.TabIndex = 2;
            this.rdBig.TabStop = true;
            this.rdBig.Text = "Big";
            this.rdBig.UseVisualStyleBackColor = true;
            // 
            // rdChocolate
            // 
            this.rdChocolate.AutoSize = true;
            this.rdChocolate.Location = new System.Drawing.Point(21, 50);
            this.rdChocolate.Name = "rdChocolate";
            this.rdChocolate.Size = new System.Drawing.Size(106, 24);
            this.rdChocolate.TabIndex = 0;
            this.rdChocolate.TabStop = true;
            this.rdChocolate.Text = "Chocolate";
            this.rdChocolate.UseVisualStyleBackColor = true;
            // 
            // rdstrawberry
            // 
            this.rdstrawberry.AutoSize = true;
            this.rdstrawberry.Location = new System.Drawing.Point(21, 89);
            this.rdstrawberry.Name = "rdstrawberry";
            this.rdstrawberry.Size = new System.Drawing.Size(110, 24);
            this.rdstrawberry.TabIndex = 1;
            this.rdstrawberry.TabStop = true;
            this.rdstrawberry.Text = "Strawberry";
            this.rdstrawberry.UseVisualStyleBackColor = true;
            // 
            // workshop2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 407);
            this.Controls.Add(this.gbFlavour);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.GetOrder);
            this.Name = "workshop2";
            this.Text = "workshop2";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbFlavour.ResumeLayout(false);
            this.gbFlavour.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetOrder;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rdBig;
        private System.Windows.Forms.RadioButton rdMedium;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.GroupBox gbFlavour;
        private System.Windows.Forms.RadioButton rdstrawberry;
        private System.Windows.Forms.RadioButton rdChocolate;
    }
}