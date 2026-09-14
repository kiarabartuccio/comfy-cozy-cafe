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
    public partial class HotDrinksForm : MenuSetup.MenuSetup
    {
        PictureBox selectedDrinkBox = null;
        Label selectedDrinkName = null;
        string selectedDrinkNamestring = null;
        PictureBox selectedSize = null;
        string selectedSizeName = null;
        string currentCategory = null;

        public HotDrinksForm()
        {
            InitializeComponent();
        }

        private void SelectSize(PictureBox sizeBox)
        {

            // Remove border from previously selected size
            if (selectedSize != null)
                selectedSize.BorderStyle = BorderStyle.None;

            // Add border to new selection
            sizeBox.BorderStyle = BorderStyle.FixedSingle;

            // Save info
            selectedSize = sizeBox;

            if (selectedSize != null)
            {
                if (selectedSize == CoffeeSmall || selectedSize == HotChocoSmall || selectedSize == TeaSmall )
                {
                    selectedSizeName = "Small";
                }
                else if (selectedSize == CoffeeMed || selectedSize == HotChocoMed || selectedSize == TeaMed)
                {
                    selectedSizeName = "Medium";
                }
                else if (selectedSize == CoffeeLarge || selectedSize == HotChocoLarge || selectedSize == TeaLarge)
                {
                    selectedSizeName = "Large";
                }
            }
            ItemPriceCalculation();
        }

        private void ItemPriceCalculation()
        {

            if (selectedDrinkName == null || selectedSizeName == null)
                return;

            Double basePrice = 0;
            int sizePrice = 0;
            // Determine base price based on selected drink
            switch (selectedDrinkBox.Name)
            {
                case "HotChocoPic":
                    selectedDrinkNamestring = "Hot Chocolate";
                    basePrice = 2.25;
                    break;
                case "WhiteHotChocoPic":
                    selectedDrinkNamestring = "White Hot Chocolate";
                    basePrice = 2.50;
                    break;

                case "CoffeePic":
                    selectedDrinkNamestring = "Coffee";
                    basePrice = 1.50;
                    break;
                case "LattePic":
                    selectedDrinkNamestring = "Latte";
                    basePrice = 2.25;
                    break;
                case "CappuccinoPic":
                    selectedDrinkNamestring = "Cappuccino";
                    basePrice = 2.25;
                    break;
                case "AmericanoPic":
                    selectedDrinkNamestring = "Americano";
                    basePrice = 2.00;
                    break;

                case "BlackTeaPic":
                    selectedDrinkNamestring = "Black Tea";
                    basePrice = 1.75;
                    break;
                case "GreenTeaPic":
                    selectedDrinkNamestring = "Green Tea";
                    basePrice = 1.75;
                    break;
                case "HibiscusTeaPic":
                    selectedDrinkNamestring = "Hibiscus Tea";
                    basePrice = 1.95;
                    break;
                case "MintTeaPic":
                    selectedDrinkNamestring = "Mint Tea";
                    basePrice = 1.85;
                    break;
                case "RaspberryTeaPic":
                    selectedDrinkNamestring = "Raspberry Tea";
                    basePrice = 2.00;
                    break;
            }

            // Determine size price based on selected size
            switch (selectedSizeName)
            {
                case "Small": sizePrice = 0; break;
                case "Medium": sizePrice = 1; break;
                case "Large": sizePrice = 2; break;
            }
            int qty = 1;
            if (selectedDrinkNamestring == "Hot Chocolate" || selectedDrinkNamestring == "White Hot Chocolate")
            {
                qty = (int)HotChocoQTY.Value;
            }
            else if (selectedDrinkNamestring == "Coffee" || selectedDrinkNamestring == "Latte" ||
                selectedDrinkNamestring == "Cappuccino" || selectedDrinkNamestring == "Americano")
            {
                qty = (int)CoffeeQTY.Value;
            }
            else if (selectedDrinkNamestring == "Black Tea" || selectedDrinkNamestring == "Green Tea" ||
                selectedDrinkNamestring == "Hibiscus Tea" || selectedDrinkNamestring == "Mint Tea" ||
                selectedDrinkNamestring == "Raspberry Tea")
            {
                qty = (int)TeaQTY.Value;
            }

            Double totalPrice = (basePrice + sizePrice) * qty;

            switch (selectedDrinkNamestring)
            {
                case "Coffee":
                case "Latte":
                case "Cappuccino":
                case "Americano":
                    CoffeePriceLabel.Text = $"${totalPrice:0.00}";
                    break;
                case "Hot Chocolate":
                case "White Hot Chocolate":
                    HotChocoPriceLabel.Text = $"${totalPrice:0.00}";
                    break;
                case "Black Tea":
                case "Green Tea":
                case "Hibiscus Tea":
                case "Mint Tea":
                case "Raspberry Tea":
                    TeaPriceLabel.Text = $"${totalPrice:0.00}";
                    break;
            }
        }

        public void ResetForm()
        {
            // Remove drink selection
            if (selectedDrinkBox != null)
                selectedDrinkBox.BorderStyle = BorderStyle.None;
            selectedDrinkBox = null;
            selectedDrinkName = null;
            selectedDrinkNamestring = null;

            // Remove size selection
            if (selectedSize != null)
                selectedSize.BorderStyle = BorderStyle.None;
            selectedSize = null;
            selectedSizeName = null;

            // Reset current category
            currentCategory = null;

            // Hide all group boxes
            choicesGB1.Visible = false;
            choicehotChocoGB.Visible = false;
            choiceTeaGB.Visible = false;

            // Reset quantities
            CoffeeQTY.Value = 1;
            HotChocoQTY.Value = 1;
            TeaQTY.Value = 1;

            // Clear price labels
            CoffeePriceLabel.Text = "";
            HotChocoPriceLabel.Text = "";
            TeaPriceLabel.Text = "";
        }


        private void CoffeeAddOns_Click_1(object sender, EventArgs e)
        {
            if (selectedSize == null)
            {
                MessageBox.Show("Please select a size first.");
                return;
            }

            int qty = (int)CoffeeQTY.Value;
            double basePrice = 0;
            int sizePrice = 0;

            switch (selectedDrinkBox.Name)
            {
                case "CoffeePic": basePrice = 1.50; break;
                case "LattePic": basePrice = 2.25; break;
                case "CappuccinoPic": basePrice = 2.25; break;
                case "AmericanoPic": basePrice = 2.00; break;
            }

            switch (selectedSizeName)
            {
                case "Small": sizePrice = 0; break;
                case "Medium": sizePrice = 1; break;
                case "Large": sizePrice = 2; break;
            }

            double finalPrice = basePrice + sizePrice;
            double subtotal = finalPrice * qty;

            Cart.CartItem tempParentDrink = new Cart.CartItem
            {
                Name = $"{selectedDrinkNamestring} ({selectedSizeName})",
                Quantity = qty,
                Price = finalPrice,
                Subtotal = subtotal,
                Category = "Hot Drinks"
            };

            AddOns addonForm = new AddOns(
                this,
                tempParentDrink,
                qty,
                selectedDrinkBox.Image
            );

            addonForm.Show();
        }
        private void TeaAddOns_Click_1(object sender, EventArgs e)
        {
            if (selectedSize == null)
            {
                MessageBox.Show("Please select a size first.");
                return;
            }

            int qty = (int)TeaQTY.Value;

            double basePrice = 0;
            int sizePrice = 0;

            switch (selectedDrinkBox.Name)
            {
                case "BlackTeaPic": basePrice = 1.75; break;
                case "GreenTeaPic": basePrice = 1.75; break;
                case "HibiscusTeaPic": basePrice = 1.95; break;
                case "MintTeaPic": basePrice = 1.85; break;
                case "RaspberryTeaPic": basePrice = 2.00; break;
            }

            switch (selectedSizeName)
            {
                case "Small": sizePrice = 0; break;
                case "Medium": sizePrice = 1; break;
                case "Large": sizePrice = 2; break;
            }

            double finalPrice = basePrice + sizePrice;
            double subtotal = finalPrice * qty;

            Cart.CartItem tempParentDrink = new Cart.CartItem
            {
                Name = $"{selectedDrinkNamestring} ({selectedSizeName})",
                Quantity = qty,
                Price = finalPrice,
                Subtotal = subtotal,
                Category = "Hot Drinks"
            };

            AddOns addonForm = new AddOns(
                this,
                tempParentDrink,
                qty,
                selectedDrinkBox.Image
            );

            addonForm.Show();
        }

        private void ResetSizeSelection()
        {
            if (selectedSize != null)
                selectedSize.BorderStyle = BorderStyle.None;

            selectedSize = null;
            selectedSizeName = null;
        }

        private void SelectCoffeeDrink(PictureBox drinkBox, Label drinkName)
        {
            if (currentCategory != "Coffee")
                ResetSizeSelection();

            currentCategory = "Coffee";

            // Remove border from previously selected drink
            if (selectedDrinkBox != null)
                selectedDrinkBox.BorderStyle = BorderStyle.None;

            // Add border to new selection
            drinkBox.BorderStyle = BorderStyle.FixedSingle;

            // Save info
            selectedDrinkBox = drinkBox;
            selectedDrinkName = drinkName;

            // Make controls visible
            choicesGB1.Visible = true;
            choicehotChocoGB.Visible = false;
            choiceTeaGB.Visible = false;
        }

        private void SelectHotChocoDrink(PictureBox drinkBox, Label drinkName)
        {
            if (currentCategory != "HotChoco")
                ResetSizeSelection();

            currentCategory = "HotChoco";

            // Remove border from previously selected drink
            if (selectedDrinkBox != null)
                selectedDrinkBox.BorderStyle = BorderStyle.None;

            // Add border to new selection
            drinkBox.BorderStyle = BorderStyle.FixedSingle;

            // Save info
            selectedDrinkBox = drinkBox;
            selectedDrinkName = drinkName;

            // Make controls visible
            choicesGB1.Visible = false;
            choicehotChocoGB.Visible = true;
            choiceTeaGB.Visible = false;
        }

        private void SelectTeaDrink(PictureBox drinkBox, Label drinkName)
        {
            if (currentCategory != "Tea")
                ResetSizeSelection();

            currentCategory = "Tea";

            // Remove border from previously selected drink
            if (selectedDrinkBox != null)
                selectedDrinkBox.BorderStyle = BorderStyle.None;

            // Add border to new selection
            drinkBox.BorderStyle = BorderStyle.FixedSingle;

            // Save info
            selectedDrinkBox = drinkBox;
            selectedDrinkName = drinkName;

            // Make controls visible
            choicesGB1.Visible = false;
            choicehotChocoGB.Visible = false;
            choiceTeaGB.Visible = true;
        }

        private void CoffeePic_Click_1(object sender, EventArgs e)
        {
            SelectCoffeeDrink(CoffeePic, CoffeeLabel);
            ItemPriceCalculation();
        }

        private void LattePic_Click_1(object sender, EventArgs e)
        {
            SelectCoffeeDrink(LattePic, LatteLabel);
            ItemPriceCalculation();
        }

        private void CappuccinoPic_Click_1(object sender, EventArgs e)
        {
            SelectCoffeeDrink(CappuccinoPic, CappuccinoLabel);
            ItemPriceCalculation();
        }

        private void AmericanoPic_Click_1(object sender, EventArgs e)
        {
            SelectCoffeeDrink(AmericanoPic, AmericanoLabel);
            ItemPriceCalculation();
        }

        private void HotChocoPic_Click_1(object sender, EventArgs e)
        {
            SelectHotChocoDrink(HotChocoPic, HotChocoLabel);
            ItemPriceCalculation();
        }

        private void WhiteHotChocoPic_Click_1(object sender, EventArgs e)
        {
            SelectHotChocoDrink(WhiteHotChocoPic, WhiteHotChocoLabel);
            ItemPriceCalculation();
        }

        private void BlackTeaPic_Click_1(object sender, EventArgs e)
        {
            SelectTeaDrink(BlackTeaPic, TeaBlackLabel);
            ItemPriceCalculation();
        }

        private void GreenTeaPic_Click_1(object sender, EventArgs e)
        {
            SelectTeaDrink(GreenTeaPic, TeaGreenLabel);
            ItemPriceCalculation();
        }

        private void HibiscusTeaPic_Click_1(object sender, EventArgs e)
        {
            SelectTeaDrink(HibiscusTeaPic, TeaHibiscusLabel);
            ItemPriceCalculation();
        }

        private void MintTeaPic_Click_1(object sender, EventArgs e)
        {
            SelectTeaDrink(MintTeaPic, TeaMintLabel);
            ItemPriceCalculation();
        }

        private void RaspberryTeaPic_Click_1(object sender, EventArgs e)
        {
            SelectTeaDrink(RaspberryTeaPic, TeaRaspberryLabel);
            ItemPriceCalculation();
        }

        private void CoffeeAddToCart_Click(object sender, EventArgs e)
        {
            if (selectedDrinkBox == null)
            {
                MessageBox.Show("Please select a drink first.", "Missing Drink",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedSize == null)
            {
                MessageBox.Show("Please select a size first.", "Missing Size",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Now safe to add to cart
            double basePrice = 0;
            int sizePrice = 0;

            // get base price again
            switch (selectedDrinkBox.Name)
            {
                case "CoffeePic": basePrice = 1.50; break;
                case "LattePic": basePrice = 2.25; break;
                case "CappuccinoPic": basePrice = 2.25; break;
                case "AmericanoPic": basePrice = 2.00; break;
            }

            switch (selectedSizeName)
            {
                case "Small": sizePrice = 0; break;
                case "Medium": sizePrice = 1; break;
                case "Large": sizePrice = 2; break;
            }

            int qty = (int)CoffeeQTY.Value;
            double totalPrice = basePrice + sizePrice;
            double subtotal = totalPrice * qty;

            // Add to cart
            Menus.Cart.CartItems.Add(new Menus.Cart.CartItem
            {
                Name = $"{selectedDrinkNamestring} ({selectedSizeName})",
                Quantity = qty,
                Price = totalPrice,
                Subtotal = subtotal,
                Category = "Hot Drinks"
            });

            this.EnableCartMenu();

            CoffeeQTY.Value = 1; // reset quantity to 1

            MessageBox.Show("Added to cart!");
            ResetForm();
        }

        private void HotChocoAddToCart_Click(object sender, EventArgs e)
        {
            if (selectedDrinkBox == null)
            {
                MessageBox.Show("Please select a drink first.", "Missing Drink",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedSize == null)
            {
                MessageBox.Show("Please select a size first.", "Missing Size",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Now safe to add to cart
            double basePrice = 0;
            int sizePrice = 0;

            // get base price again
            switch (selectedDrinkBox.Name)
            {
                case "HotChocoPic": basePrice = 2.25; break;
                case "WhiteHotChocoPic": basePrice = 2.50; break;
            }

            switch (selectedSizeName)
            {
                case "Small": sizePrice = 0; break;
                case "Medium": sizePrice = 1; break;
                case "Large": sizePrice = 2; break;
            }

            int qty = (int)HotChocoQTY.Value;
            double totalPrice = basePrice + sizePrice;
            double subtotal = totalPrice * qty;

            // Add to cart
            Menus.Cart.CartItems.Add(new Menus.Cart.CartItem
            {
                Name = $"{selectedDrinkNamestring} ({selectedSizeName})",
                Quantity = qty,
                Price = totalPrice,
                Subtotal = subtotal,
                Category = "Hot Drinks"
            });

            this.EnableCartMenu();

            HotChocoQTY.Value = 1; // reset quantity to 1

            MessageBox.Show("Added to cart!");
            ResetForm();
        }

        private void TeaAddToCart_Click(object sender, EventArgs e)
        {
            if (selectedDrinkBox == null)
            {
                MessageBox.Show("Please select a drink first.", "Missing Drink",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedSize == null)
            {
                MessageBox.Show("Please select a size first.", "Missing Size",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Now safe to add to cart
            double basePrice = 0;
            int sizePrice = 0;

            // get base price again
            switch (selectedDrinkBox.Name)
            {
                case "BlackTeaPic": basePrice = 1.75; break;
                case "GreenTeaPic": basePrice = 1.75; break;
                case "HibiscusTeaPic": basePrice = 1.95; break;
                case "MintTeaPic": basePrice = 1.85; break;
                case "RaspberryTeaPic": basePrice = 2.00; break;

            }

            switch (selectedSizeName)
            {
                case "Small": sizePrice = 0; break;
                case "Medium": sizePrice = 1; break;
                case "Large": sizePrice = 2; break;
            }

            int qty = (int)TeaQTY.Value;
            double totalPrice = basePrice + sizePrice;
            double subtotal = totalPrice * qty;

            // Add to cart
            Menus.Cart.CartItems.Add(new Menus.Cart.CartItem
            {
                Name = $"{selectedDrinkNamestring} ({selectedSizeName})",
                Quantity = qty,
                Price = totalPrice,
                Subtotal = subtotal,
                Category = "Hot Drinks"
            });

            this.EnableCartMenu();

            TeaQTY.Value = 1; // reset quantity to 1

            MessageBox.Show("Added to cart!");
            ResetForm();
        }

        private void TeaMed_Click(object sender, EventArgs e)
        {
            SelectSize(TeaMed);
        }

        private void CoffeeMed_Click(object sender, EventArgs e)
        {
            SelectSize(CoffeeMed);
        }

        private void CoffeeLarge_Click(object sender, EventArgs e)
        {
            SelectSize(CoffeeLarge);
        }

        private void HotChocoSmall_Click(object sender, EventArgs e)
        {
            SelectSize(HotChocoSmall);
        }

        private void HotChocoMed_Click(object sender, EventArgs e)
        {
            SelectSize(HotChocoMed);
        }

        private void HotChocoLarge_Click(object sender, EventArgs e)
        {
            SelectSize(HotChocoLarge);
        }

        private void TeaLarge_Click(object sender, EventArgs e)
        {
            SelectSize(TeaLarge);
        }

        private void CoffeeSmall_Click(object sender, EventArgs e)
        {
            SelectSize(CoffeeSmall);
        }

        private void TeaSmall_Click(object sender, EventArgs e)
        {
            SelectSize(TeaSmall);
        }

        private void CoffeeQTY_ValueChanged(object sender, EventArgs e)
        {
            ItemPriceCalculation();
        }

        private void HotChocoQTY_ValueChanged(object sender, EventArgs e)
        {
            ItemPriceCalculation();
        }

        private void TeaQTY_ValueChanged(object sender, EventArgs e)
        {
            ItemPriceCalculation();
        }
    }
}
