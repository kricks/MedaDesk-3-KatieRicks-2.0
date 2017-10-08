using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_KatieRicks_2._0
{
    public partial class MainMenu : Form


    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void butAddQuote_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = new AddQuote(this);
            addQuoteForm.Show();
            this.Hide();
        }

        private void butViewQuote_Click(object sender, EventArgs e)
        {
            ViewAllQuotes addViewAllQuoteForm = new ViewAllQuotes();
            addViewAllQuoteForm.Show();
            this.Hide();
        }

        private void butSearchQuote_Click(object sender, EventArgs e)
        {
            SearchQuote addSearchQuoteForm = new SearchQuote();
            addSearchQuoteForm.Show();
            this.Hide();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
