using TalabalarJurnali.Admin.API.Services;
using TalabalarJurnali.Common.Extensions;
using TalabalarJurnali.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IFileHelper, FileHelper>();
builder.Services.AddScoped<IGroupRepository, GroupRepository>();
builder.Services.AddScoped<IMarkRepository, MarkRepository>();
builder.Services.AddScoped<IStudentStatsOfDayRepository, StudentStatsOfDayRepository>();
builder.Services.AddScoped<IStudyDayRepository, StudyDayRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IGroupService, GroupService>();

builder.Services.AddAppDbContext(builder.Configuration);
builder.Services.AddIdentityManagers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();