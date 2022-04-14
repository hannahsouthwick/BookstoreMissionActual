#pragma checksum "/Users/hannahsouthwick/Documents/GitHub/BookstoreMission/BookstoreMission/Pages/Admin/AdminLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e32c6809603c4c155a19341df86da3ab5a312d08"
// <auto-generated/>
#pragma warning disable 1591
namespace BookstoreMission.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/hannahsouthwick/Documents/GitHub/BookstoreMission/BookstoreMission/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hannahsouthwick/Documents/GitHub/BookstoreMission/BookstoreMission/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/hannahsouthwick/Documents/GitHub/BookstoreMission/BookstoreMission/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/hannahsouthwick/Documents/GitHub/BookstoreMission/BookstoreMission/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/hannahsouthwick/Documents/GitHub/BookstoreMission/BookstoreMission/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/hannahsouthwick/Documents/GitHub/BookstoreMission/BookstoreMission/Pages/Admin/_Imports.razor"
using BookstoreMission.Models;

#line default
#line hidden
#nullable disable
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<nav class=""navbar sticky-top navbar-expand-lg navbar-light bg-dark justify-content-between"">

    <div class=""navbar-brand"">
        <a href=""#"" class=""ext-left"">
            <img src=""https://bootstraplogos.com/wp-content/uploads/edd/2018/07/logo.png"" width=""45"" alt class=""d-inline-block align-middle mr-2 "">
        </a>
    </div>

    <div class=""nav-item"">
        <span class=""navbar-brand m-lg-2 text-white p-2"">Bookstore Administration</span>
    </div>

    <div class=""navbar-nav"">

        <span class=""nav-item"">
            <a class=""btn btn-sm btn-outline-secondary"" href=""/account/logout"">Log Out</a>

        </span>
    </div>

</nav>
<br>

    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.AddMarkupContent(3, "\n\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row p-2");
            __builder.AddMarkupContent(6, "\n\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-3");
            __builder.AddMarkupContent(9, "\n\n                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "d-grid gap-2");
            __builder.AddMarkupContent(12, "\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(13);
            __builder.AddAttribute(14, "class", "btn btn-outline-primary");
            __builder.AddAttribute(15, "href", "/admin/books");
            __builder.AddAttribute(16, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(17, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 38 "/Users/hannahsouthwick/Documents/GitHub/BookstoreMission/BookstoreMission/Pages/Admin/AdminLayout.razor"
                                                                         NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(19, "Books");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\n\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(21);
            __builder.AddAttribute(22, "class", "btn btn-outline-primary");
            __builder.AddAttribute(23, "href", "/admin/purchases");
            __builder.AddAttribute(24, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(25, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 41 "/Users/hannahsouthwick/Documents/GitHub/BookstoreMission/BookstoreMission/Pages/Admin/AdminLayout.razor"
                                                                         NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(27, "Purchases");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col");
            __builder.AddMarkupContent(33, "\n                ");
            __builder.AddContent(34, 
#nullable restore
#line 46 "/Users/hannahsouthwick/Documents/GitHub/BookstoreMission/BookstoreMission/Pages/Admin/AdminLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(35, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
