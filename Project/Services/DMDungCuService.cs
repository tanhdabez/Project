using Project.DBConxtext;
using Project.Models;

namespace Project.Services
{
    public class DMDungCuService
    {
        private DbSet dbset;
        public DMDungCuService(DbSet dbSet)
        {
            dbset = dbSet;
        }

        public dynamic showlistDungCu(Page page)
        {
            try
            {
                int PageSize = page.PageSize ?? 25;
                int CurrentPage = page.CurrentPage ?? 1;
                string Keyword = page.Keyword;
                IEnumerable<DungCu> result = from pk in dbset.DungCu orderby pk.MaDungCu select pk;
                if (!string.IsNullOrEmpty(Keyword))
                    result = result.Where(a => a.MaDungCu.ToUpper().Contains(Keyword.ToUpper()) || a.MaDungCu.ToUpper().Contains(Keyword.ToUpper()));
                if (CurrentPage == 0)
                {
                    return result.ToList();
                }
                int totalRow = result.Count();
                result = result.OrderBy(r => r.MaDungCu).Skip(PageSize * (CurrentPage - 1)).Take(PageSize);
                var paginationSet = new Pagination<DungCu>()
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
        public string addDungCu(DungCu dc)
        {
            try
            {
                DungCu dungCu = dbset.DungCu.FirstOrDefault(x => x.MaDungCu == dc.MaDungCu && x.Id != dc.Id);

                if (string.IsNullOrEmpty(dc.Id))
                {
                    if (dungCu != null) return "Đã tồn tại mã Dụng Cụ";
                    dc.Id = Guid.NewGuid().ToString();
                    dbset.Add(dc);
                }
                else
                    if (dungCu != null)
                {
                    if (dc.Id != dungCu.Id)
                    {
                        return "Đã tồn tại id Dụng Cụ";
                    }
                    dbset.Update(dc);
                }
                else
                    dbset.Update(dc);
                dbset.SaveChanges();
                return "Thêm thành công";
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.ToString();
            }
        }

        public string dltDungCu(string id)
        {
            var result = new DungCu();
            { result.Id = id; }
            dbset.DungCu.Remove(result);
            dbset.SaveChanges();
            return "xóa thành công";
        }
    }
}
