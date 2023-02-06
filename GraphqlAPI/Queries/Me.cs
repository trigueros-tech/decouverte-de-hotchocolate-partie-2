using HotChocolate.Types;

namespace GraphqlAPI.Queries
{
    public class Me
    {
        public string Name  => "John Doe";
    }

    public class MeObjectType : ObjectType<Me>
    {
        protected override void Configure(IObjectTypeDescriptor<Me> descriptor)
        {
            descriptor.Field(x => x.Name)
                .Description("Oui, je ne fais pas dans l'originalité.");
            
            base.Configure(descriptor);
        }
    }
}