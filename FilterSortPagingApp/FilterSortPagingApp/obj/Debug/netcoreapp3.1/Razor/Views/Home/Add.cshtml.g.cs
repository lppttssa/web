#pragma checksum "C:\Users\lpptt\Desktop\3sem\C#\web\FilterSortPagingApp\FilterSortPagingApp\Views\Home\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "982587fe3dc1eb9e1ee0a42cb3b94c97308fad56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Add), @"mvc.1.0.view", @"/Views/Home/Add.cshtml")]
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
#line 1 "C:\Users\lpptt\Desktop\3sem\C#\web\FilterSortPagingApp\FilterSortPagingApp\Views\_ViewImports.cshtml"
using FilterSortPagingApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lpptt\Desktop\3sem\C#\web\FilterSortPagingApp\FilterSortPagingApp\Views\_ViewImports.cshtml"
using FilterSortPagingApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"982587fe3dc1eb9e1ee0a42cb3b94c97308fad56", @"/Views/Home/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"017473c864b5ea81fa66b554e33f23369abf473f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilterSortPagingApp.Models.Pilot>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lpptt\Desktop\3sem\C#\web\FilterSortPagingApp\FilterSortPagingApp\Views\Home\Add.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Новый пилот</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\lpptt\Desktop\3sem\C#\web\FilterSortPagingApp\FilterSortPagingApp\Views\Home\Add.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\lpptt\Desktop\3sem\C#\web\FilterSortPagingApp\FilterSortPagingApp\Views\Home\Add.cshtml"
Write(Html.LabelFor(model => model.name, "Имя пилота"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 13 "C:\Users\lpptt\Desktop\3sem\C#\web\FilterSortPagingApp\FilterSortPagingApp\Views\Home\Add.cshtml"
Write(Html.EditorFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 15 "C:\Users\lpptt\Desktop\3sem\C#\web\FilterSortPagingApp\FilterSortPagingApp\Views\Home\Add.cshtml"
Write(Html.LabelFor(model => model.City.Name, "Город"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "C:\Users\lpptt\Desktop\3sem\C#\web\FilterSortPagingApp\FilterSortPagingApp\Views\Home\Add.cshtml"
Write(Html.EditorFor(model => model.City.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "C:\Users\lpptt\Desktop\3sem\C#\web\FilterSortPagingApp\FilterSortPagingApp\Views\Home\Add.cshtml"
Write(Html.LabelFor(model => model.exp, "Стаж"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 21 "C:\Users\lpptt\Desktop\3sem\C#\web\FilterSortPagingApp\FilterSortPagingApp\Views\Home\Add.cshtml"
Write(Html.EditorFor(model => model.exp));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n    <input type=\"submit\" value=\"Добавить\" />\r\n");
#nullable restore
#line 25 "C:\Users\lpptt\Desktop\3sem\C#\web\FilterSortPagingApp\FilterSortPagingApp\Views\Home\Add.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilterSortPagingApp.Models.Pilot> Html { get; private set; }
    }
}
#pragma warning restore 1591
