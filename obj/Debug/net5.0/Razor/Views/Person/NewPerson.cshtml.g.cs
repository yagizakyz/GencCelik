#pragma checksum "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b761a5dfd395e4923229473f7e1df8cec900dd40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_NewPerson), @"mvc.1.0.view", @"/Views/Person/NewPerson.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b761a5dfd395e4923229473f7e1df8cec900dd40", @"/Views/Person/NewPerson.cshtml")]
    #nullable restore
    public class Views_Person_NewPerson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GencCelik.Models.PersonClass>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
  
    ViewData["Title"] = "NewPerson";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Yeni Personel Ekleme Sayfası</h2>\r\n<h4>");
#nullable restore
#line 8 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.ValidationSummary(false, "Her alan doldurulmak zorunda", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 9 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
 using (Html.BeginForm("NewPerson", "Person", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.Label("Ad"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.TextBoxFor(x => x.PName, new { @class = "form-control", @style = "text-transform: uppercase" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.ValidationMessageFor(x => x.PName, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 15 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.Label("Soyad"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.TextBoxFor(x => x.PSurname, new { @class = "form-control", @style = "text-transform: uppercase" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.ValidationMessageFor(x => x.PSurname, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.Label("Kullanıcı Adı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.TextBoxFor(x => x.Nickname, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 22 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.Label("Şifre"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.TextBoxFor(x => x.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.Label("İşi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 27 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.DropDownListFor(x => x.JobID, (List<SelectListItem>)ViewBag.per, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.ValidationMessageFor(x => x.JobID, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 30 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.Label("İşe Giriş Tarihi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.TextBoxFor(x => x.StartDateOfWork, new { @class = "form-control", @Value = ViewBag.dt }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 33 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.Label("İşten Çıkış Tarihi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 35 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.DropDownListFor(x => x.DismissalDate, (List<SelectListItem>)ViewBag.ldt, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 37 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.Label("İş Günevlik Belgesi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 39 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.DropDownListFor(x => x.Safety, (List<SelectListItem>)ViewBag.p1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 41 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.Label("Özlük Belgesi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 43 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.DropDownListFor(x => x.Ozlük, (List<SelectListItem>)ViewBag.p1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 45 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.Label("Yıllık İzin"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 47 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.DropDownListFor(x => x.AnnualPermit, (List<SelectListItem>)ViewBag.p2, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 49 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.Label("Yetki"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 51 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.DropDownListFor(x => x.Roles, (List<SelectListItem>)ViewBag.roles, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 53 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.Label("Kullanıcı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 55 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
Write(Html.DropDownListFor(x => x.LogUser, (List<SelectListItem>)ViewBag.lu, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\" style=\"background-color:darkblue\">Personeli Ekle</button>\r\n");
#nullable restore
#line 58 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\NewPerson.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GencCelik.Models.PersonClass> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
