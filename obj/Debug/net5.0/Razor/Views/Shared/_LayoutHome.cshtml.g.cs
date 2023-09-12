#pragma checksum "C:\Users\ADMIN\Desktop\TodoMVC\Views\Shared\_LayoutHome.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2ae01ada631b449a663dd690c8249d41f2d61ff0bd592cab27930436321b5d96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutHome), @"mvc.1.0.view", @"/Views/Shared/_LayoutHome.cshtml")]
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
#line 1 "C:\Users\ADMIN\Desktop\TodoMVC\Views\_ViewImports.cshtml"
using UniqueTodoApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\Desktop\TodoMVC\Views\_ViewImports.cshtml"
using UniqueTodoApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2ae01ada631b449a663dd690c8249d41f2d61ff0bd592cab27930436321b5d96", @"/Views/Shared/_LayoutHome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1e061fb2e45ddc075d60d2210274140d6787963ff699240fc121c1d03683c2e3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__LayoutHome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n <html lang=\"en\" class=\"no-js\"> \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ae01ada631b449a663dd690c8249d41f2d61ff0bd592cab27930436321b5d963780", async() => {
                WriteLiteral(@"
        <title>Unique To-Do Application</title>		
		
        <link rel=""stylesheet"" href=""HomePage/css/font-awesome.min.css"">
		<!-- Twitter Bootstrap css -->
        <link rel=""stylesheet"" href=""HomePage/css/bootstrap.min.css"">
		<!-- jquery.fancybox  -->
        <link rel=""stylesheet"" href=""HomePage/css/jquery.fancybox.css"">
		<!-- animate -->
        <link rel=""stylesheet"" href=""HomePage/css/animate.css"">
		<!-- Main Stylesheet -->
        <link rel=""stylesheet"" href=""HomePage/css/main.css"">
		<!-- media-queries -->
        <link rel=""stylesheet"" href=""HomePage/css/media-queries.css"">

		<!-- Modernizer Script for old Browsers -->
        <script src=""js/modernizr-2.6.2.min.js""></script>

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ae01ada631b449a663dd690c8249d41f2d61ff0bd592cab27930436321b5d965527", async() => {
                WriteLiteral(@"
	
		<!-- preloader -->
		<div id=""preloader"">
			<img src=""HomePage/img/preloader.gif"" alt=""Preloader"">
		</div>
		<!-- end preloader -->

        <!-- 
        Fixed Navigation
        ==================================== -->
        <header id=""navigation"" class=""navbar-fixed-top navbar"">
            <div class=""container"">
                <div class=""navbar-header"">
                    <!-- responsive nav button -->
					<button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                        <span class=""sr-only"">Toggle navigation</span>
                        <i class=""fa fa-bars fa-2x""></i>
                    </button>
					<!-- /responsive nav button -->
					
					<!-- logo -->
                    <a class=""navbar-brand"" href=""#body"">
						<h1 id=""unique"">
							<img src=""HomePage/img/logo.png"" alt=""To-Do App"">
						</h1>
					</a>
					<!-- /logo -->
                </div>

				<!-- main nav -->
                <na");
                WriteLiteral(@"v class=""collapse navbar-collapse navbar-right"" role=""navigation"">
                    <ul id=""nav"" class=""nav navbar-nav"">
                        
                        <li><a href=""#works"">Sign-Up</a></li> 
                        <li><a  href=""User/SignIn"">Sign-In</a></li>
");
                WriteLiteral(@"						
                    </ul>
                </nav>
				<!-- /main nav -->
				
            </div>
        </header>
        <!--
        End Fixed Navigation
        ==================================== -->
		
        <!--
        Home Slider
        ==================================== -->
		<div class=""main-container"">
            <main role=""main"">
                ");
#nullable restore
#line 76 "C:\Users\ADMIN\Desktop\TodoMVC\Views\Shared\_LayoutHome.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </main>
       </div>
		<section id=""slider"">
			<div id=""carousel-example-generic"" class=""carousel slide"" data-ride=""carousel"">
			
				<!-- Indicators bullet -->
				<ol class=""carousel-indicators"">
					<li data-target=""#carousel-example-generic"" data-slide-to=""0"" class=""active""></li>
					<li data-target=""#carousel-example-generic"" data-slide-to=""1""></li>
				</ol>
				<!-- End Indicators bullet -->				
				
				<!-- Wrapper for slides -->
				<div class=""carousel-inner"" role=""listbox"">
					
					<!-- single slide -->
					<div class=""item active"" style=""background-image: url(HomePage/img/banner.jpg);"">
						<div class=""carousel-caption"">
							<h2 data-wow-duration=""700ms"" data-wow-delay=""500ms"" class=""wow bounceInDown animated"">Unique<span> To-Do</span> App!</h2>
							<h3 data-wow-duration=""1000ms"" class=""wow slideInLeft animated""><span class=""color"">A very</span> reliable App.</h3>
							<p data-wow-duration=""1000ms"" class=""wow slideInRight animated"">We are here ");
                WriteLiteral(@"to help you in achieving your daily activities</p>
							
						</div>
					</div>
			
					<div class=""item"" style=""background-image: url(HomePage/img/banner.jpg);"">
						<div class=""carousel-caption"">
							<h2 data-wow-duration=""500ms"" data-wow-delay=""500ms"" class=""wow bounceInDown animated"">Unique<span> To-Do</span> App!</h2>
							<h3 data-wow-duration=""500ms"" class=""wow slideInLeft animated""><span class=""color"">Your satisfaction </span> is our concern.</h3>
							<p data-wow-duration=""500ms"" class=""wow slideInRight animated"">Your number one Task Scheduling Application.</p>
						</div>
					</div>
				</div>
				
			</div>
		</section>

");
                WriteLiteral(@"
		<!-- Essential jQuery Plugins
		================================================== -->
		<!-- Main jQuery -->
        <script src=""HomePage/js/jquery-1.11.1.min.js""></script>
		<!-- Single Page Nav -->
        <script src=""HomePage/js/jquery.singlePageNav.min.js""></script>
		<!-- Twitter Bootstrap -->
        <script src=""HomePage/js/bootstrap.min.js""></script>
		<!-- jquery.fancybox.pack -->
        <script src=""HomePage/js/jquery.fancybox.pack.js""></script>
		<!-- jquery.mixitup.min -->
        <script src=""HomePage/js/jquery.mixitup.min.js""></script>
		<!-- jquery.parallax -->
        <script src=""HomePage/js/jquery.parallax-1.1.3.js""></script>
		<!-- jquery.countTo -->
        <script src=""HomePage/js/jquery-countTo.js""></script>
		<!-- jquery.appear -->
        <script src=""HomePage/js/jquery.appear.js""></script>
		<!-- Contact form validation -->
		<script src=""http://cdnjs.cloudflare.com/ajax/libs/jquery.form/3.32/jquery.form.js""></script>
		<script src=""http://cdnjs.cloudflare.");
                WriteLiteral("com/ajax/libs/jquery-validate/1.11.1/jquery.validate.min.js\"></script>\r\n\t\t<!-- Google Map -->\r\n");
                WriteLiteral("\t\t<!-- jquery easing -->\r\n        <script src=\"HomePage/js/jquery.easing.min.js\"></script>\r\n\t\t<!-- jquery easing -->\r\n        <script src=\"HomePage/js/wow.min.js\"></script>\r\n");
                WriteLiteral("\t\t<!-- Custom Functions -->\r\n        <script src=\"HomePage/js/custom.js\"></script>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
