#pragma checksum "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\PhoneTotalList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c7d1819c39bc7b8d9953c2b68edec1fd665c6ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EnterCustom_PhoneTotalList), @"mvc.1.0.view", @"/Views/EnterCustom/PhoneTotalList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EnterCustom/PhoneTotalList.cshtml", typeof(AspNetCore.Views_EnterCustom_PhoneTotalList))]
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
#line 1 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\PhoneTotalList.cshtml"
using lsc.Model.Enume;

#line default
#line hidden
#line 2 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\PhoneTotalList.cshtml"
using lsc.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c7d1819c39bc7b8d9953c2b68edec1fd665c6ed", @"/Views/EnterCustom/PhoneTotalList.cshtml")]
    public class Views_EnterCustom_PhoneTotalList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EnterCustPhaseLog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\PhoneTotalList.cshtml"
  
    ViewData["Title"] = "PhoneTotalList";
    Layout = "~/Pages/_LayoutNone.cshtml";
    List<EnterCustomer> enlist = ViewBag.enlist;

#line default
#line hidden
            BeginContext(218, 260, true);
            WriteLiteral(@"
<table class=""layui-table"">
    <thead class=""layui-table-header"">
        <tr>
            <th>客户名称</th>
            <th>客户阶段</th>
            <th>联系内容</th>
            <th>联系时间</th>
        </tr>
    </thead>
    <tbody class=""layui-table-body"">
");
            EndContext();
#line 20 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\PhoneTotalList.cshtml"
         if (Model != null)
        {
            foreach (var info in Model)
            {
                string name = string.Empty;
                if (enlist!=null)
                {
                    var en = enlist.FirstOrDefault(x=>x.ID==info.EnterCustomerID);
                    if (en!=null)
                    {
                        name = en.EnterName;
                     }
                }

#line default
#line hidden
            BeginContext(904, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(951, 4, false);
#line 34 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\PhoneTotalList.cshtml"
                   Write(name);

#line default
#line hidden
            EndContext();
            BeginContext(955, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(987, 21, false);
#line 35 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\PhoneTotalList.cshtml"
                   Write(info.Phase.TryToStr());

#line default
#line hidden
            EndContext();
            BeginContext(1008, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1040, 18, false);
#line 36 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\PhoneTotalList.cshtml"
                   Write(Html.Raw(info.Rem));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1090, 47, false);
#line 37 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\PhoneTotalList.cshtml"
                   Write(info.CreateTime.ToString("yyyy-MM-dd HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(1137, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 39 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\PhoneTotalList.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1193, 30, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EnterCustPhaseLog>> Html { get; private set; }
    }
}
#pragma warning restore 1591