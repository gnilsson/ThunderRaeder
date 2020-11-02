namespace ThunderRaeder.Shared.ServerApiContracts.Requests
{
    public class GetUsersRequest : GetRequest //IPaginateable, IOrderable, ITimeStampable
    {
        //public int PageNumber { get; set; }
        //public int PageSize { get; set; }

        //public string OrderBy { get; set; }
        //public string CreatedDate { get; set; }
        //public string UpdatedDate { get; set; }
        public string Alias { get; set; }
    }
}
