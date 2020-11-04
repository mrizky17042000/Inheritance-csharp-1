using System;

namespace Latihan1
{
    public class Kampus
    {
        String dosen;
        String matkul;
        public void setDosen(String dosen)
        {
            this.dosen = dosen;
        }
        public String getDosen()
        {
            return this.dosen;
        }
        public void setMatkul(String matkul)
        {
            this.matkul = matkul;
        }
        public String getMatkul()
        {
            return this.matkul;
        }

        public class Ukm : Kampus
        {
            string ukm;

            public class Mahasiswa : Ukm
            {
                int id;
                String nama;
                String alamat;
                String kelas;
                // ==============================CONSTRUCT NULL============================
                // public Mahasiswa()
                // {

                // }
                public void setId(int id)
                {
                    this.id = id;
                }
                public int getId()
                {
                    return this.id;
                }
                public void setNama(String nama)
                {
                    this.nama = nama;
                }
                public string getNama()
                {
                    return this.nama;
                }

                public void setAlamat(String alamat)
                {
                    this.alamat = alamat;
                }
                public string getAlamat()
                {
                    return this.alamat;
                }

                public void setKelas(String kelas)
                {
                    this.kelas = kelas;
                }
                public String getKelas()
                {
                    return this.kelas;
                }
                // =========================== CONSTRUCT INISIALISASI =======================
                public Mahasiswa(int id, String nama, String alamat, String kelas, String dosen, String matkul, string ukm)
                {
                    Console.WriteLine("=============== Profile ================");
                    this.id = id;
                    this.nama = nama;
                    this.alamat = alamat;
                    this.kelas = kelas;
                    this.dosen = dosen;
                    this.matkul = matkul;
                    this.ukm = ukm;
                }
                public string getUkm()
                {
                    return this.ukm;
                }

                public void setUkm(string ukm)
                {
                    this.ukm = ukm;
                }
                public void Organisasi()
                {
                    Console.WriteLine("Organisasi Adalah " + getUkm());
                }
                public void printInfo()
                {
                    Console.WriteLine("NPM saya adalah = " + getId());
                    Console.WriteLine("Nama saya adalah = " + getNama());
                    Console.WriteLine("Alamat saya adalah = " + getAlamat());
                    Console.WriteLine("Kelas saya adalah = " + getKelas());
                    Console.WriteLine("Nama Dosen saya adalah = " + getDosen());
                    Console.WriteLine("Matkul saya adalah = " + getMatkul());
                    Console.WriteLine("Ukm saya adalah = " + getUkm());
                }
            }
        }

    }
}
