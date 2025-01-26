using AttachmentService.Application.Interfaces;
using AttachmentService.Application.UseCases.V1.GetFiles;
using AttachmentService.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IBlobStorageService>(provider =>
{
    var configuration = provider.GetRequiredService<IConfiguration>();
    var connectionString = configuration["AzureBlobStorage:ConnectionString"];
    var containerName = configuration["AzureBlobStorage:BlobContainerName"];
    return new BlobStorageService(connectionString, containerName);
});

// Register MediatR for CQRS pattern
builder.Services.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(GetFilesInput).Assembly));
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
