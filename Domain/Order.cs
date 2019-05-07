using System;

namespace Domain
{
    public class Order : BaseClass
    {
        public Guid BranchId { get; set; }
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool Approved { get; set; }
        public Guid ApprovedByUserId { get; set; }

        public Order()
        {
            Approved = false;
        }

    }
}
