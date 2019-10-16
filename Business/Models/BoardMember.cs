namespace Business.Models
{
    public class BoardMember
    {
        public int BoardMemberId { get; set; }
        public int CharityId { get; set; }
        public virtual Charity Charity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}