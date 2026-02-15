namespace ChainOfResponsibility;

public static class Program
{
    public static void Main(string[] args)
    {
        var supervisor = new Supervisor();
        var manager = new Manager();
        var director = new Director();
        var ceo = new Ceo();

        supervisor.SetNext(manager).SetNext(director).SetNext(ceo);

        var expenseRequest = new ExpenseRequest("Nicolas", 10000, "", "");
        supervisor.Handle(expenseRequest);
    }
}