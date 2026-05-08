namespace SistemSekolah
{
    public class Guru : Orang
    {
        public string MataPelajaran { get; set; }

        public Guru(string nama, int umur, string mataPelajaran) : base(nama, umur)
        {
            MataPelajaran = mataPelajaran;
        }

        public void Mengajar()
        {
            Console.WriteLine($"{Nama} sedang mengajar mata pelajaran {MataPelajaran}.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang mengajar {MataPelajaran}.");
        }
    }
}
