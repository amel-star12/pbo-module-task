using SistemSekolah;

Sekolah sekolah = new Sekolah();

Console.WriteLine("===== MEMBUAT OBJEK DAN MENAMBAHKAN KE SEKOLAH =====");

SiswaSD        siswaSD1  = new SiswaSD("Budi", 8, "3A");
SiswaSD        siswaSD2  = new SiswaSD("Ani", 9, "4B");
SiswaSMA       siswaSMA1 = new SiswaSMA("Riko", 16, "10 IPA");
SiswaSMA       siswaSMA2 = new SiswaSMA("Sari", 17, "11 IPS");
GuruMatematika guruMtk   = new GuruMatematika("Pak Hendra", 40);
GuruBahasa     guruBhs   = new GuruBahasa("Bu Dewi", 35);

sekolah.TambahOrang(siswaSD1);
sekolah.TambahOrang(siswaSD2);
sekolah.TambahOrang(siswaSMA1);
sekolah.TambahOrang(siswaSMA2);
sekolah.TambahOrang(guruMtk);
sekolah.TambahOrang(guruBhs);

sekolah.DaftarOrang();

Console.WriteLine("===== DEMONSTRASI POLYMORPHISM (Aktivitas()) =====");
List<Orang> semuaOrang = new List<Orang>
{
    siswaSD1, siswaSD2, siswaSMA1, siswaSMA2, guruMtk, guruBhs
};

foreach (Orang o in semuaOrang)
{
    o.Aktivitas();
}

Console.WriteLine("\n===== METHOD KHUSUS TIAP SUBCLASS =====");

Console.WriteLine("\n-- SiswaSD --");
siswaSD1.Belajar();
siswaSD1.Main();
siswaSD1.InfoOrang();

Console.WriteLine("\n-- SiswaSMA --");
siswaSMA1.Belajar();
siswaSMA1.UjianNasional();
siswaSMA1.InfoOrang();

Console.WriteLine("\n-- GuruMatematika --");
guruMtk.Mengajar();
guruMtk.MengajarHitung();
guruMtk.InfoOrang();

Console.WriteLine("\n-- GuruBahasa --");
guruBhs.Mengajar();
guruBhs.MengajarBahasa();
guruBhs.InfoOrang();

Console.WriteLine("\n===== SELESAI =====");
