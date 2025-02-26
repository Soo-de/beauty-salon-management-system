//***********************************************************************************************************************
//**                                                                                                                   **
//**                                     SAKARYA ÜNİVERSİTESİ                                                          **
//**                          BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                                                **
//**                                BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ                                                     **
//**                                                                                                                   **
//**                                  PROJE NUMARASI..: 1                                                              **
//**                                  ÖĞRENCİ ADI.....: SUDE ANDURMAN                                                  **
//**                                  ÖĞRENCİ NUMARASI: b231210005                                                     **
//**                                  DERS GRUBU......: B                                                              **
//**                                                                                                                   ** 
//**                                                                                                                   **  
//**                        Amaç:Güzellik merkezi - kuaför salonlarının günlük                                         **
//**            operasyonlarını düzenlemek ve müşterilere randevu vererek planlama yapılmasını                         ** 
//**                                        sağlamaktır.                                                               **
//**                                                                                                                   **
//**                                                                                                                   **
//**                                                                                                                   **  
//**                                                                                                                   **
//***********************************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_Project
{
    public partial class BookDelete : Form
    {
        public BookDelete()
        {
            InitializeComponent();
        }

        private void BookDelete_Load(object sender, EventArgs e)
        {
            /*Get file path*/
            string filePath = "C:\\Users\\Sude\\Desktop\\g\\kod\\NDP-Project\\Books.txt";

            /*Get datas line by line*/
            string[] lines = File.ReadAllLines(filePath);

            /*Write datas to listbox*/
            foreach (string line in lines)
            {
                listBox_Appointments.Items.Add(line);

            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Hide();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Appointments.SelectedIndex != -1)/*control for if there any selected item*/
            {
                /*Removing the selected item*/
                listBox_Appointments.Items.RemoveAt(listBox_Appointments.SelectedIndex);

                /*Get file path*/
                string dosyaYolu = "C:\\Users\\Sude\\Desktop\\g\\kod\\NDP-Project\\Books.txt";

                /*Refreshing the file*/
                using (StreamWriter sw = new StreamWriter(dosyaYolu))
                {
                    foreach (var item in listBox_Appointments.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }

            }
            else/*Warning*/
            {
                MessageBox.Show("Lütfen silmek istediğiniz öğeyi seçin.");
            }
        }
    }
}
