using LearnEnglish.Models;
using LearnEnglish.Services;
using Microsoft.EntityFrameworkCore;
using LearnEnglish.Functions;

var builder = WebApplication.CreateBuilder(args);

//Add services to the container.
string connectionString = Vault.GetSecretPhrase("ConnectionStrings");
builder.Services.AddDbContext<EnglishDBContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddRazorPages();
builder.Services.AddTransient<TaskService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
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
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.MapRazorPages();

app.Run();
