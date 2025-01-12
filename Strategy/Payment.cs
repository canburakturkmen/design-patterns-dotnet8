namespace Strategy;

// Strategy Interface
public interface IPaymentStrategy
{
    void Pay(decimal amount);
}

// Concrete Strategies
public class CreditCardPayment : IPaymentStrategy
{
    private readonly string _cardNumber;

    public CreditCardPayment(string cardNumber)
    {
        _cardNumber = cardNumber;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount:C} using Credit Card: {_cardNumber}");
    }
}

public class PayPalPayment : IPaymentStrategy
{
    private readonly string _email;

    public PayPalPayment(string email)
    {
        _email = email;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount:C} using PayPal account: {_email}");
    }
}

public class BitcoinPayment : IPaymentStrategy
{
    private readonly string _bitcoinAddress;

    public BitcoinPayment(string bitcoinAddress)
    {
        _bitcoinAddress = bitcoinAddress;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount:C} using Bitcoin address: {_bitcoinAddress}");
    }
}

// Context
public class PaymentProcessor
{
    private readonly IPaymentStrategy _paymentStrategy;

    public PaymentProcessor(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void ProcessPayment(decimal amount)
    {
        _paymentStrategy.Pay(amount);
    }
}

