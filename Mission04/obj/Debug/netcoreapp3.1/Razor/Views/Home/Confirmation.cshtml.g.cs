#pragma checksum "/Users/johnfluhman/Desktop/School/Winter 2022/IS413/Mission04/Mission04/Views/Home/Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "686b3901fed658bc94bdc99907226d0475e8c1d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Confirmation), @"mvc.1.0.view", @"/Views/Home/Confirmation.cshtml")]
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
#line 1 "/Users/johnfluhman/Desktop/School/Winter 2022/IS413/Mission04/Mission04/Views/_ViewImports.cshtml"
using Mission04;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/johnfluhman/Desktop/School/Winter 2022/IS413/Mission04/Mission04/Views/_ViewImports.cshtml"
using Mission04.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686b3901fed658bc94bdc99907226d0475e8c1d6", @"/Views/Home/Confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c4d8c747c1058d0058c5e69fde51e848f9faa7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Confirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mission04.Models.MovieSubmission>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/johnfluhman/Desktop/School/Winter 2022/IS413/Mission04/Mission04/Views/Home/Confirmation.cshtml"
  
    ViewData["Title"] = "Movie Form Confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h1>Thank you for submitting ");
#nullable restore
#line 7 "/Users/johnfluhman/Desktop/School/Winter 2022/IS413/Mission04/Mission04/Views/Home/Confirmation.cshtml"
                        Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" to the database!</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mission04.Models.MovieSubmission> Html { get; private set; }
    }
}
#pragma warning restore 1591