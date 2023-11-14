using Project.DBConxtext;
using Project.Models;

namespace Project.Services
{
    public class LopHocService
    {
        private DbSet DbSet;
        private readonly TKBService _TKBService;
        public LopHocService()
        { }
        public LopHocService(DbSet dbSet, TKBService tKBService)
        {
            DbSet = dbSet;
            _TKBService = tKBService;
        }
        public dynamic showlistLopHoc(Page page)
        {
            try
            {
                int PageSize = page.PageSize ?? 25;
                int CurrentPage = page.CurrentPage ?? 1;
                string Keyword = page.Keyword;
                IEnumerable<LopHoc> result = from pk in DbSet.LopHoc orderby pk.MaLopHoc select pk;
                if (!string.IsNullOrEmpty(Keyword))
                    result = result.Where(a => a.MaLopHoc.ToUpper().Contains(Keyword.ToUpper()));
                if (CurrentPage == 0)
                {
                    return result.ToList();
                }
                int totalRow = result.Count();
                result = result.OrderBy(r => r.MaLopHoc).Skip(PageSize * (CurrentPage - 1)).Take(PageSize);
                var paginationSet = new Pagination<LopHoc>()
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
        public string setLopHoc(LopHoc lh)
        {
            try
            {
                LopHoc lopHoc = DbSet.LopHoc.FirstOrDefault(x => x.MaLopHoc == lh.MaLopHoc && x.Id != lh.Id);
                if (lopHoc != null) return "đã tồn tại mã lớp học";
                if (string.IsNullOrEmpty(lh.Id))
                {
                    lh.Id = Guid.NewGuid().ToString();
                    DbSet.LopHoc.Add(lh);
                }
                else DbSet.LopHoc.Update(lh);
                var listlichhoc = DbSet.ListLichHoc.Where(a => a.IdLopHoc == lh.Id).ToList();
                if (lh.ListLichHocs != null)
                {
                    foreach (var item in lh.ListLichHocs)
                    {
                        item.Id = Guid.NewGuid().ToString();
                        item.IdLopHoc = lh.Id;
                    }
                    DbSet.AddRange(lh.ListLichHocs);
                }
                DbSet.SaveChanges();
                return "Thêm thành công";
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.ToString();
            }
        }

       

        public string dltLopHoc(string id)
        {
            var result = new LopHoc();
            { result.Id = id; }
            DbSet.LopHoc.Remove(result);
            DbSet.SaveChanges();
            return "xóa thành công";
        }


    }
}
