using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCountries.SelectedIndex = 0;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            priceValue.Text = "";
            int days = Convert.ToInt32(daysNumber.Value);
            if (days <= 0)
            {
                MessageBox.Show("Помилка введеня кількості днів!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int people = Convert.ToInt32(peopleNumber.Value);
            if (people <= 0)
            {
                MessageBox.Show("Помилка введеня кількості осіб!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Countries country;
            if (comboBoxCountries.SelectedIndex == 1)
            {
                country = Countries.Germany;
            }
            else if (comboBoxCountries.SelectedIndex == 2)
            {
                country = Countries.Poland;
            }
            else
            {
                country = Countries.Bulgaria;
            }
            Seasons season;
            if (buttonWinter.Checked)
            {
                season = Seasons.Winter;
            }
            else
            {
                season = Seasons.Summer;
            }
            bool guide;
            if (checkBoxGuide.Checked == true)
            {
                guide = true;
            }
            else
            {
                guide = false;
            }
            Tour tour = new Tour(country, days, people, season, guide);
            double price = tour.GetPrice();
            string p;
            if (price != 0 && days != 0 && people != 0)
            {
                p = price.ToString() + " $";
                priceValue.Text = p;
            }
        }
    }
}
