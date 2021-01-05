namespace Problem01
{
    partial class RestaurantBillCalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.restaurantNameLabel = new System.Windows.Forms.Label();
            this.waiterInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.waiterNameTextBox = new System.Windows.Forms.TextBox();
            this.tableNumberTextBox = new System.Windows.Forms.TextBox();
            this.waiterNameLabel = new System.Windows.Forms.Label();
            this.tableNumberLabel = new System.Windows.Forms.Label();
            this.menuItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.dessertComboBox = new System.Windows.Forms.ComboBox();
            this.mainCourseComboBox = new System.Windows.Forms.ComboBox();
            this.appetizerComboBox = new System.Windows.Forms.ComboBox();
            this.dessertLabel = new System.Windows.Forms.Label();
            this.mainCourseLabel = new System.Windows.Forms.Label();
            this.appetizerLabel = new System.Windows.Forms.Label();
            this.brevageLabel = new System.Windows.Forms.Label();
            this.brevageComboBox = new System.Windows.Forms.ComboBox();
            this.clearBillButton = new System.Windows.Forms.Button();
            this.subtotalTitleLabel = new System.Windows.Forms.Label();
            this.taxTitleLabel = new System.Windows.Forms.Label();
            this.totalTitleLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.waiterInformationGroupBox.SuspendLayout();
            this.menuItemsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // restaurantNameLabel
            // 
            this.restaurantNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurantNameLabel.Location = new System.Drawing.Point(83, 32);
            this.restaurantNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.restaurantNameLabel.Name = "restaurantNameLabel";
            this.restaurantNameLabel.Size = new System.Drawing.Size(244, 32);
            this.restaurantNameLabel.TabIndex = 0;
            this.restaurantNameLabel.Text = "Montreal Restaurant";
            this.restaurantNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // waiterInformationGroupBox
            // 
            this.waiterInformationGroupBox.Controls.Add(this.waiterNameTextBox);
            this.waiterInformationGroupBox.Controls.Add(this.tableNumberTextBox);
            this.waiterInformationGroupBox.Controls.Add(this.waiterNameLabel);
            this.waiterInformationGroupBox.Controls.Add(this.tableNumberLabel);
            this.waiterInformationGroupBox.Location = new System.Drawing.Point(87, 76);
            this.waiterInformationGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.waiterInformationGroupBox.Name = "waiterInformationGroupBox";
            this.waiterInformationGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.waiterInformationGroupBox.Size = new System.Drawing.Size(225, 82);
            this.waiterInformationGroupBox.TabIndex = 1;
            this.waiterInformationGroupBox.TabStop = false;
            this.waiterInformationGroupBox.Text = "Waiter Information";
            // 
            // waiterNameTextBox
            // 
            this.waiterNameTextBox.Location = new System.Drawing.Point(109, 51);
            this.waiterNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.waiterNameTextBox.Name = "waiterNameTextBox";
            this.waiterNameTextBox.Size = new System.Drawing.Size(91, 20);
            this.waiterNameTextBox.TabIndex = 3;
            this.waiterNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableNumberTextBox
            // 
            this.tableNumberTextBox.Location = new System.Drawing.Point(138, 25);
            this.tableNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.tableNumberTextBox.Name = "tableNumberTextBox";
            this.tableNumberTextBox.Size = new System.Drawing.Size(62, 20);
            this.tableNumberTextBox.TabIndex = 2;
            this.tableNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // waiterNameLabel
            // 
            this.waiterNameLabel.AutoSize = true;
            this.waiterNameLabel.Location = new System.Drawing.Point(11, 51);
            this.waiterNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.waiterNameLabel.Name = "waiterNameLabel";
            this.waiterNameLabel.Size = new System.Drawing.Size(79, 13);
            this.waiterNameLabel.TabIndex = 1;
            this.waiterNameLabel.Text = "Waiter\'s Name:";
            // 
            // tableNumberLabel
            // 
            this.tableNumberLabel.AutoSize = true;
            this.tableNumberLabel.Location = new System.Drawing.Point(11, 25);
            this.tableNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tableNumberLabel.Name = "tableNumberLabel";
            this.tableNumberLabel.Size = new System.Drawing.Size(77, 13);
            this.tableNumberLabel.TabIndex = 0;
            this.tableNumberLabel.Text = "Table Number:";
            // 
            // menuItemsGroupBox
            // 
            this.menuItemsGroupBox.Controls.Add(this.dessertComboBox);
            this.menuItemsGroupBox.Controls.Add(this.mainCourseComboBox);
            this.menuItemsGroupBox.Controls.Add(this.appetizerComboBox);
            this.menuItemsGroupBox.Controls.Add(this.dessertLabel);
            this.menuItemsGroupBox.Controls.Add(this.mainCourseLabel);
            this.menuItemsGroupBox.Controls.Add(this.appetizerLabel);
            this.menuItemsGroupBox.Controls.Add(this.brevageLabel);
            this.menuItemsGroupBox.Controls.Add(this.brevageComboBox);
            this.menuItemsGroupBox.Location = new System.Drawing.Point(87, 178);
            this.menuItemsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.menuItemsGroupBox.Name = "menuItemsGroupBox";
            this.menuItemsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.menuItemsGroupBox.Size = new System.Drawing.Size(225, 153);
            this.menuItemsGroupBox.TabIndex = 2;
            this.menuItemsGroupBox.TabStop = false;
            this.menuItemsGroupBox.Text = "Menu Items";
            // 
            // dessertComboBox
            // 
            this.dessertComboBox.FormattingEnabled = true;
            this.dessertComboBox.Items.AddRange(new object[] {
            "Apple Pie",
            "Sundae",
            "Carrot Cake",
            "Mud Pie",
            "Apple Crisp"});
            this.dessertComboBox.Location = new System.Drawing.Point(95, 120);
            this.dessertComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.dessertComboBox.Name = "dessertComboBox";
            this.dessertComboBox.Size = new System.Drawing.Size(111, 21);
            this.dessertComboBox.TabIndex = 7;
            this.dessertComboBox.SelectedIndexChanged += new System.EventHandler(this.dessertComboBox_SelectedIndexChanged);
            // 
            // mainCourseComboBox
            // 
            this.mainCourseComboBox.FormattingEnabled = true;
            this.mainCourseComboBox.Items.AddRange(new object[] {
            "Seafood Alfredo",
            "Chicken Alfredo",
            "Chicken Piccata",
            "Turkey Club",
            "Lobster Pie",
            "Prime Rib",
            "Shrimp Scampi",
            "Turkey Dinner",
            "Stuffed Chicken"});
            this.mainCourseComboBox.Location = new System.Drawing.Point(95, 91);
            this.mainCourseComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.mainCourseComboBox.Name = "mainCourseComboBox";
            this.mainCourseComboBox.Size = new System.Drawing.Size(111, 21);
            this.mainCourseComboBox.TabIndex = 6;
            this.mainCourseComboBox.SelectedIndexChanged += new System.EventHandler(this.mainCourseComboBox_SelectedIndexChanged);
            // 
            // appetizerComboBox
            // 
            this.appetizerComboBox.FormattingEnabled = true;
            this.appetizerComboBox.Items.AddRange(new object[] {
            "Buffalo Wings",
            "Chicken Fingers",
            "Potato Skins",
            "Nachos",
            "Mushroom Caps",
            "Shrimp Cocktail",
            "Chips and Salsa"});
            this.appetizerComboBox.Location = new System.Drawing.Point(95, 60);
            this.appetizerComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.appetizerComboBox.Name = "appetizerComboBox";
            this.appetizerComboBox.Size = new System.Drawing.Size(111, 21);
            this.appetizerComboBox.TabIndex = 5;
            this.appetizerComboBox.SelectedIndexChanged += new System.EventHandler(this.appetizerComboBox_SelectedIndexChanged);
            // 
            // dessertLabel
            // 
            this.dessertLabel.AutoSize = true;
            this.dessertLabel.Location = new System.Drawing.Point(17, 122);
            this.dessertLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dessertLabel.Name = "dessertLabel";
            this.dessertLabel.Size = new System.Drawing.Size(46, 13);
            this.dessertLabel.TabIndex = 4;
            this.dessertLabel.Text = "Dessert:";
            // 
            // mainCourseLabel
            // 
            this.mainCourseLabel.AutoSize = true;
            this.mainCourseLabel.Location = new System.Drawing.Point(17, 93);
            this.mainCourseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainCourseLabel.Name = "mainCourseLabel";
            this.mainCourseLabel.Size = new System.Drawing.Size(69, 13);
            this.mainCourseLabel.TabIndex = 3;
            this.mainCourseLabel.Text = "Main Course:";
            // 
            // appetizerLabel
            // 
            this.appetizerLabel.AutoSize = true;
            this.appetizerLabel.Location = new System.Drawing.Point(17, 62);
            this.appetizerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appetizerLabel.Name = "appetizerLabel";
            this.appetizerLabel.Size = new System.Drawing.Size(54, 13);
            this.appetizerLabel.TabIndex = 2;
            this.appetizerLabel.Text = "Appetizer:";
            // 
            // brevageLabel
            // 
            this.brevageLabel.AutoSize = true;
            this.brevageLabel.Location = new System.Drawing.Point(17, 31);
            this.brevageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brevageLabel.Name = "brevageLabel";
            this.brevageLabel.Size = new System.Drawing.Size(50, 13);
            this.brevageLabel.TabIndex = 1;
            this.brevageLabel.Text = "Brevage:";
            // 
            // brevageComboBox
            // 
            this.brevageComboBox.FormattingEnabled = true;
            this.brevageComboBox.Items.AddRange(new object[] {
            "Soda",
            "Tea",
            "Coffee",
            "Mineral Water",
            "Juice",
            "Milk"});
            this.brevageComboBox.Location = new System.Drawing.Point(95, 29);
            this.brevageComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.brevageComboBox.Name = "brevageComboBox";
            this.brevageComboBox.Size = new System.Drawing.Size(111, 21);
            this.brevageComboBox.TabIndex = 0;
            this.brevageComboBox.SelectedIndexChanged += new System.EventHandler(this.brevageComboBox_SelectedIndexChanged);
            // 
            // clearBillButton
            // 
            this.clearBillButton.Location = new System.Drawing.Point(157, 343);
            this.clearBillButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearBillButton.Name = "clearBillButton";
            this.clearBillButton.Size = new System.Drawing.Size(81, 27);
            this.clearBillButton.TabIndex = 3;
            this.clearBillButton.Text = "Clear Bill";
            this.clearBillButton.UseVisualStyleBackColor = true;
            this.clearBillButton.Click += new System.EventHandler(this.clearBillButton_Click);
            // 
            // subtotalTitleLabel
            // 
            this.subtotalTitleLabel.AutoSize = true;
            this.subtotalTitleLabel.Location = new System.Drawing.Point(127, 387);
            this.subtotalTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subtotalTitleLabel.Name = "subtotalTitleLabel";
            this.subtotalTitleLabel.Size = new System.Drawing.Size(49, 13);
            this.subtotalTitleLabel.TabIndex = 4;
            this.subtotalTitleLabel.Text = "Subtotal:";
            // 
            // taxTitleLabel
            // 
            this.taxTitleLabel.AutoSize = true;
            this.taxTitleLabel.Location = new System.Drawing.Point(127, 414);
            this.taxTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taxTitleLabel.Name = "taxTitleLabel";
            this.taxTitleLabel.Size = new System.Drawing.Size(28, 13);
            this.taxTitleLabel.TabIndex = 5;
            this.taxTitleLabel.Text = "Tax:";
            // 
            // totalTitleLabel
            // 
            this.totalTitleLabel.AutoSize = true;
            this.totalTitleLabel.Location = new System.Drawing.Point(127, 441);
            this.totalTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalTitleLabel.Name = "totalTitleLabel";
            this.totalTitleLabel.Size = new System.Drawing.Size(34, 13);
            this.totalTitleLabel.TabIndex = 6;
            this.totalTitleLabel.Text = "Total:";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subtotalLabel.Location = new System.Drawing.Point(197, 386);
            this.subtotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(64, 16);
            this.subtotalLabel.TabIndex = 7;
            this.subtotalLabel.Text = "$0.00";
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxLabel
            // 
            this.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxLabel.Location = new System.Drawing.Point(197, 412);
            this.taxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(64, 17);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "$0.00";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLabel.Location = new System.Drawing.Point(197, 439);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(64, 17);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "$0.00";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RestaurantBillCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 489);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.totalTitleLabel);
            this.Controls.Add(this.taxTitleLabel);
            this.Controls.Add(this.subtotalTitleLabel);
            this.Controls.Add(this.clearBillButton);
            this.Controls.Add(this.menuItemsGroupBox);
            this.Controls.Add(this.waiterInformationGroupBox);
            this.Controls.Add(this.restaurantNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RestaurantBillCalculatorForm";
            this.Text = "Restaurant Bill Calculator (Marissa Gonçalves)";
            this.waiterInformationGroupBox.ResumeLayout(false);
            this.waiterInformationGroupBox.PerformLayout();
            this.menuItemsGroupBox.ResumeLayout(false);
            this.menuItemsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label restaurantNameLabel;
        private System.Windows.Forms.GroupBox waiterInformationGroupBox;
        private System.Windows.Forms.TextBox waiterNameTextBox;
        private System.Windows.Forms.TextBox tableNumberTextBox;
        private System.Windows.Forms.Label waiterNameLabel;
        private System.Windows.Forms.Label tableNumberLabel;
        private System.Windows.Forms.GroupBox menuItemsGroupBox;
        private System.Windows.Forms.ComboBox dessertComboBox;
        private System.Windows.Forms.ComboBox mainCourseComboBox;
        private System.Windows.Forms.ComboBox appetizerComboBox;
        private System.Windows.Forms.Label dessertLabel;
        private System.Windows.Forms.Label mainCourseLabel;
        private System.Windows.Forms.Label appetizerLabel;
        private System.Windows.Forms.Label brevageLabel;
        private System.Windows.Forms.ComboBox brevageComboBox;
        private System.Windows.Forms.Button clearBillButton;
        private System.Windows.Forms.Label subtotalTitleLabel;
        private System.Windows.Forms.Label taxTitleLabel;
        private System.Windows.Forms.Label totalTitleLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
    }
}

