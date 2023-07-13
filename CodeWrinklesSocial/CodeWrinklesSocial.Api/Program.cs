
using CodeWrinklesSocial.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.ResterServices(typeof(Program)); 

var app = builder.Build();

app.RegisterPipelineComponents(typeof(Program));

app.Run();
