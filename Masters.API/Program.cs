using Masters.DOMAIN.Interfaces;
using Masters.SERVICES.Services.BLL;
using Masters.SERVICES.Services.DAL;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

RefitConfiguation(builder);
IdependencyInjections(builder);

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
    // Inject The Uri at IClientApiService
    builder.Services.AddHttpClient<IClientApiService>(options =>
    {
        options.BaseAddress = new Uri("https://interview.adpeai.com/");
    }).AddTypedClient(RestService.For<IClientApiService>);
    return builder;
}


//Idependency Injections
WebApplicationBuilder IdependencyInjections(WebApplicationBuilder builder)
{
    builder.Services.AddScoped<ITaskService, TaskService>(); // Add Injection of Interface TaskService
    return builder;
}