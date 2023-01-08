using DotNetWebApiFilter.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(option =>
{
    option.Filters.Add<LoggingFilter>();
    option.Filters.Add<LoggingAsyncFilter>();
    option.Filters.Add<ExceptionFilter>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
