var builder = WebApplication.CreateBuilder(args);

// Make the app listen on port 80 inside the Docker container
builder.WebHost.UseUrls("http://*:80");

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
    // app.UseHttpsRedirection(); // Disabled for Docker, since SSL is not configured inside the container
}

app.UseStaticFiles(); // Serve static content (CSS, JS, images)

app.UseRouting();

app.UseAuthorization();

// Define default MVC route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
