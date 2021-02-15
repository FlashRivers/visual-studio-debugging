using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanCalculator.Core.DataInterface;
using LoanCalculator.Core.Domain;
using LoanCalculator.Core.Services;
using LoanCalculator.Data.EFCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LoanCalculator.RazorPages
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            var connectionString = "DataSource=:memory:";
            services.ConfigureSqlLiteDatabase(connectionString);
            services.ConfigureRepositories();

            services.AddRazorPages();

            var rules = new List<ILoanQualificationRule>()
            {
                new CreditScoreLoanApprovalRule(),
                new LoanSizeLoanApprovalRule(),
                new IncomeApprovalRule(),
                new TermLengthApprovalRule(),
                new EmploymentLengthApprovalRule(),
            };
            services.AddScoped<List<ILoanQualificationRule>>(provider => rules);
            services.AddScoped<LoanProcessingService, LoanProcessingService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseRouting();

            app.UseEndpoints(ep =>
            {
                ep.MapDefaultControllerRoute();
                ep.MapRazorPages();
            });

        }
    }
}
