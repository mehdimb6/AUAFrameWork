#pragma checksum "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\Role\_IndexJs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ede4ef64ff437de4878641a230c23c85d733ef7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Accounting_Views_Role__IndexJs), @"mvc.1.0.view", @"/Areas/Accounting/Views/Role/_IndexJs.cshtml")]
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
#line 1 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.GeneralModels.LoginModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.EntitiesDto.Accounting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.ViewModels.BaseViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.ViewModels.Accounting.AppUserModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.ViewModels.Accounting.RoleModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.BaseModel.BaseViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.ListModes.Accounting.AppUserModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Common.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ede4ef64ff437de4878641a230c23c85d733ef7c", @"/Areas/Accounting/Views/Role/_IndexJs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ec40a47aaa51d43fa0db7473b4a215be6ab3108", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Accounting_Views_Role__IndexJs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<script>\r\n    var _deleteUrl = \'");
#nullable restore
#line 2 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\Role\_IndexJs.cshtml"
                 Write(Url.Action("_Delete", "Role", new { area = "Accounting",  id = "__" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var _insertUrl = \'");
#nullable restore
#line 3 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\Role\_IndexJs.cshtml"
                 Write(Url.Action("_Insert", "Role", new { area = "Accounting" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var _updateUrl = \'");
#nullable restore
#line 4 "F:\GitRepos2\auarelease\MVC\V1.1\4_AddAUACore\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\Role\_IndexJs.cshtml"
                 Write(Url.Action("_Update", "Role", new { area = "Accounting",  id = "__" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
