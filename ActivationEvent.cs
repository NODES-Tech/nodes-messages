// ReSharper disable UnusedType.Global

using System;

namespace Nodes.Messages
{
    /// <summary>
    /// Event indicating that an asset(portfolio) activation/dispatch event has occured. 
    /// </summary>
    public class ActivationEvent
    {
        // PUT IN HEADER?
        public string OrganizationId { get; set; }


        public string TradeId { get; set; }

        /// <summary>
        /// The portfolio that should be activated/dispatch
        /// </summary>
        public string PortfolioId { get; set; }

        /// <summary>
        /// The quantity the portfolio should be activated/dispatched in MW or MWh. 
        /// </summary>
        public float Quantity { get; set; }

        /// <summary>
        /// Start of this dispatch. Note that another dispatch might end at exactly this time,
        /// so the device might already be dispatched. 
        /// </summary>
        public DateTimeOffset PeriodFrom { get; set; }

        /// <summary>
        /// Start of this dispatch. Note that another dispatch might start at exactly this time,
        /// so the device should not necessary be de-dispatched.  
        /// </summary>
        public DateTimeOffset PeriodTo { get; set; }
    }
}