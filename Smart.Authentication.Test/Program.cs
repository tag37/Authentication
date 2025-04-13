using Authentication;
using Authentication.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddHttpClient("httpClient", client =>
{
    client.BaseAddress = new Uri("http://httpbin.org");
    var bAuth = new BasicAuthenticator(new BasicAuthOptions
    {
        Username = "foo",
        Password = "bar"
    });

    client.AddAuthentication(bAuth);

});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
