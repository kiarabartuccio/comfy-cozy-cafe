namespace MenuSetup
{
    partial class MenuSetup
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HotDrinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColdDrinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PastriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.cartToolStripMenuItem,
            this.checkoutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 58);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HotDrinksToolStripMenuItem,
            this.ColdDrinksToolStripMenuItem,
            this.toolStripSeparator1,
            this.PastriesToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(85, 54);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // HotDrinksToolStripMenuItem
            // 
            this.HotDrinksToolStripMenuItem.Image = global::MenuSetup.Properties.Resources.Hot;
            this.HotDrinksToolStripMenuItem.Name = "HotDrinksToolStripMenuItem";
            this.HotDrinksToolStripMenuItem.Size = new System.Drawing.Size(225, 36);
            this.HotDrinksToolStripMenuItem.Text = "Hot Drinks";
            this.HotDrinksToolStripMenuItem.Click += new System.EventHandler(this.HotDrinksToolStripMenuItem_Click);
            // 
            // ColdDrinksToolStripMenuItem
            // 
            this.ColdDrinksToolStripMenuItem.Image = global::MenuSetup.Properties.Resources.Cold;
            this.ColdDrinksToolStripMenuItem.Name = "ColdDrinksToolStripMenuItem";
            this.ColdDrinksToolStripMenuItem.Size = new System.Drawing.Size(225, 36);
            this.ColdDrinksToolStripMenuItem.Text = "Cold Drinks";
            this.ColdDrinksToolStripMenuItem.Click += new System.EventHandler(this.ColdDrinksToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // PastriesToolStripMenuItem
            // 
            this.PastriesToolStripMenuItem.Image = global::MenuSetup.Properties.Resources.Pastry;
            this.PastriesToolStripMenuItem.Name = "PastriesToolStripMenuItem";
            this.PastriesToolStripMenuItem.Size = new System.Drawing.Size(225, 36);
            this.PastriesToolStripMenuItem.Text = "Pastries";
            this.PastriesToolStripMenuItem.Click += new System.EventHandler(this.PastriesToolStripMenuItem_Click);
            // 
            // cartToolStripMenuItem
            // 
            this.cartToolStripMenuItem.Enabled = false;
            this.cartToolStripMenuItem.Name = "cartToolStripMenuItem";
            this.cartToolStripMenuItem.Size = new System.Drawing.Size(75, 54);
            this.cartToolStripMenuItem.Text = "Cart";
            this.cartToolStripMenuItem.Click += new System.EventHandler(this.cartToolStripMenuItem_Click);
            // 
            // checkoutToolStripMenuItem
            // 
            this.checkoutToolStripMenuItem.Enabled = false;
            this.checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            this.checkoutToolStripMenuItem.Size = new System.Drawing.Size(127, 54);
            this.checkoutToolStripMenuItem.Text = "Checkout";
            // 
            // MenuSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MenuSetup";
            this.Text = "MenuSetup";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HotDrinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColdDrinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem PastriesToolStripMenuItem;
    }
}

