namespace ChainOfResponsibility;

public class Director : Aprover
{
    public override void Handle(ExpenseRequest request)
    {
        if (request.Amount <= 5000)
        {
            Console.WriteLine($"✅ [Director] Pedido de {request.Amount} aprovado");
        }
        else
        {
            Console.WriteLine($"❌ [Director] Pedido de {request.Amount} rejeitado");
            _next?.Handle(request);
        }
    }
}