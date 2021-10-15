using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace MegaDesk
{
    public partial class SearchQuotes : Form
    {
        private Form _mainMenu;
        public SearchQuotes(Form mainMenu)
        {
            InitializeComponent();

            _mainMenu = mainMenu;

            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial))
                .Cast<DesktopMaterial>()
                .ToList();

            comSurfaceMaterial.DataSource = materials;
            comSurfaceMaterial.SelectedIndex = -1;

            loadGrid();
        }

        public SearchQuotes()
        {
        }

        //private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs, e)
        //{
        //    _mainMenu.Show();
        //}

        private void comSurfaceMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;

            if (combo.SelectedIndex < 0)
            {
                loadGrid();
            }

            else
            {
                loadGrid((DesktopMaterial)combo.SelectedValue);
            }
        }

        private void loadGrid()
        {
            var quotesFile = @"quotes.json";
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

        private void loadGrid(DesktopMaterial desktopMaterial)
        {
            var quotesFile = @"quotes.json";
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

                }).Where(g => g.SurfaceMaterial == desktopMaterial)
                .ToList();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ((Form)this.Tag).Show();
            this.Hide();
        }
    }
}
