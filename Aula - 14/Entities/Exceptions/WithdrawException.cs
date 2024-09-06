namespace Course.Entities.Exceptions;

class WithdrawException : DomainException
{
    public WithdrawException(string message):
    base(message){}
}