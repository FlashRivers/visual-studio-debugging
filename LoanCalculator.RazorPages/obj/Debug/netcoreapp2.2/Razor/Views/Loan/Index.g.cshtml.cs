#pragma checksum "F:\Pluralsight\Visual Studio Debugging\visual-studio-2019-debugging-m03\deliverables\start\LoanCalculator.RazorPages\Views\Loan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5ed6497d5df70af5a6261d5a38e83bd72c97abb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Loan_Index), @"mvc.1.0.view", @"/Views/Loan/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Loan/Index.cshtml", typeof(AspNetCore.Views_Loan_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ed6497d5df70af5a6261d5a38e83bd72c97abb", @"/Views/Loan/Index.cshtml")]
    public class Views_Loan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoanCalculator.Core.Domain.LoanApplicationResult>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 415, true);
            WriteLiteral(@"
    <table class=""table table-striped table-bordered dt-responsive nowrap"">
        <thead class=""thead-light"">
            <tr>
                <th colspan=""2"">
                  Loan Details
                </th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    First Name:
                </td>
                <td>
                    ");
            EndContext();
            BeginContext(473, 15, false);
#line 17 "F:\Pluralsight\Visual Studio Debugging\visual-studio-2019-debugging-m03\deliverables\start\LoanCalculator.RazorPages\Views\Loan\Index.cshtml"
               Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(488, 181, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Last Name:\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(670, 14, false);
#line 25 "F:\Pluralsight\Visual Studio Debugging\visual-studio-2019-debugging-m03\deliverables\start\LoanCalculator.RazorPages\Views\Loan\Index.cshtml"
               Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(684, 178, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Amount:\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(863, 45, false);
#line 33 "F:\Pluralsight\Visual Studio Debugging\visual-studio-2019-debugging-m03\deliverables\start\LoanCalculator.RazorPages\Views\Loan\Index.cshtml"
               Write(Math.Round(Model.LoanAmount, 2).ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(908, 176, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Term:\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1085, 14, false);
#line 41 "F:\Pluralsight\Visual Studio Debugging\visual-studio-2019-debugging-m03\deliverables\start\LoanCalculator.RazorPages\Views\Loan\Index.cshtml"
               Write(Model.LoanTerm);

#line default
#line hidden
            EndContext();
            BeginContext(1099, 178, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Status:\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1279, 40, false);
#line 49 "F:\Pluralsight\Visual Studio Debugging\visual-studio-2019-debugging-m03\deliverables\start\LoanCalculator.RazorPages\Views\Loan\Index.cshtml"
                Write((Model.Approved) ? "Approved" : "Denied");

#line default
#line hidden
            EndContext();
            BeginContext(1320, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 52 "F:\Pluralsight\Visual Studio Debugging\visual-studio-2019-debugging-m03\deliverables\start\LoanCalculator.RazorPages\Views\Loan\Index.cshtml"
             if (!Model.Approved)
            {

#line default
#line hidden
            BeginContext(1414, 158, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        Reason:\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1573, 18, false);
#line 59 "F:\Pluralsight\Visual Studio Debugging\visual-studio-2019-debugging-m03\deliverables\start\LoanCalculator.RazorPages\Views\Loan\Index.cshtml"
                   Write(Model.DenialReason);

#line default
#line hidden
            EndContext();
            BeginContext(1591, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 62 "F:\Pluralsight\Visual Studio Debugging\visual-studio-2019-debugging-m03\deliverables\start\LoanCalculator.RazorPages\Views\Loan\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1658, 143, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    Monthly Payment:\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1802, 35, false);
#line 68 "F:\Pluralsight\Visual Studio Debugging\visual-studio-2019-debugging-m03\deliverables\start\LoanCalculator.RazorPages\Views\Loan\Index.cshtml"
               Write(Model.MonthlyPayment?.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1837, 165, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Interest Rate:\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 76 "F:\Pluralsight\Visual Studio Debugging\visual-studio-2019-debugging-m03\deliverables\start\LoanCalculator.RazorPages\Views\Loan\Index.cshtml"
                       
                        var label = "NA";
                        if(Model.InterestRate != null)
                        {
                            label = Model.InterestRate.Value.ToString("P");
                        }
                    

#line default
#line hidden
            BeginContext(2280, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2301, 5, false);
#line 83 "F:\Pluralsight\Visual Studio Debugging\visual-studio-2019-debugging-m03\deliverables\start\LoanCalculator.RazorPages\Views\Loan\Index.cshtml"
               Write(label);

#line default
#line hidden
            EndContext();
            BeginContext(2306, 74, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoanCalculator.Core.Domain.LoanApplicationResult> Html { get; private set; }
    }
}
#pragma warning restore 1591