using System;
using System.Collections.Generic;

namespace Bai3_OOP
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("===== TEST =====\n");

            
            // TC01 - Validation năm sản xuất
            
            Console.WriteLine("TC01 - KIEM TRA VALIDATION");

            try
            {
                OTo otoLoi = new OTo(
                    "OT01",
                    "Toyota",
                    1850,
                    1000000000,
                    5,
                    2.0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();


            
            // TC02 - Tính giá ô tô
            
            Console.WriteLine("TC02 - KIEM TRA GIA LAN BANH O TO");

            OTo oto = new OTo(
                "OT02",
                "Toyota",
                2024,
                1000000000,
                5,
                2.0);

            Console.WriteLine(
                "Gia lan banh: " +
                oto.TinhGiaLanBanh().ToString("N0") +
                " VNĐ");

            Console.WriteLine();


            
            // TC03 - Tính giá xe máy
            
            Console.WriteLine("TC03 - KIEM TRA GIA LAN BANH XE MAY");

            XeMay xeMay = new XeMay(
                "XM01",
                "Honda",
                2023,
                50000000,
                150);

            Console.WriteLine(
                "Gia lan banh: " +
                xeMay.TinhGiaLanBanh().ToString("N0") +
                " VNĐ");

            Console.WriteLine();


            
            // TC04 - Kiểm tra đa hình
            
            Console.WriteLine("TC04 - KIEM TRA DA HINH");

            List<PhuongTien> danhSach = new List<PhuongTien>();

            danhSach.Add(oto);
            danhSach.Add(xeMay);

            foreach (PhuongTien pt in danhSach)
            {
                Console.WriteLine(
                    pt.TenHang +
                    " -> " +
                    pt.TinhGiaLanBanh().ToString("N0") +
                    " VNĐ");
            }

            Console.WriteLine();


            
            // TC05 - Tìm giá lăn bánh cao nhất
            
            Console.WriteLine("TC05 - TIM GIA LAN BANH CAO NHAT");

            QuanLyPhuongTien quanLy = new QuanLyPhuongTien();

            quanLy.AddPhuongTien(oto);
            quanLy.AddPhuongTien(xeMay);

            PhuongTien max = quanLy.FindMaxGiaLanBanh();

            Console.WriteLine("Phuong tien co gia cao nhat:");

            Console.WriteLine(max.GetInfo());

            Console.WriteLine(
                "Gia lan banh: " +
                max.TinhGiaLanBanh().ToString("N0") +
                " VNĐ");


            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}