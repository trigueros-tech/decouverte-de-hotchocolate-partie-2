using System.Runtime.CompilerServices;
using HotChocolate.Types;
using Microsoft.AspNetCore.Mvc;

namespace GraphqlAPI.Queries
{
    public class Me
    {
        public string Name  => "Rick Sanchez";
    }

    public class MeObjectType : ObjectType<Me>
    {
        protected override void Configure(IObjectTypeDescriptor<Me> descriptor)
        {
            descriptor.Field(x => x.Name)
                .Description("Oui, j'adore Rick & Morty");
            
            base.Configure(descriptor);
        }
    }
}