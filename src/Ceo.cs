namespace ChainOfResponsibility;

public class Ceo : Aprover
{
    public override void Handle(ExpenseRequest request)
    {
        Console.WriteLine($"✅ [CEO] Pedido de {request.Amount} aprovado");
    }
}