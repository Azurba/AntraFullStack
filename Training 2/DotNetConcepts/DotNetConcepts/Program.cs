using DotNetConcepts.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.Use(async (context, next) =>
{
    await next();
    await context.Response.WriteAsync("THIRD: FHSADJFHSADKF");
});

app.Use(async (context, next) =>
{
    if (context.Request.Method == HttpMethods.Get)
    {
        context.Response.ContentType = "text/html";
        await context.Response.WriteAsync("FIRST: Custom Middleware \n");
    }
    await next();
});

//app.UseMiddleware<QueryStringMiddleware>();

app.Use(async (context, next) =>
{
    await next();
    await context.Response.WriteAsync("SECOND: Hello World. Status Code: " + context.Response.StatusCode + "\n");

});


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//This is the last middleware before going back to the response 
app.Run();
