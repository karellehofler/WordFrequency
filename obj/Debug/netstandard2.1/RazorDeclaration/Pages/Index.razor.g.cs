// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WordFrequency.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using WordFrequency;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\T440\source\repos\WordFrequency\_Imports.razor"
using WordFrequency.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor"
using WordFrequency.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor"
       
    private String currentText { get; set; }
    private String prevText;
    private Boolean isCurrentText;
    private int characterCount;

    private void updateCurrentText(Microsoft.AspNetCore.Components.ChangeEventArgs args)
    {
        currentText = (string)args.Value;
        isCurrentText = false;
        isCurrentText = false;
        if(currentText != prevText)
            isCurrentText = false;

        characterCount = currentText.Length;
    }

    private void submitText(Microsoft.AspNetCore.Components.ChangeEventArgs args)
    {

    }

    protected override void OnInitialized()
    {
        currentText = "";
        prevText = currentText;
        isCurrentText = true;

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
