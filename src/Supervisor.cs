namespace ChainOfResponsibility;

public class Supervisor : Aprover
{
    public override void Handle(ExpenseRequest request)
    {
        if (request.Amount <= 100)
        {
            Console.WriteLine($"✅ [Supervisor] Pedido de {request.Amount} aprovado");
        }
        else
        {
            Console.WriteLine($"❌ [Supervisor] Pedido de {request.Amount} rejeitado");
            _next?.Handle(request);
        }
    }
}