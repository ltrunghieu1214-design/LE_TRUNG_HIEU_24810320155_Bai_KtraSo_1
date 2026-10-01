using System;

namespace Bai3_OOP
{
    class XeMay : PhuongTien
    {
        public int DungTichXylanh { get; set; }

        public XeMay(
            string maPT,
            string tenHang,
            int namSanXuat,
            decimal giaGoc,
            int dungTichXylanh)
            : base(maPT, tenHang, namSanXuat, giaGoc)
        {
            DungTichXylanh = dungTichXylanh;
        }

        public override decimal TinhGiaLanBanh()
        {
            if (DungTichXylanh < 175)
            {
                return GiaGoc + GiaGoc * 0.02m;
            }
            else
            {
                return GiaGoc + GiaGoc * 0.05m;
            }
        }

        public override string GetInfo()
        {
            return base.GetInfo() +
                   ", Xylanh: " + DungTichXylanh + "cc";
        }
    }
}