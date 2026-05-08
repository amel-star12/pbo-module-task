namespace SistemSekolah
{
    public class SiswaSMA : Siswa
    {
        public SiswaSMA(string nama, int umur, string kelas) : base(nama, umur, kelas)
        {
        }

        public void UjianNasional()
        {
            Console.WriteLine($"{Nama} sedang mengikuti Ujian Nasional.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} siswa SMA kelas {Kelas} sedang mempersiapkan ujian.");
        }
    }
}
