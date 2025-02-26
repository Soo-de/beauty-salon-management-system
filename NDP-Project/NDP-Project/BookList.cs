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
    public partial class BookList : Form
    {
        public BookList()
        {
            InitializeComponent();

            /*Get file path*/
            string filePath = "C:\\Users\\Sude\\Desktop\\g\\kod\\NDP-Project\\Books.txt";

            /*Get datas line by line*/
            string[] lines = File.ReadAllLines(filePath);

            /*Set table controls*/
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowCount = 0;

            // Adding the lines to tableLayoutPanel
            foreach (string line in lines)
            {

                // adding new row for every new line
                tableLayoutPanel1.RowCount++;
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                // Seperating infos for columns
                string[] columns = line.Split(',');

                for (int i = 0; i < columns.Length; i++)
                {
                    // create new label for datas
                    Label lbl = new Label();
                    lbl.Text = columns[i].Trim();//for deleting white spaces
                    lbl.AutoSize = true;

                    // Adding label to appropriate cell
                    tableLayoutPanel1.Controls.Add(lbl, i, tableLayoutPanel1.RowCount - 1);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Hide();

        }

        private void BookList_Load(object sender, EventArgs e)
        {

        }
    }
}
