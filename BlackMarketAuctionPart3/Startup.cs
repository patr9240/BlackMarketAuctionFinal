using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlackMarketAuctionPart3.Startup))]
namespace BlackMarketAuctionPart3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
