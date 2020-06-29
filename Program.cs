using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOPCollection.Classinduk;
using OOPCollection.Classanak;
namespace OOPCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Update Tugas Lab 8 Hilman Aulia Rahman 19.11.2656";
            int input;
            List<Karyawan> listKaryawan = new List<Karyawan>();
            do
            {
                Console.WriteLine("Pilih Menu Aplikasi");
                Console.WriteLine("=========================================");
                Console.WriteLine("1. Tambah Data Karyawan");
                Console.WriteLine("2. Tampilkan Data Karyawan");
                Console.WriteLine("3. Ubah Data Karyawan");
                Console.WriteLine("4. Hapus Data Karyawan");
                Console.WriteLine("5. Keluar");
                Console.WriteLine("=========================================");
                Console.Write("Pilihan (1 sd 5): ");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Tambah Data Karyawan\n");
                        Console.WriteLine("Jenis Karyawan\n1. Karyawan Tetap \n2. Karyawan Harian \n3. Sales ");
                        Console.Write("Pilihan (1 sd 3): ");
                        int pil = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch (pil)
                        {
                            case 1:
                                Karyawantetap Karyawantetap = new Karyawantetap();
                                Console.Write("nik : ");
                                Karyawantetap.nik = Console.ReadLine();
                                Console.Write("nama : ");
                                Karyawantetap.nama = Console.ReadLine();
                                Console.Write("gaji Bulanan : ");
                                Karyawantetap.gajibulanan = Convert.ToDouble(Console.ReadLine());
                                listKaryawan.Add(Karyawantetap);
                                break;
                            case 2:
                                Karyawanharian Karyawanharian = new Karyawanharian();
                                Console.Write("nik : ");
                                Karyawanharian.nik = Console.ReadLine();
                                Console.Write("nama : ");
                                Karyawanharian.nama = Console.ReadLine();
                                Console.Write("Jumlah Jam Kerja : ");
                                Karyawanharian.jumlahjamkerja = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Upah Per Jam : ");
                                Karyawanharian.upahperjam = Convert.ToDouble(Console.ReadLine());
                                listKaryawan.Add(Karyawanharian);
                                break;
                            case 3:
                                Sales Sales = new Sales();
                                Console.Write("nik : ");
                                Sales.nik = Console.ReadLine();
                                Console.Write("nama : ");
                                Sales.nama = Console.ReadLine();
                                Console.Write("Jumlah Jam Kerja : ");
                                Sales.jumlahpenjualan = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Upah Per Jam : ");
                                Sales.komisi = Convert.ToDouble(Console.ReadLine());
                                listKaryawan.Add(Sales);
                                break;
                            default:
                                Console.WriteLine("Menu Yang Anda Masukkan Salah!!!");
                                break;
                        }
                        break;
                    case 2:
                        int noUrut = 0;
                        string jenis = " ";
                        Console.WriteLine("Data Karyawan\n");
                        foreach (Karyawan karyawan in listKaryawan)
                        {
                            if (karyawan is Karyawantetap)
                            {
                                jenis = "Karyawan Tetap";
                            }
                            else if (karyawan is Karyawanharian)
                            {
                                jenis = "Karyawan Harian";
                            }
                            else
                            {
                                jenis = "Sales";
                            }
                            noUrut++;
                            Console.WriteLine("No. : {0}", noUrut);
                            Console.WriteLine("NIK : {0}", karyawan.nik);
                            Console.WriteLine("Nama : {0}", karyawan.nama);
                            Console.WriteLine("Gaji : {0}", karyawan.gaji());
                            Console.WriteLine("Jenis Karyawan : {0}", jenis);
                            Console.WriteLine("\n");
                        }
                        if (noUrut < 1)
                        {
                            Console.WriteLine("Data Karyawan Kosong");
                        }
                        break;
                    case 3:
                        int i;
                        Console.WriteLine("Ubah Data Karyawan\n");
                        Console.Write("nik : ");
                        string updatenik = Console.ReadLine();
                        
                        foreach (Karyawan karyawan in listKaryawan)
                        {
                                
                            if (karyawan.nik == updatenik)
                            {
                                //for (i = 0; i < sizeof(karyawan.nik); i++)
                                //{
                                    Console.WriteLine("NIK : {0}", karyawan.nik);
                                    Console.WriteLine("Nama : {0}", karyawan.nama);

                                    Console.Write("nik : ");
                                    karyawan.nik = Console.ReadLine();
                                    Console.Write("nama : ");
                                    karyawan.nama = Console.ReadLine();
                                //}
                            }
                            else
                            {
                                Console.WriteLine("\nData tidak ditemukan");
                            }
                        }
                        break;
                    case 4:
                        int no = -1, hapus = -1;
                        Console.WriteLine("Hapus Data Karyawan\n");
                        Console.Write("nik : ");
                        string nik = Console.ReadLine();
                        foreach (Karyawan karyawan in listKaryawan)
                        {
                            no++;
                            if (karyawan.nik == nik)
                            {
                                hapus = no;
                            }
                        }
                        if (hapus != -1)
                        {
                            listKaryawan.RemoveAt(hapus);
                            Console.WriteLine("\nData Berhasil dihapus");
                        }
                        else
                        {
                            Console.WriteLine("\nData tidak ditemukan");
                        }
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak tersedia!");
                        break;
                }
                Console.WriteLine("\nBerhasil !\n");
            }
            while (input != 5);
        }
    }
}
