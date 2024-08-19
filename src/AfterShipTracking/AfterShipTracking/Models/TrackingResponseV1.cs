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
    /// Tracking response for returning single tracking
    /// </summary>
    public class TrackingResponseV1
    {
        /// <summary>
        ///  Meta Meta data
        /// </summary>
        [JsonProperty("meta")]
        public MetaV1 Meta { get; set; }

        /// <summary>
        ///  Data
        /// </summary>
        [JsonProperty("data")]
        public DataTrackingResponseV1 Data { get; set; }

        public TrackingResponseV1() { }
    }

    /// <summary>
    ///
    /// </summary>
    public class DataTrackingResponseV1
    {
        /// <summary>
        ///  Tracking Object describes the tracking information.<div style="display:none; height: 0"></div>
        /// </summary>
        [JsonProperty("tracking", NullValueHandling = NullValueHandling.Ignore)]
        public Tracking? Tracking { get; set; }

        public DataTrackingResponseV1() { }
    }
}
