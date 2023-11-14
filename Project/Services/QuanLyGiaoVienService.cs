using Project.DBConxtext;
using Project.Models;

namespace Project.Services
{
    public class QuanLyGiaoVienService
    {
        private DbSet DbSet;
        public QuanLyGiaoVienService(DbSet dbSet)
        {
            DbSet = dbSet;
        }

        public dynamic showlistGiaoVien(Page page)
        {
            try
            {
                int PageSize = page.PageSize ?? 25;
                int CurrentPage = page.CurrentPage ?? 1;
                string Keyword = page.Keyword;
                IEnumerable<GiaoVien> result = from pk in DbSet.GiaoVien orderby pk.MaGiaoVien select pk;
                if (!string.IsNullOrEmpty(Keyword))
                    result = result.Where(a => a.MaGiaoVien.ToUpper().Contains(Keyword.ToUpper()) || a.TenGV.ToUpper().Contains(Keyword.ToUpper()));
                if (CurrentPage == 0)
                {
                    return result.ToList();
                }
                int totalRow = result.Count();
                result = result.OrderBy(r => r.MaGiaoVien).Skip(PageSize * (CurrentPage - 1)).Take(PageSize);
                var paginationSet = new Pagination<GiaoVien>()
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
        public string addGVien(GiaoVien gv)
        {
            //GiaoVien gv = JsonConvert.DeserializeObject<GiaoVien>(dyn.ToString());
            GiaoVien giaoVien = DbSet.GiaoVien.FirstOrDefault(x => x.MaGiaoVien == gv.MaGiaoVien && x.Id != gv.Id);
            if (giaoVien != null) return "Đã tồn tại mã giáo viên";
            if (string.IsNullOrEmpty(gv.Id))
            {
                
                gv.Id = Guid.NewGuid().ToString();
                DbSet.GiaoVien.Add(gv);
            }
            else
                DbSet.Update(gv);
            var listDonGia = DbSet.ListDonGia.Where(a => a.IdGVien == gv.Id).ToList();
            DbSet.RemoveRange(listDonGia);
            if (gv.ListDonGias != null)
            {
                foreach (var item in gv.ListDonGias)
                {
                    item.Id = Guid.NewGuid().ToString();
                    item.IdGVien = gv.Id;
                }
                DbSet.AddRange(gv.ListDonGias);
            }
            DbSet.SaveChanges();
            return "Thêm thành công";

        }

        public string dltGiaoVien(string id)
        {
            var result = new GiaoVien();
            { result.Id = id; }
            DbSet.GiaoVien.Remove(result);
            DbSet.SaveChanges();
            return "xóa thành công";
        }
    }
}
