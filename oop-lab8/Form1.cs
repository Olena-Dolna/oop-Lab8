using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxMaterial.SelectedIndex = 0;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            priceValue.Text = "";
            string w = windowWidth.Text, h = windowHeight.Text;
            if(!double.TryParse(w, out double width) || width <= 0)
            {
                MessageBox.Show("Помилка введеня ширини склопакету!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                windowWidth.Clear();
            }
            if (!double.TryParse(h, out double height) || height <= 0)
            {
                MessageBox.Show("Помилка введеня висоти склопакету!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                windowHeight.Clear();
            }
            bool windowsill;
            if (windowsillBox.Checked == true)
            {
                windowsill = true;
            }
            else
            {
                windowsill = false;
            }
            TypesOfMateial material;
            if(comboBoxMaterial.SelectedIndex == 1)
            {
                material = TypesOfMateial.Metal;
            }
            else if (comboBoxMaterial.SelectedIndex == 2)
            {
                material = TypesOfMateial.MetalPlastic;
            }
            else
            {
                material = TypesOfMateial.Wood;
            }
            GlazingType chamber;
            if (doubleChamButton.Checked)
            { 
                chamber = GlazingType.DoubleChamber; 
            }
            else
            {
                chamber = GlazingType.SingleChamber;
            }
            Glazing glazing = new Glazing(width, height, material, chamber, windowsill);
            double price = glazing.CalcPrice();
            string p;
            if (price != 0 && price != 35)
            {
                p = price.ToString("F2") + " грн";
                priceValue.Text = p;
            }
        }
    }
}
