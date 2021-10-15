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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(object _mainMenu1, object _mainMenu)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainMenuForm = new MainMenu();
            mainMenuForm.Tag = this;
            mainMenuForm.Show();

            this.Hide();
        }
    }
}
