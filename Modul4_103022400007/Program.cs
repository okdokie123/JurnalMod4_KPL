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
    class Running
    {
        static void Main(string[] args)
        {
            KodePaket paket = new KodePaket();
            Console.WriteLine("Kode Paket Basic: " + paket.getKodePaket("Basic"));
            Console.WriteLine("Kode Paket Gaming: " + paket.getKodePaket("Gaming"));
            Console.WriteLine("Kode Paket Traveler: " + paket.getKodePaket("Traveler"));
        }
    }
}
