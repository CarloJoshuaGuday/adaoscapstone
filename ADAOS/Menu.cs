namespace ADAOS
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
            btnReset.Click += new EventHandler(btnReset_Click);

            //all input in textboxes will be centered.
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).TextAlign = HorizontalAlignment.Center;
                    c.Enabled = false;
                    c.KeyPress += textBox_KeyPress;
                }
            }
        }

        // Exit or X Button
        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the application?", "ADA OS", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Invalid input. Please enter an integer.");
            }
        }

        //Regular Burger Checkbox
        private void chkRegularBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRegularBurger.Checked == true)
            {
                txtRegularBurger.Enabled = true;
                txtRegularBurger.Text = "1";
                txtRegularBurger.Focus();
            }
            else
            {
                txtRegularBurger.Enabled = false;
                txtRegularBurger.Text = "";
            }
        }

        //Cheeseburger Checkbox
        private void chkCheeseburger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheeseburger.Checked == true)
            {
                txtCheeseburger.Enabled = true;
                txtCheeseburger.Text = "1";
                txtCheeseburger.Focus();
            }
            else
            {
                txtCheeseburger.Enabled = false;
                txtCheeseburger.Text = "";
            }
        }
        //SupremeBurger Checkbox
        private void chkSupremeBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSupremeBurger.Checked == true)
            {
                txtSupremeBurger.Enabled = true;
                txtSupremeBurger.Text = "1";
                txtSupremeBurger.Focus();
            }
            else
            {
                txtSupremeBurger.Enabled = false;
                txtSupremeBurger.Text = "";
            }
        }

        //Hawaiian Burger Checkbox
        private void chkHawaiianBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHawaiianBurger.Checked == true)
            {
                txtHawaiianBurger.Enabled = true;
                txtHawaiianBurger.Text = "1";
                txtHawaiianBurger.Focus();
            }
            else
            {
                txtHawaiianBurger.Enabled = false;
                txtHawaiianBurger.Text = "";
            }
        }

        //Chicken Meal Checkbox
        private void chkChickenMeal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChickenMeal.Checked == true)
            {
                txtChickenMeal.Enabled = true;
                txtChickenMeal.Text = "1";
                txtChickenMeal.Focus();
            }
            else
            {
                txtChickenMeal.Enabled = false;
                txtChickenMeal.Text = "";
            }
        }

        //Spicy Chicken Meal Checkbox
        private void chkSpicyChickenMeal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpicyChickenMeal.Checked == true)
            {
                txtSpicyChickenMeal.Enabled = true;
                txtSpicyChickenMeal.Text = "1";
                txtSpicyChickenMeal.Focus();
            }
            else
            {
                txtSpicyChickenMeal.Enabled = false;
                txtSpicyChickenMeal.Text = "";
            }
        }

        //Burger Steak Meal Checkbox
        private void chkBurgerSteakMeal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBurgerSteakMeal.Checked == true)
            {
                txtBurgerSteakMeal.Enabled = true;
                txtBurgerSteakMeal.Text = "1";
                txtBurgerSteakMeal.Focus();
            }
            else
            {
                txtBurgerSteakMeal.Enabled = false;
                txtBurgerSteakMeal.Text = "";
            }
        }

        //Shanghai Meal Checkbox
        private void chkShanghaiMeal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShanghaiMeal.Checked == true)
            {
                txtShanghaiMeal.Enabled = true;
                txtShanghaiMeal.Text = "1";
                txtShanghaiMeal.Focus();
            }
            else
            {
                txtShanghaiMeal.Enabled = false;
                txtShanghaiMeal.Text = "";
            }
        }
        //Adobo Meal Checkbox and Textbox
        private void chkAdoboMeal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdoboMeal.Checked == true)
            {
                txtAdoboMeal.Enabled = true;
                txtAdoboMeal.Text = "1";
                txtAdoboMeal.Focus();
            }
            else
            {
                txtAdoboMeal.Enabled = false;
                txtAdoboMeal.Text = "";
            }
        }
        //Filipino Style Spaghetti Checkbox
        private void chkFilipinoSpaghetti_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFilipinoSpaghetti.Checked == true)
            {
                txtFilipinoSpaghetti.Enabled = true;
                txtFilipinoSpaghetti.Text = "1";
                txtFilipinoSpaghetti.Focus();
            }
            else
            {
                txtFilipinoSpaghetti.Enabled = false;
                txtFilipinoSpaghetti.Text = "";
            }
        }
        //Carbonara Checkbox
        private void chkCarbonara_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCarbonara.Checked == true)
            {
                txtCarbonara.Enabled = true;
                txtCarbonara.Text = "1";
                txtCarbonara.Focus();
            }
            else
            {
                txtCarbonara.Enabled = false;
                txtCarbonara.Text = "";
            }
        }
        //Fiesta Palabok Checkbox
        private void chkFiestaPalabok_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFiestaPalabok.Checked == true)
            {
                txtFiestaPalabok.Enabled = true;
                txtFiestaPalabok.Text = "1";
                txtFiestaPalabok.Focus();
            }
            else
            {
                txtFiestaPalabok.Enabled = false;
                txtFiestaPalabok.Text = "";
            }
        }
        //Cripsy Fries Checkbox
        private void chkCrispyFries_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCrispyFries.Checked == true)
            {
                txtCrispyFries.Enabled = true;
                txtCrispyFries.Text = "1";
                txtCrispyFries.Focus();
            }
            else
            {
                txtCrispyFries.Enabled = false;
                txtCrispyFries.Text = "";
            }
        }
        //Sundae Checkbox
        private void chkSundae_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSundae.Checked == true)
            {
                txtSundae.Enabled = true;
                txtSundae.Text = "1";
                txtSundae.Focus();
            }
            else
            {
                txtSundae.Enabled = false;
                txtSundae.Text = "";
            }
        }
        //Mushroom Soup Checkbox
        private void chkMushroomSoup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMushroomSoup.Checked == true)
            {
                txtMushroomSoup.Enabled = true;
                txtMushroomSoup.Text = "1";
                txtMushroomSoup.Focus();
            }
            else
            {
                txtMushroomSoup.Enabled = false;
                txtMushroomSoup.Text = "";
            }
        }
        //Juice Checkbox
        private void chkJuice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJuice.Checked == true)
            {
                txtJuice.Enabled = true;
                txtJuice.Text = "1";
                txtJuice.Focus();
            }
            else
            {
                txtJuice.Enabled = false;
                txtJuice.Text = "";
            }
        }

        //Cola Checkbox
        private void chkCola_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCola.Checked == true)
            {
                txtCola.Enabled = true;
                txtCola.Text = "1";
                txtCola.Focus();
            }
            else
            {
                txtCola.Enabled = false;
                txtCola.Text = "";
            }
        }
        //Iced Tea Checkbox
        private void chkIcedTea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIcedTea.Checked == true)
            {
                txtIcedTea.Enabled = true;
                txtIcedTea.Text = "1";
                txtIcedTea.Focus();
            }
            else
            {
                txtIcedTea.Enabled = false;
                txtIcedTea.Text = "";
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            chkRegularBurger.Checked = false;
            chkCheeseburger.Checked = false;
            chkSupremeBurger.Checked = false;
            chkHawaiianBurger.Checked = false;
            chkChickenMeal.Checked = false;
            chkSpicyChickenMeal.Checked = false;
            chkBurgerSteakMeal.Checked = false;
            chkShanghaiMeal.Checked = false;
            chkAdoboMeal.Checked = false;
            chkFilipinoSpaghetti.Checked = false;
            chkCarbonara.Checked = false;
            chkFiestaPalabok.Checked = false;
            chkCrispyFries.Checked = false;
            chkSundae.Checked = false;
            chkMushroomSoup.Checked = false;
            chkJuice.Checked = false;
            chkCola.Checked = false;
            chkIcedTea.Checked = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClickToStart clickToStart = new ClickToStart();
            clickToStart.Show();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");

            if (chkRegularBurger.Checked == true)
            {
                ListViewItem item = new ListViewItem("Regular Burger");
                item.SubItems.Add(txtRegularBurger.Text);
                int qty = Convert.ToInt32(txtRegularBurger.Text);
                double cost = qty * 40.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);


            }

            else
            {
                txtRegularBurger.Text = "";

            }


            if (chkCheeseburger.Checked == true)
            {
                ListViewItem item = new ListViewItem("CheeseBurger");
                item.SubItems.Add(txtCheeseburger.Text);
                int qty = Convert.ToInt32(txtCheeseburger.Text);
                double cost = qty * 45.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                txtCheeseburger.Text = "";
            }

            if (chkSupremeBurger.Checked == true)
            {
                ListViewItem item = new ListViewItem("Supreme Burger");
                item.SubItems.Add(txtSupremeBurger.Text);
                int qty = Convert.ToInt32(txtSupremeBurger.Text);
                double cost = qty * 70.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                txtSupremeBurger.Text = "";
            }

            if (chkHawaiianBurger.Checked == true)
            {
                ListViewItem item = new ListViewItem("Hawaiian Burger");
                item.SubItems.Add(txtHawaiianBurger.Text);
                int qty = Convert.ToInt32(txtHawaiianBurger.Text);
                double cost = qty * 100.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                txtHawaiianBurger.Text = "";
            }

            if (chkChickenMeal.Checked == true)
            {
                ListViewItem item = new ListViewItem("Chicken Meal");
                item.SubItems.Add(txtChickenMeal.Text);
                int qty = Convert.ToInt32(txtChickenMeal.Text);
                double cost = qty * 150.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                txtChickenMeal.Text = "";
            }

            if (chkSpicyChickenMeal.Checked == true)
            {
                ListViewItem item = new ListViewItem("Spicy Chicken Meal");
                item.SubItems.Add(txtSpicyChickenMeal.Text);
                int qty = Convert.ToInt32(txtSpicyChickenMeal.Text);
                double cost = qty * 155.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                txtSpicyChickenMeal.Text = "";
            }

            if (chkBurgerSteakMeal.Checked == true)
            {
                ListViewItem item = new ListViewItem("Burger Steak Meal");
                item.SubItems.Add(txtBurgerSteakMeal.Text);
                int qty = Convert.ToInt32(txtBurgerSteakMeal.Text);
                double cost = qty * 60.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                txtBurgerSteakMeal.Text = "";
            }

            if (chkShanghaiMeal.Checked == true)
            {
                ListViewItem item = new ListViewItem("Shanghai Meal");
                item.SubItems.Add(txtShanghaiMeal.Text);
                int qty = Convert.ToInt32(txtShanghaiMeal.Text);
                double cost = qty * 70.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                txtShanghaiMeal.Text = "";
            }

            if (chkAdoboMeal.Checked == true)
            {
                ListViewItem item = new ListViewItem("Adobo Meal");
                item.SubItems.Add(txtAdoboMeal.Text);
                int qty = Convert.ToInt32(txtAdoboMeal.Text);
                double cost = qty * 65.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                txtAdoboMeal.Text = "";
            }

            if (chkFilipinoSpaghetti.Checked == true)
            {
                ListViewItem item = new ListViewItem("Filipino Spaghetti");
                item.SubItems.Add(txtFilipinoSpaghetti.Text);
                int qty = Convert.ToInt32(txtFilipinoSpaghetti.Text);
                double cost = qty * 60.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                txtFilipinoSpaghetti.Text = "";
            }

            if (chkCarbonara.Checked == true)
            {
                ListViewItem item = new ListViewItem("Carbonara");
                item.SubItems.Add(txtCarbonara.Text);
                int qty = Convert.ToInt32(txtCarbonara.Text);
                double cost = qty * 75.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                txtCarbonara.Text = "";
            }

            if (chkFiestaPalabok.Checked == true)
            {
                ListViewItem item = new ListViewItem("Fiesta Palabok");
                item.SubItems.Add(txtCarbonara.Text);
                int qty = Convert.ToInt32(txtCarbonara.Text);
                double cost = qty * 60.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                txtFiestaPalabok.Text = "";
            }

            if (chkCrispyFries.Checked == true)
            {
                ListViewItem item = new ListViewItem("Crispy Fries");
                item.SubItems.Add(txtCrispyFries.Text);
                int qty = Convert.ToInt32(txtCrispyFries.Text);
                double cost = qty * 75.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                txtCrispyFries.Text = "";
            }

            if (chkSundae.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sundae");
                item.SubItems.Add(txtSundae.Text);
                int qty = Convert.ToInt32(txtSundae.Text);
                double cost = qty * 50.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                txtSundae.Text = "";
            }

            if (chkMushroomSoup.Checked == true)
            {
                ListViewItem item = new ListViewItem("Mushroom Soup");
                item.SubItems.Add(txtMushroomSoup.Text);
                int qty = Convert.ToInt32(txtMushroomSoup.Text);
                double cost = qty * 70.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                txtMushroomSoup.Text = "";
            }

            if (chkJuice.Checked == true)
            {
                ListViewItem item = new ListViewItem("Juice");
                item.SubItems.Add(txtJuice.Text);
                int qty = Convert.ToInt32(txtJuice.Text);
                double cost = qty * 20.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                txtJuice.Text = "";
            }

            if (chkCola.Checked == true)
            {
                ListViewItem item = new ListViewItem("Cola");
                item.SubItems.Add(txtCola.Text);
                int qty = Convert.ToInt32(txtCola.Text);
                double cost = qty * 35.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                txtCola.Text = "";
            }

            if (chkIcedTea.Checked == true)
            {
                ListViewItem item = new ListViewItem("Iced Tea");
                item.SubItems.Add(txtIcedTea.Text);
                int qty = Convert.ToInt32(txtIcedTea.Text);
                double cost = qty * 25.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                txtIcedTea.Text = "";
            }

            double total = 0;
            double tax = 0;
            double totaldue = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                total += Convert.ToDouble(item.SubItems[2].Text);
            }

            tax = total * 0.12;
            totaldue = tax + total;

            string taxDisplay = tax.ToString("c2");
            string totalDisplay = totaldue.ToString("c2");
            string amount = total.ToString("c2");

            txtTotal.Text = amount;
            txtTax.Text = taxDisplay;
            txtTotalDue.Text = totalDisplay;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnResetOrder_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox checkbox = (CheckBox)c;
                    checkbox.Checked = false;
                }
            }
            listView1.Items.Clear();
            txtTotal.Text = "";
            txtTax.Text = "";
            txtTotalDue.Text = "";
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }
    }
}