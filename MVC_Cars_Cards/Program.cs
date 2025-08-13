using MVC_Cars_Cards.DataBase;

//TODO:     BUILDER
var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllersWithViews();
    builder.Services.AddScoped<DataBase>();
}
//TODO:     APP
var app = builder.Build();
{
    app.UseStaticFiles();
    app.MapControllerRoute("default", "{controller}/{action}/{id?}");
    app.Run();
}