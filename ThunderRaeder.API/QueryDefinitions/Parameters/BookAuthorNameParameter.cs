using ThunderRaeder.API.QueryDefinitions.Parameters.BaseParameters;
using ThunderRaeder.Data.Entities;

namespace ThunderRaeder.API.QueryDefinitions.Parameters
{
    public class BookAuthorNameParameter : StringParameter
    {
        public override void Set(string value)
        {
            base.Set(value);
            TableReferenceParents = new[] { nameof(Book.Author) };
            TableReferenceChildren = new[] { nameof(Book.Author.Lastname), 
                                             nameof(Book.Author.Firstname) };
        }
    }
}
