using System;

namespace SuvillianceSystem.RabbitMQ_Models.Infrastructure
{
    public interface IAuthManagerInfo
    {
        string Secret { get; set; }
        string Audience { get; set; }
        string Issuer { get; set; }
    }
}