using Bookstore.BusinessLogic;
using Bookstore.Data;
using Bookstore.DataAccess;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IBookBll, BookBll>();
builder.Services.AddScoped<IBookDal, BookDal>();
builder.Services.AddScoped<IClientBll, ClientBll>();
builder.Services.AddScoped<IClientDal, ClientDal>();
builder.Services.AddScoped<IOrderedBookBll, OrderedBookBll>();
builder.Services.AddScoped<IOrderedBookDal, OrderedBookDal>();
builder.Services.AddScoped<ISoldBookBll, SoldBookBll>();
builder.Services.AddScoped<ISoldBookDal, SoldBookDal>();
builder.Services.AddScoped<IWarehouseBll, WarehouseBll>();

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
