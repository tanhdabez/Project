using Project.DBConxtext;
using Project.Models;

namespace Project.Services
{
    public class DMPhongHocService
    {
        private DbSet dbset;
        public DMPhongHocService(DbSet dbSet)
        {
            dbset = dbSet;
        }

        public dynamic showlistPhongHoc(Page page)
        {
            try
            {
                int PageSize = page.PageSize ?? 25;
                int CurrentPage = page.CurrentPage ?? 1;
                string Keyword = page.Keyword;
                IEnumerable<PhongHoc> result = from pk in dbset.PhongHoc orderby pk.MaPhongHoc select pk;
                if (!string.IsNullOrEmpty(Keyword))
                    result = result.Where(a => a.MaPhongHoc.ToUpper().Contains(Keyword.ToUpper()) || a.MaPhongHoc.ToUpper().Contains(Keyword.ToUpper()));
                if (CurrentPage == 0)
                {
                    return result.ToList();
                }
                int totalRow = result.Count();
                result = result.OrderBy(r => r.MaPhongHoc).Skip(PageSize * (CurrentPage - 1)).Take(PageSize);
                var paginationSet = new Pagination<PhongHoc>()
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
        public string addPhongHoc(PhongHoc ph)
        {
            try
            {
                PhongHoc phongHoc = dbset.PhongHoc.FirstOrDefault(x => x.MaPhongHoc == ph.MaPhongHoc && x.Id != ph.Id);

                if (string.IsNullOrEmpty(ph.Id))
                {
                    if (phongHoc != null) return "Đã tồn tại mã phòng";
                    ph.Id = Guid.NewGuid().ToString();
                    dbset.Add(ph);
                }
                else
                dbset.Update(ph);
                var dungcuPhongHoc = dbset.DungCuPhong.Where(a => a.IdPhongHoc == ph.Id).ToList();
                dbset.RemoveRange(dungcuPhongHoc);
                if (ph.DungCuPhongs != null)
                {
                    List<DungCuPhongHoc> listAdd = new List<DungCuPhongHoc>();
                    foreach (var item in ph.DungCuPhongs)
                    {
                        item.Id = Guid.NewGuid().ToString();
                        item.IdPhongHoc = ph.Id;
                        listAdd.Add(item);
                    }
                    dbset.AddRange(listAdd);
                }
                dbset.SaveChanges();
                return "Thêm thành công";

            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.ToString();
            }
        }

        public string dltPhongHoc(string id)
        {
            var result = new PhongHoc();
            { result.Id = id; }
            dbset.PhongHoc.Remove(result);
            dbset.SaveChanges();
            return "xóa thành công";
        }
    }
}
