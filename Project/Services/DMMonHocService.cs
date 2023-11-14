using Project.DBConxtext;
using Project.Models;

namespace Project.Services
{
    public class DMMonHocService
    {
        private DbSet DbSet;
        public DMMonHocService(DbSet dbSet)
        {
            DbSet = dbSet;
        }

        public dynamic showListMonHoc(Page page)
        {
            try
            {
                int PageSize = page.PageSize ?? 25;
                int CurrentPage = page.CurrentPage ?? 1;
                string Keyword = page.Keyword;
                IEnumerable<MonHoc> result = from pk in DbSet.MonHoc orderby pk.MaMonHoc select pk;
                if (!string.IsNullOrEmpty(Keyword))
                    result = result.Where(a => a.MaMonHoc.ToUpper().Contains(Keyword.ToUpper()) || a.TenMonHoc.ToUpper().Contains(Keyword.ToUpper()));
                if (CurrentPage == 0)
                {
                    return result.ToList();
                }
                int totalRow = result.Count();
                result = result.OrderBy(r => r.MaMonHoc).Skip(PageSize * (CurrentPage - 1)).Take(PageSize);
                var paginationSet = new Pagination<MonHoc>()
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
        public string addMonHoc(MonHoc mh)
        {
            try
            {
                MonHoc monHoc = DbSet.MonHoc.FirstOrDefault(x => x.MaMonHoc == mh.MaMonHoc && x.Id != mh.Id);

                if (string.IsNullOrEmpty(mh.Id))
                {
                    if (monHoc != null) return "Đã tồn tại id môn học";
                    mh.Id = Guid.NewGuid().ToString();
                    DbSet.Add(mh);
                }
                else
                    if (monHoc != null)
                {
                    if (mh.Id != monHoc.Id)
                    {
                        return "Đã tồn tại id môn học";
                    }
                    DbSet.Update(mh);
                }
                else
                    DbSet.Update(mh);
                DbSet.SaveChanges();
                return "Thêm thành công";
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.ToString();
            }
        }

        public string deleteMonHoc(string id)
        {
            var result = new MonHoc();
            { result.Id = id; }
            DbSet.MonHoc.Remove(result);
            DbSet.SaveChanges();
            return "xóa thành công";
        }
    }
}
