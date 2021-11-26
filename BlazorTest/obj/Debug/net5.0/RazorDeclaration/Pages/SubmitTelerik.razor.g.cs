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
