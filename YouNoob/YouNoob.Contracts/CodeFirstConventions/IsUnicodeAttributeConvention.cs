using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;
using YouNoob.Contracts.DataAnnotations;

namespace YouNoob.Contracts.CodeFirstConventions
{
    public class IsUnicodeAttributeConvention :
        PrimitivePropertyAttributeConfigurationConvention<IsUnicodeAttribute>
    {
        public override void Apply(
            ConventionPrimitivePropertyConfiguration configuration,
            IsUnicodeAttribute attribute)
        {
            configuration.IsUnicode(attribute.IsUnicode);
        }
    }
}