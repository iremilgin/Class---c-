using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulamasıClass
{

    public class Ogrenci
    {
        private int ogrno;

        private string isim;

        private string soyisim;

        private int vize1;

        private int vize2;

        private int final;

        private string okulIsmi;


        public void OgrenciBilgileriGoster()
        {
            Console.WriteLine("Öğrenci Numarası: " + ogrno);
            Console.WriteLine("Öğrenci İsmi " + isim);
            Console.WriteLine("Öğrenci Soyismi: " + soyisim);
            Console.WriteLine("Öğrenci Vize1: " + vize1);
            Console.WriteLine("Öğrenci Vize2: " + vize2);
            Console.WriteLine("Öğrenci Final " + final);
            Console.WriteLine("Öğrenci Okul İsmi: " + okulIsmi);
        }

        public Ogrenci(int _ogrno, string _isim, string _soyIsim , int _vize1 , int _vize2, int _final , string _okulIsmi )
        {

            ogrno = _ogrno;
            isim = _isim;   
            soyisim = _soyIsim;
            vize1 = _vize1;
            vize2= _vize2;
            final = _final;
            okulIsmi= _okulIsmi;    

        }



        public double OgrenciNotuBul()
        {
           double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            return ortalama;
        }

        public void OkulGetir()
        {
            Console.WriteLine("Öğrencinin Okulu: " + okulIsmi);
        }

    }
}
