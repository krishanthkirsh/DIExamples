using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyEx1
{
    public class StripPaymentService : IStripePaymentService
    {
        public PaymentModel PaymentMessage()
        {
            PaymentModel paymentModel = new PaymentModel();
            paymentModel.Status = "Not Done";
            paymentModel.Error = "Strips Payment Done";
            return paymentModel;
        }
    }
}
