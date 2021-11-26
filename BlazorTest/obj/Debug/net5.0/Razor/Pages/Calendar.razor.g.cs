#pragma checksum "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\Calendar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32935529ddca87b7f17970c14d1da448f51db3ed"
// <auto-generated/>
#pragma warning disable 1591
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
#line 12 "D:\Visual Studio 2019\BlazorTest\BlazorTest\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/calendar")]
    public partial class Calendar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"demo-alert demo-alert-info\">\r\n    You will not be able to book an event hall for the dates between April 10th 2020 and April 12th 2020 (Easter Day).\r\n    You can select multiple dates.\r\n</div>");
#nullable restore
#line 8 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\Calendar.razor"
  
    if (SelectedDatesList.Any())
    {
        DateTime firstSelectedDate = SelectedDatesList.FirstOrDefault();
        DateTime lastSelectedDate = SelectedDatesList.LastOrDefault();

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "k-state-success p-sm mb-sm");
            __builder.AddMarkupContent(3, "\r\n            The event hall will be booked between ");
            __builder.OpenElement(4, "strong");
#nullable restore
#line 14 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\Calendar.razor"
__builder.AddContent(5, FormatDate(firstSelectedDate));

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, " and ");
#nullable restore
#line 14 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\Calendar.razor"
__builder.AddContent(7, FormatDate(lastSelectedDate));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 16 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\Calendar.razor"
        if (firstSelectedDate < EasterDate && lastSelectedDate > EasterDate)
        {
            string firstDisabledDate = FormatDate(DisabledDatesList.FirstOrDefault());
            string lastDisabledDate = FormatDate(DisabledDatesList.LastOrDefault());

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "k-state-error p-sm mb-sm");
            __builder.AddMarkupContent(10, "\r\n                In the selected time period you will not be able to use the hall between ");
            __builder.OpenElement(11, "strong");
#nullable restore
#line 21 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\Calendar.razor"
__builder.AddContent(12, firstDisabledDate);

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, " and ");
#nullable restore
#line 21 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\Calendar.razor"
__builder.AddContent(14, lastDisabledDate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\Calendar.razor"
        }
    }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikCalendar>(15);
            __builder.AddAttribute(16, "Min", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 27 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\Calendar.razor"
                       MinDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "Max", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 28 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\Calendar.razor"
                       MaxDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "DisabledDates", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.DateTime>>(
#nullable restore
#line 30 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\Calendar.razor"
                                 DisabledDatesList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "SelectionMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.CalendarSelectionMode>(
#nullable restore
#line 31 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\Calendar.razor"
                                CalendarSelectionMode.Multiple

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime>(this, 
#nullable restore
#line 33 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\Calendar.razor"
                                SelectionHandler

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(21, "Date", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 29 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\Calendar.razor"
                              DateToNavigate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "DateChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DateToNavigate = __value, DateToNavigate))));
            __builder.AddComponentReferenceCapture(23, (__value) => {
#nullable restore
#line 32 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\Calendar.razor"
                       CalendarReference = (Telerik.Blazor.Components.TelerikCalendar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\Calendar.razor"
       
    DateTime EasterDate { get; set; }
    DateTime MinDate { get; set; }
    DateTime MaxDate { get; set; }
    DateTime DateToNavigate { get; set; }
    List<DateTime> DisabledDatesList { get; set; } = new List<DateTime>();
    List<DateTime> SelectedDatesList { get; set; } = new List<DateTime>();

    TelerikCalendar CalendarReference;

    protected override void OnInitialized()
    {
        EasterDate = GetEasterDate();
        MinDate = EasterDate.AddMonths(-3);
        MaxDate = EasterDate.AddMonths(3);
        DateToNavigate = EasterDate;

        DisabledDatesList = new List<DateTime>()
{
            EasterDate.AddDays(-2),
            EasterDate.AddDays(-1),
            EasterDate
        };
    }

    DateTime GetEasterDate()
    {
        return new DateTime(2020, 4, 12);
    }

    void SelectionHandler()
    {
        SelectedDatesList = CalendarReference.SelectedDates;
        SelectedDatesList.Sort();
    }

    string FormatDate(DateTime dateToFormat)
    {
        return dateToFormat.ToString("dd MMM yyyy");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591