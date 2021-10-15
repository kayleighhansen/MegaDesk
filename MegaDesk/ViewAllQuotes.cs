using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {

        private Form _mainMenu;

        public ViewAllQuotes(Form mainMenu)
        {
            InitializeComponent();

            _mainMenu = mainMenu;

            loadGrid();
        }

        public ViewAllQuotes()
        {
        }

        private void loadGrid()
        {
            var quotesFile = @"quotes.json";

            if (File.Exists(quotesFile))
            {
                using (StreamReader reader = new StreamReader(quotesFile))
                {
                    string quotes = reader.ReadToEnd();

                    List<DeskQuote> deskQuotes = System.Text.Json.JsonSerializer.Deserialize<List<DeskQuote>>(quotes);
;
                    dataGridView1.DataSource = deskQuotes.Select(d => new
                    {
                        Date = d.QuoteDate,
                        Customer = d.CustomerName,
                        Depth = d.Desk.Depth,
                        Width = d.Desk.Width,
                        Drawers = d.Desk.NumberOfDrawers,
                        SurfaceMaterial = d.Desk.desktopMaterial,
                        DeliveryType = d.shipping,
                        QuoteAmount = d.QuoteAmount.ToString("c")

                    }).ToList();
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ((Form)this.Tag).Show();
            this.Hide();
        }
    }
}
