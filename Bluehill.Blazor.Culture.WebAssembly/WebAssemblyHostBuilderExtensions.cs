using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using System.Globalization;
using System.Threading.Tasks;

namespace Bluehill.Blazor;

public static class WebAssemblyHostBuilderExtensions {
    public static async Task<WebAssemblyHost> BuildAndSetCultureAsync(this WebAssemblyHostBuilder builder, string defaultCulture) {
        var host = builder.Build();
        var js = host.Services.GetRequiredService<IJSRuntime>();
        var result = await js.InvokeAsync<string>("blazorCulture.get");
        var culture = CultureInfo.GetCultureInfo(result ?? defaultCulture);

        if (result == null) {
            await js.InvokeVoidAsync("blazorCulture.set", defaultCulture);
        }

        CultureInfo.DefaultThreadCurrentCulture = culture;
        CultureInfo.DefaultThreadCurrentUICulture = culture;

        return host;
    }
}
