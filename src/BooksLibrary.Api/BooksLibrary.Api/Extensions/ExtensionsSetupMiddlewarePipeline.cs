using BooksLibrary.Api.Middlewares;

namespace BooksLibrary.Api.Extensions;

public static class ExtensionsSetupMiddlewarePipeline
{
    public static WebApplication SetupMiddleware(this WebApplication app)
    {
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseCounter();

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

        return app;
    }

    public static IApplicationBuilder UseCounter(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<CounterMiddleware>();
    }
}

