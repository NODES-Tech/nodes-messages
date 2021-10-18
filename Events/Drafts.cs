using System;
using System.Collections.Generic;

namespace Nodes.Messages.Events
{
    // // PUBLIC EVENTS - no "sensitive information" 
    //
    // // Public messages
    // public class OrderPlaced
    // {
    //     public string MarketId;
    //     public string OrderId;
    //     public float Quantity;
    //     public float UnitPrice;
    //
    //     public string GridNodeId;
    //     public DateTimeOffset PeriodFrom, PeriodTo;
    // }
    //
    // // Or should this be public?? 
    // public class MatchCreated
    // {
    //     public List<object> TradeInfosOrSomething;
    // }
    //
    //
    // // PRIVATE EVENTS - only available to selected recipients
    //
    // public class OrderUpdated
    // {
    //     public string OrderId;
    //     public string MarketId;
    //     public List<(string property, string oldValue, string newValue)> Updates;
    // }
}