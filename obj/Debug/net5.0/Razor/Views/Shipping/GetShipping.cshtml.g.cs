#pragma checksum "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bbb7e4c7a334b71baeddc70af816ffcf776c8e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shipping_GetShipping), @"mvc.1.0.view", @"/Views/Shipping/GetShipping.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbb7e4c7a334b71baeddc70af816ffcf776c8e8", @"/Views/Shipping/GetShipping.cshtml")]
    #nullable restore
    public class Views_Shipping_GetShipping : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GencCelik.Models.ShippingClass>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
  
    ViewData["Title"] = "GetShipping";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Yeni Sevkiyat Ekleme Sayfası</h2>\r\n<h4>");
#nullable restore
#line 8 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.ValidationSummary(false, "Her alan doldurulmak zorunda", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 9 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
 using (Html.BeginForm("UpdateShipping", "Shipping", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.Label("Id"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.TextBoxFor(x => x.Id, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.Label("Şöför"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 16 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.DropDownListFor(x => x.PersonID, (List<SelectListItem>)ViewBag.per, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 18 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.Label("Araç"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 20 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.DropDownListFor(x => x.VehicleID, (List<SelectListItem>)ViewBag.vec, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 22 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.Label("Firma"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.TextBoxFor(x => x.Company, new { @class = "form-control", @style = "text-transform: uppercase" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.Label("Yükleme Yeri"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.TextBoxFor(x => x.Location, new { @class = "form-control", @style = "text-transform: uppercase" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 28 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.Label("Gideceği Yer"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.TextBoxFor(x => x.Destination, new { @class = "form-control", @style = "text-transform: uppercase" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 31 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.Label("Navlun"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.TextBoxFor(x => x.Navlun, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 34 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.Label("Türü"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 36 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.DropDownListFor(x => x.Kind, (List<SelectListItem>)ViewBag.p1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 38 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.Label("Fatura"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 40 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.DropDownListFor(x => x.Invoice, (List<SelectListItem>)ViewBag.r2, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 42 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.Label("Booking NO"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.TextBoxFor(x => x.BookingNo, new { @class = "form-control", @style = "text-transform: uppercase" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 45 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.Label("Konteyner"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.TextBoxFor(x => x.Container, new { @class = "form-control", @style = "text-transform: uppercase" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 48 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.Label("Açıklama"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 51 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.Label("Tarih"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.TextBoxFor(x => x.Date, new { @class = "form-control", placeholder = "06.10.2021 (gün-ay-yıl) şeklinde giriş yapın." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 54 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.Label("Kullanıcı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 56 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
Write(Html.DropDownListFor(x => x.LogUser, (List<SelectListItem>)ViewBag.lu, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\" style=\"background-color:darkblue\">Güncelle</button>\r\n");
#nullable restore
#line 59 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Shipping\GetShipping.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GencCelik.Models.ShippingClass> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
