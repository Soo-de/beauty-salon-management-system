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
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace NDP_Project
{
    public partial class Books : Form
    {
        List<IServices> services = new List<IServices>();

        public Books()
        {
            InitializeComponent();

            /*Adding list items*/
            services.Add(new Epilation("Lazer epilasyon", 1000));
            services.Add(new Epilation("Ağda", 200));
            services.Add(new EyeCare("Kaş şekillendirme", 125));
            services.Add(new EyeCare("Kirpik liftingi", 350));
            services.Add(new EyeCare("Kirpik Ekstensions", 600));
            services.Add(new Makeup("Günlük makyaj", 275));
            services.Add(new Makeup("Gece makyajı", 350));
            services.Add(new Makeup("Düğün makyajı", 950));
            services.Add(new Makeup("Kalıcı makyaj", 1500));
            services.Add(new ManiPedi("Klasik manikür/pedikür", 175));
            services.Add(new ManiPedi("Jel manikür", 250));
            services.Add(new ManiPedi("Spa manikür/pedikür", 350));
            services.Add(new Massage("Aromaterapi masajı", 400));
            services.Add(new Massage("Aromaterapi masajı", 400));
            services.Add(new Massage("Spor masajı", 500));
            services.Add(new SkinCare("Yüz bakımı", 1900));
            services.Add(new SkinCare("Vücut bakımı", 1500));
        }
        private void Books_Load(object sender, EventArgs e)
        {
            /*adding items to checkedlist*/
            foreach (var service in services)
            {
                checkedListBox_BServices.Items.Add(service.ToString());
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            ClientSystem clientSystem = new ClientSystem();
            clientSystem.Show();
            this.Hide();
        }

        private void button_BakMP_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button_CBook_Click(object sender, EventArgs e)
        {
            /*items visibility changes*/
            label_BClient.Visible = true;
            comboBox_BClient.Visible = true;
            button_BFinishChoise.Visible = true;

            label_BBookSuccess.Visible = false;
            label_BBookWarning.Visible = false;
            button_BDeleteItems.Visible = false;
            button_BAddList.Visible = false;
            label_BListFee.Visible = false;
            label_BClientWarning.Visible = false;
            label_BDate.Visible = false;
            label_BPersonel.Visible = false;
            label_BServices.Visible = false;
            comboBox_BPersonel.Visible = false;
            checkedListBox_BServices.Visible = false;
            listBox_BFee.Visible = false;
            button_BFinishBook.Visible = false;
            monthCalendar_BookDate.Visible = false;

            /*get the file path*/
            string filePath = "C:\\Users\\Sude\\Desktop\\g\\kod\\NDP-Project\\ClientInfo.txt";

            /*get datas line by line*/
            string[] clientsinfo = File.ReadAllLines(filePath);

            /*Adding client infos to checkbox*/
            for (int i = 0; i < clientsinfo.Length; i++)
            {
                string[] veri = clientsinfo[i].Split(',');
                comboBox_BClient.Items.Add(veri[0] + " " + veri[1]);
            }

            /*get the file path*/
            string filePath2 = "C:\\Users\\Sude\\Desktop\\g\\kod\\NDP-Project\\PersonelInfo.txt";

            /*get datas line by line*/
            string[] personelsinfo = File.ReadAllLines(filePath2);

            /*Adding personel infos to checkbox*/
            for (int i = 0; i < personelsinfo.Length; i++)
            {
                string[] veri = personelsinfo[i].Split(',');
                comboBox_BPersonel.Items.Add(veri[0] + " " + veri[1]);
            }

        }

        private void button_BFinishChoise_Click(object sender, EventArgs e)
        {


            if (comboBox_BClient.Text == "")//checking whether the textbox is empty
            {
                label_BClientWarning.Visible = true;
            }
            else
            {
                /*items visibility changes*/
                label_BDate.Visible = true;
                label_BPersonel.Visible = true;
                label_BServices.Visible = true;
                comboBox_BPersonel.Visible = true;
                checkedListBox_BServices.Visible = true;
                listBox_BFee.Visible = true;
                button_BFinishBook.Visible = true;
                monthCalendar_BookDate.Visible = true;
                label_BListFee.Visible = true;
                button_BAddList.Visible = true;
                button_BDeleteItems.Visible = true;

                label_BBookSuccess.Visible = false;
                label_BBookWarning.Visible = false;
                label_BClientWarning.Visible = false;
                label_BClient.Visible = false;
                comboBox_BClient.Visible = false;
                button_BFinishChoise.Visible = false;
            }

        }

        private void button_BAddList_Click(object sender, EventArgs e)
        {
            /*adding items to listbox from checked list box*/
            foreach (var item in checkedListBox_BServices.CheckedItems)
            {
                listBox_BFee.Items.Add(item);
            }

            /*reseting checked list box*/
            for (int i = 0; i < checkedListBox_BServices.Items.Count; i++)
            {
                checkedListBox_BServices.SetItemChecked(i, false);
            }
        }

        private void button_BDeleteItems_Click(object sender, EventArgs e)
        {
            /*clear list box*/
            listBox_BFee.Items.Clear();
        }

        private void button_BFinishBook_Click(object sender, EventArgs e)
        {
            /*get file path and date*/
            DateTime selectedDate = monthCalendar_BookDate.SelectionStart;
            string selectedDateString = selectedDate.ToShortDateString();
            string filePath = "C:\\users\\Sude\\Desktop\\g\\kod\\NDP-Project\\Books.txt";


            if (comboBox_BPersonel.Text == "" || listBox_BFee.Items.Count == 0)//checking whether the boxes are empty or not
            {
                label_BBookSuccess.Visible = false;
                label_BBookWarning.Visible = true;
            }
            else
            {
                label_BBookWarning.Visible = false;
                label_BBookSuccess.Visible = true;
                for (int i = 0; i < listBox_BFee.Items.Count; i++)
                {
                    //getting items to appointment text file
                    string listBoxItem = listBox_BFee.Items[i].ToString();
                    string newBook = $"{comboBox_BClient.Text},{comboBox_BPersonel.Text},{listBoxItem},{selectedDateString}";
                    File.AppendAllText(filePath, newBook + Environment.NewLine);

                }
            }
        }

        private void button_BBooksList_Click(object sender, EventArgs e)
        {
            BookList bookList = new BookList();
            bookList.Show();
            this.Hide();
        }

        private void button_BBookDelete_Click(object sender, EventArgs e)
        {
            BookDelete bookDelete = new BookDelete();
            bookDelete.Show();
            this.Hide();
        }
    }
}
