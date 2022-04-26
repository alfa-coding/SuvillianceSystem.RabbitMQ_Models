using System;
using SuvillianceSystem.RabbitMQ_Models.Infrastructure;

namespace SuvillianceSystem.RabbitMQ_Models.Concrete
{
    public class AuthManagerInfo: IAuthManagerInfo
    {
        public string Secret { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
    }
}