using System;

namespace Bai3_OOP
{
    class OTo : PhuongTien
    {
        public int SoChoNgoi { get; set; }
        public double DungTichDongCo { get; set; }

        public OTo(
            string maPT,
            string tenHang,
            int namSanXuat,
            decimal giaGoc,
            int soChoNgoi,
            double dungTichDongCo)
            : base(maPT, tenHang, namSanXuat, giaGoc)
        {
            SoChoNgoi = soChoNgoi;
            DungTichDongCo = dungTichDongCo;
        }

        public override decimal TinhGiaLanBanh()
        {
            if (SoChoNgoi <= 9)
            {
                return GiaGoc + GiaGoc * 0.12m + GiaGoc * 0.30m;
            }
            else
            {
                return GiaGoc + GiaGoc * 0.10m;
            }
        }

        public override string GetInfo()
        {
            return base.GetInfo() +
                   ", So cho: " + SoChoNgoi +
                   ", Đong co: " + DungTichDongCo + "L";
        }
    }
}