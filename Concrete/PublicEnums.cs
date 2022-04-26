using System;

namespace SuvillianceSystem.RabbitMQ_Models.Concrete
{
    public enum OperationType
    {
        Authorization,
        Validation
    }
    public enum OperationStatus
    {
        Authorized,
        Unauthorized
    }
}