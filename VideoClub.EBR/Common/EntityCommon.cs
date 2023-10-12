namespace VideoClub.Entities.Common
{
    public class EntityCommon
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; } = 0;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public int UpdatedBy { get; set; } = 0;
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;
    }
}
