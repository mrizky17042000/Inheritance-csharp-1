using System;

namespace Latihan1
{
    class Program
    {
        static void Main(string[] args)
        {
            // =============================== INHERITANCE ===================================

            // ========================= SET IN MAIN WITH CONSTRUCT======================
            Kampus.Mahasiswa.Ukm kmps = new Kampus.Mahasiswa.Ukm(1194021, "M. RIZKY", "Sarijadi", "D4 TI - 2A", "Moh. Nurkamal Fauzan", "Pemrograman WEB 2", "Himatif");
            kmps.printInfo();

            // ========================= SET IN MAIN WITH CONSTRUCT AND VAR======================
            // var kmps = new Kampus.Mahasiswa(20, "M. RIZKY", "Sarijadi", "D4 TI", "Moh Nurkamal Fauzan", "Pemrograman WEB 2");
            // kmps.printInfo();
        }
    }
}
