#pragma checksum "/Users/garynewmeyer/Desktop/CodingDojo/c_sharp/AspNetCoreMvcII/ViewModelFun/Views/Home/User.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cf8ae9b35b87bc66ee9784da82419982ec701d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_User), @"mvc.1.0.view", @"/Views/Home/User.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/garynewmeyer/Desktop/CodingDojo/c_sharp/AspNetCoreMvcII/ViewModelFun/Views/_ViewImports.cshtml"
using ViewModelFun;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/garynewmeyer/Desktop/CodingDojo/c_sharp/AspNetCoreMvcII/ViewModelFun/Views/_ViewImports.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cf8ae9b35b87bc66ee9784da82419982ec701d6", @"/Views/Home/User.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_User : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/garynewmeyer/Desktop/CodingDojo/c_sharp/AspNetCoreMvcII/ViewModelFun/Views/Home/User.cshtml"
      
    ViewData["Title"] = "User";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Here is a User!</h1>\n<p>");
#nullable restore
#line 7 "/Users/garynewmeyer/Desktop/CodingDojo/c_sharp/AspNetCoreMvcII/ViewModelFun/Views/Home/User.cshtml"
Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "/Users/garynewmeyer/Desktop/CodingDojo/c_sharp/AspNetCoreMvcII/ViewModelFun/Views/Home/User.cshtml"
               Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
