namespace Project.Services
{
    public class Page
    {
        public int? CurrentPage { get; set; } = 1;
        public int? PageSize { get; set; } = 25;
        public string Keyword { get; set; } = "";
    }
}
