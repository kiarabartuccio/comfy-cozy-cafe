using Menus;
using System;
using System.Drawing;
using System.Windows.Forms;



namespace Menus
{
    
    public partial class AddOns : Form
    {
        private HotDrinksForm parentForm;
        public int DrinkQuantity { get; private set; }
        public Cart.CartItem ParentDrink { get; set; }

        // Constructor that receives quantity
        public AddOns(HotDrinksForm parent, Cart.CartItem drink, int quantity, Image chosenImage)
        {
            InitializeComponent();

            parentForm = parent;      // save reference
            ParentDrink = drink;
            DrinkQuantity = quantity;

            ItemAddOnsQTY.Value = quantity;
            ChosenItemPic.Image = chosenImage;
        }



        // Property wrapper 
        public Image ChosenItemImage
        {
            get { return ChosenItemPic.Image; }
            set { ChosenItemPic.Image = value; }
        }

        private void AddOnsAddToCart_Click(object sender, EventArgs e)
        {
            if (MilkQTY.Value > 0)
                ParentDrink.AddOns.Add(new Cart.AddOnItem
                {
                    Name = "Milk 2%",
                    Quantity = (int)MilkQTY.Value
                });

            if (Cream10QTY.Value > 0)
                ParentDrink.AddOns.Add(new Cart.AddOnItem
                {
                    Name = "Cream 10%",
                    Quantity = (int)Cream10QTY.Value
                });

            if (Cream18QTY.Value > 0)
                ParentDrink.AddOns.Add(new Cart.AddOnItem
                {
                    Name = "Cream 18%",
                    Quantity = (int)Cream18QTY.Value
                });

            if (WhiteSugarQTY.Value > 0)
                ParentDrink.AddOns.Add(new Cart.AddOnItem
                {
                    Name = "White Sugar",
                    Quantity = (int)WhiteSugarQTY.Value
                });

            if (BrownSugarQTY.Value > 0)
                ParentDrink.AddOns.Add(new Cart.AddOnItem
                {
                    Name = "Brown Sugar",
                    Quantity = (int)BrownSugarQTY.Value
                });

            if (SweetnerQTY.Value > 0)
                ParentDrink.AddOns.Add(new Cart.AddOnItem
                {
                    Name = "Sweetner",
                    Quantity = (int)SweetnerQTY.Value
                });


            Menus.Cart.CartItems.Add(ParentDrink);


            foreach (Form f in Application.OpenForms)
                if (f is Cart cart)
                    cart.ReloadCart();


            parentForm.ResetForm();
            parentForm.EnableCartMenu();

            MessageBox.Show("Add-ons added!");

            this.Close();
        }



    }
}
