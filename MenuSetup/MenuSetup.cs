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

            OpenMenuForm("Menus.HotDrinksForm");
        }

        private void ColdDrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HotDrinksToolStripMenuItem.Checked = false;
            ColdDrinksToolStripMenuItem.Checked = true;
            PastriesToolStripMenuItem.Checked = false;

            OpenMenuForm("Menus.ColdDrinksForm");
        }

        private void PastriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HotDrinksToolStripMenuItem.Checked = false;
            ColdDrinksToolStripMenuItem.Checked = false;
            PastriesToolStripMenuItem.Checked = true;

            OpenMenuForm("Menus.PastriesForm");
        }

        public void EnableCartMenu()
        {
            cartToolStripMenuItem.Enabled = true;
            checkoutToolStripMenuItem.Enabled = true; 
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMenuForm("Menus.Cart", false);
        }

        // Load menu forms by name to avoid a circular project reference.
        private void OpenMenuForm(string typeName, bool closeCurrentForm = true)
        {
            Type formType = Type.GetType(typeName + ", Menus");
            Form form = formType == null ? null : Activator.CreateInstance(formType) as Form;

            if (form == null)
            {
                MessageBox.Show("The selected menu could not be opened.", "Comfy Cozy Cafe");
                return;
            }

            form.Show();
            if (closeCurrentForm)
            {
                Close();
            }
        }
    }
}
