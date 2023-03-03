using Masters.SERVICES.BLL;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

RefitConfiguation(builder);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();


// Refit Configration
WebApplicationBuilder RefitConfiguation(WebApplicationBuilder builder)
{
    builder.Services.AddHttpClient<IClientApiService>(options =>
    {
        options.BaseAddress = new Uri("https://interview.adpeai.com/");
    }).AddTypedClient(RestService.For<IClientApiService>);
    return builder;
}
