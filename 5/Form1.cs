using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        string dogumYeri = "";

        private void comboBoxSehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            dogumYeri = comboBoxSehirler.SelectedItem.ToString();

        }

        private void buttonGoster_Click(object sender, EventArgs e)
        {
            string cinsiyet = "";
            if (radioButtonErkek.Checked)
                cinsiyet = "Erkek";
            else if (radioButtonKadin.Checked)
                cinsiyet = "Kadın";
            else
                cinsiyet = "Belirtilmedi";

            string dogumTarihi = dateTimePickerDogumTarihi.Text;
            string bilgiler = "Adı:\t" + textBoxAd.Text
                + "\nSoyadı:\t" + textBoxSoyad.Text
                + "\nCinsiyet:\t" + cinsiyet
                + "\nD.Yeri:\t" + dogumYeri
                + "\nD.Tarihi:\t" + dogumTarihi;

            textBoxAd.Text = "";
            textBoxSoyad.Text = "";
            textBoxAd.Select();
            radioButtonErkek.Checked = false;
            radioButtonKadin.Checked = false;
            comboBoxSehirler.SelectedIndex = 0;
            dateTimePickerDogumTarihi.Value = new DateTime(2000, 01, 01);


            MessageBox.Show(bilgiler);
        }

    }
}
