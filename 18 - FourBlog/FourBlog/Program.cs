using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using FourBlog.Areas.Identity.Data;
using FourBlog.Repositories;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("FourBlogContextConnection") ?? throw new InvalidOperationException("Connection string 'FourBlogContextConnection' not found.");

builder.Services.AddDbContext<FourBlogContext>(options =>
    options.UseSqlServer(connectionString));;

builder.Services.AddDefaultIdentity<Usuario>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<FourBlogContext>();;

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ITagRepository, TagRepository>();
builder.Services.AddScoped<IPostagemRepository, PostagemRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.MapRazorPages();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
