
using FootBall.API.Context;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string connection = "FootBallDB";

builder.Services.AddDbContext<UserContext>(opt => opt.UseSqlServer(connection));

builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();


app.UseRouting();

app.UseSwagger();

app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FootBall.API v1"));

app.UseEndpoints(end => end.MapControllers());

app.Run();
