using System.Collections.Generic;
using FluentNHibernate.Conventions;
using Throne.Framework.Persistence.Conventions.Identity;
using Throne.Framework.Persistence.Conventions.Naming;
using Throne.Framework.Persistence.Conventions.Properties;
using Throne.Framework.Persistence.Conventions.Relationships;

namespace Throne.Framework.Persistence
{
    public abstract class GameDatabaseContext : DatabaseContext
    {
        protected override sealed IEnumerable<IConvention> CreateConventions()
        {
            yield return new IdConvention();
            yield return new IdGenerationConvention();

            yield return new ClassNameConvention();
            yield return new ForeignKeyNameConvention();

            yield return new PropertyNullableConvention();
            yield return new PropertyUpdateConvention();

            yield return new ReferenceConvention();
            yield return new RelationshipCascadeConvention();
            yield return new RelationshipFetchConvention();
            yield return new RelationshipLazyLoadConvention();
        }
    }
}