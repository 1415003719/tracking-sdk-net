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
    /// Object describes the notification information.
    /// </summary>
    public class Notification
    {
        /// <summary>
        ///  Emails Email address(es) to receive email notifications.
        /// </summary>
        [JsonProperty("emails", NullValueHandling = NullValueHandling.Ignore)]
        public string?[] Emails { get; set; }

        /// <summary>
        ///  Smses The phone number(s) to receive sms notifications.
        /// </summary>
        [JsonProperty("smses", NullValueHandling = NullValueHandling.Ignore)]
        public string?[] Smses { get; set; }

        public Notification() { }
    }
}