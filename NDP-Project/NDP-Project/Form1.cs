//***********************************************************************************************************************
//**                                                                                                                   **
//**                                     SAKARYA �N�VERS�TES�                                                          **
//**                          B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�                                                **
//**                                B�LG�SAYAR M�HEND�SL��� B�L�M�                                                     **
//**                                                                                                                   **
//**                                  PROJE NUMARASI..: 1                                                              **
//**                                  ��RENC� ADI.....: SUDE ANDURMAN                                                  **
//**                                  ��RENC� NUMARASI: b231210005                                                     **
//**                                  DERS GRUBU......: B                                                              **
//**                                                                                                                   ** 
//**                                                                                                                   **  
//**                        Ama�:G�zellik merkezi - kuaf�r salonlar�n�n g�nl�k                                         **
//**            operasyonlar�n� d�zenlemek ve m��terilere randevu vererek planlama yap�lmas�n�                         ** 
//**                                        sa�lamakt�r.                                                               **
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
