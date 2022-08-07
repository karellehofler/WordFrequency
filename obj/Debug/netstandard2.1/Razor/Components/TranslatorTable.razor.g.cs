#pragma checksum "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abaa44dc630914813a7d6c51e7fbec6e212c3205"
// <auto-generated/>
#pragma warning disable 1591
namespace WordFrequency.Components
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
#line 1 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
using WordFrequency.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
using WordFrequency.Components;

#line default
#line hidden
#nullable disable
    public partial class TranslatorTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.AddMarkupContent(2, "<h3 class=\"text-center text-2xl font-mono text-white\">Results</h3>\r\n    ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table-fixed w-1/2 m-auto bg-zinc-100 drop-shadow-lg p-5");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<thead>\r\n            <tr>\r\n                <th>word</th>\r\n                <th>frequency</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(7, "tbody");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 14 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
             foreach (var word in words)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "                ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
            __builder.AddAttribute(13, "class", "indent-3");
            __builder.AddContent(14, 
#nullable restore
#line 17 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
                                          word.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddAttribute(17, "class", "text-center");
            __builder.AddContent(18, 
#nullable restore
#line 18 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
                                             word.Frequency

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 20 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "p");
            __builder.AddAttribute(25, "class", "font-bold text-white text-center mt-3");
            __builder.AddContent(26, "Total Amount of Words: ");
            __builder.AddContent(27, 
#nullable restore
#line 23 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
                                                                             totalWords

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\T440\source\repos\WordFrequency\Components\TranslatorTable.razor"
       

    [Parameter]
    public String textInput { get; set; }

    List<Word> words = new List<Word>();
    int totalWords;
    protected override void OnInitialized()
    {
        base.OnInitialized();

        /*@ dummy data @*/
        words.Add(new Word("all", 1));
        words.Add(new Word("cream", 1));
        words.Add(new Word("for", 1));
        words.Add(new Word("I", 1));
        words.Add(new Word("ice", 1));
        words.Add(new Word("scream", 3));
        words.Add(new Word("we", 1));
        words.Add(new Word("you", 1));

        totalWords = words.Count;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
