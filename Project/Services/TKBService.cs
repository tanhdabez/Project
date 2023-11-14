using Project.DBConxtext;
using Project.Models;

namespace Project.Services
{
    public class TKBService
    {
        private DbSet dbset;
        public TKBService(DbSet dbSet)
        {
            dbset = dbSet;
        }

        public dynamic findTKBbyDay(TimKiemThoiKhoaBieu timkiem)
        {
            DateTime denngay = new DateTime();
            DateTime tungay = new DateTime();
            if (timkiem.TuNgay > 0)
            {
                tungay = Definedata.UnixTimeStampToDateTime(timkiem.TuNgay);
            }
            if (timkiem.DenNgay > 0)
            {
                denngay = Definedata.UnixTimeStampToDateTime(timkiem.DenNgay);
            }
            var data = dbset.TKB.Where(x => (timkiem.TuNgay == 0 || x.NgayHoc >= tungay) && (timkiem.DenNgay == 0 || x.NgayHoc <= denngay)).ToList();
            return data;
        }

        public dynamic findtkb(TimKiemThoiKhoaBieu timkiem)
        {
            DateTime denngay = new DateTime();
            DateTime tungay = new DateTime();
            var str = addlisttkb(timkiem);
            var record = from tkb in dbset.TKB
                         join gv in dbset.GiaoVien on tkb.IdGVien equals gv.Id
                         join lh in dbset.LopHoc on tkb.IdLop equals lh.Id
                         where (string.IsNullOrEmpty(timkiem.IdGiaoVien) || gv.Id == timkiem.IdGiaoVien)
                         && (string.IsNullOrEmpty(timkiem.IdLop) || lh.Id == timkiem.IdLop)
                         select tkb;

            if (timkiem.TuNgay > 0)
            {
                tungay = Definedata.UnixTimeStampToDateTime(timkiem.TuNgay);
                record = record.Where(a => a.NgayHoc >= tungay);
            }
            if (timkiem.DenNgay > 0)
            {
                denngay = Definedata.UnixTimeStampToDateTime(timkiem.DenNgay);
                record = record.Where(a => a.NgayHoc <= denngay);
            }
            if (!string.IsNullOrEmpty(timkiem.IdHocVien))
            {
                var lop_hv = dbset.LopHocVien.Where(a => a.IdHocVien == timkiem.IdHocVien);
                List<string> IdLops = lop_hv.Select(a => a.IdLop).Distinct().ToList();
                record = record.Where(a => IdLops.Contains(a.IdLop));
            }
            return record.ToList();
        }



        public dynamic addTKB(TKB tkb)
        {
            //TKB tkb = JsonConvert.DeserializeObject<TKB>(thoigianbieu.ToString());
            try
            {
                TKB thoikhoabieu = dbset.TKB.FirstOrDefault(x => x.Id != tkb.Id);
                //if (thoikhoabieu.NgayHocUnix > 0)
                //    thoikhoabieu.NgayHoc = UnixTimeStampToDateTime(thoikhoabieu.NgayHocUnix);
                if (string.IsNullOrEmpty(tkb.Id))
                {
                    tkb.Id = Guid.NewGuid().ToString();
                    dbset.Add(tkb);
                }
                else
                    dbset.Update(tkb);
                dbset.SaveChanges();
                return "Thêm thành công";
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.ToString();
            }
        }

        public dynamic dltTKB(string id)
        {
            var result = new TKB();
            { result.Id = id; }
            dbset.TKB.Remove(result);
            dbset.SaveChanges();
            return "xóa thành công";
        }
        public dynamic addlisttkb(TimKiemThoiKhoaBieu timkiem)
        {
            //List<LopHoc> listLopHoc = DbSet.LopHoc.Where(x => x.TrangThai == Definedata.eTrangThaiThaiLopHoc.DANGHOC.ToString()).ToList();
            List<LopHoc> listLopHoc = dbset.LopHoc.ToList();
            var listIdlophoc = listLopHoc.Select(a => a.Id).Distinct().ToList();
            List<ListLichHoc> listLichHoc = dbset.ListLichHoc.Where(a => listIdlophoc.Contains(a.IdLopHoc)).ToList();
            List<TKB> listThoiKhoaBieu = new List<TKB>();

            DateTime tungay = Definedata.UnixTimeStampToDateTime(timkiem.TuNgay);
            DateTime denngay = Definedata.UnixTimeStampToDateTime(timkiem.DenNgay);
            var TKBGN = dbset.TKB.OrderBy(x => x.NgayHoc).LastOrDefault();///
            foreach (var itemlophoc in listLopHoc)
            {
                var LichHoc = listLichHoc.Where(a => a.IdLopHoc == itemlophoc.Id).ToList();
                if (LichHoc != null)
                    foreach (var itemlichhoc in LichHoc)
                    {
                        DateTime? NgayDaTao = itemlophoc.NgayBatDau;
                        if (TKBGN != null)
                            NgayDaTao = TKBGN.NgayHoc;
                        DateTime time = tungay;
                        if (time < NgayDaTao)
                            time = NgayDaTao.Value.AddDays(1);
                        while (time <= denngay)
                        {
                            if (time.DayOfWeek.ToString() == Definedata.QuyDoiThuTA(itemlichhoc.Thu ?? 0))
                            {
                                TKB tkbAdd = new TKB();
                                tkbAdd.Id = Guid.NewGuid().ToString();
                                tkbAdd.IdLop = itemlophoc.Id;
                                tkbAdd.IdCaHoc = itemlophoc.IdCaHoc;
                                tkbAdd.IdGVien = itemlophoc.IdGVien;
                                tkbAdd.IdPhongHoc = itemlophoc.IdPhongHoc;
                                tkbAdd.IdMonHoc = itemlophoc.IdMonHoc;
                                tkbAdd.NgayHoc = time;
                                listThoiKhoaBieu.Add(tkbAdd);
                            }
                            time = time.AddDays(1);
                        }
                    }
            }
            dbset.AddRange(listThoiKhoaBieu);
            dbset.SaveChanges();
            return timkiem;
        }

    }
}
