#pragma checksum "C:\Users\sergi\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a38e71ac6ea88f2b86a98ac6bc6a63e72072bc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\sergi\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sergi\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a38e71ac6ea88f2b86a98ac6bc6a63e72072bc8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClienteModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sergi\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Pagina Cliente";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
	<h1 class=""display-4"">Bienvenido</h1>

	<div class=""text-center"">
		<table cellpadding=""0"" cellspacing=""0"" class=""table"">
			<thead>
				<tr>
					<th scope=""col"">Clave</th>
					<th scope=""col"">Nombre</th>
					<th scope=""col"">Dirección</th>
					<th scope=""col"">Pedido</th>
				</tr>
			</thead>
");
#nullable restore
#line 19 "C:\Users\sergi\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
             foreach (ClienteModel Cliente in (ClienteModel[])ViewBag.ClienteModel)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 22 "C:\Users\sergi\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                   Write(Cliente.Clave_Cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 23 "C:\Users\sergi\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                   Write(Cliente.Nombre_Cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 24 "C:\Users\sergi\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                   Write(Cliente.Direccion_Cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 25 "C:\Users\sergi\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                   Write(Cliente.Pedido_Cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t</tr>\r\n");
#nullable restore
#line 27 "C:\Users\sergi\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</table>\r\n\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClienteModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
