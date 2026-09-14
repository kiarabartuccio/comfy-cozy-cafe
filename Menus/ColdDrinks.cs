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
    public partial class ColdDrinksForm : MenuSetup.MenuSetup
    {
        PictureBox selectedDrinkBox = null;
        Label selectedDrinkName = null;
        string selectedDrinkNamestring = null;
        PictureBox selectedSize = null;
        string selectedSizeName = null;
        string currentCategory = null;

        public ColdDrinksForm()
        {
            InitializeComponent();
        }

        private void ResetSizeSelection()
        {
            if (selectedSize != null)
                selectedSize.BorderStyle = BorderStyle.None;

            selectedSize = null;
            selectedSizeName = null;
        }


        private void SelectIceCoffeeDrink(PictureBox drinkBox, Label drinkName)
        {
            // Reset size selection if changing category
            if (currentCategory != "IcedCoffee")
                ResetSizeSelection();

            currentCategory = "IcedCoffee";

            // Remove border from previously selected drink
            if (selectedDrinkBox != null)
                selectedDrinkBox.BorderStyle = BorderStyle.None;

            // Add border to new selection
            drinkBox.BorderStyle = BorderStyle.FixedSingle;

            // Save info
            selectedDrinkBox = drinkBox;
            selectedDrinkName = drinkName;

            // Make controls visible
            IceCoffeeGB.Visible = true;
            SmoothieGB.Visible = false;
            FrappuccinoGB.Visible = false;
            LemonadeGB.Visible = false;
        }

        private void SelectFrappuccinoDrink(PictureBox drinkBox, Label drinkName)
        {
            // Reset size selection if changing category
            if (currentCategory != "Frapp")
                ResetSizeSelection();

            currentCategory = "Frapp";

            // Remove border from previously selected drink
            if (selectedDrinkBox != null)
                selectedDrinkBox.BorderStyle = BorderStyle.None;

            // Add border to new selection
            drinkBox.BorderStyle = BorderStyle.FixedSingle;

            // Save info
            selectedDrinkBox = drinkBox;
            selectedDrinkName = drinkName;

            // Make controls visible
            IceCoffeeGB.Visible = false;
            SmoothieGB.Visible = false;
            FrappuccinoGB.Visible = true;
            LemonadeGB.Visible = false;
        }
        private void SelectSmoothieDrink(PictureBox drinkBox, Label drinkName)
        {
            // Reset size selection if changing category
            if (currentCategory != "Smoothie")
                ResetSizeSelection();

            currentCategory = "Smoothie";

            // Remove border from previously selected drink
            if (selectedDrinkBox != null)
                selectedDrinkBox.BorderStyle = BorderStyle.None;

            // Add border to new selection
            drinkBox.BorderStyle = BorderStyle.FixedSingle;

            // Save info
            selectedDrinkBox = drinkBox;
            selectedDrinkName = drinkName;
            
            // Make controls visible
            IceCoffeeGB.Visible = false;
            SmoothieGB.Visible = true;
            FrappuccinoGB.Visible = false;
            LemonadeGB.Visible = false;
        }

        private void SelectLemonadeDrink(PictureBox drinkBox, Label drinkName)
        {
            // Reset size selection if changing category
            if (currentCategory != "Lemonade")
                ResetSizeSelection();

            currentCategory = "Lemonade";

            // Remove border from previously selected drink
            if (selectedDrinkBox != null)
                selectedDrinkBox.BorderStyle = BorderStyle.None;

            // Add border to new selection
            drinkBox.BorderStyle = BorderStyle.FixedSingle;

            // Save info
            selectedDrinkBox = drinkBox;
            selectedDrinkName = drinkName;

            // Make controls visible
            IceCoffeeGB.Visible = false;
            SmoothieGB.Visible = false;
            FrappuccinoGB.Visible = false;
            LemonadeGB.Visible = true;
        }

        private void SmoothieQTY_ValueChanged(object sender, EventArgs e)
        {
            ItemPriceCalculation();
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
                if (selectedSize == SmoothieSmall || selectedSize == FrappSmall || selectedSize == LemonadeSmall || selectedSize == IceCoffeeSmall)
                {
                    selectedSizeName = "Small";
                }
                else if (selectedSize == SmoothieMed || selectedSize == FrappMed || selectedSize == LemonadeMed || selectedSize == IceCoffeeMed)
                {
                    selectedSizeName = "Medium";
                }
                else if (selectedSize == SmoothieLarge || selectedSize == FrappLarge || selectedSize == LemonadeLarge || selectedSize == IceCoffeeLarge)
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
                case "AvocadoPic":
                    selectedDrinkNamestring = "Avocado Smoothie";
                    basePrice = 4.25; 
                    break;
                case "BlueberryPic":
                    selectedDrinkNamestring = "Blueberry Smoothie";
                    basePrice = 3.75; 
                    break;
                case "MangoPic":
                    selectedDrinkNamestring = "Mango Smoothie";
                    basePrice = 4.50; 
                    break;
                case "StrawberryPic":
                    selectedDrinkNamestring = "Strawberry Smoothie";
                    basePrice = 4.00; 
                    break;
                case "LemonadePic":
                    selectedDrinkNamestring = "Lemonade";
                    basePrice = 2.25; 
                    break;
                case "FrozenLemonadePic":
                    selectedDrinkNamestring = "Frozen Lemonade";
                    basePrice = 2.50; 
                    break;
                case "OrangeLemonadePic": 
                    selectedDrinkNamestring = "Orange Lemonade";
                    basePrice = 2.75; 
                    break;
                case "PinkLemonadePic":
                    selectedDrinkNamestring = "Pink Lemonade";
                    basePrice = 2.65; 
                    break;
                case "FrappuccinoPic":
                    selectedDrinkNamestring = "Original Frappuccino";
                    basePrice = 4.75; 
                    break;

                case "CaramelFrappPic":
                    selectedDrinkNamestring = "Caramel Frappuccino";
                    basePrice = 5.15; 
                    break;
                case "ChocoFrappPic":
                    selectedDrinkNamestring = "Chocolate Frappuccino";
                    basePrice = 5.15; 
                    break;
                case "IceCoffeePic":
                    selectedDrinkNamestring = "Original Iced Coffee";
                    basePrice = 4.00; 
                    break;
                case "CaramelIceCoffeePic":
                    selectedDrinkNamestring = "Caramel Iced Coffee";
                    basePrice = 4.50; 
                    break;
                case "ChocoIceCoffeePic":
                    selectedDrinkNamestring = "Chocolate Iced Coffee";
                    basePrice = 4.50; 
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
            if (selectedDrinkNamestring == "Avocado Smoothie" || selectedDrinkNamestring == "Blueberry Smoothie" ||
                selectedDrinkNamestring == "Mango Smoothie" || selectedDrinkNamestring == "Strawberry Smoothie")
            {
                qty = (int)SmoothieQTY.Value;
            }
            else if (selectedDrinkNamestring == "Lemonade" || selectedDrinkNamestring == "Frozen Lemonade" ||
                selectedDrinkNamestring == "Orange Lemonade" || selectedDrinkNamestring == "Pink Lemonade")
            {
                qty = (int)LemonadeQTY.Value;
            }
            else if (selectedDrinkBox == FrappuccinoPic || selectedDrinkBox == CaramelFrappPic ||
                selectedDrinkBox == ChocoFrappPic)
            {
                qty = (int)FrappQTY.Value;
            }
            else if (selectedDrinkBox == IceCoffeePic || selectedDrinkBox == CaramelIceCoffeePic ||
                selectedDrinkBox == ChocoIceCoffeePic)
            {
                qty = (int)IceCoffeeQTY.Value;
            }

                Double totalPrice = (basePrice + sizePrice) * qty;

            switch (selectedDrinkNamestring)
            {
                case "Avocado Smoothie":
                case "Blueberry Smoothie":
                case "Mango Smoothie":
                case "Strawberry Smoothie":
                    SmoothiePriceLabel.Text = $"${totalPrice:0.00}";

                    break;
                case "Lemonade":
                case "Frozen Lemonade":
                case "Orange Lemonade":
                case "Pink Lemonade":
                    LemonadePriceLabel.Text = $"${totalPrice:0.00}";
                    break;
                case "Original Frappuccino":
                case "Caramel Frappuccino":
                case "Chocolate Frappuccino":
                    FrappPriceLabel.Text = $"${totalPrice:0.00}";
                    break;
                case "Original Iced Coffee":
                case "Caramel Iced Coffee":
                case "Chocolate Iced Coffee":
                    IceCoffeePriceLabel.Text = $"${totalPrice:0.00}";
                    break;
            }
        }


        private void AvocadoPic_Click_1(object sender, EventArgs e)
        {
            SelectSmoothieDrink(AvocadoPic, AvocadoLabel);
            ItemPriceCalculation();
        }

        private void BlueberryPic_Click(object sender, EventArgs e)
        {
            SelectSmoothieDrink(BlueberryPic, BlueberryLabel);
            ItemPriceCalculation();
        }

        private void MangoPic_Click(object sender, EventArgs e)
        {
            SelectSmoothieDrink(MangoPic, MangoLabel);
            ItemPriceCalculation();
        }

        private void StrawberryPic_Click(object sender, EventArgs e)
        {
            SelectSmoothieDrink(StrawberryPic, StrawberryLabel);
            ItemPriceCalculation();
        }

        private void LemonadePic_Click(object sender, EventArgs e)
        {
            SelectLemonadeDrink(LemonadePic, LemonadeLabel);
            ItemPriceCalculation();
        }

        private void FrozenLemonadePic_Click(object sender, EventArgs e)
        {
            SelectLemonadeDrink(FrozenLemonadePic, FrozenLemonadeLabel);
            ItemPriceCalculation();
        }

        private void OrangeLemonadePic_Click(object sender, EventArgs e)
        {
            SelectLemonadeDrink(OrangeLemonadePic, OrangeLemonadeLabel);
            ItemPriceCalculation();
        }

        private void PinkLemonadePic_Click(object sender, EventArgs e)
        {
            SelectLemonadeDrink(PinkLemonadePic, PinkLemonadeLabel);
            ItemPriceCalculation();
        }

        private void FrappuccinoPic_Click(object sender, EventArgs e)
        {
            SelectFrappuccinoDrink(FrappuccinoPic, FrappuccinoLabel);
            ItemPriceCalculation();
        }

        private void CaramelFrappPic_Click(object sender, EventArgs e)
        {
            SelectFrappuccinoDrink(CaramelFrappPic, CaramelFrappLabel);
            ItemPriceCalculation();
        }

        private void ChocoFrappPic_Click(object sender, EventArgs e)
        {
            SelectFrappuccinoDrink(ChocoFrappPic, ChocoFrappLabel);
            ItemPriceCalculation();
        }

        private void IceCoffeePic_Click(object sender, EventArgs e)
        {
            SelectIceCoffeeDrink(IceCoffeePic, IceCoffeeLabel);
            ItemPriceCalculation();
        }

        private void CaramelIceCoffeePic_Click(object sender, EventArgs e)
        {
            SelectIceCoffeeDrink(CaramelIceCoffeePic, CaramelIceCoffeeLabel);
            ItemPriceCalculation();
        }

        private void ChocoIceCoffeePic_Click(object sender, EventArgs e)
        {
            SelectIceCoffeeDrink(ChocoIceCoffeePic, ChocoIceCoffeeLabel);
            ItemPriceCalculation();
        }

        private void SmoothieSmall_Click(object sender, EventArgs e)
        {
            SelectSize(SmoothieSmall);
            ItemPriceCalculation();
        }

        private void SmoothieMed_Click(object sender, EventArgs e)
        {
            SelectSize(SmoothieMed);
            ItemPriceCalculation();
        }

        private void SmoothieLarge_Click(object sender, EventArgs e)
        {
            SelectSize(SmoothieLarge);
            ItemPriceCalculation();
        }

        private void FrappSmall_Click(object sender, EventArgs e)
        {
            SelectSize(FrappSmall);
            ItemPriceCalculation();
        }

        private void FrappMed_Click(object sender, EventArgs e)
        {
            SelectSize(FrappMed);
            ItemPriceCalculation();
        }

        private void FrappLarge_Click(object sender, EventArgs e)
        {
            SelectSize(FrappLarge);
            ItemPriceCalculation();
        }

        private void LemonadeSmall_Click(object sender, EventArgs e)
        {
            SelectSize(LemonadeSmall);
            ItemPriceCalculation();
        }

        private void IceCoffeeLarge_Click(object sender, EventArgs e)
        {
            SelectSize(IceCoffeeLarge);
            ItemPriceCalculation();
        }

        private void IceCoffeeMed_Click(object sender, EventArgs e)
        {
            SelectSize(IceCoffeeMed);
            ItemPriceCalculation();
        }

        private void IceCoffeeSmall_Click(object sender, EventArgs e)
        {
            SelectSize(IceCoffeeSmall);
            ItemPriceCalculation();
        }

        private void LemonadeLarge_Click(object sender, EventArgs e)
        {
            SelectSize(LemonadeLarge);
            ItemPriceCalculation();
        }

        private void LemonadeMed_Click(object sender, EventArgs e)
        {
            SelectSize(LemonadeMed);
            ItemPriceCalculation();
        }

        private void ResetColdDrinksForm()
        {
            // Remove drink border
            if (selectedDrinkBox != null)
                selectedDrinkBox.BorderStyle = BorderStyle.None;

            selectedDrinkBox = null;
            selectedDrinkName = null;
            selectedDrinkNamestring = null;

            // Remove size border
            if (selectedSize != null)
                selectedSize.BorderStyle = BorderStyle.None;

            selectedSize = null;
            selectedSizeName = null;

            // Reset category tracking
            currentCategory = null;

            // Reset quantities
            SmoothieQTY.Value = 1;
            LemonadeQTY.Value = 1;
            FrappQTY.Value = 1;
            IceCoffeeQTY.Value = 1;

            // Reset price labels
            SmoothiePriceLabel.Text = "";
            LemonadePriceLabel.Text = "";
            FrappPriceLabel.Text = "";
            IceCoffeePriceLabel.Text = "";

            // Hide all drink sections
            IceCoffeeGB.Visible = false;
            SmoothieGB.Visible = false;
            FrappuccinoGB.Visible = false;
            LemonadeGB.Visible = false;
        }



        private void SmoothieAddToCartbutton_Click(object sender, EventArgs e)
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

            // get base price again (you may combine with ItemPriceCalculation if you want)
            switch (selectedDrinkName.Text)
            {
                case "Avocado": basePrice = 4.25; break;
                case "Blueberry": basePrice = 3.75; break;
                case "Mango":  basePrice = 4.50; break;
                case "Strawberry":  basePrice = 4.00; break;
            }

            switch (selectedSizeName)
            {
                case "Small": sizePrice = 0; break;
                case "Medium": sizePrice = 1; break;
                case "Large": sizePrice = 2; break;
            }

            int qty = (int)SmoothieQTY.Value;
            double totalPrice = basePrice + sizePrice;
            double subtotal = totalPrice * qty;

            // Add to cart
            Menus.Cart.CartItems.Add(new Menus.Cart.CartItem
            {
                Name = $"{selectedDrinkNamestring} ({selectedSizeName})",
                Quantity = qty,
                Price = totalPrice,
                Subtotal = subtotal,
                Category = "Cold Drinks"
            });

            this.EnableCartMenu();

            SmoothieQTY.Value = 1; // reset quantity to 1

            MessageBox.Show("Added to cart!");
            ResetColdDrinksForm();
        }

        

        private void FrappAddToCart_Click(object sender, EventArgs e)
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
            switch (selectedDrinkNamestring)
            {
                case "Original Frappuccino": basePrice = 4.75; break;
                case "Caramel Frappuccino": basePrice = 5.15; break;
                case "Chocolate Frappuccino": basePrice = 5.15; break;
            }

            switch (selectedSizeName)
            {
                case "Small": sizePrice = 0; break;
                case "Medium": sizePrice = 1; break;
                case "Large": sizePrice = 2; break;
            }
            int qty = (int)FrappQTY.Value;
            double totalPrice = (basePrice + sizePrice);
            double subtotal = totalPrice * qty;

            // Add to cart
            Menus.Cart.CartItems.Add(new Menus.Cart.CartItem
            {
                Name = $"{selectedDrinkNamestring} ({selectedSizeName})",
                Quantity = qty,
                Price = totalPrice,
                Subtotal = subtotal,
                Category = "Cold Drinks"
            });

            this.EnableCartMenu();

            FrappQTY.Value = 1; // reset quantity to 1

            MessageBox.Show("Added to cart!");
            ResetColdDrinksForm();
        }

        private void IceCoffeeAddToCart_Click(object sender, EventArgs e)
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
            switch (selectedDrinkNamestring)
            {
                case "Original Iced Coffee": basePrice = 4.00; break;
                case "Caramel Iced Coffee": basePrice = 4.50; break;
                case "Chocolate Iced Coffee": basePrice = 4.50; break;
            }

            switch (selectedSizeName)
            {
                case "Small": sizePrice = 0; break;
                case "Medium": sizePrice = 1; break;
                case "Large": sizePrice = 2; break;
            }

            int qty = (int)IceCoffeeQTY.Value;
            double totalPrice = basePrice + sizePrice;
            double subtotal = totalPrice * qty;

            // Add to cart
            Menus.Cart.CartItems.Add(new Menus.Cart.CartItem
            {
                Name = $"{selectedDrinkNamestring} ({selectedSizeName})",
                Quantity = qty,
                Price = totalPrice,
                Subtotal = subtotal,
                Category = "Cold Drinks"
            });

            this.EnableCartMenu();

            IceCoffeeQTY.Value = 1; // reset quantity to 1

            MessageBox.Show("Added to cart!");
            ResetColdDrinksForm();
        }

        private void LemonadeAddToCart_Click(object sender, EventArgs e)
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
            switch (selectedDrinkNamestring)
            {
                case "Lemonade": basePrice = 2.25; break;
                case "Frozen Lemonade": basePrice = 2.50; break;
                case "Orange Lemonade": basePrice = 2.75; break;
                case "Pink Lemonade": basePrice = 2.65; break;
            }

            switch (selectedSizeName)
            {
                case "Small": sizePrice = 0; break;
                case "Medium": sizePrice = 1; break;
                case "Large": sizePrice = 2; break;
            }

            int qty = (int)LemonadeQTY.Value;
            double totalPrice = basePrice + sizePrice;
            double subtotal = totalPrice * qty;

            // Add to cart
            Menus.Cart.CartItems.Add(new Menus.Cart.CartItem
            {
                Name = $"{selectedDrinkNamestring} ({selectedSizeName})",
                Quantity = qty,
                Price = totalPrice,
                Subtotal = subtotal,
                Category = "Cold Drinks"
            });

            this.EnableCartMenu();

            LemonadeQTY.Value = 1; // reset quantity to 1

            MessageBox.Show("Added to cart!");
            ResetColdDrinksForm();
        }

        private void FrappQTY_ValueChanged(object sender, EventArgs e)
        {
            ItemPriceCalculation();
        }

        private void IceCoffeeQTY_ValueChanged(object sender, EventArgs e)
        {
            ItemPriceCalculation();
        }

        private void LemonadeQTY_ValueChanged(object sender, EventArgs e)
        {
            ItemPriceCalculation();
        }
    }
}
