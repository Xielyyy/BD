using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОПБД
{
    public partial class TRANSFER : Form
    {
        public TRANSFER()
        {
            InitializeComponent();
        }

        private void TRANSFER_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Добавляем марки автомобилей в ComboBox
            comboBox1.Items.Add("Toyota");
            comboBox1.Items.Add("Ford");
            comboBox1.Items.Add("Volkswagen");
            comboBox1.Items.Add("Honda");
            comboBox1.Items.Add("BMW");
            comboBox1.Items.Add("Mercedes-Benz");
            comboBox1.Items.Add("Audi");
            comboBox1.Items.Add("Nissan");
            comboBox1.Items.Add("Hyundai");
            comboBox1.Items.Add("Chevrolet");
        }

        // Обработчик события изменения выбранного элемента
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Здесь вы можете добавить логику, которая будет выполняться при выборе марки
            string selectedBrand = comboBox1.SelectedItem.ToString();
            MessageBox.Show("Вы выбрали марку: " + selectedBrand);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Оформлено, мы вам перезвоним!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainPage MainForm = new MainPage();
            this.Hide();
            MainForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
