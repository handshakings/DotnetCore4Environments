
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}





app.Run(async (context) =>
{
    //You can set environment variable in launchsetting.json
    //You can set your own custom environment instead of Development,Production and Staging
    if (app.Environment.IsDevelopment())
    {
        await context.Response.WriteAsync(app.Environment.EnvironmentName);
    }
    else if (app.Environment.IsProduction())
    {
        await context.Response.WriteAsync(app.Environment.EnvironmentName);
    }
    else if (app.Environment.IsStaging())
    {
        await context.Response.WriteAsync(app.Environment.EnvironmentName);
    }
    else
    {
        await context.Response.WriteAsync(app.Environment.EnvironmentName);
    }
});





app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
