using FBDAL.Context;
using FBDAL.DAL;
using FBGateway.Services;

var builder = WebApplication.CreateBuilder(args);

//services.AddDbContext<DbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
//builder.Services.AddDbContext<FormBuddyContext>(options=>options.UseSqlServer(Configuration))
builder.Services.AddDbContext<FormBuddyContext>(ServiceLifetime.Scoped);

// Add services to the container.
builder.Services.AddScoped<ICodeTableRespository, CodeTableRespository>();
builder.Services.AddScoped<ICodeTableService, CodeTableService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

// enasble CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            //policy.WithOrigins("http://localhost:4200",
            //                    "http://www.test.com");
            policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod();
        });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

object value = builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
