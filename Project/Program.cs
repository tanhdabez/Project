using Microsoft.EntityFrameworkCore;
using Project.DBConxtext;
using Project.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
// Add services to the container.
builder.Services.AddDbContext<DbSet>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("MyConnectionString")));
builder.Services.AddScoped<DbSet>();
builder.Services.AddScoped<DMDungCuService>();
builder.Services.AddScoped<DMTrinhDoService>();
builder.Services.AddScoped<DMMonHocService>();
builder.Services.AddScoped<DMPhongHocService>();
builder.Services.AddScoped<HocPhiService>();
builder.Services.AddScoped<QuanLyGiaoVienService>();
builder.Services.AddScoped<QuanLyHocVienService>();
builder.Services.AddScoped<LopHocService>();
builder.Services.AddScoped<CaHocService>();
builder.Services.AddScoped<TKBService>();
builder.Services.AddControllers().AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNamingPolicy = null);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
