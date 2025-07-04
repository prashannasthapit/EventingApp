using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// specification, structure
// generate documentation
builder.Services.AddOpenApi();

// ^ Service registration w dependency injection

var app = builder.Build();

// v Middleware registration
// request processing pipeline

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference("/api-reference",
        options => { options.WithTheme(ScalarTheme.Mars); });
}

app.MapControllers();

app.Run();