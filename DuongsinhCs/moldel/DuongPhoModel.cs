using System.Collections.Generic;
using DuongsinhCs.entity;
using MySql.Data.MySqlClient;
using StreetCRUD.model;
using StreetCRUD.Helper;

namespace StreetCRUD.model
{
    public class DuongPhoModel
    {
        public bool Save(DuongPho duongPho)
        {
            var connection = ConnectionHelper.GetConnection();
            connection.Open();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"INSERT INTO duongphos (Ma,Ten,MoTa,NgaySuDung,LichSu,TrangThai) " +
                                       $"VALUES ('{duongPho.Ma}', '{duongPho.Ten}', '{duongPho.MoTa}', '{duongPho.NgaySuDung}', '{duongPho.TenQuan}', {duongPho.TrangThai})";
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
            var listDuongPho = new List<DuongPho>();
            return listDuongPho;
        }
        public DuongPho FindById(string id)
        {
            return null;
        }
        public void Update(string id,DuongPho updateDuongPhoe)
        {
            
        }
        public void Delete()
        {
            
        }
    }
}