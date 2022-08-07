#pragma checksum "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d9d5661a1aa6fda37a833b65818b05e576d4965"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "flex flex-row w-screen h-full");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "id", "para-form");
            __builder.AddAttribute(5, "class", "w-1/2 flex flex-col");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<h1 class=\"mt-10 text-center text-2xl text-zinc-900 text-cyan-400 font-semibold\">Word Frequency</h1>\r\n        ");
            __builder.OpenElement(8, "form");
            __builder.AddAttribute(9, "class", "flex flex-col w-2/3 m-auto justify-items-end");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "id", "form-and-character-count");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.AddMarkupContent(14, "<label class=\"font-serif text-zinc-700 text-semibold\">Your text</label>\r\n                ");
            __builder.OpenElement(15, "textarea");
            __builder.AddAttribute(16, "class", "shadow-inner w-full rounded border border-1 border-zinc-200 resize-none bg-zinc-100");
            __builder.AddAttribute(17, "rows", "5");
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor"
                                               updateCurrentText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "placeholder", "The brown cow has speckled spots...");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "p");
            __builder.AddContent(22, 
#nullable restore
#line 11 "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor"
                    characterCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, " / 2048 characters");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "id", "submit-btn");
            __builder.AddAttribute(28, "class", "flex justify-end");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "disabled", 
#nullable restore
#line 14 "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor"
                                   isCurrentText

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "class", "p-2 w-1/3 font-mono drop-shadow-lg bg-cyan-600 text-white disabled:bg-zinc-500 disabled:text-zinc-100");
            __builder.AddMarkupContent(33, "\r\n                    Translate\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "id", "translator-table");
            __builder.AddAttribute(40, "class", "w-1/2 bg-cyan-500 h-screen flex flex-column items-center shadow-inner");
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 22 "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor"
         if (isCurrentText == false)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "            ");
            __builder.OpenComponent<WordFrequency.Components.TranslatorTable>(43);
            __builder.AddAttribute(44, "textInput", "I scream, you scream, we all scream for ice cream.");
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 25 "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "            ");
            __builder.AddMarkupContent(47, "<h2 class=\"m-auto w-1/2 text-2xl font-mono text-white flex flex-column items-center\">Let\'s Translate Some Words!</h2>\r\n");
#nullable restore
#line 29 "C:\Users\T440\source\repos\WordFrequency\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.AddMarkupContent(50, "<footer class=\"w-1/2 absolute bg-zinc-200 bottom-0\">\r\n        <p class=\"indent-5 text-cyan-700\">Word Frequency. 2022</p>\r\n    </footer>\r\n");
            __builder.CloseElement();
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
