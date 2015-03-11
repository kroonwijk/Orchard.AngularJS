using Orchard.UI.Resources;

namespace Orchard.AngularJS
{
    public class ResourceManifest : IResourceManifestProvider
    {
        private const string StableVersion = "1.3.14";

        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            // main library
            manifest.DefineScript("AngularJS")
                .SetUrl("angular.min.js", "angular.js")
                .SetVersion(StableVersion)
                .SetCdn(
                    string.Format("//ajax.googleapis.com/ajax/libs/angularjs/{0}/angular.min.js", StableVersion),
                    string.Format("//ajax.googleapis.com/ajax/libs/angularjs/{0}/angular.js", StableVersion),
                    true);

            // partial libraries
            manifest.DefineScript("AngularJS_Animate")
                .SetUrl("angular-animate.min.js", "angular-animate.js")
                .SetDependencies("AngularJS")
                .SetVersion(StableVersion);

            manifest.DefineScript("AngularJS_Aria")
                .SetUrl("angular-aria.min.js", "angular-aria.js")
                .SetDependencies("AngularJS")
                .SetVersion(StableVersion);

            manifest.DefineScript("AngularJS_Cookies")
                .SetUrl("angular-cookies.min.js", "angular-cookies.js")
                .SetDependencies("AngularJS")
                .SetVersion(StableVersion);

            manifest.DefineScript("AngularJS_Loader")
                .SetUrl("angular-loader.min.js", "angular-loader.js")
                .SetDependencies("AngularJS")
                .SetVersion(StableVersion);

            manifest.DefineScript("AngularJS_Messages")
                .SetUrl("angular-messages.js", "angular-messages.js")
                .SetDependencies("AngularJS")
                .SetVersion(StableVersion);

            manifest.DefineScript("AngularJS_Mocks")
                .SetUrl("angular-mocks.js", "angular-mocks.js")
                .SetDependencies("AngularJS")
                .SetVersion(StableVersion);

            manifest.DefineScript("AngularJS_Resource")
                .SetUrl("angular-resource.min.js", "angular-resource.js")
                .SetDependencies("AngularJS")
                .SetVersion(StableVersion);

            manifest.DefineScript("AngularJS_Route")
                .SetUrl("angular-route.min.js", "angular-route.js")
                .SetDependencies("AngularJS")
                .SetVersion(StableVersion);

            manifest.DefineScript("AngularJS_Sanitize")
                .SetUrl("angular-sanitize.min.js", "angular-sanitize.js")
                .SetDependencies("AngularJS")
                .SetVersion(StableVersion);

            manifest.DefineScript("AngularJS_Scenario")
                .SetUrl("angular-scenario.js", "angular-scenario.js")
                .SetDependencies("AngularJS")
                .SetVersion(StableVersion);

            manifest.DefineScript("AngularJS_Touch")
                .SetUrl("angular-touch.min.js", "angular-touch.js")
                .SetDependencies("AngularJS")
                .SetVersion(StableVersion);
        }
    }
}