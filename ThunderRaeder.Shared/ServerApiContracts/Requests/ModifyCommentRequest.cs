namespace ThunderRaeder.Shared.ServerApiContracts.Requests
{
    public class ModifyCommentRequest
    {
        public string Message { get; set; }
        public string AdditionalContent { get; set; }
        public int Upvotes { get; set; }
    }
}
