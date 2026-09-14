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
    public partial class PastriesForm : MenuSetup.MenuSetup
    {
        PictureBox selectedPastryBox = null;
        Label selectedPastryName = null;
        string selectedPastryNamestring = null;
        public PastriesForm()
        {
            InitializeComponent();
        }
        private void SelectClassicPastry(PictureBox drinkBox, Label drinkName)
        {
            // Remove border from previously selected drink
            if (selectedPastryBox != null)
                selectedPastryBox.BorderStyle = BorderStyle.None;

            // Add border to new selection
            drinkBox.BorderStyle = BorderStyle.FixedSingle;

            // Save info
            selectedPastryBox = drinkBox;
            selectedPastryName = drinkName;

            // Make controls visible
            ClassicGB.Visible = true;
            DanishGB.Visible = false;
            MuffinGB.Visible = false;
        }
        private void SelectDanishPastry(PictureBox drinkBox, Label drinkName)
        {
            // Remove border from previously selected drink
            if (selectedPastryBox != null)
                selectedPastryBox.BorderStyle = BorderStyle.None;

            // Add border to new selection
            drinkBox.BorderStyle = BorderStyle.FixedSingle;

            // Save info
            selectedPastryBox = drinkBox;
            selectedPastryName = drinkName;

            // Make controls visible
            ClassicGB.Visible = false;
            DanishGB.Visible = true;
            MuffinGB.Visible = false;
        }
        private void SelectMuffinPastry(PictureBox drinkBox, Label drinkName)
        {
            // Remove border from previously selected drink
            if (selectedPastryBox != null)
                selectedPastryBox.BorderStyle = BorderStyle.None;

            // Add border to new selection
            drinkBox.BorderStyle = BorderStyle.FixedSingle;

            // Save info
            selectedPastryBox = drinkBox;
            selectedPastryName = drinkName;

            // Make controls visible
            ClassicGB.Visible = false;
            DanishGB.Visible = false;
            MuffinGB.Visible = true;
        }

        private void ItemPriceCalculation()
        {

            if (selectedPastryName == null)
                return;

            Double basePrice = 0;
            // Determine base price based on selected drink
            switch (selectedPastryBox.Name)
            {
                case "CroissantPic":
                    selectedPastryNamestring = "Croissant";
                    basePrice = 1.75;
                    break;
                case "ChocoCroissantPic":
                    selectedPastryNamestring = "Chocolate Croissant";
                    basePrice = 2.00;
                    break;
                case "ChocolatinePic":
                    selectedPastryNamestring = "Chocolatine";
                    basePrice = 1.75;
                    break;
                case "BlueberryCheesecakeDanishPic":
                    selectedPastryNamestring = "Blueberry Cheesecake Danish";
                    basePrice = 3.25;
                    break;

                case "DanishPic":
                    selectedPastryNamestring = "Clasic Danish";
                    basePrice = 2.25;
                    break;
                case "AppleDanishPic":
                    selectedPastryNamestring = "Apple Danish";
                    basePrice = 2.50;
                    break;
                case "BlueberryDanishPic":
                    selectedPastryNamestring = "Blueberry Danish";
                    basePrice = 2.50;
                    break;
                case "PineappleDanishPic":
                    selectedPastryNamestring = "Pineapple Danish";
                    basePrice = 3.00;
                    break;

                case "BlueberryMuffinPic":
                    selectedPastryNamestring = "Blueberry Muffin";
                    basePrice = 1.95;
                    break;
                case "ChocoChipMuffinPic":
                    selectedPastryNamestring = "Chocolate Chip Muffin";
                    basePrice = 2.00;
                    break;
                case "DBLChocoMuffinPic":
                    selectedPastryNamestring = "Double Chocolate Muffin";
                    basePrice = 2.15;
                    break;
                case "CranOrangeMuffinPic":
                    selectedPastryNamestring = "Cranberry Orange Muffin";
                    basePrice = 1.75;
                    break;
                case "CarmBanPecMuffinPic":
                    selectedPastryNamestring = "Caramel Banana Pecan Muffin";
                    basePrice = 3.25;
                    break;

            }

            int qty = 1;

            if (selectedPastryNamestring == "Croissant" || selectedPastryNamestring == "Chocolate Croissant" ||
                selectedPastryNamestring == "Chocolatine" || selectedPastryNamestring == "Blueberry Cheesecake Danish")
            {
                qty = (int)PastriesQTY.Value;
            }
            else if (selectedPastryNamestring == "Clasic Danish" || selectedPastryNamestring == "Apple Danish" ||
                selectedPastryNamestring == "Blueberry Danish" || selectedPastryNamestring == "Pineapple Danish")
            {
                qty = (int)DanishQTY.Value;
            }
            else if (selectedPastryNamestring == "Blueberry Muffin" || selectedPastryNamestring == "Chocolate Chip Muffin" ||
                selectedPastryNamestring == "Double Chocolate Muffin" || selectedPastryNamestring == "Cranberry Orange Muffin" ||
                selectedPastryNamestring == "Caramel Banana Pecan Muffin")
            {
                qty = (int)MuffinQTY.Value;
            }

            Double totalPrice = basePrice * qty;

            switch (selectedPastryNamestring)
            {
                case "Croissant":
                case "Chocolate Croissant":
                case "Chocolatine":
                case "Blueberry Cheesecake Danish":
                    ClassicPastryPriceLabel.Text = $"${totalPrice:0.00}";
                    break;
                case "Clasic Danish":
                case "Apple Danish":
                case "Blueberry Danish":
                case "Pineapple Danish":
                    DanishPriceLabel.Text = $"${totalPrice:0.00}";
                    break;
                case "Blueberry Muffin":
                case "Chocolate Chip Muffin":
                case "Double Chocolate Muffin":
                case "Cranberry Orange Muffin":
                case "Caramel Banana Pecan Muffin":
                    MuffinPriceLabel.Text = $"${totalPrice:0.00}";
                    break;
            }
        }
        private void CroissantPic_Click_1(object sender, EventArgs e)
        {
            SelectClassicPastry(CroissantPic, CroissantLabel);
            ItemPriceCalculation();
        }

        private void ChocoCroissantPic_Click_1(object sender, EventArgs e)
        {
            SelectClassicPastry(ChocoCroissantPic, ChocoCroissantLabel);
            ItemPriceCalculation();
        }

        private void ChocolatinePic_Click_1(object sender, EventArgs e)
        {
            SelectClassicPastry(ChocolatinePic, ChocolatineLabel);
            ItemPriceCalculation();
        }

        private void BlueberryCheesecakeDanishPic_Click_1(object sender, EventArgs e)
        {
            SelectClassicPastry(BlueberryCheesecakeDanishPic, BlueberryCheesecakeDanishLabel);
            ItemPriceCalculation();
        }

        private void DanishPic_Click_1(object sender, EventArgs e)
        {
            SelectDanishPastry(DanishPic, DanishLabel);
            ItemPriceCalculation();
        }

        private void AppleDanishPic_Click_1(object sender, EventArgs e)
        {
            SelectDanishPastry(AppleDanishPic, AppleDanishLabel);
            ItemPriceCalculation();
        }

        private void BlueberryDanishPic_Click_1(object sender, EventArgs e)
        {
            SelectDanishPastry(BlueberryDanishPic, BlueberryDanishLabel);
            ItemPriceCalculation();
        }

        private void PineappleDanishPic_Click_1(object sender, EventArgs e)
        {
            SelectDanishPastry(PineappleDanishPic, PineappleDanishLabel);
            ItemPriceCalculation();
        }

        private void BlueberryMuffinPic_Click_1(object sender, EventArgs e)
        {
            SelectMuffinPastry(BlueberryMuffinPic, BlueberryMuffinLabel);
            ItemPriceCalculation();
        }

        private void ChocoChipMuffinPic_Click_1(object sender, EventArgs e)
        {
            SelectMuffinPastry(ChocoChipMuffinPic, ChocoChipMuffinLabel);
            ItemPriceCalculation();
        }

        private void DBLChocoMuffinPic_Click_1(object sender, EventArgs e)
        {
            SelectMuffinPastry(DBLChocoMuffinPic, DBLChocoMuffinLabel);
            ItemPriceCalculation();
        }

        private void CranOrangeMuffinPic_Click_1(object sender, EventArgs e)
        {
            SelectMuffinPastry(CranOrangeMuffinPic, CranOrangeMuffinLabel);
            ItemPriceCalculation();
        }

        private void CarmBanPecMuffinPic_Click_1(object sender, EventArgs e)
        {
            SelectMuffinPastry(CarmBanPecMuffinPic, CarmBanPecMuffinLabel);
            ItemPriceCalculation();
        }

        private void PastriesQTY_ValueChanged(object sender, EventArgs e)
        {
            ItemPriceCalculation();
        }

        private void DanishQTY_ValueChanged(object sender, EventArgs e)
        {
            ItemPriceCalculation();
        }

        private void MuffinQTY_ValueChanged(object sender, EventArgs e)
        {
            ItemPriceCalculation();
        }

        private void ResetPastryForm()
        {
            // Remove pastry border
            if (selectedPastryBox != null)
                selectedPastryBox.BorderStyle = BorderStyle.None;
            selectedPastryBox = null;

            // Reset names
            selectedPastryName = null;
            selectedPastryNamestring = null;

            // Reset quantity controls
            PastriesQTY.Value = 1;
            DanishQTY.Value = 1;
            MuffinQTY.Value = 1;

            // Reset price labels
            ClassicPastryPriceLabel.Text = "";
            DanishPriceLabel.Text = "";
            MuffinPriceLabel.Text = "";

            // Hide all group boxes
            ClassicGB.Visible = false;
            DanishGB.Visible = false;
            MuffinGB.Visible = false;
        }


        private void PastriesAddToCart_Click(object sender, EventArgs e)
        {
            // Now safe to add to cart
            double basePrice = 0;

            // get base price again 
            switch (selectedPastryNamestring)
            {
                case "Croissant": basePrice = 1.75; break;
                case "Chocolate Croissant": basePrice = 2.00; break;
                case "Chocolatine": basePrice = 1.75; break;
                case "Blueberry Cheesecake Danish": basePrice = 3.25; break;
            }

            int qty = (int)PastriesQTY.Value;
            double totalPrice = basePrice;
            double subtotal = totalPrice * qty;

            // Add to cart
            Menus.Cart.CartItems.Add(new Menus.Cart.CartItem
            {
                Name = selectedPastryNamestring,
                Quantity = qty,
                Price = totalPrice,
                Subtotal = subtotal,
                Category = "Pastries"

            });

            this.EnableCartMenu();

            PastriesQTY.Value = 1; // reset quantity to 1

            MessageBox.Show("Added to cart!");
            ResetPastryForm();
        }

        private void DanishAddToCart_Click(object sender, EventArgs e)
        {
            // Now safe to add to cart
            double basePrice = 0;

            // get base price again 
            switch (selectedPastryNamestring)
            {
                case "Clasic Danish": basePrice = 2.25; break;
                case "Apple Danish": basePrice = 2.50; break;
                case "Blueberry Danish": basePrice = 2.50; break;
                case "Pineapple Danish": basePrice = 3.00; break;
            }

            int qty = (int)DanishQTY.Value;
            double totalPrice = basePrice;
            double subtotal = totalPrice * qty;

            // Add to cart
            Menus.Cart.CartItems.Add(new Menus.Cart.CartItem
            {
                Name = selectedPastryNamestring,
                Quantity = qty,
                Price = totalPrice,
                Subtotal = subtotal,
                Category = "Pastries"

            });

            this.EnableCartMenu();

            DanishQTY.Value = 1; // reset quantity to 1

            MessageBox.Show("Added to cart!");
            ResetPastryForm();
        }

        private void MuffinAddToCart_Click(object sender, EventArgs e)
        {
            // Now safe to add to cart
            double basePrice = 0;

            // get base price again 
            switch (selectedPastryNamestring)
            {
                case "Blueberry Muffin": basePrice = 1.95; break;
                case "Chocolate Chip Muffin": basePrice = 2.00; break;
                case "Double Chocolate Muffin": basePrice = 2.15; break;
                case "Cranberry Orange Muffin": basePrice = 1.75; break;
                case "Caramel Banana Pecan Muffin": basePrice = 3.25; break;
            }

            int qty = (int)MuffinQTY.Value;
            double totalPrice = basePrice;
            double subtotal = totalPrice * qty;

            // Add to cart
            Menus.Cart.CartItems.Add(new Menus.Cart.CartItem
            {
                Name = selectedPastryNamestring,
                Quantity = qty,
                Price = totalPrice,
                Subtotal = subtotal,
                Category = "Pastries"

            });

            this.EnableCartMenu();



            MuffinQTY.Value = 1; // reset quantity to 1

            MessageBox.Show("Added to cart!");
            ResetPastryForm();
        }
    }
}
