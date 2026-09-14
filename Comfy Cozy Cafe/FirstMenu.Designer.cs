namespace Comfy_Cozy_Cafe
{
    partial class FirstMenu
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
            this.PastryIcon = new System.Windows.Forms.PictureBox();
            this.ColdDrinkIcon = new System.Windows.Forms.PictureBox();
            this.HotDrinkIcon = new System.Windows.Forms.PictureBox();
            this.HotDrinksLabel = new System.Windows.Forms.Label();
            this.ColdDrinkLabel = new System.Windows.Forms.Label();
            this.PastryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PastryIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColdDrinkIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotDrinkIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PastryIcon
            // 
            this.PastryIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PastryIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PastryIcon.Image = global::Comfy_Cozy_Cafe.Properties.Resources.IconPasteries;
            this.PastryIcon.Location = new System.Drawing.Point(572, 128);
            this.PastryIcon.Name = "PastryIcon";
            this.PastryIcon.Size = new System.Drawing.Size(195, 194);
            this.PastryIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PastryIcon.TabIndex = 11;
            this.PastryIcon.TabStop = false;
            this.PastryIcon.Click += new System.EventHandler(this.PastryIcon_Click);
            // 
            // ColdDrinkIcon
            // 
            this.ColdDrinkIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ColdDrinkIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColdDrinkIcon.Image = global::Comfy_Cozy_Cafe.Properties.Resources.IconColdDrink;
            this.ColdDrinkIcon.Location = new System.Drawing.Point(301, 128);
            this.ColdDrinkIcon.Name = "ColdDrinkIcon";
            this.ColdDrinkIcon.Size = new System.Drawing.Size(195, 194);
            this.ColdDrinkIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ColdDrinkIcon.TabIndex = 10;
            this.ColdDrinkIcon.TabStop = false;
            this.ColdDrinkIcon.Click += new System.EventHandler(this.ColdDrinkIcon_Click_1);
            // 
            // HotDrinkIcon
            // 
            this.HotDrinkIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HotDrinkIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HotDrinkIcon.Image = global::Comfy_Cozy_Cafe.Properties.Resources.IconHotDrink;
            this.HotDrinkIcon.Location = new System.Drawing.Point(35, 128);
            this.HotDrinkIcon.Name = "HotDrinkIcon";
            this.HotDrinkIcon.Size = new System.Drawing.Size(195, 194);
            this.HotDrinkIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HotDrinkIcon.TabIndex = 9;
            this.HotDrinkIcon.TabStop = false;
            this.HotDrinkIcon.Click += new System.EventHandler(this.HotDrinkIcon_Click);
            // 
            // HotDrinksLabel
            // 
            this.HotDrinksLabel.AllowDrop = true;
            this.HotDrinksLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HotDrinksLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HotDrinksLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotDrinksLabel.Location = new System.Drawing.Point(35, 325);
            this.HotDrinksLabel.Name = "HotDrinksLabel";
            this.HotDrinksLabel.Size = new System.Drawing.Size(195, 38);
            this.HotDrinksLabel.TabIndex = 12;
            this.HotDrinksLabel.Text = "Hot Drinks";
            this.HotDrinksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HotDrinksLabel.Click += new System.EventHandler(this.HotDrinksLabel_Click);
            // 
            // ColdDrinkLabel
            // 
            this.ColdDrinkLabel.AllowDrop = true;
            this.ColdDrinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ColdDrinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColdDrinkLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColdDrinkLabel.Location = new System.Drawing.Point(301, 325);
            this.ColdDrinkLabel.Name = "ColdDrinkLabel";
            this.ColdDrinkLabel.Size = new System.Drawing.Size(195, 38);
            this.ColdDrinkLabel.TabIndex = 13;
            this.ColdDrinkLabel.Text = "Cold Drinks";
            this.ColdDrinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ColdDrinkLabel.Click += new System.EventHandler(this.ColdDrinkLabel_Click);
            // 
            // PastryLabel
            // 
            this.PastryLabel.AllowDrop = true;
            this.PastryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PastryLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PastryLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PastryLabel.Location = new System.Drawing.Point(572, 325);
            this.PastryLabel.Name = "PastryLabel";
            this.PastryLabel.Size = new System.Drawing.Size(195, 38);
            this.PastryLabel.TabIndex = 14;
            this.PastryLabel.Text = "Pastries";
            this.PastryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PastryLabel.Click += new System.EventHandler(this.PastryLabel_Click_1);
            // 
            // FirstMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(187)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PastryLabel);
            this.Controls.Add(this.ColdDrinkLabel);
            this.Controls.Add(this.HotDrinksLabel);
            this.Controls.Add(this.PastryIcon);
            this.Controls.Add(this.ColdDrinkIcon);
            this.Controls.Add(this.HotDrinkIcon);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FirstMenu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.PastryIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColdDrinkIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotDrinkIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HotDrinkIcon;
        private System.Windows.Forms.PictureBox ColdDrinkIcon;
        private System.Windows.Forms.PictureBox PastryIcon;
        private System.Windows.Forms.Label HotDrinksLabel;
        private System.Windows.Forms.Label ColdDrinkLabel;
        private System.Windows.Forms.Label PastryLabel;
    }
}