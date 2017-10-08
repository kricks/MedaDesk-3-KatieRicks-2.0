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

namespace MegaDesk_3_KatieRicks_2._0
{
    public partial class AddQuote : Form
    {
        private Form _mainMenu;

        public AddQuote(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            Desk desk = new Desk();

            switch (comMaterial.Text)
            {
                case "Oak":
                    desk.material = Desk.deskMaterial.Oak;
                    break;
                case "Laminate":
                    desk.material = Desk.deskMaterial.Laminate;
                    break;
                case "Pine":
                    desk.material = Desk.deskMaterial.Pine;
                    break;
                case "Rosewood":
                    desk.material = Desk.deskMaterial.Rosewood;
                    break;
                case "Veneer":
                    desk.material = Desk.deskMaterial.Veneer;
                    break;
            }

            DeskQuote quote = new DeskQuote();

            quote.customerName = textCustName.Text;
            quote.desk = desk;

            switch (comShipping.Text)
            {
                case "Three Days":
                    quote.DeliveryType = DeskQuote.Delivery.Rush3Days;
                    break;
                case "Five Days":
                    quote.DeliveryType = DeskQuote.Delivery.Rush5Days;
                    break;
                case "Seven Days":
                    quote.DeliveryType = DeskQuote.Delivery.Rush7Days;
                    break;
                case "Normal - Fourteen Days":
                    quote.DeliveryType = DeskQuote.Delivery.Normal14Days;
                    break;
            }


        }

        private void butBack_Click(object sender, EventArgs e)
        {
            _mainMenu.Show();
            this.Close();
        }

        private void butDisplayQuote_Click(object sender, EventArgs e)
        {
            string[] lines = { "First line", "Second line", "Third line" };
            File.WriteAllLines(@"C:\Users\asus\source\repos\MegaDesk-3-KatieRicks-2.0\MegaDesk-3-KatieRicks-2.0\bin\Debug\quotes.txt", lines);
        }
    }
}
