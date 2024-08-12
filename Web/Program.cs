using Core.DataManager;
using Core.GraphQL;
using Core.Interfaces;
using Core.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.json");

// Add services to the container.
builder.Services.AddDbContext<UserDbContext>(options =>
                    options.UseNpgsql(builder.Configuration.GetConnectionString("UserDbConnection")));

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();

builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IPositionService, PositionService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.MapGraphQL("/graphql");

app.Run();
