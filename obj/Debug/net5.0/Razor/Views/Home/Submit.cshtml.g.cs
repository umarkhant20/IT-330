#pragma checksum "C:\Users\umark\OneDrive\Desktop\Spring 2022\IT-330\week 8\Proj4-Khan\Views\Home\Submit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54ab07837d1cc460bc5be9fe8e310109bf3f8063"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Submit), @"mvc.1.0.view", @"/Views/Home/Submit.cshtml")]
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
#line 1 "C:\Users\umark\OneDrive\Desktop\Spring 2022\IT-330\week 8\Proj4-Khan\Views\_ViewImports.cshtml"
using Proj3_Khan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\umark\OneDrive\Desktop\Spring 2022\IT-330\week 8\Proj4-Khan\Views\_ViewImports.cshtml"
using Proj3_Khan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54ab07837d1cc460bc5be9fe8e310109bf3f8063", @"/Views/Home/Submit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c6410058ae70592cc2e0d70823b254f8d3ff61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Submit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Proj3_Khan.Models.RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<!--it will display one heading and set the background color to provided color-->

<h1 class=""display-4"">Pagal University</h1>
<br>

<!--it will display the summary of entered data-->
<h3>Thank you for registering!</h3>
<br>
<h4><strong>Id: </strong>");
#nullable restore
#line 12 "C:\Users\umark\OneDrive\Desktop\Spring 2022\IT-330\week 8\Proj4-Khan\Views\Home\Submit.cshtml"
                    Write(Model.UserInfo.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4><strong>Name: </strong>");
#nullable restore
#line 13 "C:\Users\umark\OneDrive\Desktop\Spring 2022\IT-330\week 8\Proj4-Khan\Views\Home\Submit.cshtml"
                      Write(Model.UserInfo.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4><strong>Address: </strong>");
#nullable restore
#line 14 "C:\Users\umark\OneDrive\Desktop\Spring 2022\IT-330\week 8\Proj4-Khan\Views\Home\Submit.cshtml"
                         Write(Model.UserInfo.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4><strong>City: </strong>");
#nullable restore
#line 15 "C:\Users\umark\OneDrive\Desktop\Spring 2022\IT-330\week 8\Proj4-Khan\Views\Home\Submit.cshtml"
                      Write(Model.UserInfo.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4><strong>State: </strong>");
#nullable restore
#line 16 "C:\Users\umark\OneDrive\Desktop\Spring 2022\IT-330\week 8\Proj4-Khan\Views\Home\Submit.cshtml"
                       Write(Model.UserInfo.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4><strong>Zip: </strong>");
#nullable restore
#line 17 "C:\Users\umark\OneDrive\Desktop\Spring 2022\IT-330\week 8\Proj4-Khan\Views\Home\Submit.cshtml"
                     Write(Model.UserInfo.Zip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4><strong>Username: </strong>");
#nullable restore
#line 18 "C:\Users\umark\OneDrive\Desktop\Spring 2022\IT-330\week 8\Proj4-Khan\Views\Home\Submit.cshtml"
                          Write(Model.UserInfo.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4><strong>Password: </strong>");
#nullable restore
#line 19 "C:\Users\umark\OneDrive\Desktop\Spring 2022\IT-330\week 8\Proj4-Khan\Views\Home\Submit.cshtml"
                          Write(Model.UserInfo.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4><strong>Degree Program: </strong>");
#nullable restore
#line 20 "C:\Users\umark\OneDrive\Desktop\Spring 2022\IT-330\week 8\Proj4-Khan\Views\Home\Submit.cshtml"
                                Write(Model.UserInfo.DegreeProgram);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4><strong>Age: </strong>");
#nullable restore
#line 21 "C:\Users\umark\OneDrive\Desktop\Spring 2022\IT-330\week 8\Proj4-Khan\Views\Home\Submit.cshtml"
                     Write(Model.UserInfo.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4><strong>Status: </strong>");
#nullable restore
#line 22 "C:\Users\umark\OneDrive\Desktop\Spring 2022\IT-330\week 8\Proj4-Khan\Views\Home\Submit.cshtml"
                        Write(Model.UserInfo.FirstTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4><strong>Notification: </strong>");
#nullable restore
#line 23 "C:\Users\umark\OneDrive\Desktop\Spring 2022\IT-330\week 8\Proj4-Khan\Views\Home\Submit.cshtml"
                              Write(Model.UserInfo.Notification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<br>\r\n\r\n<h4><strong>Registered On: </strong>");
#nullable restore
#line 26 "C:\Users\umark\OneDrive\Desktop\Spring 2022\IT-330\week 8\Proj4-Khan\Views\Home\Submit.cshtml"
                               Write(Model.RegistrationDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4><strong>Client Info: </strong>");
#nullable restore
#line 27 "C:\Users\umark\OneDrive\Desktop\Spring 2022\IT-330\week 8\Proj4-Khan\Views\Home\Submit.cshtml"
                             Write(Model.ClientInfo);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h4>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proj3_Khan.Models.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591