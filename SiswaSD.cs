namespace SistemSekolah
{
    public class SiswaSD : Siswa
    {
        public SiswaSD(string nama, int umur, string kelas) : base(nama, umur, kelas)
        {
        }

        public void Main()
        {
            Console.WriteLine($"{Nama} sedang bermain di taman sekolah.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} siswa SD kelas {Kelas} sedang belajar dan bermain.");
        }
    }
}
