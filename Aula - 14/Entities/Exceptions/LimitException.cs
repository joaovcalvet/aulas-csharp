namespace Course.Entities.Exceptions;

class LimitException : DomainException
{
    public LimitException(string message):
    base(message){}
}