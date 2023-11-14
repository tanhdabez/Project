using Project.DBConxtext;
using Project.Models;

namespace Project.Services
{
    public class CaHocService
    {
        private DbSet dbset;
        public CaHocService(DbSet dbSet)
        {
            dbset = dbSet;
        }
        public string addCaHoc(CaHoc ch)
        {
            try
            {
                CaHoc caHoc = dbset.CaHoc.FirstOrDefault(x => x.Id != ch.Id);

                if (string.IsNullOrEmpty(ch.Id))
                {
                    ch.Id = Guid.NewGuid().ToString();
                    dbset.Add(ch);
                }
                else
                    if (caHoc != null)
                {
                    if (ch.Id != caHoc.Id)
                    {
                        return "Đã tồn tại id ca Học";
                    }
                    dbset.Update(ch);
                }
                else
                    dbset.Update(ch);
                dbset.SaveChanges();
                return "Thêm thành công";
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.ToString();
            }
        }
    }
}
