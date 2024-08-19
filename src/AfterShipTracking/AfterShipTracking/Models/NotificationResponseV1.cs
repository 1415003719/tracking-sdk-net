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
    public class NotificationResponseV1
    {
        /// <summary>
        ///  Meta Meta data
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public MetaV1? Meta { get; set; }

        /// <summary>
        ///  Data
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public DataNotificationResponseV1? Data { get; set; }

        public NotificationResponseV1() { }
    }

    /// <summary>
    ///
    /// </summary>
    public class DataNotificationResponseV1
    {
        /// <summary>
        ///  Notification Object describes the notification information.
        /// </summary>
        [JsonProperty("notification", NullValueHandling = NullValueHandling.Ignore)]
        public Notification? Notification { get; set; }

        public DataNotificationResponseV1() { }
    }
}