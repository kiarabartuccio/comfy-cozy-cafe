using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Menus
{
    public partial class Cart : MenuSetup.MenuSetup
    {
        public static List<CartItem> CartItems = new List<CartItem>();
        public Cart()
        {
            InitializeComponent();
            LoadCartItems();
        }

        public class CartItem
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public Double Price { get; set; }
            public Double Subtotal { get; set; }
            public string Category { get; set; }
            public List<AddOnItem> AddOns { get; set; } = new List<AddOnItem>();

        }

        public class AddOnItem
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
        }

        private void LoadCartItems()
        {
            listViewCart.BeginUpdate();
            listViewCart.Items.Clear();
            listViewCart.Groups.Clear();

            // Create category groups
            var coldGroup = new ListViewGroup("Cold Drinks");
            var hotGroup = new ListViewGroup("Hot Drinks");
            var pastryGroup = new ListViewGroup("Pastries");

            listViewCart.Groups.Add(coldGroup);
            listViewCart.Groups.Add(hotGroup);
            listViewCart.Groups.Add(pastryGroup);

            foreach (var item in CartItems)
            {
                // MAIN ITEM ROW
                ListViewItem row = new ListViewItem(item.Name);
                row.SubItems.Add(item.Quantity.ToString());
                row.SubItems.Add("$" + item.Price.ToString("0.00"));
                row.SubItems.Add("$" + item.Subtotal.ToString("0.00"));
                row.Tag = item;

                // Assign correct group
                switch (item.Category)
                {
                    case "Cold Drinks":
                        row.Group = coldGroup;
                        break;

                    case "Hot Drinks":
                        row.Group = hotGroup;
                        break;

                    case "Pastries":
                        row.Group = pastryGroup;
                        break;
                }

                listViewCart.Items.Add(row);

                // ADD-ONS UNDER ITEM
                foreach (var addon in item.AddOns)
                {
                    ListViewItem addonRow = new ListViewItem("   • " + addon.Name);
                    addonRow.SubItems.Add(addon.Quantity.ToString());

                    addonRow.SubItems.Add("");
                    addonRow.SubItems.Add("");

                    addonRow.ForeColor = Color.DarkSlateGray;

                    // Match parent group
                    addonRow.Group = row.Group;

                    addonRow.Tag = addon;

                    listViewCart.Items.Add(addonRow);
                }
            }

            listViewCart.EndUpdate();
            UpdateTotal();
        }

        public void ReloadCart()
        {
            LoadCartItems();
        }

        private void UpdateTotal()
        {
            Double total = 0;

            foreach (var item in CartItems)
                total += item.Subtotal;

            lblTotal.Text = "Total: $" + total.ToString("0.00");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listViewCart.SelectedItems.Count == 0)
                return;

            var selected = listViewCart.SelectedItems[0];
            var item = selected.Tag as CartItem;

            CartItems.Remove(item);
            LoadCartItems();
        }

        private void btnEditQuantity_Click(object sender, EventArgs e)
        {
            if (listViewCart.SelectedItems.Count == 0)
                return;

            var selected = listViewCart.SelectedItems[0];

            // CASE 1: Main drink/pastry item
            if (selected.Tag is CartItem item)
            {
                using (QuantityForm qf = new QuantityForm(item.Quantity))
                {
                    if (qf.ShowDialog() == DialogResult.OK)
                    {
                        item.Quantity = qf.SelectedQuantity;
                        item.Subtotal = item.Price * item.Quantity;
                        LoadCartItems();
                    }
                }
            }

            // CASE 2: Add-on item
            else if (selected.Tag is AddOnItem addon)
            {
                using (QuantityForm qf = new QuantityForm(addon.Quantity))
                {
                    if (qf.ShowDialog() == DialogResult.OK)
                    {
                        addon.Quantity = qf.SelectedQuantity;

                        LoadCartItems();
                    }
                }
            }
        }

    }
}
