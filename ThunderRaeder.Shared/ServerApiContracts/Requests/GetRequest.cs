namespace ThunderRaeder.Shared.ServerApiContracts.Requests
{
    public abstract class GetRequest : IPaginateable, IOrderable, ITimeStampable
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string OrderBy { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
    }
}
