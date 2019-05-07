using System;

namespace Domain
{
    public class User : BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Infix { get; set; }
        public string EmailAddress { get; set; }
        public string PassWord { get; set; }
        public Guid BranchId { get; set; }

    }
}
