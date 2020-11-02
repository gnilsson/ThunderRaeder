namespace ThunderRaeder.Shared.ServerApiContracts.Requests
{
    public class GetBooksRequest : GetRequest
    {
        public string Title { get; set; }
        public string Author { get; set; }     
    }
}
