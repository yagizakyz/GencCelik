#pragma checksum "C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Industry\GetIndustry.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1bd04883ef8dd2c5dfd960b352b8f3b0406a5eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Industry_GetIndustry), @"mvc.1.0.view", @"/Views/Industry/GetIndustry.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1bd04883ef8dd2c5dfd960b352b8f3b0406a5eb", @"/Views/Industry/GetIndustry.cshtml")]
    public class Views_Industry_GetIndustry : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GencCelik.Models.IndustryClass>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Industry\GetIndustry.cshtml"
  
    ViewData["Title"] = "GetIndustry";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Sanayi Gideri Bilgilerini Güncelleme Sayfası</h2>\r\n");
#nullable restore
#line 8 "C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Industry\GetIndustry.cshtml"
 using (Html.BeginForm("UpdateIndustry", "Industry", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Industry\GetIndustry.cshtml"
Write(Html.Label("Id"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Industry\GetIndustry.cshtml"
Write(Html.TextBoxFor(x => x.Id, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 13 "C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Industry\GetIndustry.cshtml"
Write(Html.Label("Araç"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 15 "C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Industry\GetIndustry.cshtml"
Write(Html.DropDownListFor(x => x.VehicleID, (List<SelectListItem>)ViewBag.vec, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Industry\GetIndustry.cshtml"
Write(Html.ValidationMessageFor(x => x.VehicleID, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 18 "C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Industry\GetIndustry.cshtml"
Write(Html.Label("Tutar"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Industry\GetIndustry.cshtml"
Write(Html.TextBoxFor(x => x.Expense, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Industry\GetIndustry.cshtml"
Write(Html.ValidationMessageFor(x => x.Expense, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 22 "C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Industry\GetIndustry.cshtml"
Write(Html.Label("Açıklama"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Industry\GetIndustry.cshtml"
Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Industry\GetIndustry.cshtml"
Write(Html.Label("Tarih"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Industry\GetIndustry.cshtml"
Write(Html.TextBoxFor(x => x.Date, new { @class = "form-control", placeholder = "06.10.2021 (gün-ay-yıl) şeklinde giriş yapın." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 28 "C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Industry\GetIndustry.cshtml"
Write(Html.Label("Kullanıcı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 30 "C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Industry\GetIndustry.cshtml"
Write(Html.DropDownListFor(x => x.LogUser, (List<SelectListItem>)ViewBag.lu, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\" style=\"background-color:darkblue\">Güncelle</button>\r\n");
#nullable restore
#line 33 "C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Industry\GetIndustry.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GencCelik.Models.IndustryClass> Html { get; private set; }
    }
}
#pragma warning restore 1591
