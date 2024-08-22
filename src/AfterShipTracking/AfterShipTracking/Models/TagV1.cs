/*
 * This code was auto generated by AfterShip SDK Generator.
 * Do not edit the class manually.
 */
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AfterShipTracking
{
    /// <summary>
    /// Current status of tracking. (
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TagV1
    {
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "InfoReceived")]
        Inforeceived,
        [EnumMember(Value = "InTransit")]
        Intransit,
        [EnumMember(Value = "OutForDelivery")]
        Outfordelivery,
        [EnumMember(Value = "AttemptFail")]
        Attemptfail,
        [EnumMember(Value = "Delivered")]
        Delivered,
        [EnumMember(Value = "AvailableForPickup")]
        Availableforpickup,
        [EnumMember(Value = "Exception")]
        Exception,
        [EnumMember(Value = "Expired")]
        Expired,
    }
}
