#pragma checksum "D:\gitCode\crm\lsc\lsc.crm\Views\Users\RoleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e3876ce42112feb2499287033a6c99f0403c190"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_RoleList), @"mvc.1.0.view", @"/Views/Users/RoleList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/RoleList.cshtml", typeof(AspNetCore.Views_Users_RoleList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3876ce42112feb2499287033a6c99f0403c190", @"/Views/Users/RoleList.cshtml")]
    public class Views_Users_RoleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<lsc.Model.UserRole>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\gitCode\crm\lsc\lsc.crm\Views\Users\RoleList.cshtml"
  
    ViewData["Title"] = "角色管理";
    Layout = "~/Pages/_Layout.cshtml";

#line default
#line hidden
            BeginContext(122, 592, true);
            WriteLiteral(@"

<blockquote class=""layui-elem-quote"">
    本页面系统中所有用户角色
    <a class=""layui-btn layui-btn-normal addrole"" href=""javascript:;"" target=""_blank"" >添加角色</a>
</blockquote>

<fieldset class=""layui-elem-field layui-field-title"" style=""margin-top: 20px;"">
    <legend>模块列表</legend>
</fieldset>
<table class=""layui-table"">
    <colgroup>
        <col width=""120"" />
        <col width=""150"" />
        <col width=""60"" />
    </colgroup>
    <thead>
        <tr>
            <th>角色ID</th>
            <th>角色名称</th>
            <th>操作</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 31 "D:\gitCode\crm\lsc\lsc.crm\Views\Users\RoleList.cshtml"
         if (Model != null && Model.Count() > 0)
        {
            foreach (var m in Model)
            {

#line default
#line hidden
            BeginContext(828, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(875, 4, false);
#line 36 "D:\gitCode\crm\lsc\lsc.crm\Views\Users\RoleList.cshtml"
                   Write(m.ID);

#line default
#line hidden
            EndContext();
            BeginContext(879, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(911, 10, false);
#line 37 "D:\gitCode\crm\lsc\lsc.crm\Views\Users\RoleList.cshtml"
                   Write(m.RoleName);

#line default
#line hidden
            EndContext();
            BeginContext(921, 64, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 985, "\"", 1007, 3);
            WriteAttributeValue("", 995, "Del(\'", 995, 5, true);
#line 39 "D:\gitCode\crm\lsc\lsc.crm\Views\Users\RoleList.cshtml"
WriteAttributeValue("", 1000, m.ID, 1000, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 1005, "\')", 1005, 2, true);
            EndWriteAttribute();
            BeginContext(1008, 135, true);
            WriteLiteral(" class=\"layui-btn layui-btn-small layui-btn-radius layui-btn-danger\"><i class=\"layui-icon\"></i>删除</button>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1143, "\"", 1183, 2);
            WriteAttributeValue("", 1150, "/Users/AddRoleJuri?roleid=", 1150, 26, true);
#line 40 "D:\gitCode\crm\lsc\lsc.crm\Views\Users\RoleList.cshtml"
WriteAttributeValue("", 1176, m.ID, 1176, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1184, 146, true);
            WriteLiteral(" class=\"layui-btn layui-btn-small layui-btn-normal\"><i class=\"layui-icon\">&#xe608;</i>分配权限</a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 43 "D:\gitCode\crm\lsc\lsc.crm\Views\Users\RoleList.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1356, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1399, 1172, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        var layer
        layui.use(['layer','element'], function () {
            var element = layui.element
            layer = layui.layer;
        })
        $("".addrole"").on('click', function () {
            layer.prompt({ title: '请输角色名称：', formType: 3 }, function (text, index) {
                layer.close(index);
                $.post('/Users/AddRole', { name: text }, function (res) {
                    if (res.code === 1) {
                        window.location.reload()
                    }
                })
            });
        })
        function Del(id) {
            layer.confirm('是否删除该模块？', {
                btn: ['删除', '取消'] //按钮
            }, function () {
                $.get('/Users/DelRole?id=' + id, function (res) {
                    if (res.code === 1) {
                        layer.msg('删除成功', { icon: 6 });
                        window.location.reload()
                    } else {
                        lay");
                WriteLiteral("er.msg(\'删除失败\', { icon: 5 });\r\n                    }\r\n                })\r\n            }, function () {\r\n            });\r\n        }\r\n\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<lsc.Model.UserRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
