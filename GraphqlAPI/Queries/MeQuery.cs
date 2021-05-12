using HotChocolate.Types;
using Microsoft.AspNetCore.Mvc;

namespace GraphqlAPI.Queries
{
    [ExtendObjectType(typeof(Query))]
    public class MeQuery
    {
        public Me Me([FromServices] Me query) => query;   
    }
}