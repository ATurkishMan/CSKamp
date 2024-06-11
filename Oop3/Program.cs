using System;
namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); //interfaceler de o interfacei implemente eden klasın referans numarasını tutabiliyor
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService(); 

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService); //fonksiyon IKrediManager türünde obje alıyor. 
                                                            //ve kredi türlerini IKrediManager türüne bağladık

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager};
            List<ILoggerService> loggers = new List<ILoggerService>() {databaseLoggerService, fileLoggerService};

            basvuruManager.KrediOnBilgilendirmesiYap(krediler, loggers);
        }


    }
}