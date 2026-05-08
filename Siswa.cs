namespace SistemSekolah
{
    public class Siswa : Orang
    {
        public string Kelas { get; set; }

        public Siswa(string nama, int umur, string kelas) : base(nama, umur)
        {
            Kelas = kelas;
        }

        public void Belajar()
        {
            Console.WriteLine($"{Nama} dari kelas {Kelas} sedang belajar.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang belajar di kelas {Kelas}.");
        }
    }
}
