var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //Relier les vues aux controleurs

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
 name: "default",
 pattern: "{controller=Home}/{action=Index}/{numero?}"
);

app.MapControllerRoute(
 name: "default",
 //pattern: structure de l'url : peut contenir le contr�leur,
 //la m�thode d'action et les param�tres
 pattern: "/{numero}",
 //defaults : indiquer le contr�ler et la m�thode d'action par d�faut.
 defaults: new { controller = "Home", action = "Chercher" }
);

app.Run();
