using LearnEnglish.Models;
using LearnEnglish.Services;
using Microsoft.EntityFrameworkCore;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

var builder = WebApplication.CreateBuilder(args);

//var keyVaultEndpoint = new Uri(("https://bigsecrets.vault.azure.net/"));
//builder.Configuration.AddAzureKeyVault(keyVaultEndpoint, new DefaultAzureCredential());

//Add services to the container.
const string keyVaultUrl = "https://bigsecrets.vault.azure.net/";
var credential = new DefaultAzureCredential();
var client = new SecretClient(vaultUri: new Uri(keyVaultUrl), credential);
KeyVaultSecret secret = client.GetSecret("english");

builder.Services.AddDbContext<EnglishDBContext>(options => options.UseSqlServer(secret.Value));
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
