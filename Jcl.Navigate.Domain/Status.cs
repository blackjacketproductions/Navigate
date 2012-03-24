namespace Jcl.Navigate.Domain
{
    public class Status
    {
        public Status()
        {
            StatusType = new StatusType();
        }

        public string Id { get; set; }

        public string CssClass { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public StatusType StatusType { get; set; }
    }
}
