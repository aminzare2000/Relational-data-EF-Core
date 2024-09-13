using ContosoPizza.Data;
using RelationalDataEFCore.Data;
using RelationalDataEFCore.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add the JournalEnvDbContext
//builder.Services.AddDbContext<JournalEnvDbContext>(options => options.UseSqlServer("server=.;database=JournalEnvDb;User Id=sa;Password=1;Persist Security Info=true;Trusted_Connection=false;TrustServerCertificate=true;"));
builder.Services.AddScoped<JournalService>();

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

// Un comment the CreateDbIfNotExists method call if implement data seeding
//app.CreateDbIfNotExists();

app.Run();
