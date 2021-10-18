// ReSharper disable UnusedType.Global

using System;

namespace Nodes.Messages.Events
{
    /// <summary>
    /// Event indicating that an asset(portfolio) dispatch/activation/de-activation event has occured. 
    /// </summary>
    public class DispatchEvent
    {
        // PUT IN HEADER?
        public string OrganizationId { get; set; }


        /// <summary>
        /// Reference to the trade that causes this dispatch
        /// </summary>
        public string TradeId { get; set; }

        /// <summary>
        /// The portfolio that should be dispatched
        /// </summary>
        public string PortfolioId { get; set; }

        /// <summary>
        /// The quantity the portfolio should be dispatched in MW or MWh.
        /// Note that this is a positive number and the regulation type
        /// indicates whether this is an Up or Down regulation.  
        /// </summary>
        public float Quantity { get; set; }

        /// <summary>
        /// Up or Down, where Up corresponds to increased production / decreased consumption. 
        /// </summary>
        public string RegulationType { get; set; }

        /// <summary>
        /// Start of this dispatch. Note that another dispatch might end at exactly this time,
        /// so the device might already be dispatched - thus PeriodFrom does not necessarily
        /// indicate a change in the dispatch status. 
        /// </summary>
        public DateTimeOffset PeriodFrom { get; set; }

        /// <summary>
        /// Start of this dispatch. Note that another dispatch might start at exactly this time,
        /// so the device should not necessary be de-dispatched - thus PeriodTo does not necessarily
        /// indicate a change in the dispatch status..  
        /// </summary>
        public DateTimeOffset PeriodTo { get; set; }
    }
}