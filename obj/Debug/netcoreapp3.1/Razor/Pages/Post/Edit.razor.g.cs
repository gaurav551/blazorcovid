#pragma checksum "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\Post\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f38e72e541a7d0f56d6c9977b3b87ca7c244b933"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCrud.Pages.Post
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/post/edit/{Id:int}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"font-family: Verdana, Geneva, Tahoma, sans-serif;\"> Edit Post </h3>\r\n\r\n\r\n");
            __builder.OpenComponent<BlazorCrud.Pages.Post.Form>(1);
            __builder.AddAttribute(2, "ButtonText", "Update");
            __builder.AddAttribute(3, "Post", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorCrud.Models.Post>(
#nullable restore
#line 8 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\Post\Edit.razor"
                                post

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\Post\Edit.razor"
                      EditPost

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\Post\Edit.razor"
       
    [Parameter] public int Id { get; set; }
    Post post = new Post();

    protected  override void OnParametersSet()
    {
        post = context.Posts.FirstOrDefault(x=>x.Id==Id);
    }

    async Task EditPost()
    {
       context.Posts.Update(post);
      await context.SaveChangesAsync();
        uriHelper.NavigateTo("post/index");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDBContext context { get; set; }
    }
}
#pragma warning restore 1591
