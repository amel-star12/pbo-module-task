namespace SistemSekolah
{
    public class GuruMatematika : Guru
    {
        public GuruMatematika(string nama, int umur) : base(nama, umur, "Matematika")
        {
        }

        public void MengajarHitung()
        {
            Console.WriteLine($"{Nama} sedang mengajar cara menghitung dan rumus matematika.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang mengajar Matematika dan menjelaskan rumus.");
        }
    }
}
