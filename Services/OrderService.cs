using ProvaPub.Models;

namespace ProvaPub.Services
{
	public class OrderService
	{
        private readonly Dictionary<string, Func<Task>> paymentMethods = new Dictionary<string, Func<Task>>
        {
            ["pix"] =
            {
                // Faz Pagamento
            },
            ["creditcard"] = 
            {
                //Faz pagamento...
            },
            ["paypal"] = 
            {
                //Faz pagamento...
            },
            ["cash"] =
            {
                //Faz pagamento...
            }
        };

        public async Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId)
		{
            if (paymentMethods.TryGetValue(paymentMethod, out var paymentFunction))
            {
                await paymentFunction.Invoke();
            }
            else
            {
                Console.WriteLine("Método de pagamento não suportado.");
            }

            return await Task.FromResult( new Order()
			{
				Value = paymentValue
			});
		}
	}
}
