using System.Collections.Generic;
using DuongsinhCs.entity;
using MySql.Data.MySqlClient;
using StreetCRUD.Helper;

namespace DuongsinhCs.moldel
{
    public class DuongPhoDbModel
    {
        public bool Save(DuongPho duongPho)
        {
            var connection = ConnectionHelper.GetConnection();
            connection.Open();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"INSERT INTO duongpho (Ma,Ten,MoTa,NgaySuDung,LichSu,TenQuan,TrangThai) " +
                                       $"VALUES ('{duongPho.Ma}', '{duongPho.Ten}', '{duongPho.MoTa}', '{duongPho.NgaySuDung}', '{duongPho.LichSu}', '{duongPho.TenQuan}', '{duongPho.TrangThai}')";
            int result = mySqlCommand.ExecuteNonQuery();
            connection.Close();
            if (result == 1)
            {
                return true;
            }

            return false;
        }

        public List<DuongPho> FindAll()
        {
            List<DuongPho> listDuongPho = new List<DuongPho>();
            var connection = ConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"select * from duongphos";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                var maduongPho = mySqlDataReader.GetString("MaDuongPho");
                var tenduongpho = mySqlDataReader.GetString("Ten");
                var mota = mySqlDataReader.GetString("MoTa");
                var ngaysudung = mySqlDataReader.GetDateTime("NgaySuDung");
                var lichsu = mySqlDataReader.GetString("LichSu");
                var tenquan = mySqlDataReader.GetString("TenQuan");
                var trangthai = mySqlDataReader.GetInt32("TrangThai");
                var duongPho = new DuongPho();
                duongPho.Ma = maduongPho;
                duongPho.Ten = tenduongpho;
                duongPho.MoTa = mota;
                duongPho.NgaySuDung = ngaysudung;
                duongPho.LichSu = lichsu;
                duongPho.TenQuan = tenquan;
                duongPho.TrangThai = trangthai;
                listDuongPho.Add(duongPho);
            }

            mySqlDataReader.Close();
            return listDuongPho;
        }

        public DuongPho FindById(string id)
        {
            DuongPho duongPho = null;
            var connection = ConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"select * from duongphos where Ma = '{id}'";
            var mySqlDataReader = mySqlCommand.ExecuteReader();
            if (mySqlDataReader.Read())
            {
                var maduongpho = mySqlDataReader.GetString("Ma");
                var tenduongpho = mySqlDataReader.GetString("Ten");
                var mota = mySqlDataReader.GetString("MoTa");
                var ngaysudung = mySqlDataReader.GetDateTime("NgaySuDung");
                var lichsu = mySqlDataReader.GetString("LichSu");
                var tenquan = mySqlDataReader.GetString("TenQuan");
                var trangthai = mySqlDataReader.GetInt32("TrangThai");
                duongPho = new DuongPho();
                duongPho.Ma = maduongpho;
                duongPho.Ten = tenduongpho;
                duongPho.MoTa = mota;
                duongPho.NgaySuDung = ngaysudung;
                duongPho.LichSu = lichsu;
                duongPho.TenQuan = tenquan;
                duongPho.TrangThai = trangthai;
            }

            mySqlDataReader.Close();
            return duongPho;
        }

        public bool Update(string id, DuongPho duongPhoUpdate)
        {
            var dp = FindById(id);
            if (dp == null)
            {
                return false;
            }

            dp.Ten = duongPhoUpdate.Ten;
            dp.MoTa = duongPhoUpdate.MoTa;
            dp.NgaySuDung = duongPhoUpdate.NgaySuDung;
            dp.LichSu = duongPhoUpdate.LichSu;
            dp.TenQuan = duongPhoUpdate.TenQuan;
            dp.TrangThai = duongPhoUpdate.TrangThai;
            var connection = ConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText =
                $"Update duongpho set Ten`= '{dp.Ten}', MoTa`= '{dp.MoTa}', NgaySuDung`= '{dp.NgaySuDung}', LichSu`= '{dp.LichSu}', TenQuan`= '{dp.TenQuan}', TrangThai`= '{dp.TrangThai}' where MaDuongPho = '{id}'";
            var result = mySqlCommand.ExecuteNonQuery();
            if (result == 1)
            {
                return true;
            }

            return false;
        }

        public bool Delete(string id)
        {
            var db = FindById(id);
            if (db == null)
            {
                return false;
            }

            var connection = ConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"Delete from duongpho where MaDuongPho = '{id}'";
            var result = mySqlCommand.ExecuteNonQuery();
            if (result == 1)
            {
                return true;
            }

            return false;
        }
    }
}