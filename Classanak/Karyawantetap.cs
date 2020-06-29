using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOPCollection.Classinduk;
namespace OOPCollection.Classanak
{
    class Karyawantetap:Karyawan
    {
        public override string nik { get; set; }
        public override string nama { get; set; }
        public double gajibulanan { get; set; }
        public override double gaji()
        {
            return this.gajibulanan;
        }
    }
}
