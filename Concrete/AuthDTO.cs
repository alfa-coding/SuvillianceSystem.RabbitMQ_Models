using System;

namespace SuvillianceSystem.RabbitMQ_Models.Concrete
{
    public class AuthDTO
    {
        public OperationType Operation { get; set; }

        public string UserName {get;set;}

        public AuthToken Token { get; set; }
        public OperationStatus Status { get; set; }
    }
}