#pragma checksum "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b0839a9cba4f1f67e31136f0f2968eeb449bede"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmailManage_Index), @"mvc.1.0.view", @"/Views/EmailManage/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EmailManage/Index.cshtml", typeof(AspNetCore.Views_EmailManage_Index))]
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
#line 1 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\Index.cshtml"
using lsc.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b0839a9cba4f1f67e31136f0f2968eeb449bede", @"/Views/EmailManage/Index.cshtml")]
    public class Views_EmailManage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<lsc.Model.EmailResources>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\Index.cshtml"
  
    ViewData["Title"] = "邮件资源管理";
    Layout = "~/Pages/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 129, true);
            WriteLiteral("<blockquote class=\"layui-elem-quote\">\r\n    邮箱资源管理\r\n    <a class=\"layui-btn layui-btn-normal\" href=\"/EmailManage/Add\">添加邮箱资源</a>\r\n");
            EndContext();
            BeginContext(507, 543, true);
            WriteLiteral(@"</blockquote>
<fieldset class=""layui-elem-field layui-field-title"" style=""margin-top: 20px;"">
    <legend>邮箱资源管理</legend>
</fieldset>
<div class=""layui-fluid"">
    <div class=""layui-row"">
        <table class=""layui-table"">
            <thead>
                <tr>
                    <th>邮箱</th>
                    <th>用户名</th>
                    <th>密码</th>
                    <th>端口号</th>
                    <th>服务器IP</th>
                    <th>操作</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 30 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\Index.cshtml"
                 if (Model != null)
                {
                    foreach (EmailResources emailResourcese in Model)
                    {

#line default
#line hidden
            BeginContext(1200, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1264, 21, false);
#line 35 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\Index.cshtml"
                            Write(emailResourcese.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1286, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1327, 24, false);
#line 36 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\Index.cshtml"
                            Write(emailResourcese.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1352, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1393, 24, false);
#line 37 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\Index.cshtml"
                            Write(emailResourcese.Password);

#line default
#line hidden
            EndContext();
            BeginContext(1418, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1459, 20, false);
#line 38 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\Index.cshtml"
                            Write(emailResourcese.Port);

#line default
#line hidden
            EndContext();
            BeginContext(1480, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1521, 30, false);
#line 39 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\Index.cshtml"
                            Write(emailResourcese.SenderServerIp);

#line default
#line hidden
            EndContext();
            BeginContext(1552, 96, true);
            WriteLiteral("</td>\r\n                            <td><a href=\"javascript:;\" class=\"layui-btn layui-btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1648, "\"", 1686, 3);
            WriteAttributeValue("", 1658, "del(\'", 1658, 5, true);
#line 40 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\Index.cshtml"
WriteAttributeValue("", 1663, emailResourcese.Id, 1663, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 1684, "\')", 1684, 2, true);
            EndWriteAttribute();
            BeginContext(1687, 45, true);
            WriteLiteral(">删除</a></td>\r\n                        </tr>\r\n");
            EndContext();
#line 42 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(1774, 60, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1851, 940, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        var layer, form;
        layui.use(['element', 'layer', 'upload', 'table'],
            function() {
                var element = layui.element;
                layer = layui.layer;
                var upload = layui.upload;
                var table = layui.table;
            });
       
        del = function (id) {
            layer.confirm('是否删除？', { icon: 3, title: '删除提示' }, function (index) {
                $.get('/EmailManage/DelAsync?id=' + id,
                    function(res) {
                        if (res.code == 1) {
                            layer.msg('成功', { icon: 6 });
                            window.location.reload();
                        } else {
                            layer.msg('失败', { icon: 5 });
                        }
                    });
                layer.close(index);
            });
        }
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<lsc.Model.EmailResources>> Html { get; private set; }
    }
}
#pragma warning restore 1591
