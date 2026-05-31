var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();


// Logging Middleware
app.Use(async (context, next) =>
{
    Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");

    await next();

    Console.WriteLine($"Response Status: {context.Response.StatusCode}");
});


// Error Handling Middleware
app.UseExceptionHandler(errorApp =>
{
    errorApp.Run(async context =>
    {
        context.Response.ContentType = "text/html";

        await context.Response.WriteAsync(
            "<h1>Something went wrong!</h1>");
    });
});


// Content Security Policy
app.Use(async (context, next) =>
{
    context.Response.Headers.Append(
        "Content-Security-Policy",
        "default-src 'self'; script-src 'self' 'unsafe-inline'; style-src 'self' 'unsafe-inline';");

    await next();
});


// Static Files
app.UseStaticFiles();


// Default Route
app.MapGet("/", () =>
{
    return Results.Redirect("/index.html");
});

app.Run();