using Orchard.UI.Resources;

namespace Fukasawa {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            // Register styles
            manifest.DefineStyle("MediaElement").SetUrl("mediaelementplayer.css");
            manifest.DefineStyle("OrchardMediaElement").SetUrl("orchard-mediaplayer.css");
            manifest.DefineStyle("ThemeStyles").SetUrl("styles.css");
            manifest.DefineStyle("GenericIcons").SetUrl("genericicons.css");
            manifest.DefineStyle("GoogleFonts").SetUrl("//fonts.googleapis.com/css?family=Lato%3A400%2C400italic%2C700%2C700italic&ver=4.4.5");


            // Register javascript files
            manifest.DefineScript("MediaElement").SetUrl("mediaelement-and-player.js");
            manifest.DefineScript("ThemeScripts").SetUrl("global.js").SetDependencies("jQuery");
            manifest.DefineScript("Masonry").SetUrl("masonry.pkgd.js");
            manifest.DefineScript("ImagesLoaded").SetUrl("imagesloaded.pkgd.js");
            manifest.DefineScript("Flexslider").SetUrl("flexslider.min.js");

        }
    }
}