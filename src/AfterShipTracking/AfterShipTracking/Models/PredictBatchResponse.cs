/*
 * This code was auto generated by AfterShip SDK Generator.
 * Do not edit the class manually.
 */
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AfterShipTracking
{
    /// <summary>
    /// 
    /// </summary>
    public class  PredictBatchResponse
    {
        /// <summary>
        ///  EstimatedDeliveryDates 
        /// </summary>
        [JsonProperty("estimated_delivery_dates")]
        public EstimatedDeliveryDateResponse [] EstimatedDeliveryDates { get; set; }
        public PredictBatchResponse()
        {
        }
    }
    
}
