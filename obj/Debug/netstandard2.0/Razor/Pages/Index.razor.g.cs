#pragma checksum "C:\Projects\ExpensesBlazor\ExpensesBlazor\ExpensesBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1263182b655a2f6cfafbc021a8a9bf970c0ef315"
// <auto-generated/>
#pragma warning disable 1591
namespace ExpensesBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Projects\ExpensesBlazor\ExpensesBlazor\ExpensesBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Projects\ExpensesBlazor\ExpensesBlazor\ExpensesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Projects\ExpensesBlazor\ExpensesBlazor\ExpensesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "C:\Projects\ExpensesBlazor\ExpensesBlazor\ExpensesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Projects\ExpensesBlazor\ExpensesBlazor\ExpensesBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Projects\ExpensesBlazor\ExpensesBlazor\ExpensesBlazor\_Imports.razor"
using ExpensesBlazor;

#line default
#line hidden
#line 7 "C:\Projects\ExpensesBlazor\ExpensesBlazor\ExpensesBlazor\_Imports.razor"
using ExpensesBlazor.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            builder.OpenComponent<ExpensesBlazor.Shared.SurveyPrompt>(1);
            builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
