using System;
using System.Linq;
using Orchard.ContentManagement;
using Orchard.Fields.Fields;

namespace Fukasawa {
    public static class FukasawaExtensions {
        public static BlogPostTypes GetBlogPostType(this ContentPart contentPart) {
            EnumerationField field = (EnumerationField) contentPart.Fields.SingleOrDefault(f => f.Name == "BlogPostType");
            if (field == null)
                return BlogPostTypes.Image;
           
            BlogPostTypes blogPostType;
            if (Enum.TryParse(field.Value, true, out blogPostType))
                return blogPostType;
            return BlogPostTypes.Image;
        }
    }
}