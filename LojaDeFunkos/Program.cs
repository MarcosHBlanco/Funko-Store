using LojaDeFunkos.Data;
using LojaDeFunkos.Serviços;
using Microsoft.EntityFrameworkCore;
using FunkoServico = LojaDeFunkos.Serviços.Data.FunkoServico;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
//var connectionString = builder.Configuration.GetConnectionString("FunkoDbContextConnection") ?? throw new InvalidOperationException("Connection string 'FunkoDbContextConnection' not found.");

// Add services to the container.
builder.Services.AddRazorPages(options => {
                                    options.Conventions.AuthorizeFolder("/Marcas");
                                    options.Conventions.AuthorizeFolder("/Universos");
                                });
builder.Services.AddTransient<IFunkoServico, FunkoServico>();
builder.Services.AddDbContext<FunkoDbContext>();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<FunkoDbContext>();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 3;

    options.Lockout.MaxFailedAccessAttempts = 15;
    options.Lockout.AllowedForNewUsers = true;

    options.User.RequireUniqueEmail = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

var context = new FunkoDbContext();
context.Database.Migrate();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
