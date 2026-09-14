using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comfy_Cozy_Cafe
{
    public partial class FirstMenu : Form
    {
        public FirstMenu()
        {
            InitializeComponent();
        }

        private void ColdDrinkIcon_Click_1(object sender, EventArgs e)
        {
            Menus.ColdDrinksForm coldDrinksForm = new Menus.ColdDrinksForm();
            coldDrinksForm.Show();
            this.Close();
        }

        private void ColdDrinkLabel_Click(object sender, EventArgs e)
        {
            Menus.ColdDrinksForm coldDrinksForm = new Menus.ColdDrinksForm();
            coldDrinksForm.Show();
            this.Close();
        }

        private void PastryIcon_Click(object sender, EventArgs e)
        {
            Menus.PastriesForm pasteriesForm = new Menus.PastriesForm();
            pasteriesForm.Show();
            this.Close();
        }

        private void PastryLabel_Click_1(object sender, EventArgs e)
        {
            Menus.PastriesForm pasteriesForm = new Menus.PastriesForm();
            pasteriesForm.Show();
            this.Close();
        }

        private void HotDrinkIcon_Click(object sender, EventArgs e)
        {
            Menus.HotDrinksForm hotDrinksForm = new Menus.HotDrinksForm();
            hotDrinksForm.Show();
            this.Close();
        }

        private void HotDrinksLabel_Click(object sender, EventArgs e)
        {
            Menus.HotDrinksForm hotDrinksForm = new Menus.HotDrinksForm();
            hotDrinksForm.Show();
            this.Close();
        }
    }
}
