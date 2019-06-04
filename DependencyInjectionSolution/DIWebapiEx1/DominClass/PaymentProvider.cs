using DependencyEx1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIWebapiEx1.DominClass
{
    public class PaymentProvider
    {
        public IPaymentService _paymentService;

        public PaymentProvider(string mode)
        {
            if (mode == "Strip")
            {
                _paymentService = new StripPaymentService();
            }
            else
            {
                _paymentService = new PaypalPaymentService();
            }
        }
    }
}
