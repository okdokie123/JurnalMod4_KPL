using System;
using System.Collections.Generic;

namespace JurnalMod4_103022400007
{
    class KodePaket
    {
        public string getKodePaket(string namaPaket)
        {
            Dictionary<string, string> tabelKodePaket = new Dictionary<string, string>()
            {
                {"Basic", "P201"},
                {"Standard", "P202"},
                {"Premium", "P203"},
                {"Unlimited", "P204"},
                {"Gaming", "P205"},
                {"Streaming", "P206"},
                {"Family", "P207"},
                {"Business", "P208"},
                {"Student", "P209"},
                {"Traveler", "P210"}
            };
            if (tabelKodePaket.ContainsKey(namaPaket))
            {
                return tabelKodePaket[namaPaket];
            }   
            else
            {
                return "kode paket tidak ditemukan";
            }
        }
    }
    class MesinKopi
    {
        public enum State { OFF, STANDBY, BREWING, MAINTENANCE };
        public State currentState = State.OFF;

        public void PowerON()
        {
            if (currentState == State.OFF)
            {
                currentState = State.STANDBY;
                Console.WriteLine("Mesin OFF berubah menjadi STANDBY");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }
        public void PowerOFF()
        {
            if (currentState == State.STANDBY)
            {
                currentState = State.OFF;
                Console.WriteLine("Mesin STANBY berubah menjadi OFF");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }
        public void StartBrew()
        {
            if (currentState == State.STANDBY)
            {
                currentState = State.BREWING;
                Console.WriteLine("Mesin STANBY berubah menjadi BREWING");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }
        public void FinishBrew()
        {
            if (currentState == State.BREWING)
            {
                currentState = State.STANDBY;
                Console.WriteLine("Mesin BREWING berubah menjadi STANDBY");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }
        public void StartMaintenance()
        {
            if (currentState == State.STANDBY)
            {
                currentState = State.MAINTENANCE;
                Console.WriteLine("Mesin STANDBY berubah menjadi MAINTENANCE");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }
        public void FinishMaintenance()
        {
            if (currentState == State.MAINTENANCE)
            {
                currentState = State.STANDBY;
                Console.WriteLine("Mesin MAINTENANCE berubah menjadi STANDBY");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }
    }
    class Running
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Table Driven-");
            KodePaket paket = new KodePaket();
            Console.WriteLine("Kode Paket Basic: " + paket.getKodePaket("Basic"));
            Console.WriteLine("Kode Paket Gaming: " + paket.getKodePaket("Gaming"));
            Console.WriteLine("Kode Paket Traveler: " + paket.getKodePaket("Traveler"));

            Console.WriteLine();
            Console.WriteLine("-State Based Construction-");

            MesinKopi mesin = new MesinKopi();

            mesin.PowerON();
            mesin.StartMaintenance();
            mesin.FinishMaintenance();
            mesin.StartBrew();
            mesin.FinishBrew();
            mesin.PowerOFF();

            mesin.PowerOFF();
        }
    }
}
