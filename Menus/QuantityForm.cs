using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus
{
    public partial class QuantityForm : Form
    {
        public int SelectedQuantity { get; private set; }

        public QuantityForm(int currentQuantity)
        {
            InitializeComponent();
            EditValue.Value = currentQuantity;
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            SelectedQuantity = (int)EditValue.Value;
            this.DialogResult = DialogResult.OK;
            this.Close(); 
        }
    }
}