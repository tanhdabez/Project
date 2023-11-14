using Microsoft.AspNetCore.Components.Forms;
using Project.DBConxtext;
using Project.Models;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;
using System.Text;

namespace Project.Services
{
    public class HocPhiService
    {
        private DbSet DbSet;
        public HocPhiService(DbSet dbSet)
        {
            DbSet = dbSet;
        }

        public dynamic tinhHocPhi(TimKiemHocPhi timkiem)
        {
            //var idLopHoc = DbSet.LopHocs.Select(x => x.Id == id).ToList();
            DateTime tungay = Definedata.UnixTimeStampToDateTime(timkiem.TuNgay);
            DateTime denngay = Definedata.UnixTimeStampToDateTime(timkiem.DenNgay);
            List<ListLichHoc> listThu = DbSet.ListLichHoc.Where(a => a.IdLopHoc == timkiem.IdLop).ToList();
            List<HocPhi_LopHoc_ChiTiet> listHocPhis = new List<HocPhi_LopHoc_ChiTiet>();
            List<TKB> listDataTKB = DbSet.TKB.Where(x => x.IdLop == timkiem.IdLop && tungay <= x.NgayHoc && denngay >= x.NgayHoc).ToList();
            List<TKB> listDaHoc = listDataTKB.Where(x => x.TrangThai == Definedata.eTrangThaiTKB.DAHOC.ToString()).ToList();
            DateTime time = tungay;
            int soBuoiDuKien = 0;
            int soBuoiTT = listDaHoc.Count;
            int soBuoiConlai = 0;
            while (time <= denngay)
            {
                int thu = (int)time.DayOfWeek;
                var check = listThu.Where(x => x.Thu == thu).ToList();
                soBuoiDuKien += check.Count;
                time = time.AddDays(1);
            }

            foreach (var item in listThu)
            {
                HocPhi_LopHoc_ChiTiet listHocPhi_LopHoc_ChiTiets = new HocPhi_LopHoc_ChiTiet();
                listHocPhi_LopHoc_ChiTiets.Id = Guid.NewGuid().ToString();
                listHocPhi_LopHoc_ChiTiets.IdLop = timkiem.IdLop;
                listHocPhi_LopHoc_ChiTiets.TuNgay = tungay;
                listHocPhi_LopHoc_ChiTiets.DenNgay = denngay;
                //listHocPhi_LopHoc_ChiTiets.BuoiDuKien = soBuoiDuKien;
                listHocPhi_LopHoc_ChiTiets.SoBuoiDaDong = timkiem.SoBuoiDaDong;
                listHocPhi_LopHoc_ChiTiets.SoBuoiThucTe = soBuoiTT;
                //..
                listHocPhis.Add(listHocPhi_LopHoc_ChiTiets);
            }
            DbSet.AddRange(listHocPhis);
            DbSet.SaveChanges();
            return listHocPhis;
            /// theo thoi khoá biểu
            //LopHocService lopHocService = new LopHocService();
            //lopHocService.addlisttkb(timkiem);
            //List<TKB> listTKBId = DbSet.TKBs.Where(x => x.IdLop == id && x.NgayHoc >= tungay && x.NgayHoc <= denngay).ToList();
            //SOBuoiDuKien = listTKBId.Count;
        }

        public dynamic SetNopHocPhiHocVien(HocPhi_HocVien entity)
        {
            try
            {
                List<HocPhi_LopHoc> listLopHoc_old = DbSet.HocPhi_LopHoc.Where(x => x.IdHocVien == entity.Id).ToList();
                if (listLopHoc_old != null && listLopHoc_old.Count > 0)
                    DbSet.RemoveRange(listLopHoc_old);
                List<HocPhi_LopHoc_ChiTiet> listLopHocCT_old = DbSet.HocPhi_LopHoc_ChiTiet.Where(x => x.IdHocVien != entity.Id).ToList();
                if (listLopHocCT_old != null && listLopHocCT_old.Count > 0)
                    DbSet.RemoveRange(listLopHocCT_old);
                if (entity.listLop != null && entity.listLop.Count > 0)
                {
                    List<HocPhi_LopHoc_ChiTiet> listCheck = entity.listLop.SelectMany(a => a.listChiTiet.Where(a => a.DaTinh == false && a.DaNop == true)).ToList();
                    //lưu ds đóng tiền
                    List<HocPhi_LopHoc_ChiTiet> listAdd = new List<HocPhi_LopHoc_ChiTiet>();
                    foreach (var item in entity.listLop)
                    {
                        item.Id = Guid.NewGuid().ToString();
                        if (item.listChiTiet != null && item.listChiTiet.Count > 0)
                        {
                            foreach (var obj in item.listChiTiet)
                            {
                                obj.Id = Guid.NewGuid().ToString();
                                if (obj.DaNop == true)
                                    obj.DaTinh = true;
                                obj.IdHocVien = entity.Id;
                                obj.IdLop = item.IdLopHoc;
                                obj.IdHocPhi = item.Id;
                            }
                            listAdd.AddRange(item.listChiTiet);
                        }
                    }
                    // tính số buổi còn lại
                    if (listCheck != null && listCheck.Count > 0)
                    {
                        List<string> listIdLop = listCheck.Select(x => x.IdLop).Distinct().ToList();
                        var soBuoiConLai = DbSet.BuoiConLai.Where(a => a.IdHocVien == entity.Id && listIdLop.Contains(a.IdLopHoc)).ToList();
                        foreach (var item in soBuoiConLai)
                        {
                            var chiTiet = listCheck.Where(a => a.IdLop == item.IdLopHoc).ToList();
                            if (chiTiet != null && chiTiet.Count > 0)
                            {
                                item.SoBuoiConLai += chiTiet.Sum(a => a.SoBuoiDaDong ?? 0);
                            }
                        }
                        DbSet.UpdateRange(soBuoiConLai);
                        DateTime time = listCheck.OrderByDescending(a => a.DenNgay).FirstOrDefault().DenNgay.Value;
                    }
                    DbSet.AddRange(entity.listLop);
                    if (listAdd != null && listAdd.Count > 0)
                    {
                        DbSet.AddRange(listAdd);
                        DbSet.SaveChanges();
                    }
                }
                return "thành công";
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.ToString();
            }
        }

        public Lop_SoBuoiConLai GetSoBuoiConLai(string IdLop, string IdHocVien, double TuNgay, double DenNgay)
        {
            DateTime tuNgay = Definedata.UnixTimeStampToDateTime(TuNgay);
            DateTime denNgay = Definedata.UnixTimeStampToDateTime(DenNgay);
            Lop_SoBuoiConLai sbcl = new Lop_SoBuoiConLai()
            {
                SobuoiDuKien = 0,
                SoBuoiConLaiKyTruoc = 0,
                SoBuoiThucTe = 0,
                TienThuaKyTruoc = 0,
                ThanhTienThucTe = 0
            };

        }
    }
}
