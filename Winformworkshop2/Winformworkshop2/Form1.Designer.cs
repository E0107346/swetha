namespace Winformworkshop2
{
    partial class Form1
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
            this.rdbtnSmall = new System.Windows.Forms.RadioButton();
            this.rdbtnMedium = new System.Windows.Forms.RadioButton();
            this.rdbtnBig = new System.Windows.Forms.RadioButton();
            this.Size = new System.Windows.Forms.GroupBox();
            this.sizeSmall = new System.Windows.Forms.RadioButton();
            this.sizeMedium = new System.Windows.Forms.RadioButton();
            this.sizeBig = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.sizeOrder = new System.Windows.Forms.Button();
            this.Size.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbtnSmall
            // 
            this.rdbtnSmall.AutoSize = true;
            this.rdbtnSmall.Location = new System.Drawing.Point(12, 26);
            this.rdbtnSmall.Name = "rdbtnSmall";
            this.rdbtnSmall.Size = new System.Drawing.Size(73, 24);
            this.rdbtnSmall.TabIndex = 0;
            this.rdbtnSmall.TabStop = true;
            this.rdbtnSmall.Text = "Small";
            this.rdbtnSmall.UseVisualStyleBackColor = true;
            // 
            // rdbtnMedium
            // 
            this.rdbtnMedium.AutoSize = true;
            this.rdbtnMedium.Location = new System.Drawing.Point(12, 56);
            this.rdbtnMedium.Name = "rdbtnMedium";
            this.rdbtnMedium.Size = new System.Drawing.Size(90, 24);
            this.rdbtnMedium.TabIndex = 1;
            this.rdbtnMedium.TabStop = true;
            this.rdbtnMedium.Text = "Medium";
            this.rdbtnMedium.UseVisualStyleBackColor = true;
            // 
            // rdbtnBig
            // 
            this.rdbtnBig.AutoSize = true;
            this.rdbtnBig.Location = new System.Drawing.Point(12, 86);
            this.rdbtnBig.Name = "rdbtnBig";
            this.rdbtnBig.Size = new System.Drawing.Size(57, 24);
            this.rdbtnBig.TabIndex = 2;
            this.rdbtnBig.TabStop = true;
            this.rdbtnBig.Text = "Big";
            this.rdbtnBig.UseVisualStyleBackColor = true;
            // 
            // Size
            // 
            this.Size.Controls.Add(this.sizeOrder);
            this.Size.Controls.Add(this.sizeBig);
            this.Size.Controls.Add(this.sizeMedium);
            this.Size.Controls.Add(this.sizeSmall);
            this.Size.Location = new System.Drawing.Point(13, 143);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(386, 246);
            this.Size.TabIndex = 3;
            this.Size.TabStop = false;
            this.Size.Text = "Size";
            // 
            // sizeSmall
            // 
            this.sizeSmall.AutoSize = true;
            this.sizeSmall.Location = new System.Drawing.Point(26, 44);
            this.sizeSmall.Name = "sizeSmall";
            this.sizeSmall.Size = new System.Drawing.Size(73, 24);
            this.sizeSmall.TabIndex = 0;
            this.sizeSmall.TabStop = true;
            this.sizeSmall.Text = "Small";
            this.sizeSmall.UseVisualStyleBackColor = true;
            // 
            // sizeMedium
            // 
            this.sizeMedium.AutoSize = true;
            this.sizeMedium.Location = new System.Drawing.Point(26, 90);
            this.sizeMedium.Name = "sizeMedium";
            this.sizeMedium.Size = new System.Drawing.Size(90, 24);
            this.sizeMedium.TabIndex = 1;
            this.sizeMedium.TabStop = true;
            this.sizeMedium.Text = "Medium";
            this.sizeMedium.UseVisualStyleBackColor = true;
            // 
            // sizeBig
            // 
            this.sizeBig.AutoSize = true;
            this.sizeBig.Location = new System.Drawing.Point(26, 140);
            this.sizeBig.Name = "sizeBig";
            this.sizeBig.Size = new System.Drawing.Size(57, 24);
            this.sizeBig.TabIndex = 2;
            this.sizeBig.TabStop = true;
            this.sizeBig.Text = "Big";
            this.sizeBig.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(220, 70);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(132, 28);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Get Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // sizeOrder
            // 
            this.sizeOrder.Location = new System.Drawing.Point(207, 90);
            this.sizeOrder.Name = "sizeOrder";
            this.sizeOrder.Size = new System.Drawing.Size(112, 31);
            this.sizeOrder.TabIndex = 3;
            this.sizeOrder.Text = "Get Order";
            this.sizeOrder.UseVisualStyleBackColor = true;
            this.sizeOrder.Click += new System.EventHandler(this.sizeOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 440);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.rdbtnBig);
            this.Controls.Add(this.rdbtnMedium);
            this.Controls.Add(this.rdbtnSmall);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Size.ResumeLayout(false);
            this.Size.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnSmall;
        private System.Windows.Forms.RadioButton rdbtnMedium;
        private System.Windows.Forms.RadioButton rdbtnBig;
        private System.Windows.Forms.GroupBox Size;
        private System.Windows.Forms.Button sizeOrder;
        private System.Windows.Forms.RadioButton sizeBig;
        private System.Windows.Forms.RadioButton sizeMedium;
        private System.Windows.Forms.RadioButton sizeSmall;
        private System.Windows.Forms.Button btnOrder;
    }
}

