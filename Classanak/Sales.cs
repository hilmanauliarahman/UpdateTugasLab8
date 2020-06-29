using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOPCollection.Classinduk;
namespace OOPCollection.Classanak
{
    class Sales:Karyawan
    {
        public override string nik { get; set; }
        public override string nama { get; set; }
        public double komisi { get; set; }
        public int jumlahpenjualan { get; set; }
        public override double gaji()
        {
            return jumlahpenjualan * komisi;
        }
    }
}
