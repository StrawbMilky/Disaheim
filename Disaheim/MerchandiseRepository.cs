using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises = []; // istedet for new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            if (merchandise != null)
            {
                merchandises.Add(merchandise);
            }
        }

        public Merchandise GetMerchandise(string itemId)
        {
            foreach (var merchandise in merchandises) //var betyder variable, og er en fleksibel datatype (systemet regner selv ud hvad det skal være)
            {
                if (merchandise.ItemId == itemId)
                {
                    return merchandise;
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double total = 0;

            Utility utility = new Utility();

            foreach (var merchandise in merchandises)
            {
                total = total + utility.GetValueOfMerchandise(merchandise);
            }
            return total;
        }
    }
}
