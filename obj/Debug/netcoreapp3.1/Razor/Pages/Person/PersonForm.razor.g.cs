#pragma checksum "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\Person\PersonForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b1b30504bd356ddf1ad02dae771dd38bb82d62a"
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
    public partial class PersonForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 1 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\Person\PersonForm.razor"
                 Person

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 1 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\Person\PersonForm.razor"
                                        OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.AddMarkupContent(10, "<lable> Name </lable>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "class", "form-control");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\Person\PersonForm.razor"
                                                  Person.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Person.Name = __value, Person.Name))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Person.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __Blazor.BlazorCrud.Pages.Person.PersonForm.TypeInference.CreateValidationMessage_0(__builder2, 17, 18, 
#nullable restore
#line 6 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\Person\PersonForm.razor"
                              () => Person.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(19, "\r\n\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "\r\n    ");
                __builder2.AddMarkupContent(24, "<lable> Biography </lable>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(25);
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\Person\PersonForm.razor"
                                                  Person.Biography

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Person.Biography = __value, Person.Biography))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Person.Biography));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __Blazor.BlazorCrud.Pages.Person.PersonForm.TypeInference.CreateValidationMessage_1(__builder2, 31, 32, 
#nullable restore
#line 12 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\Person\PersonForm.razor"
                              () => Person.Biography

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(33, "\r\n\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.AddMarkupContent(38, "<lable> Name </lable>\r\n    ");
                __Blazor.BlazorCrud.Pages.Person.PersonForm.TypeInference.CreateInputDate_2(__builder2, 39, 40, "form-control", 41, 
#nullable restore
#line 17 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\Person\PersonForm.razor"
                                                  Person.DateOfBirth

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Person.DateOfBirth = __value, Person.DateOfBirth)), 43, () => Person.DateOfBirth);
                __builder2.AddMarkupContent(44, "\r\n    ");
                __Blazor.BlazorCrud.Pages.Person.PersonForm.TypeInference.CreateValidationMessage_3(__builder2, 45, 46, 
#nullable restore
#line 18 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\Person\PersonForm.razor"
                              () => Person.DateOfBirth

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(47, "\r\n\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n");
                __builder2.AddMarkupContent(49, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\gaura\OneDrive\Desktop\BlazorServer\BlazorCrud\Pages\Person\PersonForm.razor"
      
 [Parameter]   public Person Person {get;set;}
 [Parameter]   public EventCallback OnValidSubmit {get;set;}



#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorCrud.Pages.Person.PersonForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
