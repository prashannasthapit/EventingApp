using EventingApp.ApiService.Data;
using EventingApp.ApiService.Data.Entities;
using EventingApp.ApiService.Data.Seeders;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

builder.Services.AddControllers();

builder.AddNpgsqlDbContext<EventingDbContext>("eventing-db",
    configureDbContextOptions: options =>
    {
        options.UseAsyncSeeding(async (context, _, cancellationToken) =>
        {
            await UsersSeeder.SeedAsync(context, cancellationToken);
            await EventsSeeder.SeedAsync(context, cancellationToken);
        });
    });

builder.Services.AddIdentity<User, IdentityRole<Guid>>()
    .AddEntityFrameworkStores<EventingDbContext>()
    .AddDefaultTokenProviders()
    .AddApiEndpoints();

builder.Services.AddAuthentication().AddJwtBearer();

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

    app.MapPost("/migrate-db", (EventingDbContext dbContext) => dbContext.Database.MigrateAsync());
        
    // app.MapScalarApiReference("/api-reference",
    //     options => { options.WithTheme(ScalarTheme.Mars); });

    app.MapScalarApiReference();
}

app.UseAuthentication();

app.UseAuthorization();

app.MapIdentityApi<User>()/*.WithGroupName("Account")*/;

app.MapControllers();

app.Run();