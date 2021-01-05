//ID: 1775227
//Name: Marissa Goncalves
//Assignment 5 - Problem 1: Restaurant Bill Calculator

using System;
using System.Windows.Forms;

namespace Problem01
{
    public partial class RestaurantBillCalculatorForm : Form
    {
        private double BillSubtotal { get; set; }
        private double BillTax { get; set; }
        private double BillTotal { get; set; }
        private double BrevagePrice { get; set; }
        private double AppetizerPrice { get; set; }
        private double MainCoursePrice { get; set; }
        private double DessertPrice { get; set; }

        public RestaurantBillCalculatorForm()
        {
            InitializeComponent();
        }

        private void clearBillButton_Click(object sender, EventArgs e)
        {
            BillSubtotal = 0.00;
            BillTax = 0.00;
            BillTotal = 0.00;
            BrevagePrice = 0.00;
            AppetizerPrice = 0.00;
            MainCoursePrice = 0.00;
            DessertPrice = 0.00;
            tableNumberTextBox.Text = "";
            waiterNameTextBox.Text = "";
            brevageComboBox.Text = "";
            appetizerComboBox.Text = "";
            mainCourseComboBox.Text = "";
            dessertComboBox.Text = "";
            subtotalLabel.Text = $"{BillSubtotal:C}";
            taxLabel.Text = $"{BillTax:C}";
            totalLabel.Text = $"{BillTotal:C}";
        }


        public void Calculate(double menuItemPrice)
        {
            BillSubtotal += menuItemPrice;
            subtotalLabel.Text = $"{BillSubtotal:C}";

            BillTax = BillSubtotal * 0.15;
            taxLabel.Text = $"{BillTax:C}";

            BillTotal = BillSubtotal + BillTax;
            totalLabel.Text = $"{BillTotal:C}";
        }


        private void brevageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BillSubtotal -= BrevagePrice;

            switch (brevageComboBox.SelectedItem)
            {
                case "Soda": BrevagePrice = 1.95; break;
                case "Tea": BrevagePrice = 1.50; break;
                case "Coffee": BrevagePrice = 1.25; break;
                case "Mineral Water": BrevagePrice = 2.95; break;
                case "Juice": BrevagePrice = 2.50; break;
                case "Milk": BrevagePrice = 1.50; break;
            }

            Calculate(BrevagePrice);
        }

        private void appetizerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BillSubtotal -= AppetizerPrice;

            switch (appetizerComboBox.SelectedItem)
            {
                case "Buffalo Wings": AppetizerPrice = 5.95; break;
                case "Buffalo Fingers": AppetizerPrice = 6.95; break;
                case "Potato Skins": AppetizerPrice = 8.95; break;
                case "Nachos": AppetizerPrice = 8.95; break;
                case "Mushroom Caps": AppetizerPrice = 10.95; break;
                case "Shrimp Cocktail": AppetizerPrice = 12.95; break;
                case "Chips and Salsa": AppetizerPrice = 6.95; break;
            }

            Calculate(AppetizerPrice);
        }

        private void mainCourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BillSubtotal -= MainCoursePrice;

            switch (mainCourseComboBox.SelectedItem)
            {
                case "Seafood Alfredo": MainCoursePrice = 15.95; break;
                case "Chicken Alfredo": MainCoursePrice = 13.95; break;
                case "Chicken Picatta": MainCoursePrice = 13.95; break;
                case "Turkey Club": MainCoursePrice = 11.95; break;
                case "Lobster Pie": MainCoursePrice = 19.95; break;
                case "Prime Rib": MainCoursePrice = 20.95; break;
                case "Shrimp Scampi": MainCoursePrice = 18.95; break;
                case "Turkey Dinner": MainCoursePrice = 13.95; break;
                case "Stuffed Chicken": MainCoursePrice = 14.95; break;
            }

            Calculate(MainCoursePrice);
        }

        private void dessertComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BillSubtotal -= DessertPrice;

            switch (dessertComboBox.SelectedItem)
            {
                case "Apple Pie": DessertPrice = 5.95; break;
                case "Sundae": DessertPrice = 3.95; break;
                case "Carrot Pie": DessertPrice = 5.95; break;
                case "Mud Pie": DessertPrice = 4.95; break;
                case "Apple Crisp": DessertPrice = 5.95; break;
            }

            Calculate(DessertPrice);
        }

    }
}
