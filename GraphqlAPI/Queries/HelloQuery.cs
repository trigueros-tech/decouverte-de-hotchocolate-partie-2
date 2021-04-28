namespace GraphqlAPI.Queries
{
    public class HelloQuery
    {
        public string Hello()
        {
            return "World";
        }

        public string HelloName(string name)
        {
            return $"Hello {name}";
        }
    }
}