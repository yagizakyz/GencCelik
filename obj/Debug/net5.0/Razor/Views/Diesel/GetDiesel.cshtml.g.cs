#pragma checksum "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Diesel\GetDiesel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8530a7ab2c3f636c20e5a95a923f0ae5bf057544"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Diesel_GetDiesel), @"mvc.1.0.view", @"/Views/Diesel/GetDiesel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8530a7ab2c3f636c20e5a95a923f0ae5bf057544", @"/Views/Diesel/GetDiesel.cshtml")]
    #nullable restore
    public class Views_Diesel_GetDiesel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GencCelik.Models.DieselClass>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Diesel\GetDiesel.cshtml"
  
    ViewData["Title"] = "GetDiesel";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Mazot Kullanımı Bilgilerini Güncelleme Sayfası</h2>\r\n<h4>");
#nullable restore
#line 8 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Diesel\GetDiesel.cshtml"
Write(Html.ValidationSummary(false, "Her alan doldurulmak zorunda", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 9 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Diesel\GetDiesel.cshtml"
 using (Html.BeginForm("UpdateDiesel", "Diesel", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 12 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Diesel\GetDiesel.cshtml"
Write(Html.Label("Id"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Diesel\GetDiesel.cshtml"
Write(Html.TextBoxFor(x => x.Id, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 15 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Diesel\GetDiesel.cshtml"
Write(Html.Label("Araç"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Diesel\GetDiesel.cshtml"
Write(Html.DropDownListFor(x => x.VehicleID, (List<SelectListItem>)ViewBag.vec, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Diesel\GetDiesel.cshtml"
Write(Html.Label("Alınan Yakıt"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Diesel\GetDiesel.cshtml"
Write(Html.TextBoxFor(x => x.Liter, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 22 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Diesel\GetDiesel.cshtml"
Write(Html.Label("Kilometre"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Diesel\GetDiesel.cshtml"
Write(Html.TextBoxFor(x => x.Km, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Diesel\GetDiesel.cshtml"
Write(Html.Label("Tutar"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Diesel\GetDiesel.cshtml"
Write(Html.TextBoxFor(x => x.Expense, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 28 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Diesel\GetDiesel.cshtml"
Write(Html.Label("Tarih"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Diesel\GetDiesel.cshtml"
Write(Html.TextBoxFor(x => x.Date, new { @class = "form-control", placeholder = "06.10.2021 (gün-ay-yıl) şeklinde giriş yapın." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 31 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Diesel\GetDiesel.cshtml"
Write(Html.Label("Kullanıcı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 33 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Diesel\GetDiesel.cshtml"
Write(Html.DropDownListFor(x => x.LogUser, (List<SelectListItem>)ViewBag.lu, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\" style=\"background-color:darkblue\">Güncelle</button>\r\n");
#nullable restore
#line 36 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Diesel\GetDiesel.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GencCelik.Models.DieselClass> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
