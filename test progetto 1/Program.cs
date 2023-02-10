var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();//SI CARICANO  vIEWS 

var app = builder.Build();//SI CREA UNA ZONA SULLA RAM NELLA QUALE VERRANNO CARICATI TUTTI I COMPONENTI DEL NOSTRO SITO

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
}

app.UseStaticFiles();
app.UseRouting();//SI INTENDE LA NAVIGAZIONE TRA PAGINE E IL "COSA FARE QUANDO C'ARRIVA UNA DETERMINATA CHIAMATA" quindi a quale controller gigirare la richiesta

//mapping-> associare informazioni secondo una logica precisa
//controller-> è un punto d'ingresso nel quale posso inserire più action il punto di controllo deve essere reltivo a un unica entità
//entità-> tutto ciò che è relativo a un unico agglomerato d'informazioni/azioni pensare a una classe persona che ha metodi e attributi
//action sono le azioni che possiamo fare su quell'entità: le action quando si parla di controller si riferiscono alle action http
/* 
   GET the GET method requests a representation of the specified resource. Requests using GET should only retrieve data.
   POST The POST method submits an entity to the specified resource, often causing a change in state or side effects on the server.
   PUT The PUT method replaces all current representations of the target resource with the request payload.
   DELETE The DELETE method deletes the specified resource.
   PATCH The PATCH method applies partial modifications to a resource.
*/
//https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods
app.MapControllerRoute(//qua andiamo a fare il mapping dei controller con le loro action
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();//avviamo il sito
