#pragma checksum "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Category\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "804f0592d792478ea55b59c7253c88ac2220cd3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Add), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Category/Add.cshtml", typeof(AspNetCore.Areas_Admin_Views_Category_Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"804f0592d792478ea55b59c7253c88ac2220cd3c", @"/Areas/Admin/Views/Category/Add.cshtml")]
    public class Areas_Admin_Views_Category_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog.Model.CATEGORY>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Category\Add.cshtml"
  
    ViewData["Title"] = "Add";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(126, 41, true);
            WriteLiteral("\r\n<blockquote class=\"layui-elem-quote\">\r\n");
            EndContext();
#line 8 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Category\Add.cshtml"
     if (Model.Id == 0)
    {
        

#line default
#line hidden
            BeginContext(208, 22, false);
#line 10 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Category\Add.cshtml"
   Write(string.Format("添加新分类"));

#line default
#line hidden
            EndContext();
#line 10 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Category\Add.cshtml"
                               
    }

#line default
#line hidden
            BeginContext(239, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 12 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Category\Add.cshtml"
     if (Model.Id != 0)
    {
        

#line default
#line hidden
            BeginContext(280, 37, false);
#line 14 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Category\Add.cshtml"
   Write(string.Format("修改 {0} ", Model.CName));

#line default
#line hidden
            EndContext();
#line 14 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Category\Add.cshtml"
                                              
    }

#line default
#line hidden
            BeginContext(326, 241, true);
            WriteLiteral("</blockquote>\r\n<form class=\"layui-form\" action=\"\" method=\"post\" style=\"padding:10px;height:100%;\">\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">标题：</label>\r\n        <div class=\"layui-input-block\">\r\n            ");
            EndContext();
            BeginContext(568, 132, false);
#line 21 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Category\Add.cshtml"
       Write(Html.TextBoxFor(model => model.CName, htmlAttributes: new { @class = "layui-input", @placeholder = "请输入类型", @autocomplete = "off" }));

#line default
#line hidden
            EndContext();
            BeginContext(700, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(842, 185, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"layui-form-item layui-form-text\">\r\n        <label class=\"layui-form-label\">内容：</label>\r\n        <div class=\"layui-input-block\">\r\n            ");
            EndContext();
            BeginContext(1028, 111, false);
#line 28 "F:\Person\BanditLearn\Blog\Blog\Areas\Admin\Views\Category\Add.cshtml"
       Write(Html.TextAreaFor(model => model.Remark, htmlAttributes: new { @class = "layui-textarea", @placeholder = "描述" }));

#line default
#line hidden
            EndContext();
            BeginContext(1139, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1257, 297, true);
            WriteLiteral(@"        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-input-block"">
            <button class=""layui-btn"" lay-submit lay-filter=""formDemo"">保存</button>
            <a href=""/Admin/Category/Index"" class=""layui-btn"">返回列表</a>
        </div>
    </div>
</form>
");
            EndContext();
            BeginContext(1554, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eb611d2dc2a4304afc25cd687679fe2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1598, 498, true);
            WriteLiteral(@"
<style>
    textarea {
        min-height: 200px;
    }
</style>
<script>
    //Demo
    layui.use(['form', 'layedit'], function () {
        var form = layui.form;
        var layedit = layui.layedit;
        layedit.build('Remark', {
            height: 200 //设置编辑器高度
        }); //建立编辑器
        //监听提交
        //form.on('submit(formDemo)', function (data) {
        //    layer.msg(JSON.stringify(data.field));
        //    return false;
        //});
    });
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog.Model.CATEGORY> Html { get; private set; }
    }
}
#pragma warning restore 1591
