#pragma checksum "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68dbecaaac6416971aab01483c78fe02e6cc3374"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Index), @"mvc.1.0.view", @"/Views/Person/Index.cshtml")]
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
#line 1 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68dbecaaac6416971aab01483c78fe02e6cc3374", @"/Views/Person/Index.cshtml")]
    #nullable restore
    public class Views_Person_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GencCelik.Models.PersonClass>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Personel Listesi</h1>\r\n<a href=\"/Person/ExportToExcel\" class=\"btn btn-success\">Excel Olarak İndir</a>\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 13 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
 using (Html.BeginForm("Index", "Person", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"text-transform: uppercase\">\r\n        Personel Adı: ");
#nullable restore
#line 16 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
                 Write(Html.TextBox("p"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  Personel Soyadı: ");
#nullable restore
#line 16 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
                                                      Write(Html.TextBox("surname"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <input class=\"form-check\" style=\"text-transform: uppercase\" type=\"submit\" value=\"Ara\" />\r\n    </p>\r\n");
#nullable restore
#line 19 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
 if (User.IsInRole("Full"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"/Person/NewPerson/\" class=\"btn btn-primary\" style=\"background-color:darkblue\">Yeni Personel Ekle</a>\r\n");
#nullable restore
#line 23 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-bordered"">
    <tr>
        <th>ID</th>
        <th>Ad</th>
        <th>Soyad</th>
        <th>İşi</th>
        <th>İşe Giriş Tarihi</th>
        <th>İşten Çıkış Tarihi</th>
        <th>İş Güvenliği Belgesi</th>
        <th>Özlük Dosyası</th>
        <th>Yıllık İzin</th>
");
#nullable restore
#line 35 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
         if (User.IsInRole("Full"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>Pasif</th>\r\n            <th>Güncelle</th>\r\n            <th>İşleri</th>\r\n");
#nullable restore
#line 40 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <th>Yetki</th>\r\n        <th>Ekleyen Kullanıcı</th>\r\n    </tr>\r\n");
#nullable restore
#line 44 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 47 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 48 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
           Write(item.PName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 49 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
           Write(item.PSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 50 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
           Write(item.Job.JName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 51 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
           Write(item.StartDateOfWork.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 52 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
           Write(item.DismissalDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 53 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
             if (item.Safety == false)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Hazırlanmadı</td>\r\n");
#nullable restore
#line 56 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
             if (item.Safety == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Hazırlandı</td>\r\n");
#nullable restore
#line 60 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
             if (item.Ozlük == false)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Hazırlanmadı</td>\r\n");
#nullable restore
#line 64 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
             if (item.Ozlük == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Hazırlandı</td>\r\n");
#nullable restore
#line 68 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
             if (item.AnnualPermit == false)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Kullanmadı</td>\r\n");
#nullable restore
#line 72 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
             if (item.AnnualPermit == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Kullandı</td>\r\n");
#nullable restore
#line 76 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
             if (User.IsInRole("Full"))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
                 if (item.Deletes == false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><a");
            BeginWriteAttribute("href", " href=\"", 2409, "\"", 2445, 2);
            WriteAttributeValue("", 2416, "/Person/DeletePerson/", 2416, 21, true);
#nullable restore
#line 81 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
WriteAttributeValue("", 2437, item.Id, 2437, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Silmek istediğine emin misin?\')\" class=\"btn btn-danger\">Pasif</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 2570, "\"", 2603, 2);
            WriteAttributeValue("", 2577, "/Person/GetPerson/", 2577, 18, true);
#nullable restore
#line 82 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
WriteAttributeValue("", 2595, item.Id, 2595, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n");
#nullable restore
#line 83 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
                 if (item.Deletes == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"color:#ff000d\">Pasif</td>\r\n                    <td><a href=\"#pasif\" class=\"btn btn-success\">Pasif</a></td>\r\n");
#nullable restore
#line 88 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td><a");
            BeginWriteAttribute("href", " href=\"", 2910, "\"", 2946, 2);
            WriteAttributeValue("", 2917, "/Person/DetailPerson/", 2917, 21, true);
#nullable restore
#line 89 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
WriteAttributeValue("", 2938, item.Id, 2938, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">İşleri</a></td>\r\n");
#nullable restore
#line 90 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 91 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
           Write(item.Roles);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 92 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
           Write(item.LogUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 94 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 96 "C:\Users\akyz6\OneDrive\Masaüstü\Dosyalar\Kodlamalar\Mvc\GencCelik\GencCelik\Views\Person\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GencCelik.Models.PersonClass>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591