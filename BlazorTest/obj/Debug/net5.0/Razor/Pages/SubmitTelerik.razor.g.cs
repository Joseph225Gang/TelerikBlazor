#pragma checksum "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ea279a67b03a5b0c51a1e20c9ee18051819baed"
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
#nullable restore
#line 3 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
using Telerik.Blazor.Components.Upload;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/upload/overview")]
    public partial class SubmitTelerik : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "demo-section k-form k-form-horizontal");
#nullable restore
#line 9 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
     if (string.IsNullOrEmpty(SuccessMessage))
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "EditContext", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Forms.EditContext>(
#nullable restore
#line 11 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
                                MyEditContext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
                                                               HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "OnInvalidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
                                                                                                    HandleInvalidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
#nullable restore
#line 14 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
             if (NotValid)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "demo-alert demo-alert-error");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 19 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "k-form-field");
                __builder2.AddMarkupContent(13, "<label for=\"name\" class=\"k-label k-form-label\">Name:</label>\r\n                ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "k-form-field-wrap");
                __builder2.OpenComponent<Telerik.Blazor.Components.TelerikTextBox>(16);
                __builder2.AddAttribute(17, "Id", "name");
                __builder2.AddAttribute(18, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
                                                  currentForm.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => currentForm.Name = __value, currentForm.Name))));
                __builder2.AddAttribute(20, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => currentForm.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "k-form-field");
                __builder2.AddMarkupContent(24, "<label for=\"email\" class=\"k-label k-form-label\">Email:</label>\r\n                ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "k-form-field-wrap");
                __builder2.OpenComponent<Telerik.Blazor.Components.TelerikTextBox>(27);
                __builder2.AddAttribute(28, "Id", "email");
                __builder2.AddAttribute(29, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
                                                  currentForm.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => currentForm.Email = __value, currentForm.Email))));
                __builder2.AddAttribute(31, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => currentForm.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "k-form-field");
                __builder2.AddMarkupContent(35, "<label class=\"k-label k-form-label\">CV:</label>\r\n                ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "k-form-field-wrap");
                __builder2.OpenComponent<Telerik.Blazor.Components.TelerikUpload>(38);
                __builder2.AddAttribute(39, "SaveUrl", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
                                             SaveUrl

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "RemoveUrl", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
                                               RemoveUrl

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "AllowedExtensions", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 38 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
                                                         new List<string>() { ".pdf", ".docx" } 

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "OnSelect", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Telerik.Blazor.Components.UploadSelectEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.UploadSelectEventArgs>(this, 
#nullable restore
#line 39 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
                                              OnSelectHandler

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(43, "OnCancel", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Telerik.Blazor.Components.UploadCancelEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.UploadCancelEventArgs>(this, 
#nullable restore
#line 40 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
                                              OnCancelHandler

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(44, "OnRemove", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Telerik.Blazor.Components.UploadEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.UploadEventArgs>(this, 
#nullable restore
#line 41 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
                                              OnRemoveHandler

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __builder2.AddMarkupContent(46, "<div class=\"k-form-hint\">Accepted files: <strong>PDF and DOCX</strong></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n            ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "text-right");
                __builder2.OpenComponent<Telerik.Blazor.Components.TelerikButton>(50);
                __builder2.AddAttribute(51, "Primary", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(53, "Submit Application");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 51 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "demo-alert demo-alert-success");
            __builder.AddAttribute(56, "role", "alert");
#nullable restore
#line 55 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
__builder.AddContent(57, SuccessMessage);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(58, "\r\n            <br>\r\n            ");
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikButton>(59);
            __builder.AddAttribute(60, "Primary", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 57 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
                                    true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
                                                    BackToForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(63, "Go back");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 59 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "D:\Visual Studio 2019\BlazorTest\BlazorTest\Pages\SubmitTelerik.razor"
       
    // setup upload endpoints
    public string SaveUrl => ToAbsoluteUrl("api/upload/save");
    public string RemoveUrl => ToAbsoluteUrl("api/upload/remove");

    public string ToAbsoluteUrl(string url)
    {
        return $"{NavigationManager.BaseUri}{url}";
    }

    // setup validation, this is a workaround because file validation does not exist in the framework
    // see more here https://github.com/dotnet/aspnetcore/issues/18821
    JobApplicationForm currentForm { get; set; }
    protected EditContext MyEditContext { get; set; }

    private bool NotValid => MyEditContext.GetValidationMessages().Any();
    Dictionary<string, bool> FilesValidationInfo { get; set; } = new Dictionary<string, bool>();

    protected override void OnInitialized()
    {
        currentForm = new JobApplicationForm();
        MyEditContext = new EditContext(currentForm);
    }

    void OnSelectHandler(UploadSelectEventArgs e)
    {
        foreach (var item in e.Files)
        {
            if (!FilesValidationInfo.Keys.Contains(item.Id))
            {
                // nothing is assumed to be valid until the server returns an OK
                FilesValidationInfo.Add(item.Id, IsSelectedFileValid(item));
            }
        }

        UpdateValidationModel();
    }

    void OnCancelHandler(UploadCancelEventArgs e)
    {
        RemoveFailedFilesFromList(e.Files);
        UpdateValidationModel();
    }

    void OnRemoveHandler(UploadEventArgs e)
    {
        RemoveFailedFilesFromList(e.Files);
        UpdateValidationModel();
    }

    void RemoveFailedFilesFromList(List<UploadFileInfo> files)
    {
        foreach (var file in files)
        {
            if (FilesValidationInfo.Keys.Contains(file.Id))
            {
                FilesValidationInfo.Remove(file.Id);
            }
        }
    }

    bool IsSelectedFileValid(UploadFileInfo file)
    {
        return !(file.InvalidExtension || file.InvalidMaxFileSize || file.InvalidMinFileSize);
    }

    void UpdateValidationModel()
    {
        bool areAllUploadedFilesValid = false;

        if (FilesValidationInfo.Keys.Count > 0 &&
            !FilesValidationInfo.Values.Contains(false))
        {
            areAllUploadedFilesValid = true;
        }

        currentForm.IsResumeValid = areAllUploadedFilesValid;

        // we update the validation state out of the standard form cycle and events
        // so we need an EditContext that we can call upon to re-evaluate the validation
        MyEditContext.Validate();
    }


    // sample model
    public class JobApplicationForm
    {
        [Required(ErrorMessage = "Enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter your email")]
        [EmailAddress(ErrorMessage = "Please provide a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please upload a resume - PDF or DOCX files only")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Please upload a resume - PDF or DOCX files only")]
        public bool IsResumeValid { get; set; }
    }

    // UI for the demo to showcase changes to the form validation and success
    string SuccessMessage = string.Empty;

    void HandleValidSubmit()
    {
        SuccessMessage = "Form Submitted Successfully! We will get back to you.";
    }

    void HandleInvalidSubmit()
    {
        SuccessMessage = string.Empty;
    }

    async Task BackToForm()
    {
        await JsInterop.InvokeVoidAsync("window.location.reload");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsInterop { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
