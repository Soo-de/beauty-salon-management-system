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

namespace NDP_Project.Services
{
    internal class Makeup:  IServices
    {
        public string NameOfService { get; set; }
        public int PriceOfService { get; set; }

        public Makeup(string nos, int pos)
        {
            NameOfService = nos;
            PriceOfService = pos;
        }
        public override string ToString()
        {
            return NameOfService + "   " + PriceOfService + " TL";
        }
        
    }
}
