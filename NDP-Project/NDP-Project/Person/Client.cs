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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_Project.Person
{
    internal class Client : IPerson
    {
        public string NameOfPerson { get; set; }
        public string SecondNameOfPerson { get; set; }
        public int ContactOfPerson { get; set; }

        
        public Client(string name, string sname, int contact)
        {
            NameOfPerson = name;
            SecondNameOfPerson = sname;
            ContactOfPerson = contact;
        }
    }
}
