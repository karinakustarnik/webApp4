using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddAntiforgery(options => options.SuppressXFrameOptionsHeader = true); ;

builder.Services.AddRazorPages().AddRazorPagesOptions(x
    => x.Conventions
    .ConfigureFilter(new IgnoreAntiforgeryTokenAttribute())).AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();

app.Run();
