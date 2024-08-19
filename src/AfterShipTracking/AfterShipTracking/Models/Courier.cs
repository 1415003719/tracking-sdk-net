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
    /// Courier object
    /// </summary>
    public class Courier
    {
        /// <summary>
        ///  Slug Unique code of courier. Get the slugs from .
        /// </summary>
        [JsonProperty("slug", NullValueHandling = NullValueHandling.Ignore)]
        public string? Slug { get; set; }

        /// <summary>
        ///  Name Name of courier
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; }

        /// <summary>
        ///  Phone Contact phone number of courier
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string? Phone { get; set; }

        /// <summary>
        ///  OtherName Other name of courier
        /// </summary>
        [JsonProperty("other_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? OtherName { get; set; }

        /// <summary>
        ///  WebUrl Website link of courier
        /// </summary>
        [JsonProperty("web_url", NullValueHandling = NullValueHandling.Ignore)]
        public string? WebUrl { get; set; }

        /// <summary>
        ///  RequiredFields The extra fields need for tracking, such as `tracking_account_number`, `tracking_postal_code`, `tracking_ship_date`, `tracking_key`, `tracking_destination_country`
        /// </summary>
        [JsonProperty("required_fields", NullValueHandling = NullValueHandling.Ignore)]
        public string?[] RequiredFields { get; set; }

        /// <summary>
        ///  OptionalFields The extra fields which are optional for tracking. Basically it's the same as required_fields, but the difference is that only some of the tracking numbers require these fields.
        /// </summary>
        [JsonProperty("optional_fields", NullValueHandling = NullValueHandling.Ignore)]
        public string?[] OptionalFields { get; set; }

        /// <summary>
        ///  DefaultLanguage Default language of tracking results
        /// </summary>
        [JsonProperty("default_language", NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultLanguage { get; set; }

        /// <summary>
        ///  SupportLanguages Other supported languages
        /// </summary>
        [JsonProperty("support_languages", NullValueHandling = NullValueHandling.Ignore)]
        public string?[] SupportLanguages { get; set; }

        /// <summary>
        ///  ServiceFromCountryIso3 Country/Region code (ISO Alpha-3) where the courier provides service
        /// </summary>
        [JsonProperty("service_from_country_iso3", NullValueHandling = NullValueHandling.Ignore)]
        public string?[] ServiceFromCountryIso3 { get; set; }

        public Courier() { }
    }
}