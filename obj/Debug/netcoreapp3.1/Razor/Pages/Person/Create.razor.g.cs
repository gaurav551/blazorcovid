#pragma checksum "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\Person\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3c9bbc1d514e4d8f9880c26ef4c3b8155164a60"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCrud.Pages.Person
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
#line 10 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\_Imports.razor"
using BlazorCrud.Data;

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/person/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"font-family: Verdana, Geneva, Tahoma, sans-serif\"> New Person </h3>\r\n\r\n");
            __builder.OpenComponent<BlazorCrud.Pages.Person.PersonForm>(1);
            __builder.AddAttribute(2, "Person", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorCrud.Models.Person>(
#nullable restore
#line 5 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\Person\Create.razor"
                    person

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 5 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\Person\Create.razor"
                                           CreatePerson

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\Person\Create.razor"
      
    Person person = new Person();
    public void CreatePerson()
    {
        System.Console.WriteLine("Ok");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
