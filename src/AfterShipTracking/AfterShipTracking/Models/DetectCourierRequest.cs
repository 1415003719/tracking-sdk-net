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
    public class DetectCourierRequest
    {
        /// <summary>
        ///  Tracking Detect courier request
        /// </summary>
        [JsonProperty("tracking", NullValueHandling = NullValueHandling.Ignore)]
        public TrackingDetectCourierRequest? Tracking { get; set; }

        public DetectCourierRequest() { }
    }

    /// <summary>
    ///
    /// </summary>
    public class TrackingDetectCourierRequest
    {
        /// <summary>
        ///  TrackingNumber Tracking number of a shipment.
        /// </summary>
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        /// <summary>
        ///  Slug If not specified, Aftership will automatically detect the courier based on the tracking number format and your . Use array or comma separated to input a list of couriers for auto detect. Cannot be used with slug_group at the same time.
        /// </summary>
        [JsonProperty("slug", NullValueHandling = NullValueHandling.Ignore)]
        public string?[] Slug { get; set; }

        /// <summary>
        ///  TrackingPostalCode The postal code of receiver's address. Required by some couriers. Refer to  for more details
        /// </summary>
        [JsonProperty("tracking_postal_code", NullValueHandling = NullValueHandling.Ignore)]
        public string? TrackingPostalCode { get; set; }

        /// <summary>
        ///  TrackingShipDate Shipping date in `YYYYMMDD` format. Required by some couriers. Refer to  for more details
        /// </summary>
        [JsonProperty("tracking_ship_date", NullValueHandling = NullValueHandling.Ignore)]
        public string? TrackingShipDate { get; set; }

        /// <summary>
        ///  TrackingAccountNumber Account number of the shipper for a specific courier. Required by some couriers. Refer to  for more details
        /// </summary>
        [JsonProperty("tracking_account_number", NullValueHandling = NullValueHandling.Ignore)]
        public string? TrackingAccountNumber { get; set; }

        /// <summary>
        ///  TrackingKey Key of the shipment for a specific courier. Required by some couriers. Refer to  for more details
        /// </summary>
        [JsonProperty("tracking_key", NullValueHandling = NullValueHandling.Ignore)]
        public string? TrackingKey { get; set; }

        /// <summary>
        ///  TrackingOriginCountry Origin Country/Region of the shipment for a specific courier. Required by some couriers.
        /// </summary>
        [JsonProperty("tracking_origin_country", NullValueHandling = NullValueHandling.Ignore)]
        public string? TrackingOriginCountry { get; set; }

        /// <summary>
        ///  TrackingDestinationCountry Destination Country/Region of the shipment for a specific courier. Required by some couriers. Refer to  for more details
        /// </summary>
        [JsonProperty("tracking_destination_country", NullValueHandling = NullValueHandling.Ignore)]
        public string? TrackingDestinationCountry { get; set; }

        /// <summary>
        ///  TrackingState State of the destination shipping address of the shipment. Required by some couriers.
        /// </summary>
        [JsonProperty("tracking_state", NullValueHandling = NullValueHandling.Ignore)]
        public string? TrackingState { get; set; }

        /// <summary>
        ///  SlugGroup Slug group is a group of slugs which belong to same courier. For example, when you inpit "fedex-group" as slug_group, AfterShip will detect the tracking with "fedex-uk", "fedex-fims", and other slugs which belong to "fedex". It cannot be used with slug at the same time. (
        /// </summary>
        [JsonProperty("slug_group", NullValueHandling = NullValueHandling.Ignore)]
        public SlugGroupV1? SlugGroup { get; set; }

        /// <summary>
        ///  OriginCountryIso3 Enter .
        /// </summary>
        [JsonProperty("origin_country_iso3", NullValueHandling = NullValueHandling.Ignore)]
        public string? OriginCountryIso3 { get; set; }

        /// <summary>
        ///  DestinationCountryIso3 Enter .
        /// </summary>
        [JsonProperty("destination_country_iso3", NullValueHandling = NullValueHandling.Ignore)]
        public string? DestinationCountryIso3 { get; set; }

        public TrackingDetectCourierRequest() { }
    }
}