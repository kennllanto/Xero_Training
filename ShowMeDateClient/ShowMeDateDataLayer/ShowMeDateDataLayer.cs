using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeDateDataLayer
{
    /// <summary>
    /// Database Layer Class to show current date
    /// </summary>
    public class ShowMeDateDataLayer
    {
        /// <summary>
        /// Gets current date and passes it dbusiness layer
        /// </summary>
        /// <returns>
        /// DateTime - current DateTime
        /// </returns>
        public DateTime GetDate()
        {
                return DateTime.Now;
        }
    }
}
