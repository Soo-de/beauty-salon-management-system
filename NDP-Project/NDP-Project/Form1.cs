//***********************************************************************************************************************
//**                                                                                                                   **
//**                                     SAKARYA ÜNÝVERSÝTESÝ                                                          **
//**                          BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ                                                **
//**                                BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ                                                     **
//**                                                                                                                   **
//**                                  PROJE NUMARASI..: 1                                                              **
//**                                  ÖÐRENCÝ ADI.....: SUDE ANDURMAN                                                  **
//**                                  ÖÐRENCÝ NUMARASI: b231210005                                                     **
//**                                  DERS GRUBU......: B                                                              **
//**                                                                                                                   ** 
//**                                                                                                                   **  
//**                        Amaç:Güzellik merkezi - kuaför salonlarýnýn günlük                                         **
//**            operasyonlarýný düzenlemek ve müþterilere randevu vererek planlama yapýlmasýný                         ** 
//**                                        saðlamaktýr.                                                               **
//**                                                                                                                   **
//**                                                                                                                   **
//**                                                                                                                   **  
//**                                                                                                                   **
//***********************************************************************************************************************

using NDP_Project.Person;
using NDP_Project.Services;

namespace NDP_Project
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Personel_Click(object sender, EventArgs e)
        {
            PersonelSystem personelSystem = new PersonelSystem();
            personelSystem.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button_Client_Click(object sender, EventArgs e)
        {
            ClientSystem clientSystem = new ClientSystem();
            clientSystem.Show();
            this.Hide();
        }
    }
}
