using DependencyEx1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIWebapiEx1.DominClass
{
    internal class PaymentProvider
    {
        private IPaymentService _paymentService;

        public IPaymentService PaymentMethodSelection(string mode)
        {
            if (mode == "Strip")
            {
                _paymentService = new StripPaymentService();
            }
            else
            {
                _paymentService = new PaypalPaymentService();
            }

            return _paymentService;
        }
    }
}
