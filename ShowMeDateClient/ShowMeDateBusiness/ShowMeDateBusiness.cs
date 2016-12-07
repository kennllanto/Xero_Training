using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeDateBusiness
{
    /// <summary>
    /// Business Layer Class to show current date
    /// </summary>
    public class ShowMeDateBusiness
    {
        /// <summary>
        /// Gets current date and passes it client layer
        /// </summary>
        /// <returns>
        /// DateTime - current DateTime
        /// </returns>
        public DateTime GetDate()
        {
            ShowMeDateDataLayer.ShowMeDateDataLayer db = new ShowMeDateDataLayer.ShowMeDateDataLayer();
            return db.GetDate();
        }
        
    }
}
