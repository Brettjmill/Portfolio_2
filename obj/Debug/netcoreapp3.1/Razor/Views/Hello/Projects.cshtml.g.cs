#pragma checksum "C:\Users\speed\Desktop\Coding_Dojo\c_stack\Portfolio_2\Views\Hello\Projects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f9a4b5fcc40b1bf16bad9ef77aadd2ea1f9d263"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hello_Projects), @"mvc.1.0.view", @"/Views/Hello/Projects.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f9a4b5fcc40b1bf16bad9ef77aadd2ea1f9d263", @"/Views/Hello/Projects.cshtml")]
    public class Views_Hello_Projects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f9a4b5fcc40b1bf16bad9ef77aadd2ea1f9d2632730", async() => {
                WriteLiteral("\r\n        <meta charset=\'utf-8\'>\r\n        <title>My Portfolio</title>\r\n    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f9a4b5fcc40b1bf16bad9ef77aadd2ea1f9d2633779", async() => {
                WriteLiteral(@"
        <div style = ""max-width: 1000px; text-align: center"">
            <h2 style = ""text-align: center; font-family: Helvetica"">
                <a style = ""text-decoration: none; color: black"" href=""/"">Home</a> | <a style = ""text-decoration: none; color: black"" href=""/projects"">Projects</a> | <a style = ""text-decoration: none; color: black"" href=""/contact"">Contact</a>
            </h2>
            <br>
            <h1 style = ""text-align: center; font-family: Helvetica"">Here are some projects of mine!</h1>
            <div style = ""display: inline-block; text-align: center"">
                <div style = ""text-align: center; max-width: 500px; border: 1px solid black; padding: 10px; margin-bottom: 10px; display: flex"">
                    <div>
                        <img style = ""max-width: 150px; margin-right: 20px"" src=""https://fermi.gsfc.nasa.gov/science/constellations/pages/inc/img/godzilla/Godzilla_Artwork.jpg"" alt=""godzillaPic"">
                    </div>
                    <div>
    ");
                WriteLiteral(@"                    <p style = ""font-weight: bold"">Godzilla Movie Collection!</p>
                        <p>Discover and begin your journey through the King of the Monster's filmography!</p>
                    </div>
                </div>
                <div style = ""text-align: center; max-width: 500px; border: 1px solid black; padding: 10px; margin-bottom: 10px; display: flex"">
                    <div>
                        <img style = ""max-width: 150px; margin-right: 20px"" src=""https://upload.wikimedia.org/wikipedia/en/thumb/4/48/Seattle_Kraken_official_logo.svg/1200px-Seattle_Kraken_official_logo.svg.png"" alt=""krakenPic"">
                    </div>
                    <div>
                        <p style = ""font-weight: bold"">Build your own Kraken hockey team!</p>
                        <p>Select players from across the NHL to build the ultimate version of the Seattle Kraken!</p>
                    </div>
                </div>
                <div style = ""text-align: center; max");
                WriteLiteral(@"-width: 500px; border: 1px solid black; padding: 10px; margin-bottom: 10px; display: flex"">
                    <div>
                        <img style = ""max-width: 150px; margin-right: 20px"" src=""https://powelllacrosse.com/wp-content/uploads/2020/04/mysterybox.jpg"" alt=""mysteryPic"">
                    </div>
                    <div>
                        <p style = ""font-weight: bold"">TBD!</p>
                        <p>TBD</p>
                    </div>
                </div>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
