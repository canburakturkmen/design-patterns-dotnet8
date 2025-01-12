// Choose payment method at runtime
using Strategy;

IPaymentStrategy creditCardPayment = new CreditCardPayment("1234-5678-9876-5432");
IPaymentStrategy payPalPayment = new PayPalPayment("user@example.com");
IPaymentStrategy bitcoinPayment = new BitcoinPayment("1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa");

var paymentProcessor1 = new PaymentProcessor(creditCardPayment);
paymentProcessor1.ProcessPayment(100.50m);  // Pay using Credit Card

var paymentProcessor2 = new PaymentProcessor(payPalPayment);
paymentProcessor2.ProcessPayment(200.75m);  // Pay using PayPal

var paymentProcessor3 = new PaymentProcessor(bitcoinPayment);
paymentProcessor3.ProcessPayment(50.00m);  // Pay using Bitcoin