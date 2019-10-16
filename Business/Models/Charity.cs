using System.Collections.Generic;

namespace Business.Models
{
    public class Charity
    {
        public Charity()
        {
            this.BoardMembers = new HashSet<BoardMember>();
        }
        public virtual ICollection<BoardMember> BoardMembers { get; set; }
        public int CharityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}