namespace WebAppStartar.Extension;

public static class RequestTimingMiddleWareExtension
{
    public static IApplicationBuilder UseRequestTiming(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<MiddleWare.RequestTimingMiddleware>();
    }
}
