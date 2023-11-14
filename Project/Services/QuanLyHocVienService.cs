using Project.DBConxtext;
using Project.Models;
using System.Runtime.CompilerServices;
using static Project.Models.Definedata;

namespace Project.Services
{
    public class QuanLyHocVienService
    {
        private DbSet DbSet;
        public QuanLyHocVienService(DbSet dbSet)
        {
            DbSet = dbSet;
        }

        public dynamic findIdHocVien(string id)
        {
            var showHocVienInfo = from hv in DbSet.HocVien
                                  join lh in DbSet.LopHoc on hv.Id equals lh.IdHocVien
                                  where lh.IdHocVien == id
                                  select new HocVienViewModels
                                  {
                                      IdHocVien = hv.Id,
                                      TenHocVien = hv.TenHocVien,
                                      GioiTinh = hv.GioiTinh,
                                      NgaySinh = hv.NgaySinh,
                                      SDT = hv.SDT,
                                      Email = hv.Email,
                                      DiaChi = hv.DiaChi,
                                      TrangThai = hv.TrangThai,
                                      IdLopHoc = lh.Id,
                                      IdCaHoc = lh.IdCaHoc,
                                      IdMonHoc = lh.IdMonHoc,
                                      IdPhongHoc = lh.IdPhongHoc,
                                      IdGVien = lh.IdGVien,
                                  };
                                  
            return showHocVienInfo;
        }
        public dynamic showlistHocVien(Page page)
        {
            try
            {
                int PageSize = page.PageSize ?? 25;
                int CurrentPage = page.CurrentPage ?? 1;
                string Keyword = page.Keyword;
                IEnumerable<HocVien> result = from pk in DbSet.HocVien orderby pk.MaHocVien select pk;
                if (!string.IsNullOrEmpty(Keyword))
                    result = result.Where(a => a.MaHocVien.ToUpper().Contains(Keyword.ToUpper()) || a.TenHocVien.ToUpper().Contains(Keyword.ToUpper()));
                if (CurrentPage == 0)
                {
                    return result.ToList();
                }
                int totalRow = result.Count();
                result = result.OrderBy(r => r.MaHocVien).Skip(PageSize * (CurrentPage - 1)).Take(PageSize);
                var paginationSet = new Pagination<HocVien>()
                {
                    Items = result.ToList(),
                    Page = CurrentPage,
                    TotalCount = totalRow,
                    PageSize = PageSize
                };
                return paginationSet;
            }
            catch (Exception ex)
            {

                return "Lỗi: " + ex.ToString();
            }
        }
        public string addHocVien(HocVien hv)
        {
            try
            {
                HocVien hocVien = DbSet.HocVien.FirstOrDefault(x => x.MaHocVien == hv.MaHocVien);
                List<LopHocVien> lopHocVien = new List<LopHocVien>();
                List<LopHoc> lopHoc = DbSet.LopHoc.Where(x=>x.IdHocVien == hv.Id).ToList();
                if (string.IsNullOrEmpty(hv.Id))
                {
                    if (hocVien != null) return "Đã tồn tại mã học viên";
                    hv.Id = Guid.NewGuid().ToString();
                    DbSet.HocVien.Add(hv);
                }
                else DbSet.HocVien.Update(hv);
                var listLopHocVien = DbSet.LopHocVien.Where(a => a.IdHocVien == hv.Id).ToList();
                if (hv.lopHocVien != null)
                {
                    foreach (var item in lopHocVien)
                    {
                        item.Id = Guid.NewGuid().ToString();
                        item.IdHocVien = hv.Id;
                    }
                    DbSet.AddRange(hv.lopHocVien);
                }
                DbSet.SaveChanges();
                return "Thêm thành công";

            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.ToString();
            }
        }

        //public CheckIfUsed FunccheckIfUsed(List<string> id)
        //{
        //    CheckIfUsed cis = new CheckIfUsed();
        //    List<string> idUsed = new List<string>();
        //    cis.isUsed = false;
        //    var listId = DbSet.LopHocs.Where(x=>id.Contains(x.Id)).ToList();
        //}
        public string deleteHocVien(string id)
        {
            var result = new HocVien();
            { result.Id = id; }
            DbSet.HocVien.Remove(result);
            DbSet.SaveChanges();
            return "xóa thành công";
        }
    }
}
