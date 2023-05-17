using TaskProjectWebAPI.Interfaces.Repositories;
using TaskProjectWebAPI.Implementations.Repositories;
using TaskProjectWebAPI.Interfaces.Services;
using TaskProjectWebAPI.Implementations.Services;
using Microsoft.EntityFrameworkCore;
using TaskProjectWebAPI.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseCosmos(builder.Configuration["CosmosDBConnectionString"],
    databaseName: "ProgramApplicationDB"));
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IApplicationRepository, ApplicationRepository>();
builder.Services.AddScoped<IProgramRepository, ProgramRepository>();
builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
builder.Services.AddScoped<IStageRepository, StageRepository>();
builder.Services.AddScoped<IApplicationTemplateService, ApplicationTemplateService>();
builder.Services.AddScoped<IPreviewService, PreviewService>();
builder.Services.AddScoped<IProgramDetailsService, ProgramDetailsService>();
builder.Services.AddScoped<IWorkflowService, WorkflowService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    await using var scope = app.Services?.GetService<IServiceScopeFactory>()?.CreateAsyncScope();
    var context = scope?.ServiceProvider.GetRequiredService<ApplicationContext>();
    var result = await context!.Database.EnsureCreatedAsync();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
