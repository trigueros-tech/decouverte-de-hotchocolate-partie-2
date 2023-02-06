using HotChocolate;

namespace GraphqlAPI.Queries
{
    // [Authorize] // Cela sera couvert davantage dans un prochain article
    public class Hello
    {
        public string SayHello()
        {
            return "World";
        }

        [GraphQLDescription("Say hello to the given name")]
        // [AllowAnonymous] // Cela sera couvert davantage dans un prochain article
        public string HelloName(string name)
        {
            return $"Hello {name}";
        }
    }
}