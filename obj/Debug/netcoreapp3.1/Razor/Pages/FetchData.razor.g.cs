#pragma checksum "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "006f7e5fd4c10a058aec52d8a3c76c2567a15b2f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCrud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\_Imports.razor"
using BlazorCrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\_Imports.razor"
using BlazorCrud.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\_Imports.razor"
using BlazorCrud.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\_Imports.razor"
using BlazorCrud.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
using BlazorCrud.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/covidstatus")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
 if(rootobject == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "  ");
            __builder.AddMarkupContent(1, "<div class=\"d-flex flex-row justify-content-center align-items-center\" style=\"height: 100px;\">\r\n    <div class=\"p-2\">\r\n   <div class=\"spinner-border\" role=\"status\">\r\n  <span class=\"sr-only\">Loading...</span>\r\n</div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 16 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"


}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, " ");
            __builder.AddMarkupContent(3, "<div class=\"alert alert-primary\" role=\"alert\">\r\n GLOBAL Covid19 Live Report\r\n</div>\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n  ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-sm-6");
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card");
            __builder.AddMarkupContent(12, "\r\n      ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-body");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.AddMarkupContent(16, "<h5 class=\"card-title\">New Confirmed</h5>\r\n        ");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", "#");
            __builder.AddAttribute(19, "class", "btn btn-primary");
            __builder.AddContent(20, 
#nullable restore
#line 29 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
                                             rootobject.Global.NewConfirmed

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n  ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-sm-6");
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "card");
            __builder.AddMarkupContent(30, "\r\n      ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "card-body");
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.AddMarkupContent(34, "<h5 class=\"card-title\">Total Confirmed</h5>\r\n        ");
            __builder.OpenElement(35, "a");
            __builder.AddAttribute(36, "href", "#");
            __builder.AddAttribute(37, "class", "btn btn-primary");
            __builder.AddContent(38, 
#nullable restore
#line 37 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
                                             rootobject.Global.TotalConfirmed

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n  ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-sm-6");
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "card");
            __builder.AddMarkupContent(48, "\r\n      ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "card-body");
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.AddMarkupContent(52, "<h5 class=\"card-title\">New Death</h5>\r\n        ");
            __builder.OpenElement(53, "a");
            __builder.AddAttribute(54, "href", "#");
            __builder.AddAttribute(55, "class", "btn btn-primary");
            __builder.AddContent(56, 
#nullable restore
#line 45 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
                                             rootobject.Global.NewDeaths

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n  ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "col-sm-6");
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "card");
            __builder.AddMarkupContent(66, "\r\n      ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "card-body");
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.AddMarkupContent(70, "<h5 class=\"card-title\">Total Death</h5>\r\n        ");
            __builder.OpenElement(71, "a");
            __builder.AddAttribute(72, "href", "#");
            __builder.AddAttribute(73, "class", "btn btn-primary");
            __builder.AddContent(74, 
#nullable restore
#line 53 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
                                             rootobject.Global.TotalDeaths

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n  ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "col-sm-6");
            __builder.AddMarkupContent(81, "\r\n    ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "card");
            __builder.AddMarkupContent(84, "\r\n      ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "card-body");
            __builder.AddMarkupContent(87, "\r\n        ");
            __builder.AddMarkupContent(88, "<h5 class=\"card-title\">New Recovered</h5>\r\n        ");
            __builder.OpenElement(89, "a");
            __builder.AddAttribute(90, "href", "#");
            __builder.AddAttribute(91, "class", "btn btn-primary");
            __builder.AddContent(92, 
#nullable restore
#line 61 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
                                             rootobject.Global.NewRecovered

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n  ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "col-sm-6");
            __builder.AddMarkupContent(99, "\r\n    ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "card");
            __builder.AddMarkupContent(102, "\r\n      ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "card-body");
            __builder.AddMarkupContent(105, "\r\n        ");
            __builder.AddMarkupContent(106, "<h5 class=\"card-title\">Total Recovered</h5>\r\n        ");
            __builder.OpenElement(107, "a");
            __builder.AddAttribute(108, "href", "#");
            __builder.AddAttribute(109, "class", "btn btn-primary");
            __builder.AddContent(110, 
#nullable restore
#line 69 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
                                             rootobject.Global.TotalRecovered

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n<br>\r\n<hr>\r\n");
            __builder.AddMarkupContent(116, "<div class=\"alert alert-primary\" role=\"alert\">\r\n Country wise Covid19 Live Report\r\n</div>\r\n");
            __builder.OpenElement(117, "table");
            __builder.AddAttribute(118, "class", "table table-striped");
            __builder.AddMarkupContent(119, "\r\n  ");
            __builder.AddMarkupContent(120, @"<thead>
    <tr>
      <th scope=""col"">Country</th>
      <th scope=""col"">Code</th>
      <th scope=""col"">Slug</th>
      <th scope=""col"">New Confirmed</th>
      <th scope=""col"">Total Confirmed</th>
      <th scope=""col"">New Deaths</th>
      <th scope=""col"">Total Deaths</th>
      <th scope=""col"">New Recovered</th>
      <th scope=""col"">Total Recovered</th>
    </tr>
  </thead>
  ");
            __builder.OpenElement(121, "tbody");
            __builder.AddMarkupContent(122, "\r\n");
#nullable restore
#line 96 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
       foreach(var x in rootobject.Countries)
      {

#line default
#line hidden
#nullable disable
            __builder.AddContent(123, "    ");
            __builder.OpenElement(124, "tr");
            __builder.AddMarkupContent(125, "\r\n      ");
            __builder.OpenElement(126, "th");
            __builder.AddAttribute(127, "scope", "row");
            __builder.AddContent(128, 
#nullable restore
#line 99 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
                       x.Country

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n      ");
            __builder.OpenElement(130, "td");
            __builder.AddContent(131, 
#nullable restore
#line 100 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
           x.CountryCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n      ");
            __builder.OpenElement(133, "td");
            __builder.AddContent(134, 
#nullable restore
#line 101 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
           x.Slug

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n      ");
            __builder.OpenElement(136, "td");
            __builder.AddContent(137, 
#nullable restore
#line 102 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
           x.NewConfirmed

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n       ");
            __builder.OpenElement(139, "td");
            __builder.AddContent(140, 
#nullable restore
#line 103 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
            x.TotalConfirmed

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n        ");
            __builder.OpenElement(142, "td");
            __builder.AddContent(143, 
#nullable restore
#line 104 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
             x.NewDeaths

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n         ");
            __builder.OpenElement(145, "td");
            __builder.AddContent(146, 
#nullable restore
#line 105 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
              x.TotalDeaths

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n          ");
            __builder.OpenElement(148, "td");
            __builder.AddContent(149, 
#nullable restore
#line 106 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
               x.NewRecovered

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n           ");
            __builder.OpenElement(151, "td");
            __builder.AddContent(152, 
#nullable restore
#line 107 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
                x.TotalRecovered

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n");
#nullable restore
#line 110 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
      }

#line default
#line hidden
#nullable disable
            __builder.AddContent(155, "  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n");
#nullable restore
#line 113 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\FetchData.razor"
       
    public Rootobject rootobject;

    protected override async Task OnInitializedAsync()
    {
        rootobject = await ForecastService.GetAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CovidStatus ForecastService { get; set; }
    }
}
#pragma warning restore 1591
