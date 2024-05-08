using Adapter;

/*
 * O Design Pattern Adapter consegue pegar duas classes com assinaturas de métodos diferentes e adaptar ambas para uma única assinatura via interface
 */


//Assinatura de Paypal com PayPalPayment e PayPalReceive
//PayPal payment = new PayPal();
//payment.PayPalPayment();
//payment.PaylPalReceive();

//Assinatura do Payonner com SendPayment e ReceivePayment
//Payonner paymentPayonner = new Payonner();
//paymentPayonner.SendPayment();
//paymentPayonner.ReceivePayment();


//Assinaturas adaptadas e padronizadas para ambas as classes ao aplicar PayonnerAdapter, adaptando-se ao PayPal
IPaypalPayment paymentAdapter = new PayonnerAdapter(new Payonner());
//IPaypalPayment paymentAdapter = new PayPal();
paymentAdapter.PayPalPayment();
paymentAdapter.PaylPalReceive();



Console.ReadLine();