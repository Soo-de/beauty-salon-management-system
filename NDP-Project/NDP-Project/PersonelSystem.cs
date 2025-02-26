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
using NDP_Project.Person;
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
    public partial class PersonelSystem : Form
    {
        List<IPerson> personels = new List<IPerson>();
        public PersonelSystem()
        {
            InitializeComponent();
        }
        private void PersonelSystem_Load(object sender, EventArgs e)
        {

        }
        private void button_RegisterPersonel_Click(object sender, EventArgs e)
        {
            /*items visibility changes*/

            button_PFinishRegister.Visible = true;
            label_PName.Visible = true;
            label_PContact.Visible = true;
            label_PSecondName.Visible = true;
            textBox_PContact.Visible = true;
            textBox_PName.Visible = true;
            textBox_PSecondName.Visible = true;
            label_PWarningRegister.Visible = false;
            label_PSuccessRegister.Visible = false;

            tableLayoutPanel_PList.Visible = false;
            label_PTableName.Visible = false;
            label_PTableSecondName.Visible = false;
            label_PTableContact.Visible = false;

            label_PWarningDelete.Visible = false;
            label_PSuccessDelete.Visible = false;
            button_PDelete.Visible = false;
            label_PContactDelete.Visible = false;
            textBox_PContactDelete.Visible = false;

        }

        private void button_PersonelDelete_Click(object sender, EventArgs e)
        {
            /*items visibility changes*/
            button_PDelete.Visible = true;
            label_PContactDelete.Visible = true;
            textBox_PContactDelete.Visible = true;
            label_PWarningDelete.Visible = false;
            label_PSuccessDelete.Visible = false;

            tableLayoutPanel_PList.Visible = false;
            label_PTableName.Visible = false;
            label_PTableSecondName.Visible = false;
            label_PTableContact.Visible = false;

            button_PFinishRegister.Visible = false;
            label_PName.Visible = false;
            label_PContact.Visible = false;
            label_PSecondName.Visible = false;
            textBox_PContact.Visible = false;
            textBox_PName.Visible = false;
            textBox_PSecondName.Visible = false;
            label_PWarningRegister.Visible = false;
            label_PSuccessRegister.Visible = false;


        }

        private void button_PFinishRegister_Click(object sender, EventArgs e)
        {
            if (textBox_PContact.Text == "" || textBox_PName.Text == "" || textBox_PSecondName.Text == "")/*checking for if there any empty box*/
            {
                label_PSuccessRegister.Visible = false;
                label_PWarningRegister.Visible = true;
            }
            else
            {
                label_PSuccessRegister.Visible = true;
                label_PWarningRegister.Visible = false;

                /*Getting datas and saving them to the file*/
                string name = textBox_PName.Text;
                string secondName = textBox_PSecondName.Text;
                int contact = Convert.ToInt32(textBox_PContact.Text);


                string filePath = "C:\\Users\\Sude\\Desktop\\g\\kod\\NDP-Project\\PersonelInfo.txt";
                string newRegister = $"{name},{secondName},{contact}";//String Interpolation(Dizin ekleme)
                File.AppendAllText(filePath, newRegister + Environment.NewLine);

            }
        }

        private void button_PDelete_Click(object sender, EventArgs e)
        {
            int control = 0;//control for if we deleted any
            string delper = textBox_PContactDelete.Text;//getting text

            /*Getting file path*/
            string filePath = "C:\\Users\\Sude\\Desktop\\g\\kod\\NDP-Project\\PersonelInfo.txt";

            /*Get datas line by line*/
            string[] lines = File.ReadAllLines(filePath);

            /*list for refreshing the file*/
            List<string> newLines = new List<string>();

            if(delper=="")/*checking whether the textbox is empty*/
            {
                MessageBox.Show("Lütfen İstenen Alanları Doldurunuz.","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] veri = lines[i].Split(',');/*splitting the datas*/
                    if (veri[2] == delper)/*maching datas*/
                    {
                        control = 1;
                        continue;//if its mached continue and do not save the data line
                    }
                    newLines.Add(lines[i]);
                }
                if (control == 1)//checking for if we deleted any data
                {
                    label_PSuccessDelete.Visible = true;
                    label_PWarningDelete.Visible = false;
                    File.WriteAllLines(filePath, newLines);//if so writing new datas to our file

                }
                else
                {
                    label_PSuccessDelete.Visible = false;
                    label_PWarningDelete.Visible = true;
                }
            }
            
        }
        private void button_PesonelList_Click(object sender, EventArgs e)
        {
            /*items visibility changes*/
            tableLayoutPanel_PList.Visible = true;
            label_PTableName.Visible = true;
            label_PTableSecondName.Visible = true;
            label_PTableContact.Visible = true;

            button_PDelete.Visible = false;
            label_PContactDelete.Visible = false;
            textBox_PContactDelete.Visible = false;
            label_PWarningDelete.Visible = false;
            label_PSuccessDelete.Visible = false;
            button_PFinishRegister.Visible = false;
            label_PName.Visible = false;
            label_PContact.Visible = false;
            label_PSecondName.Visible = false;
            textBox_PContact.Visible = false;
            textBox_PName.Visible = false;
            textBox_PSecondName.Visible = false;
            label_PWarningRegister.Visible = false;
            label_PSuccessRegister.Visible = false;

            /*get the file path*/
            string filePath = "C:\\Users\\Sude\\Desktop\\g\\kod\\NDP-Project\\PersonelInfo.txt";

            /*get datas line by line*/
            string[] lines = File.ReadAllLines(filePath);

            /*Set table controls*/
            tableLayoutPanel_PList.Controls.Clear();
            tableLayoutPanel_PList.RowCount = 0;

            // Adding the lines to tableLayoutPanel
            foreach (string line in lines)
            {
                // adding new row for every new line
                tableLayoutPanel_PList.RowCount++;
                tableLayoutPanel_PList.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                // Seperating infos for columns
                string[] columns = line.Split(',');

                for (int i = 0; i < columns.Length; i++)
                {
                    // create new label for datas
                    Label lbl = new Label();
                    lbl.Text = columns[i].Trim();//for deleting white spaces
                    lbl.AutoSize = true;

                    // Adding label to appropriate cell
                    tableLayoutPanel_PList.Controls.Add(lbl, i, tableLayoutPanel_PList.RowCount - 1);
                }
            }
        }

        private void button_BackMP_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label_PWarningDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
