using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(pattern: "api/document.json");
    app.MapScalarApiReference(options =>
    {
        options.OpenApiRoutePattern = "api/document.json";
        options.Title = "Weather Forecast API Sample";
        options.Theme = ScalarTheme.Default;
        options.Favicon = "/favicon.svg";
        options.Layout = ScalarLayout.Modern;
        options.DarkMode = true;
        options.Metadata = new Dictionary<string, string>()
        {
            { "ogDescription", "Open Graph description" },
            { "ogTitle", "Open Graph title" },
            { "twitterCard", "summary_large_image" },
            { "twitterSite", "https://example.com/api" },
            { "twitterTitle", "My Api documentation" },
            { "twitterDescription", "This is the description for the twitter card" },
            { "twitterImage", "https://dotnet.microsoft.com/blob-assets/images/illustrations/swimlane-build-scalable-web-apps.svg" }
        };
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
