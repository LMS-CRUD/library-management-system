#pragma checksum "C:\Users\muril\Desktop\Projetos\LMS\Library-Management-System\Library-Management-System\Views\User\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bcf2c009fc03bc715770c3d12bdc025aaa5c89e24fbae5ece7217f77d46a8193"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\muril\Desktop\Projetos\LMS\Library-Management-System\Library-Management-System\Views\_ViewImports.cshtml"
using Library_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\muril\Desktop\Projetos\LMS\Library-Management-System\Library-Management-System\Views\_ViewImports.cshtml"
using Library_Management_System.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bcf2c009fc03bc715770c3d12bdc025aaa5c89e24fbae5ece7217f77d46a8193", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"622a0428b584f1aa1f3b4cda8ef31ea1d52994c7eacb33b1dd65217537edd3f1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Library_Management_System.Models.UserViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2>Users</h2>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 121, "\"", 149, 1);
#nullable restore
#line 5 "C:\Users\muril\Desktop\Projetos\LMS\Library-Management-System\Library-Management-System\Views\User\Index.cshtml"
WriteAttributeValue("", 128, Url.Action("Create"), 128, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success mb-2"">Create New User</a>
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Email</th>
                <th>Registration Date</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 16 "C:\Users\muril\Desktop\Projetos\LMS\Library-Management-System\Library-Management-System\Views\User\Index.cshtml"
             foreach (var user in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\muril\Desktop\Projetos\LMS\Library-Management-System\Library-Management-System\Views\User\Index.cshtml"
                   Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\muril\Desktop\Projetos\LMS\Library-Management-System\Library-Management-System\Views\User\Index.cshtml"
                   Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\muril\Desktop\Projetos\LMS\Library-Management-System\Library-Management-System\Views\User\Index.cshtml"
                   Write(user.RegistrationDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 762, "\"", 810, 1);
#nullable restore
#line 23 "C:\Users\muril\Desktop\Projetos\LMS\Library-Management-System\Library-Management-System\Views\User\Index.cshtml"
WriteAttributeValue("", 769, Url.Action("Edit", new { id = user.Id }), 769, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 872, "\"", 923, 1);
#nullable restore
#line 24 "C:\Users\muril\Desktop\Projetos\LMS\Library-Management-System\Library-Management-System\Views\User\Index.cshtml"
WriteAttributeValue("", 879, Url.Action("Details", new { id = user.Id }), 879, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">View</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 982, "\"", 1032, 1);
#nullable restore
#line 25 "C:\Users\muril\Desktop\Projetos\LMS\Library-Management-System\Library-Management-System\Views\User\Index.cshtml"
WriteAttributeValue("", 989, Url.Action("Delete", new { id = user.Id }), 989, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 28 "C:\Users\muril\Desktop\Projetos\LMS\Library-Management-System\Library-Management-System\Views\User\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Library_Management_System.Models.UserViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591