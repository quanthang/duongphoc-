using System;
using System.Collections.Generic;
using DuongsinhCs.entity;

namespace DuongsinhCs.controller
{
    
    public class DuongPhoController
    {
        public static List<DuongPho> _listDuongpho = new List<DuongPho>();
        public void TaoMoiDuongPho()
        {
            Console.WriteLine("vui long nhap thong tin duong pho: ");
            var dp1 = new DuongPho();
            Console.WriteLine(" vui long nhap ma duong: ");
            var maDuong = Console.ReadLine();
            dp1.Ma =maDuong ;
            Console.WriteLine("nhap ten duong: ");
            var tenDuong = Console.ReadLine();
            dp1.Ten = tenDuong;
            Console.WriteLine("nhap mo ta ve duong: ");
            var moTa = Console.ReadLine();
            dp1.Ten = moTa;
            Console.WriteLine("ngay duong duoc dua vao su dung: ");
            var ngaySuDung = DateTime.Parse(Console.ReadLine());
            dp1.NgaySuDung = ngaySuDung;
            Console.WriteLine("lich su cua duong: ");
            var lichSu = Console.ReadLine();
            dp1.LichSu = lichSu;
            Console.WriteLine("duong nam tren dia phan quan: ");
            var tenQuan = Console.ReadLine();
            dp1.TenQuan =tenQuan;
            Console.WriteLine("nhap trang thai duong: ");
            var trangThai = int.Parse(Console.ReadLine() );
            dp1.TrangThai = trangThai;
            
            _listDuongpho.Add(dp1);
            
        }

        public void HienThiDanhSachDuong()
        {
            Console.WriteLine("danh sach duong vua nhap la: ");
            for (int i = 0; i < _listDuongpho.Count; i++)
            {
                var dp2 = _listDuongpho[i];
                Console.WriteLine($"ma: {dp2.Ma},  ten duong:{dp2.Ten},mo ta: {dp2.MoTa},ngay su dung {dp2.NgaySuDung},lichsu:{dp2.LichSu}, ten quan {dp2.TenQuan},trangthai: {dp2.TrangThai}");
            }
        }

        public void SuaDanhSachDuongPho()
        {
            Console.WriteLine("vui longf nhap ma duong can sua: ");
            var maDuongPho = Console.ReadLine();
            DuongPho duongPho = null;
            for (int i = 0; i < _listDuongpho.Count; i++)
            {
                var dp3 = _listDuongpho[i];
                if (dp3.Ma == maDuongPho)
                {
                    duongPho = _listDuongpho[i];
                    break;
                }
                Console.WriteLine("nhap ten duong: ");
                var tenDuong = Console.ReadLine();
                dp3.Ten = tenDuong;
                Console.WriteLine("nhap mo ta ve duong: ");
                var moTa = Console.ReadLine();
                dp3.Ten = moTa;
                Console.WriteLine("ngay duong duoc dua vao su dung: ");
                var ngaySuDung = DateTime.Parse(Console.ReadLine());
                dp3.NgaySuDung = ngaySuDung;
                Console.WriteLine("lich su cua duong: ");
                var lichSu = Console.ReadLine();
                dp3.LichSu = lichSu;
                Console.WriteLine("duong nam tren dia phan quan: ");
                var tenQuan = Console.ReadLine();
                dp3.TenQuan =tenQuan;
                Console.WriteLine("nhap trang thai duong: ");
                var trangThai = int.Parse(Console.ReadLine() );
                dp3.TrangThai = trangThai; 
            }

            if (duongPho==null)
            {
                Console.WriteLine("khong tim thay thong tin sinh vien: ");
            }
            
        }
        

        public void XoaThongTinDuongPho()
        {
            Console.WriteLine("nhap ma duong can xoa: ");
            var maDuong = Console.ReadLine();
            var index = -1;
            for (int i = 0; i < _listDuongpho.Count; i++)
            {
                var gv3 = _listDuongpho[i];
                if (gv3.Ma==maDuong)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("khong tim thay thong tin duong");
                return;
            }
            _listDuongpho.RemoveAt(index);
            Console.WriteLine("xoa thanh cong");
        }
    }
}