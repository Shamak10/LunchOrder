namespace LunchOrderApp
{
    partial class Form1
    {
        private System.Windows.Forms.GroupBox grpMainCourse;
        private System.Windows.Forms.RadioButton rdoHamburger;
        private System.Windows.Forms.RadioButton rdoPizza;
        private System.Windows.Forms.RadioButton rdoSalad;

        private System.Windows.Forms.GroupBox grpAddOns;
        private System.Windows.Forms.CheckBox chkLettuceTomatoOnions;
        private System.Windows.Forms.CheckBox chkKetchupMustardMayo;
        private System.Windows.Forms.CheckBox chkFrenchFries;

        private System.Windows.Forms.GroupBox grpOrderTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtOrderTotal;

        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;

        private void InitializeComponent()
        {
            grpMainCourse = new System.Windows.Forms.GroupBox();
            rdoHamburger = new System.Windows.Forms.RadioButton();
            rdoPizza = new System.Windows.Forms.RadioButton();
            rdoSalad = new System.Windows.Forms.RadioButton();
            grpAddOns = new System.Windows.Forms.GroupBox();
            chkLettuceTomatoOnions = new System.Windows.Forms.CheckBox();
            chkKetchupMustardMayo = new System.Windows.Forms.CheckBox();
            chkFrenchFries = new System.Windows.Forms.CheckBox();
            grpOrderTotal = new System.Windows.Forms.GroupBox();
            lblSubtotal = new System.Windows.Forms.Label();
            lblTax = new System.Windows.Forms.Label();
            lblOrderTotal = new System.Windows.Forms.Label();
            txtSubtotal = new System.Windows.Forms.TextBox();
            txtTax = new System.Windows.Forms.TextBox();
            txtOrderTotal = new System.Windows.Forms.TextBox();
            btnPlaceOrder = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            grpMainCourse.SuspendLayout();
            grpAddOns.SuspendLayout();
            grpOrderTotal.SuspendLayout();
            SuspendLayout();
            // 
            // grpMainCourse
            // 
            grpMainCourse.Controls.Add(rdoHamburger);
            grpMainCourse.Controls.Add(rdoPizza);
            grpMainCourse.Controls.Add(rdoSalad);
            grpMainCourse.Location = new System.Drawing.Point(12, 12);
            grpMainCourse.Name = "grpMainCourse";
            grpMainCourse.Size = new System.Drawing.Size(200, 100);
            grpMainCourse.TabIndex = 0;
            grpMainCourse.TabStop = false;
            grpMainCourse.Text = "Main Course";
            // 
            // rdoHamburger
            // 
            rdoHamburger.AutoSize = true;
            rdoHamburger.Checked = true;
            rdoHamburger.Location = new System.Drawing.Point(6, 19);
            rdoHamburger.Name = "rdoHamburger";
            rdoHamburger.Size = new System.Drawing.Size(124, 19);
            rdoHamburger.TabIndex = 0;
            rdoHamburger.TabStop = true;
            rdoHamburger.Text = "Hamburger - $6.95";
            rdoHamburger.CheckedChanged += MainCourse_CheckedChanged;
            // 
            // rdoPizza
            // 
            rdoPizza.AutoSize = true;
            rdoPizza.Location = new System.Drawing.Point(6, 42);
            rdoPizza.Name = "rdoPizza";
            rdoPizza.Size = new System.Drawing.Size(89, 19);
            rdoPizza.TabIndex = 1;
            rdoPizza.Text = "Pizza - $5.95";
            rdoPizza.CheckedChanged += MainCourse_CheckedChanged;
            // 
            // rdoSalad
            // 
            rdoSalad.AutoSize = true;
            rdoSalad.Location = new System.Drawing.Point(6, 65);
            rdoSalad.Name = "rdoSalad";
            rdoSalad.Size = new System.Drawing.Size(91, 19);
            rdoSalad.TabIndex = 2;
            rdoSalad.Text = "Salad - $4.95";
            rdoSalad.CheckedChanged += MainCourse_CheckedChanged;
            // 
            // grpAddOns
            // 
            grpAddOns.Controls.Add(chkLettuceTomatoOnions);
            grpAddOns.Controls.Add(chkKetchupMustardMayo);
            grpAddOns.Controls.Add(chkFrenchFries);
            grpAddOns.Location = new System.Drawing.Point(218, 12);
            grpAddOns.Name = "grpAddOns";
            grpAddOns.Size = new System.Drawing.Size(200, 100);
            grpAddOns.TabIndex = 1;
            grpAddOns.TabStop = false;
            grpAddOns.Text = "Add-ons ($0.75/each)";
            // 
            // chkLettuceTomatoOnions
            // 
            chkLettuceTomatoOnions.AutoSize = true;
            chkLettuceTomatoOnions.Location = new System.Drawing.Point(6, 19);
            chkLettuceTomatoOnions.Name = "chkLettuceTomatoOnions";
            chkLettuceTomatoOnions.Size = new System.Drawing.Size(175, 19);
            chkLettuceTomatoOnions.TabIndex = 0;
            chkLettuceTomatoOnions.Text = "Lettuce, tomato, and onions";
            chkLettuceTomatoOnions.CheckedChanged += AddOn_CheckedChanged;
            // 
            // chkKetchupMustardMayo
            // 
            chkKetchupMustardMayo.AutoSize = true;
            chkKetchupMustardMayo.Location = new System.Drawing.Point(6, 42);
            chkKetchupMustardMayo.Name = "chkKetchupMustardMayo";
            chkKetchupMustardMayo.Size = new System.Drawing.Size(179, 19);
            chkKetchupMustardMayo.TabIndex = 1;
            chkKetchupMustardMayo.Text = "Ketchup, mustard, and mayo";
            chkKetchupMustardMayo.CheckedChanged += AddOn_CheckedChanged;
            // 
            // chkFrenchFries
            // 
            chkFrenchFries.AutoSize = true;
            chkFrenchFries.Location = new System.Drawing.Point(6, 65);
            chkFrenchFries.Name = "chkFrenchFries";
            chkFrenchFries.Size = new System.Drawing.Size(87, 19);
            chkFrenchFries.TabIndex = 2;
            chkFrenchFries.Text = "French fries";
            chkFrenchFries.CheckedChanged += AddOn_CheckedChanged;
            // grpOrderTotal
            grpOrderTotal.Controls.Add(lblSubtotal);
            grpOrderTotal.Controls.Add(lblTax);
            grpOrderTotal.Controls.Add(lblOrderTotal);
            grpOrderTotal.Controls.Add(txtSubtotal);
            grpOrderTotal.Controls.Add(txtTax);
            grpOrderTotal.Controls.Add(txtOrderTotal);
            grpOrderTotal.Location = new System.Drawing.Point(12, 118);
            grpOrderTotal.Name = "grpOrderTotal";
            grpOrderTotal.Size = new System.Drawing.Size(200, 100);
            grpOrderTotal.TabIndex = 2;
            grpOrderTotal.TabStop = false;
            grpOrderTotal.Text = "Order Total"; 
            // lblSubtotal
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new System.Drawing.Point(6, 16);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new System.Drawing.Size(54, 15);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "Subtotal:";
            // lblTax 
            lblTax.AutoSize = true;
            lblTax.Location = new System.Drawing.Point(6, 42);
            lblTax.Name = "lblTax";
            lblTax.Size = new System.Drawing.Size(69, 15);
            lblTax.TabIndex = 2;
            lblTax.Text = "Tax (7.75%):";
            // lblOrderTotal
            lblOrderTotal.AutoSize = true;
            lblOrderTotal.Location = new System.Drawing.Point(6, 68);
            lblOrderTotal.Name = "lblOrderTotal";
            lblOrderTotal.Size = new System.Drawing.Size(68, 15);
            lblOrderTotal.TabIndex = 4;
            lblOrderTotal.Text = "Order Total:";
            // txtSubtotal
            txtSubtotal.Location = new System.Drawing.Point(80, 13);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new System.Drawing.Size(100, 23);
            txtSubtotal.TabIndex = 1;
            // txtTax 
            txtTax.Location = new System.Drawing.Point(80, 39);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new System.Drawing.Size(100, 23);
            txtTax.TabIndex = 3; 
            // txtOrderTotal
            txtOrderTotal.Location = new System.Drawing.Point(80, 65);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new System.Drawing.Size(100, 23);
            txtOrderTotal.TabIndex = 5;
            // btnPlaceOrder 
            btnPlaceOrder.Location = new System.Drawing.Point(270, 131);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new System.Drawing.Size(89, 23);
            btnPlaceOrder.TabIndex = 3;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;          
            // btnExit           
            btnExit.Location = new System.Drawing.Point(270, 183);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(89, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // Form1 
            ClientSize = new System.Drawing.Size(439, 272);
            Controls.Add(grpMainCourse);
            Controls.Add(grpAddOns);
            Controls.Add(grpOrderTotal);
            Controls.Add(btnPlaceOrder);
            Controls.Add(btnExit);
            Name = "Form1";
            Text = "Shamak Patel's Kitchen Dhaba";
            grpMainCourse.ResumeLayout(false);
            grpMainCourse.PerformLayout();
            grpAddOns.ResumeLayout(false);
            grpAddOns.PerformLayout();
            grpOrderTotal.ResumeLayout(false);
            grpOrderTotal.PerformLayout();
            ResumeLayout(false);
        }
    }
}
