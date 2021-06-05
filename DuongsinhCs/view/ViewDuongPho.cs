using System;
using DuongsinhCs.controller;

namespace DuongsinhCs.view
{
    public class ViewDuongPho
    {
        public void DuongPhoView()
        {
            DuongPhoController duongPhoController = new DuongPhoController();
            while (true)
            {
                Console.WriteLine("---------------------------------------GiangVienManager----------------------------------");
                Console.WriteLine("| 1.Them moi duong                                                                 |");
                Console.WriteLine("| 2.Hien thi danh sach duong                                                       |");
                Console.WriteLine("| 3.Sua thong tin duong                                                            |");        
                Console.WriteLine("| 4.xoa duong                                                                     |");
                Console.WriteLine("| 5.Dong chuong trinh                                                                   |");
                Console.WriteLine("-----------------------------------------------------------------------------------------");
                int luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1 :
                        Console.WriteLine("chon 1 roi");
                        duongPhoController.TaoMoiDuongPho();
                        break  ;
                    case 2:
                        Console.WriteLine("chon 2 roi");
                        duongPhoController.HienThiDanhSachDuong();
                        break;
                    case 3:
                        Console.WriteLine("chon 3 roi");
                        duongPhoController.SuaDanhSachDuongPho();
                        break;
                    case 4:
                        Console.WriteLine("chon 4 roi");
                        duongPhoController.XoaThongTinDuongPho();
                        break;
                    
                }

                if (luachon != 5) continue;
                Console.WriteLine("byby"); 
                break;
            }
            }
        }
    }
