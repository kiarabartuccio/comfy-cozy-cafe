using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Menus;    

namespace MenuSetup
{
    public partial class MenuSetup : Form
    {
        public MenuSetup()
        {
            InitializeComponent();
            
        }

        private void HotDrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HotDrinksToolStripMenuItem.Checked = true;
            ColdDrinksToolStripMenuItem.Checked = false;
            PastriesToolStripMenuItem.Checked = false;

            Menus.HotDrinksForm hotDrinksForm = new Menus.HotDrinksForm();
            hotDrinksForm.Show();
            this.Close();
        }

        private void ColdDrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HotDrinksToolStripMenuItem.Checked = false;
            ColdDrinksToolStripMenuItem.Checked = true;
            PastriesToolStripMenuItem.Checked = false;

            Menus.ColdDrinksForm coldDrinksForm = new Menus.ColdDrinksForm();
            coldDrinksForm.Show();
            this.Close();
        }

        private void PastriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HotDrinksToolStripMenuItem.Checked = false;
            ColdDrinksToolStripMenuItem.Checked = false;
            PastriesToolStripMenuItem.Checked = true;

            Menus.PastriesForm pastriesForm = new Menus.PastriesForm();
            pastriesForm.Show();
            this.Close();
        }

        public void EnableCartMenu()
        {
            cartToolStripMenuItem.Enabled = true;
            checkoutToolStripMenuItem.Enabled = true; 
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menus.Cart cartForm = new Menus.Cart();
            cartForm.Show();
        }
    }
}
