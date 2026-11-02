namespace TaskApi.Repositories
{
    public interface ISoftDeletable
    {
        bool IsDeleted { get; set; }
        public string? DeletedByName { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}
