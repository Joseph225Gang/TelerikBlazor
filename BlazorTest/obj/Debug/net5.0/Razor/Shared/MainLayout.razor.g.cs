#pragma checksum "D:\Visual Studio 2019\BlazorTest\BlazorTest\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99d7e7a50750537dbeb8477a290032b0eff7655e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTest.Shared
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
#line 12 "D:\Visual Studio 2019\BlazorTest\BlazorTest\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-gfuazdoowf");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-gfuazdoowf");
            __builder.OpenComponent<BlazorTest.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-gfuazdoowf");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-gfuazdoowf><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-gfuazdoowf>About</a></div>\r\n\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-gfuazdoowf");
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikRootComponent>(15);
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 14 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Shared\MainLayout.razor"
__builder2.AddContent(17, Body);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
