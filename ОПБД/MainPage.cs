using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОПБД
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Catalog_Click(object sender, EventArgs e)
        {
            catalog CatalogForm = new catalog();
            this.Hide();
            CatalogForm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            account accountform = new account();
            this.Hide();
            accountform.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dillers dilFrom = new Dillers();
            this.Hide();
            dilFrom.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            news newsform = new news();
            this.Hide();
            newsform.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TRANSFER trform = new TRANSFER();
            this.Hide();
            trform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.ru/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Event eventform = new Event();
            this.Hide();
            eventform.Show();
        }
    }
}
