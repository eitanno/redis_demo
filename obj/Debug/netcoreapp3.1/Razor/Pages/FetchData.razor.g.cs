#pragma checksum "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00a5aa40ed39ebe5b395ccc3b1ffce1141c56b2b"
// <auto-generated/>
#pragma warning disable 1591
namespace RedisDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\_Imports.razor"
using RedisDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\_Imports.razor"
using RedisDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\_Imports.razor"
using Microsoft.Extensions.Caching.Distributed;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\Pages\FetchData.razor"
using RedisDemo.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\Pages\FetchData.razor"
using RedisDemo.Extensions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\Pages\FetchData.razor"
                                          LoadForecast

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Load Forecast");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
#nullable restore
#line 14 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\Pages\FetchData.razor"
 if (forecasts is null && loadLocation == "")
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.AddMarkupContent(8, "<p><em>Click the button to load the forecast</em></p>\r\n");
#nullable restore
#line 17 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\Pages\FetchData.razor"
}
else if (forecasts is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.AddMarkupContent(10, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 21 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "h3" + " " + (
#nullable restore
#line 24 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\Pages\FetchData.razor"
                    isCacheData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, 
#nullable restore
#line 24 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\Pages\FetchData.razor"
                                  loadLocation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "table");
            __builder.AddAttribute(17, "class", "table");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.AddMarkupContent(19, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(20, "tbody");
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 35 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "                ");
            __builder.OpenElement(23, "tr");
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 38 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 39 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 40 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 41 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 43 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 46 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\shaam\source\repos\RedisDemoApp\RedisDemo\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;
    private string loadLocation = "";
    private string isCacheData = "";

    private async Task LoadForecast()
    {
        forecasts = null;
        loadLocation = null;

        string recordKey = "WeatherForecast_" + DateTime.Now.ToString("yyyyMMdd_hhmm");

        forecasts = await cache.GetRecordAsync<WeatherForecast[]>(recordKey);

        if (forecasts is null)
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);

            loadLocation = $"Loaded from API at { DateTime.Now }";
            isCacheData = "";

            await cache.SetRecordAsync(recordKey, forecasts);
        }
        else
        {
            loadLocation = $"Loaded from the cache at { DateTime.Now }";
            isCacheData = "text-danger";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDistributedCache cache { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
