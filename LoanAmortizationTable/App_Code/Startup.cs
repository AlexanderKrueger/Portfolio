using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoanAmortizationTable.Startup))]
namespace LoanAmortizationTable
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
