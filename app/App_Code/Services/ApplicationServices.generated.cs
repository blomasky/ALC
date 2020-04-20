using FreeTrial.Handlers;
using FreeTrial.Data;
using FreeTrial.Web;
using System.Web.Configuration;

namespace FreeTrial.Services
{
	public class AppFrameworkConfig
    {
        
        public virtual void Initialize()
        {
            ApplicationServices.FrameworkAppName = "American Lumber Co. Inc.";
            ApplicationServices.Version = "8.9.4.0";
            ApplicationServices.JqmVersion = "1.4.6";
            ApplicationServices.HostVersion = "1.2.5.0";
            var releaseMode = true;
            AquariumExtenderBase.EnableMinifiedScript = releaseMode;
            AquariumExtenderBase.EnableCombinedScript = releaseMode;
            ApplicationServices.EnableMinifiedCss = releaseMode;
            ApplicationServices.EnableCombinedCss = releaseMode;
            CultureManager.SupportedCultures = new string[] {
                    "en-US,en-US"};
            ApplicationServicesBase.AuthorizationIsSupported = false;
            BlobFactoryConfig.Initialize();
        }
    }
}
