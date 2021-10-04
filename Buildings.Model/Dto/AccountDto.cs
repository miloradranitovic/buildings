using System;

namespace Buildings.Model.Dto
{
    public class AccountDto
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public decimal Balance { get; set; }
        public decimal StartingBalance { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
