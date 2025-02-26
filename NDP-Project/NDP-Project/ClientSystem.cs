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

using NDP_Project.Services;
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
    public partial class ClientSystem : Form
    {

        public ClientSystem()
        {
            InitializeComponent();
        }

        private void button_BackMP_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void ClientSystem_Load(object sender, EventArgs e)
        {

        }

        private void button_CClientRegister_Click(object sender, EventArgs e)
        {
            label_CContact.Visible = true;
            label_CName.Visible = true;
            label_CSecondName.Visible = true;
            textBox_CContact.Visible = true;
            textBox_CName.Visible = true;
            textBox_CSecondName.Visible = true;
            button_CFinishRegister.Visible = true;
            label_CSuccessRegister.Visible = false;
            label_CWarningRegister.Visible = false;

            label_CContactList.Visible = false;
            label_CSecondnameList.Visible = false;
            tableLayoutPanel_CList.Visible = false;
            label_CNameList.Visible = false;
            label_CContactDelete.Visible = false;
            label_CWarningDelete.Visible = false;
            label_CSuccessDelete.Visible = false;
            textBox_CContactDelete.Visible = false;
            button_CDelete.Visible = false;
        }

        private void button_CFinishRegister_Click(object sender, EventArgs e)
        {
            if (textBox_CContact.Text == "" || textBox_CName.Text == "" || textBox_CSecondName.Text == "")
            {
                label_CSuccessRegister.Visible = false;
                label_CWarningRegister.Visible = true;
            }
            else
            {
                label_CSuccessRegister.Visible = true;
                label_CWarningRegister.Visible = false;
                string name = textBox_CName.Text;
                string secondName = textBox_CSecondName.Text;
                int contact = Convert.ToInt32(textBox_CContact.Text);

                string filePath = "C:\\users\\Sude\\Desktop\\g\\kod\\NDP-Project\\ClientInfo.txt";
                string newRegister = $"{name},{secondName},{contact}";//String Interpolation(Dizin ekleme)
                File.AppendAllText(filePath, newRegister + Environment.NewLine);

            }
        }

        private void button_CClientDelete_Click(object sender, EventArgs e)
        {
            label_CContactDelete.Visible = true;
            label_CWarningDelete.Visible = false;
            label_CSuccessDelete.Visible = false;
            textBox_CContactDelete.Visible = true;
            button_CDelete.Visible = true;

            label_CContactList.Visible = false;
            label_CSecondnameList.Visible = false;
            tableLayoutPanel_CList.Visible = false;
            label_CNameList.Visible = false;
            label_CContact.Visible = false;
            label_CName.Visible = false;
            label_CSecondName.Visible = false;
            textBox_CContact.Visible = false;
            textBox_CName.Visible = false;
            textBox_CSecondName.Visible = false;
            button_CFinishRegister.Visible = false;
            label_CSuccessRegister.Visible = false;
            label_CWarningRegister.Visible = false;
        }

        private void button_CDelete_Click(object sender, EventArgs e)
        {

            int control = 0;//control for if we deleted any
            string delcli = textBox_CContactDelete.Text;//getting text

            /*Getting file path*/
            string filePath = "C:\\Users\\Sude\\Desktop\\g\\kod\\NDP-Project\\ClientInfo.txt";

            /*Get datas line by line*/
            string[] lines = File.ReadAllLines(filePath);

            /*list for refreshing the file*/
            List<string> newLines = new List<string>();

            if (delcli == "")/*checking whether the textbox is empty*/
            {
                MessageBox.Show("Lütfen İstenen Alanları Doldurunuz.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] veri = lines[i].Split(',');/*splitting the datas*/
                    if (veri[2] == delcli)/*maching datas*/
                    {
                        control = 1;
                        continue;//if its mached continue and do not save the data line
                    }
                    newLines.Add(lines[i]);
                }
                if (control == 1)//checking for if we deleted any data
                {
                    label_CSuccessDelete.Visible = true;
                    label_CWarningDelete.Visible = false;
                    File.WriteAllLines(filePath, newLines);//if so writing new datas to our file

                }
                else
                {
                    label_CSuccessDelete.Visible = false;
                    label_CWarningDelete.Visible = true;
                }
            }
            
        }
        private void button_ClientList_Click(object sender, EventArgs e)
        {
            /*items visibility changes*/
            tableLayoutPanel_CList.Visible = true;
            label_CNameList.Visible = true;
            label_CSecondnameList.Visible = true;
            label_CContactList.Visible = true;

            label_CContactDelete.Visible = false;
            label_CWarningDelete.Visible = false;
            label_CSuccessDelete.Visible = false;
            textBox_CContactDelete.Visible = false;
            button_CDelete.Visible = false;


            label_CContact.Visible = false;
            label_CName.Visible = false;
            label_CSecondName.Visible = false;
            textBox_CContact.Visible = false;
            textBox_CName.Visible = false;
            textBox_CSecondName.Visible = false;
            button_CFinishRegister.Visible = false;
            label_CSuccessRegister.Visible = false;
            label_CWarningRegister.Visible = false;

            /*get the file path*/
            string filePath = "C:\\Users\\Sude\\Desktop\\g\\kod\\NDP-Project\\ClientInfo.txt";

            /*get datas line by line*/
            string[] lines = File.ReadAllLines(filePath);

            /*Set table controls*/
            tableLayoutPanel_CList.Controls.Clear();
            tableLayoutPanel_CList.RowCount = 0;

            // Adding the lines to tableLayoutPanel
            foreach (string line in lines)
            {
                // adding new row for every new line
                tableLayoutPanel_CList.RowCount++;
                tableLayoutPanel_CList.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                // Seperating infos for columns
                string[] columns = line.Split(',');

                for (int i = 0; i < columns.Length; i++)
                {
                    // create new label for datas
                    Label lbl = new Label();
                    lbl.Text = columns[i].Trim();//for deleting white spaces
                    lbl.AutoSize = true;

                    // Adding label to appropriate cell
                    tableLayoutPanel_CList.Controls.Add(lbl, i, tableLayoutPanel_CList.RowCount - 1);
                }
            }
        }

        private void button_CBook_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Hide();
        }


      
    }
}
