using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex009
{

    interface PaymentMethodsProps
    {
        protected abstract void Pix();
    }

    internal abstract class paymentMethods
    {
        protected abstract void Pix(int num);

    }

    class PayPal : paymentMethods
    {
        protected override void Pix(int num)
        {
            Console.WriteLine("Hello, world: " + num);
        }

        public void DisplayNum(int num)
        {
            Pix(num);
        }
    }
}
