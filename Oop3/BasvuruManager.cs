using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{   //method injection
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) //bütün kredi ve logger türlerlini alabilir
        {

            //KonutKrediManager konutKrediManager = new KonutKrediManager(); bu satır BasvuruYap fonksiyonunu KonutKrediManeger türüne bağlı yapar. 
            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler, List<ILoggerService> loggers)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
            foreach (var logger in loggers)
            {
                logger.Log();
            }
        }
    }
}
