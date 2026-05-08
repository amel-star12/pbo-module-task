namespace SistemSekolah
{
    public class Sekolah
    {
        private List<Orang> daftarOrang;

        public Sekolah()
        {
            daftarOrang = new List<Orang>();
        }

        public void TambahOrang(Orang orang)
        {
            daftarOrang.Add(orang);
            Console.WriteLine($"{orang.Nama} berhasil ditambahkan ke sekolah.");
        }

        public void DaftarOrang()
        {
            Console.WriteLine("\n========== DAFTAR ORANG DI SEKOLAH ==========");
            if (daftarOrang.Count == 0)
            {
                Console.WriteLine("Belum ada orang yang terdaftar.");
                return;
            }

            foreach (Orang orang in daftarOrang)
            {
                orang.InfoOrang();
            }
            Console.WriteLine("==============================================\n");
        }
    }
}
