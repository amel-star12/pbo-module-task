namespace SistemSekolah
{
    public class GuruBahasa : Guru
    {
        public GuruBahasa(string nama, int umur) : base(nama, umur, "Bahasa Indonesia")
        {
        }

        public void MengajarBahasa()
        {
            Console.WriteLine($"{Nama} sedang mengajar tata bahasa dan sastra.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang mengajar Bahasa Indonesia dan membaca puisi.");
        }
    }
}
