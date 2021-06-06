using System.Collections.Generic;
using DuongsinhCs.entity;

public class DuongPhoModel
{
    private List<DuongPho> _listDuongPho = new List<DuongPho>();

    public List<DuongPho> FindAll()
    {
        return _listDuongPho;
    }

    public bool Save(DuongPho duongPho)
    {
        _listDuongPho.Add(duongPho);
        return true;
    }

    public DuongPho FindById(string id)
    {
        for (int i = 0; i < _listDuongPho.Count; i++)
        {
            var db = _listDuongPho[i];
            if (db.Ma==id)
            {
                return db;
            }
        }
        return null;
    }

    public bool Update(string id, DuongPho updateDuongPho)
    {
        DuongPho duongPho1 = FindById(id);
        if (duongPho1==null)
        {
            return false;
        }

        duongPho1.Ma = updateDuongPho.Ma;
        duongPho1.Ten = updateDuongPho.Ten;
        duongPho1.MoTa = updateDuongPho.MoTa;
        duongPho1.NgaySuDung = updateDuongPho.NgaySuDung;
        duongPho1.LichSu = updateDuongPho.LichSu;
        duongPho1.TenQuan = updateDuongPho.TenQuan;
        duongPho1.TrangThai = updateDuongPho.TrangThai;
        return true;
    }

    public bool Delete(string id)
    {
        DuongPho duongPho2 = FindById(id);
        if (duongPho2==null)
        {
            return false;
        }
        _listDuongPho.Remove(duongPho2);
        return true;
    }
}