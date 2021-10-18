// ReSharper disable UnusedType.Global

using System;

namespace Nodes.Messages.Events
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
        /// The portfolio that should be activated/dispatched
        /// </summary>
        public string PortfolioId { get; set; }

        /// <summary>
        /// The quantity the portfolio should be activated/dispatched in MW or MWh.
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