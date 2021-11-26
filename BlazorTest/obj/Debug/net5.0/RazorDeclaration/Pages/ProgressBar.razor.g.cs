// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Visual Studio 2019\BlazorTest\BlazorTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio 2019\BlazorTest\BlazorTest\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Visual Studio 2019\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Visual Studio 2019\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Visual Studio 2019\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Visual Studio 2019\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Visual Studio 2019\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Visual Studio 2019\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Visual Studio 2019\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Visual Studio 2019\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Visual Studio 2019\BlazorTest\BlazorTest\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\ProgressBar.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\ProgressBar.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/progressbar/overview")]
    public partial class ProgressBar : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\ProgressBar.razor"
       
    public const int TimerInterval = 1000;
    public const int TotalTime = 10 * TimerInterval;
    public double ProgressValue = 0;
    public int ProgressStep = 100 / (TotalTime / TimerInterval);
    public Timer Timer { get; set; } = new Timer();

    public void Dispose()
    {
        StopProgress();
        Timer?.Close();
    }

    protected override void OnAfterRender(bool firstRender)
    {
        if (Timer.Enabled == false)
        {
            Timer.Interval = TimerInterval;
            Timer.Elapsed -= OnTimerElapsed;
            Timer.Elapsed += OnTimerElapsed;
            Timer.AutoReset = true;
            Timer.Start();
        }
    }

    public void OnTimerElapsed(Object source, ElapsedEventArgs e)
    {
        if (ProgressValue < 100)
        {
            UpdateProgress();
        }
        else
        {
            StopProgress();
        }
    }

    public void UpdateProgress()
    {
        ProgressValue += ProgressStep;

        InvokeAsync(StateHasChanged);
    }

    public void StopProgress()
    {
        Timer?.Stop();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591