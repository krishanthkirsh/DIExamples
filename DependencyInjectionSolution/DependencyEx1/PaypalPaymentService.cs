using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyEx1
{
    public class PaypalPaymentService : IPaypalPaymentService
    {
        public PaymentModel PaymentMessage()
        {
            PaymentModel paymentModel = new PaymentModel();
            paymentModel.Status = "Done";
            paymentModel.Error = "Paypal Payment Done";
            return paymentModel;
        }
    }
}
