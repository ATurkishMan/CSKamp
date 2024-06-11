using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3//Interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız *****
{
    interface IKrediManager //genellikle operasyonlarda kullanılır, // IKrediManager ı ortak bir arayüz kullanmak için
    {
        void Hesapla(); //imzanın aynı olup yapılan iş farklı ise interface oluştur
        void BirSeyYap();
    }
}
