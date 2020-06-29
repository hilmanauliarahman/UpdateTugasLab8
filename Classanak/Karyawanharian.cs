using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOPCollection.Classinduk;
namespace OOPCollection.Classanak
{
    class Karyawanharian : Karyawan
    {
        public override string nik { get; set; }
        public override string nama { get; set; }
        public double upahperjam { get; set; }
        public int jumlahjamkerja { get; set; }
        public override double gaji() {
            return upahperjam * jumlahjamkerja;
        }
    }
}
