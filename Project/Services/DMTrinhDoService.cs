using Project.DBConxtext;
using Project.Models;

namespace Project.Services
{
    public class DMTrinhDoService
    {
        private DbSet dbSet;
        public DMTrinhDoService(DbSet dbSet)
        {
            dbSet = dbSet;
        }

        public dynamic showlistTrinhDo(Page page)
        {
            try
            {
                int PageSize = page.PageSize ?? 25;
                int CurrentPage = page.CurrentPage ?? 1;
                string Keyword = page.Keyword;
                IEnumerable<TrinhDo> result = from pk in dbSet.TrinhDo orderby pk.MaTrinhDo select pk;
                if (!string.IsNullOrEmpty(Keyword))
                    result = result.Where(a => a.MaTrinhDo.ToUpper().Contains(Keyword.ToUpper()) || a.MaTrinhDo.ToUpper().Contains(Keyword.ToUpper()));
                if (CurrentPage == 0)
                {
                    return result.ToList();
                }
                int totalRow = result.Count();
                result = result.OrderBy(r => r.MaTrinhDo).Skip(PageSize * (CurrentPage - 1)).Take(PageSize);
                var paginationSet = new Pagination<TrinhDo>()
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

        public string addTrinhDo(TrinhDo td)
        {
            try
            {
                TrinhDo trinhDo = dbSet.TrinhDo.FirstOrDefault(x => x.MaTrinhDo == td.MaTrinhDo && x.Id != td.Id);

                if (string.IsNullOrEmpty(td.Id))
                {
                    if (trinhDo != null) return "Đã tồn tại mã trình độ";
                    td.Id = Guid.NewGuid().ToString();
                    dbSet.Add(td);
                }
                else
                    if (trinhDo != null)
                {
                    if (td.Id != trinhDo.Id)
                    {
                        return "Đã tồn tại id trình độ";
                    }
                    dbSet.Update(td);
                }
                else
                    dbSet.Update(td);
                dbSet.SaveChanges();
                return "Thêm thành công";
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.ToString();
            }
        }

        public string dltTrinhDo(string id)
        {
            var result = new TrinhDo();
            { result.Id = id; }
            dbSet.TrinhDo.Remove(result);
            dbSet.SaveChanges();
            return "xóa thành công";
        }
    }
}
