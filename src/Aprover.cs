namespace ChainOfResponsibility;

public abstract class Aprover
{
    protected Aprover? _next;

    public Aprover SetNext(Aprover aprover)
    {
        _next = aprover;
        return aprover;
    }

    public abstract void Handle(ExpenseRequest request);
}