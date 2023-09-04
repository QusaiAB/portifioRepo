#pragma checksum "C:\Users\PC\Source\Repos\portifio\Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bbb26288ea118aebcfc15b313a0369f7dfced9c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bbb26288ea118aebcfc15b313a0369f7dfced9c", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("masthead-avatar mb-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/avatar.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:50%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/portfolio/instagram.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded mb-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Masthead -->\r\n<header class=\"masthead bg-primary text-white text-center\">\r\n    <div class=\"container d-flex align-items-center flex-column\">\r\n\r\n        <!-- Masthead Avatar Image -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7bbb26288ea118aebcfc15b313a0369f7dfced9c5236", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        <!-- Masthead Heading -->
        <h1 class=""masthead-heading text-uppercase mb-0"">Start Bootstrap</h1>

        <!-- Icon Divider -->
        <div class=""divider-custom divider-light"">
            <div class=""divider-custom-line""></div>
            <div class=""divider-custom-icon"">
                <i class=""fas fa-star""></i>
            </div>
            <div class=""divider-custom-line""></div>
        </div>

        <!-- Masthead Subheading -->
        <p class=""masthead-subheading font-weight-light mb-0"">Graphic Artist - Web Designer - Illustrator</p>

    </div>
</header>

<!-- Portfolio Section -->
<section class=""page-section portfolio"" id=""portfolio"">
    <div class=""container"">

        <!-- Portfolio Section Heading -->
        <h2 class=""page-section-heading text-center text-uppercase text-secondary mb-0"">Portfolio</h2>

        <!-- Icon Divider -->
        <div class=""divider-custom"">
            <div class=""divider-custom-line""></div>
            <div clas");
            WriteLiteral(@"s=""divider-custom-icon"">
                <i class=""fas fa-star""></i>
            </div>
            <div class=""divider-custom-line""></div>
        </div>

        <!-- Portfolio Grid Items -->
        <div class=""row"">

            <!-- Portfolio Item 1 -->
            <div class=""col-md-6 col-lg-4"">
                <div class=""portfolio-item mx-auto"" data-toggle=""modal"" data-target=""#portfolioModal1"">
                    <div class=""portfolio-item-caption d-flex align-items-center justify-content-center h-100 w-100"">
                        <div class=""portfolio-item-caption-content text-center text-white"">
                            <i class=""fas fa-plus fa-3x""></i>
                        </div>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7bbb26288ea118aebcfc15b313a0369f7dfced9c8391", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>



        </div>
        <!-- /.row -->

    </div>
</section>

<!-- About Section -->
<section class=""page-section bg-primary text-white mb-0"" id=""about"">
    <div class=""container"">

        <!-- About Section Heading -->
        <h2 class=""page-section-heading text-center text-uppercase text-white"">About</h2>

        <!-- Icon Divider -->
        <div class=""divider-custom divider-light"">
            <div class=""divider-custom-line""></div>
            <div class=""divider-custom-icon"">
                <i class=""fas fa-star""></i>
            </div>
            <div class=""divider-custom-line""></div>
        </div>

        <!-- About Section Content -->
        <div class=""row"">
            <div class=""col-lg-4 ml-auto"">
                <p class=""lead"">Freelancer is a free bootstrap theme created by Start Bootstrap. The download includes the complete source files including HTML, CSS, and JavaScript as well as optional SASS stylesheet");
            WriteLiteral(@"s for easy customization.</p>
            </div>
            <div class=""col-lg-4 mr-auto"">
                <p class=""lead"">You can create your own custom avatar for the masthead, change the icon in the dividers, and add your email address to the contact form to make it fully functional!</p>
            </div>
        </div>

        <!-- About Section Button -->
        <div class=""text-center mt-4"">
            <a class=""btn btn-xl btn-outline-light"" href=""https://startbootstrap.com/themes/freelancer/"">
                <i class=""fas fa-download mr-2""></i>
                Free Download!
            </a>
        </div>

    </div>
</section>

<!-- Contact Section -->
<section class=""page-section"" id=""contact"">
    <div class=""container"">

        <!-- Contact Section Heading -->
        <h2 class=""page-section-heading text-center text-uppercase text-secondary mb-0"">Contact Me</h2>

        <!-- Icon Divider -->
        <div class=""divider-custom"">
            <div class=""divider-cus");
            WriteLiteral(@"tom-line""></div>
            <div class=""divider-custom-icon"">
                <i class=""fas fa-star""></i>
            </div>
            <div class=""divider-custom-line""></div>
        </div>

        <!-- Contact Section Form -->
        <div class=""row"">
            <div class=""col-lg-8 mx-auto"">
                <!-- To configure the contact form email address, go to mail/contact_me.php and update the email address in the PHP file on line 19. -->
                <form name=""sentMessage"" id=""contactForm"" novalidate=""novalidate"">
                    <div class=""control-group"">
                        <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                            <label>Name</label>
                            <input class=""form-control"" id=""name"" type=""text"" placeholder=""Name"" required=""required"" data-validation-required-message=""Please enter your name."">
                            <p class=""help-block text-danger""></p>
                        </div>
    ");
            WriteLiteral(@"                </div>
                    <div class=""control-group"">
                        <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                            <label>Email Address</label>
                            <input class=""form-control"" id=""email"" type=""email"" placeholder=""Email Address"" required=""required"" data-validation-required-message=""Please enter your email address."">
                            <p class=""help-block text-danger""></p>
                        </div>
                    </div>
                    <div class=""control-group"">
                        <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                            <label>Phone Number</label>
                            <input class=""form-control"" id=""phone"" type=""tel"" placeholder=""Phone Number"" required=""required"" data-validation-required-message=""Please enter your phone number."">
                            <p class=""help-block text-danger""></p>
         ");
            WriteLiteral(@"               </div>
                    </div>
                    <div class=""control-group"">
                        <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                            <label>Message</label>
                            <textarea class=""form-control"" id=""message"" rows=""5"" placeholder=""Message"" required=""required"" data-validation-required-message=""Please enter a message.""></textarea>
                            <p class=""help-block text-danger""></p>
                        </div>
                    </div>
                    <br>
                    <div id=""success""></div>
                    <div class=""form-group"">
                        <button type=""submit"" class=""btn btn-primary btn-xl"" id=""sendMessageButton"">Send</button>
                    </div>
                </form>
            </div>
        </div>

    </div>
</section>

<!-- Portfolio Modals -->
<!-- Portfolio Modal 1 -->
<div class=""portfolio-modal modal fade"" id=""portf");
            WriteLiteral(@"olioModal1"" tabindex=""-1"" role=""dialog"" aria-labelledby=""portfolioModal1Label"" aria-hidden=""true"">
    <div class=""modal-dialog modal-xl"" role=""document"">
        <div class=""modal-content"">
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                <span aria-hidden=""true"">
                    <i class=""fas fa-times""></i>
                </span>
            </button>
            <div class=""modal-body text-center"">
                <div class=""container"">
                    <div class=""row justify-content-center"">
                        <div class=""col-lg-8"">
                            <!-- Portfolio Modal - Title -->
                            <h2 class=""portfolio-modal-title text-secondary text-uppercase mb-0"">Log Cabin</h2>
                            <!-- Icon Divider -->
                            <div class=""divider-custom"">
                                <div class=""divider-custom-line""></div>
                                <div clas");
            WriteLiteral(@"s=""divider-custom-icon"">
                                    <i class=""fas fa-star""></i>
                                </div>
                                <div class=""divider-custom-line""></div>
                            </div>
                            <!-- Portfolio Modal - Image -->
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7bbb26288ea118aebcfc15b313a0369f7dfced9c16447", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <!-- Portfolio Modal - Text -->
                            <p class=""mb-5"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia neque assumenda ipsam nihil, molestias magnam, recusandae quos quis inventore quisquam velit asperiores, vitae? Reprehenderit soluta, eos quod consequuntur itaque. Nam.</p>
                            <button class=""btn btn-primary"" href=""#"" data-dismiss=""modal"">
                                <i class=""fas fa-times fa-fw""></i>
                                Close Window
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
