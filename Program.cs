using Microsoft.EntityFrameworkCore;
using DealershipAudi.Data;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddRazorPages();

// Configure the DealershipAudiContext for the main application database
builder.Services.AddDbContext<DealershipAudiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DealershipAudiContext")));

// Configure the LibraryIdentityContext for Identity
builder.Services.AddDbContext<LibraryIdentityContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LibraryIdentityContext")));

// Add Identity services
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
}).AddEntityFrameworkStores<LibraryIdentityContext>();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); // Enable authentication
app.UseAuthorization();  // Enable authorization

app.MapRazorPages();

app.Run();
