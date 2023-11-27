using Microsoft.EntityFrameworkCore;
using Model.Context;
using Model.Mapping;
using Model.Model;
using Repository.IRepo;
using Repository.Repo;
using Service.IService;
using Service.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<VanPhongPhamContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Myconn")));
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped<ISanPhamRepo, SanPhamRepo>();
builder.Services.AddScoped<ILoaiSanPhamRepo, LoaiSanPhamRepo>();
builder.Services.AddScoped<IDonHangRepo, DonHangRepo>();
builder.Services.AddScoped<INguoiDungRepo, NguoiDungRepo>();
builder.Services.AddScoped<IChiTietDonHangRepo, ChiTietDonHangRepo>();

builder.Services.AddScoped<INguoiDungService, NguoiDungService>();
builder.Services.AddScoped<ILoaiSanPhamService, LoaiSanPhamService>();
builder.Services.AddScoped<IDonHangService, DonHangService>();
builder.Services.AddScoped<IChiTietDonHangService, ChiTietDonHangService>();
builder.Services.AddScoped<ISanPhamService, SanPhamService>();
builder.Services.AddScoped<ICloudinaryService, CloudinaryService>();








var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
