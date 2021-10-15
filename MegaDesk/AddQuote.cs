using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{ 
    public partial class AddQuote : Form
    {
        private object _mainMenu;
        public AddQuote()
        {
            InitializeComponent();

            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            comSurfaceMaterial.DataSource = materials;
            comSurfaceMaterial.SelectedIndex = -1;

            List<ShippingType> shipping = Enum.GetValues(typeof(ShippingType)).Cast<ShippingType>().ToList();
            comShippingType.DataSource = shipping;
            comShippingType.SelectedIndex = -1;

            numDeskDepth.Text = String.Empty;
            numDeskWidth.Text = String.Empty;
            numNumberOfDrawers.Text = String.Empty;
        }
        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((Form)this.Tag).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Form)this.Tag).Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool ValidInt(decimal depth)
        {
            decimal Depth_Max = 94;
            decimal Depth_Min = 24;

            if (depth > Depth_Min && depth < Depth_Max)
            {
                numDeskWidth.ForeColor = System.Drawing.Color.Blue;
                const string message = "";
                errorMessageWidth.Text = message;
                return true;
            }
            else
            {
                numDeskWidth.ForeColor = System.Drawing.Color.Red;
                const string message = "Invalid Width, redo it.";
                errorMessageWidth.Text = message;
                errorMessageWidth.ForeColor = System.Drawing.Color.Red;
                return false;
            }
        }

        private void addQuote_Save_Click(object sender, EventArgs e)
        {
            
            var desk = new Desk
            {
                Depth = numDeskDepth.Value,
                Width = numDeskWidth.Value,
                NumberOfDrawers = (int)numNumberOfDrawers.Value,
                desktopMaterial = (DesktopMaterial)comSurfaceMaterial.SelectedValue,
            };

            var deskQuote = new DeskQuote
            {
                Desk = desk,
                CustomerName = CustomerName.Text,
                QuoteDate = DateTime.Now,
                shipping = (ShippingType)comShippingType.SelectedValue,
            };

            try
            {
                var price = deskQuote.GetQuotePrice();

                deskQuote.QuoteAmount = price;

                AddQuoteToFile(deskQuote);

                DisplayQuote frmDisplayQuote = new DisplayQuote(_mainMenu, deskQuote);
                frmDisplayQuote.Show();
                Hide();
            }
            catch (Exception err)
            {
                MessageBox.Show("There was an error creating the quote. {0}", err.InnerException.ToString());
            };
        }

        private void AddQuoteToFile(DeskQuote deskQuote)
        {
            var quotesFile = @"quotes.json";
            List<DeskQuote> deskQuotes = System.Text.Json.JsonSerializer.Deserialize<List<DeskQuote>>(quotesFile);

        }

        private void numDeskDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || Char.IsControl(e.KeyChar)))
            {
        MessageBox.Show("please enter digits only");
                e.Handled = true;
            }
        }
    }
}
