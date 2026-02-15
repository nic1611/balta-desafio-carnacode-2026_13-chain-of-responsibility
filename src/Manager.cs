namespace ChainOfResponsibility;

public class Manager : Aprover
{
    public override void Handle(ExpenseRequest request)
    {
        if (request.Amount <= 500)
        {
            Console.WriteLine($"✅ [Manager] Pedido de {request.Amount} aprovado");
        }
        else
        {
            Console.WriteLine($"❌ [Manager] Pedido de {request.Amount} rejeitado");
            _next?.Handle(request);
        }
    }
}