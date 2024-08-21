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
    /// Object describes the tracking information.<div style="display:none; height: 0"></div>
    /// </summary>
    public class GetTrackingBySlugTrackingNumberResponse
    {
        /// <summary>
        ///  Id Tracking ID.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        ///  LegacyId The length of the tracking ID has been increased from 24 characters to 32 characters. We will use the legacy_id field to store the original 24-character tracking ID to maintain compatibility with existing data. Therefore, all tracking endpoints will continue to work with the legacy_id field as before.
        /// </summary>
        [JsonProperty("legacy_id")]
        public string? LegacyId { get; set; }

        /// <summary>
        ///  CreatedAt The date and time the shipment was imported or added to AfterShip. It uses the format `YYYY-MM-DDTHH:mm:ssZ` for the timezone GMT +0.
        /// </summary>
        [JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        ///  UpdatedAt The date and time the shipment was updated. It uses the format `YYYY-MM-DDTHH:mm:ssZ` for the timezone GMT +0.
        /// </summary>
        [JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        ///  LastUpdatedAt (Legacy) The date and time the shipment was updated. It uses the format `YYYY-MM-DDTHH:mm:ssZ` for the timezone GMT +0.
        /// </summary>
        [JsonProperty("last_updated_at")]
        public string? LastUpdatedAt { get; set; }

        /// <summary>
        ///  TrackingNumber Tracking number.
        /// </summary>
        [JsonProperty("tracking_number")]
        public string? TrackingNumber { get; set; }

        /// <summary>
        ///  Slug Unique courier code. When importing a shipment with no courier slug and the tracking number can’t be recognized, the courier will be marked as `unrecognized`. Get courier codes .
        /// </summary>
        [JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        ///  Active Whether or not AfterShip will continue tracking the shipments. Value is `false` when tag (status) is `Delivered`, `Expired`, or further updates for 30 days since last update.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        ///  CustomFields Custom fields that accept an object with string field. In order to protect the privacy of your customers, do not include any  in custom fields.
        /// </summary>
        [JsonProperty("custom_fields")]
        public Dictionary<string, string>? CustomFields { get; set; }

        /// <summary>
        ///  CustomerName Customer name of the tracking.
        /// </summary>
        [JsonProperty("customer_name")]
        public string? CustomerName { get; set; }

        /// <summary>
        ///  TransitTime Total transit time in days.- For delivered shipments: Transit time (in days) = Delivered date - Pick-up date- For undelivered shipments: Transit time (in days) = Current date - Pick-up dateValue as `null` for the shipment without pick-up date.
        /// </summary>
        [JsonProperty("transit_time")]
        public int? TransitTime { get; set; }

        /// <summary>
        ///  OriginCountryIso3 The  for the origin country/region. E.g. USA for the United States.
        /// </summary>
        [JsonProperty("origin_country_iso3")]
        public string? OriginCountryIso3 { get; set; }

        /// <summary>
        ///  OriginState The state of the sender’s address.
        /// </summary>
        [JsonProperty("origin_state")]
        public string? OriginState { get; set; }

        /// <summary>
        ///  OriginCity The city of the sender’s address.
        /// </summary>
        [JsonProperty("origin_city")]
        public string? OriginCity { get; set; }

        /// <summary>
        ///  OriginPostalCode The postal code of the sender’s address.
        /// </summary>
        [JsonProperty("origin_postal_code")]
        public string? OriginPostalCode { get; set; }

        /// <summary>
        ///  OriginRawLocation The sender address that the shipment is shipping from.
        /// </summary>
        [JsonProperty("origin_raw_location")]
        public string? OriginRawLocation { get; set; }

        /// <summary>
        ///  DestinationCountryIso3 The  for the destination country/region. E.g. USA for the United States.
        /// </summary>
        [JsonProperty("destination_country_iso3")]
        public string? DestinationCountryIso3 { get; set; }

        /// <summary>
        ///  DestinationState The state of the recipient’s address.
        /// </summary>
        [JsonProperty("destination_state")]
        public string? DestinationState { get; set; }

        /// <summary>
        ///  DestinationCity The city of the recipient’s address.
        /// </summary>
        [JsonProperty("destination_city")]
        public string? DestinationCity { get; set; }

        /// <summary>
        ///  DestinationPostalCode The postal code of the recipient’s address.
        /// </summary>
        [JsonProperty("destination_postal_code")]
        public string? DestinationPostalCode { get; set; }

        /// <summary>
        ///  DestinationRawLocation The shipping address that the shipment is shipping to.
        /// </summary>
        [JsonProperty("destination_raw_location")]
        public string? DestinationRawLocation { get; set; }

        /// <summary>
        ///  CourierDestinationCountryIso3 Destination country/region of the tracking detected from the courier. ISO Alpha-3 (three letters). Value will be `null` if the courier doesn't provide the destination country.
        /// </summary>
        [JsonProperty("courier_destination_country_iso3")]
        public string? CourierDestinationCountryIso3 { get; set; }

        /// <summary>
        ///  Emails Email address(es) to receive email notifications.
        /// </summary>
        [JsonProperty("emails")]
        public string?[] Emails { get; set; }

        /// <summary>
        ///  ExpectedDelivery The estimated delivery date provided by the carrier. It uses the shipment recipient’s timezone and the format may differ depending on how the carrier provides it:- YYYY-MM-DD- YYYY-MM-DDTHH:mm:ss- YYYY-MM-DDTHH:mm:ssZ
        /// </summary>
        [JsonProperty("expected_delivery")]
        public string? ExpectedDelivery { get; set; }

        /// <summary>
        ///  Note Text field for the note.
        /// </summary>
        [JsonProperty("note")]
        public string? Note { get; set; }

        /// <summary>
        ///  OrderId A globally-unique identifier for the order.
        /// </summary>
        [JsonProperty("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        ///  OrderIdPath The URL for the order in your system or store.
        /// </summary>
        [JsonProperty("order_id_path")]
        public string? OrderIdPath { get; set; }

        /// <summary>
        ///  OrderDate The date and time the order was created in your system or store. It uses the format: `YYYY-MM-DDTHH:mm:ssZ` based on whichever timezone you provide.
        /// </summary>
        [JsonProperty("order_date")]
        public string? OrderDate { get; set; }

        /// <summary>
        ///  ShipmentPackageCount Number of packages under the tracking.
        /// </summary>
        [JsonProperty("shipment_package_count")]
        public double? ShipmentPackageCount { get; set; }

        /// <summary>
        ///  ShipmentPickupDate The date and time the shipment was picked up by the carrier. It uses the timezone where the pickup occured. The format may differ depending on how the carrier provides it:- YYYY-MM-DD- YYYY-MM-DDTHH:mm:ss- YYYY-MM-DDTHH:mm:ssZ
        /// </summary>
        [JsonProperty("shipment_pickup_date")]
        public string? ShipmentPickupDate { get; set; }

        /// <summary>
        ///  ShipmentDeliveryDate The date and time the shipment was delivered. It uses the shipment recipient’s timezone. The format may differ depending on how the carrier provides it:- YYYY-MM-DD- YYYY-MM-DDTHH:mm:ss- YYYY-MM-DDTHH:mm:ssZ
        /// </summary>
        [JsonProperty("shipment_delivery_date")]
        public string? ShipmentDeliveryDate { get; set; }

        /// <summary>
        ///  ShipmentType The carrier service type for the shipment.
        /// </summary>
        [JsonProperty("shipment_type")]
        public string? ShipmentType { get; set; }

        /// <summary>
        ///  ShipmentWeight The shipment_weight field represents the total weight of the shipment. In scenarios where the carrier does not provide this information, you can provide the weight to AfterShip. We will prioritize the data provided by the carrier, if available. The shipment weight will be included in the Response and accessed through the GET API, Webhook, and CSV export. It will also be displayed on the AfterShip Tracking admin. Additionally, it plays a significant role in error-free shipment handling and carbon emission calculations, ensuring accurate and informed decision-making
        /// </summary>
        [JsonProperty("shipment_weight")]
        public ShipmentWeightGetTrackingBySlugTrackingNumberResponse? ShipmentWeight { get; set; }

        /// <summary>
        ///  SignedBy Signed by information for delivered shipment.
        /// </summary>
        [JsonProperty("signed_by")]
        public string? SignedBy { get; set; }

        /// <summary>
        ///  Smses The phone number(s) to receive sms notifications.  Phone number should begin with `+` and `Area Code` before phone number.
        /// </summary>
        [JsonProperty("smses")]
        public string?[] Smses { get; set; }

        /// <summary>
        ///  Source Source of how this tracking is added.
        /// </summary>
        [JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        ///  Tag Current status of tracking. (
        /// </summary>
        [JsonProperty("tag")]
        public TagV1? Tag { get; set; }

        /// <summary>
        ///  Subtag Current subtag of tracking. (
        /// </summary>
        [JsonProperty("subtag")]
        public string? Subtag { get; set; }

        /// <summary>
        ///  SubtagMessage Normalized tracking message. (
        /// </summary>
        [JsonProperty("subtag_message")]
        public string? SubtagMessage { get; set; }

        /// <summary>
        ///  Title By default this field shows the `tracking_number`, but you can customize it as you wish with any info (e.g. the order number).
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        ///  TrackedCount Number of attempts AfterShip tracks at courier's system.
        /// </summary>
        [JsonProperty("tracked_count")]
        public double? TrackedCount { get; set; }

        /// <summary>
        ///  LastMileTrackingSupported Indicates if the shipment is trackable till the final destination.Three possible values:- true- false- null
        /// </summary>
        [JsonProperty("last_mile_tracking_supported")]
        public bool? LastMileTrackingSupported { get; set; }

        /// <summary>
        ///  Language The recipient’s language. If you set up AfterShip notifications in different languages, we use this to send the recipient tracking updates in their preferred language.
        /// </summary>
        [JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        ///  UniqueToken Deprecated
        /// </summary>
        [JsonProperty("unique_token")]
        public string? UniqueToken { get; set; }

        /// <summary>
        ///  Checkpoints Array of checkpoint object describes the checkpoint information.
        /// </summary>
        [JsonProperty("checkpoints")]
        public Checkpoint?[] Checkpoints { get; set; }

        /// <summary>
        ///  SubscribedSmses Phone number(s) subscribed to receive sms notifications.
        /// </summary>
        [JsonProperty("subscribed_smses")]
        public string?[] SubscribedSmses { get; set; }

        /// <summary>
        ///  SubscribedEmails Email address(es) subscribed to receive email notifications.
        /// </summary>
        [JsonProperty("subscribed_emails")]
        public string?[] SubscribedEmails { get; set; }

        /// <summary>
        ///  ReturnToSender Whether or not the shipment is returned to sender. Value is `true` when any of its checkpoints has subtag `Exception_010` (returning to sender) or `Exception_011` (returned to sender). Otherwise value is `false`.
        /// </summary>
        [JsonProperty("return_to_sender")]
        public bool? ReturnToSender { get; set; }

        /// <summary>
        ///  OrderPromisedDeliveryDate The promised delivery date of the order. It uses the formats:- YYYY-MM-DD- YYYY-MM-DDTHH:mm:ss- YYYY-MM-DDTHH:mm:ssZ
        /// </summary>
        [JsonProperty("order_promised_delivery_date")]
        public string? OrderPromisedDeliveryDate { get; set; }

        /// <summary>
        ///  DeliveryType Shipment delivery type- pickup_at_store- pickup_at_courier- door_to_door
        /// </summary>
        [JsonProperty("delivery_type")]
        public string? DeliveryType { get; set; }

        /// <summary>
        ///  PickupLocation Shipment pickup location for receiver
        /// </summary>
        [JsonProperty("pickup_location")]
        public string? PickupLocation { get; set; }

        /// <summary>
        ///  PickupNote Shipment pickup note for receiver
        /// </summary>
        [JsonProperty("pickup_note")]
        public string? PickupNote { get; set; }

        /// <summary>
        ///  CourierTrackingLink Official tracking URL of the courier (if any). The language parameter of this link relies on the destination country/region and the language associated with the shipment, if the data regarding the destination country/region and language of the shipment is not available, AfterShip will set the language parameter of the link to "US" by default.
        /// </summary>
        [JsonProperty("courier_tracking_link")]
        public string? CourierTrackingLink { get; set; }

        /// <summary>
        ///  FirstAttemptedAt The date and time of the carrier’s first attempt to deliver the package to the recipient.  It uses the shipment recipient’s timezone. The format may differ depending on how the carrier provides it:- YYYY-MM-DDTHH:mm:ss- YYYY-MM-DDTHH:mm:ssZ
        /// </summary>
        [JsonProperty("first_attempted_at")]
        public string? FirstAttemptedAt { get; set; }

        /// <summary>
        ///  CourierRedirectLink Delivery instructions (delivery date or address) can be modified by visiting the link if supported by a carrier. The language parameter of this link relies on the destination country/region and the language associated with the shipment, if the data regarding the destination country/region and language of the shipment is not available, AfterShip will set the language parameter of the link to "US" by default.
        /// </summary>
        [JsonProperty("courier_redirect_link")]
        public string? CourierRedirectLink { get; set; }

        /// <summary>
        ///  TrackingAccountNumber Additional field required by some carriers to retrieve the tracking info. The shipper’s carrier account number. Refer to our article on  for more details.
        /// </summary>
        [JsonProperty("tracking_account_number")]
        public string? TrackingAccountNumber { get; set; }

        /// <summary>
        ///  TrackingKey Additional field required by some carriers to retrieve the tracking info. A type of tracking credential required by some carriers. Refer to our article on  for more details.
        /// </summary>
        [JsonProperty("tracking_key")]
        public string? TrackingKey { get; set; }

        /// <summary>
        ///  TrackingShipDate Additional field required by some carriers to retrieve the tracking info. The date the shipment was sent, using the format YYYYMMDD. Refer to our article on  for more details.
        /// </summary>
        [JsonProperty("tracking_ship_date")]
        public string? TrackingShipDate { get; set; }

        /// <summary>
        ///  OnTimeStatus Whether the tracking is delivered on time or not.
        /// </summary>
        [JsonProperty("on_time_status")]
        public string? OnTimeStatus { get; set; }

        /// <summary>
        ///  OnTimeDifference The difference days of the on time.
        /// </summary>
        [JsonProperty("on_time_difference")]
        public double? OnTimeDifference { get; set; }

        /// <summary>
        ///  OrderTags The tags of the order.
        /// </summary>
        [JsonProperty("order_tags")]
        public string?[] OrderTags { get; set; }

        /// <summary>
        ///  AftershipEstimatedDeliveryDate The estimated delivery date of the shipment provided by AfterShip’s AI and shown to the recipients. It uses the format `YYYY-MM-DD` based on the shipment recipient’s timezone.
        /// </summary>
        [JsonProperty("aftership_estimated_delivery_date")]
        public AftershipEstimatedDeliveryDateGetTrackingBySlugTrackingNumberResponse? AftershipEstimatedDeliveryDate { get; set; }

        /// <summary>
        ///  CustomEstimatedDeliveryDate Estimated delivery time of the shipment based on your . It uses the format `YYYY-MM-DD` based on the shipment recipient’s timezone.
        /// </summary>
        [JsonProperty("custom_estimated_delivery_date")]
        public CustomEstimatedDeliveryDateGetTrackingBySlugTrackingNumberResponse? CustomEstimatedDeliveryDate { get; set; }

        /// <summary>
        ///  OrderNumber A unique, human-readable identifier for the order.
        /// </summary>
        [JsonProperty("order_number")]
        public string? OrderNumber { get; set; }

        /// <summary>
        ///  FirstEstimatedDelivery The shipment’s original estimated delivery date. It could be provided by the carrier, AfterShip AI, or based on your custom settings. The format of carrier EDDs may differ depending on how the carrier provides it:- YYYY-MM-DD- YYYY-MM-DDTHH:mm:ss- YYYY-MM-DDTHH:mm:ssZ AfterShip AI and custom EDDs always use the format `YYYY-MM-DD`. All EDDs use the shipment recipient’s timezone.
        /// </summary>
        [JsonProperty("first_estimated_delivery")]
        public FirstEstimatedDeliveryGetTrackingBySlugTrackingNumberResponse? FirstEstimatedDelivery { get; set; }

        /// <summary>
        ///  LatestEstimatedDelivery The most recently calculated estimated delivery date. It could be provided by the carrier, AfterShip AI, or based on your custom settings. The format of carrier EDDs may differ depending on how the carrier provides it:- YYYY-MM-DD- YYYY-MM-DDTHH:mm:ss- YYYY-MM-DDTHH:mm:ssZ AfterShip AI and custom EDDs always use the format `YYYY-MM-DD`. All EDDs use the shipment recipient’s timezone.
        /// </summary>
        [JsonProperty("latest_estimated_delivery")]
        public LatestEstimatedDeliveryGetTrackingBySlugTrackingNumberResponse? LatestEstimatedDelivery { get; set; }

        /// <summary>
        ///  ShipmentTags Used to add tags to your shipments to help categorize and filter them easily.
        /// </summary>
        [JsonProperty("shipment_tags")]
        public string?[] ShipmentTags { get; set; }

        /// <summary>
        ///  CourierConnectionId If you have multiple accounts connected for a single carrier on AfterShip, we have introduced the courier_connection_id field to allow you to specify the carrier account associated with each shipment. By providing this information, you enable us to accurately track and monitor your shipments based on the correct carrier account.(</br>In the event that you do not specify the courier_connection_id, we will handle your shipment using the connection that was created earliest among your connected accounts.
        /// </summary>
        [JsonProperty("courier_connection_id")]
        public string? CourierConnectionId { get; set; }

        /// <summary>
        ///  NextCouriers The next couriers get the second carrier information from user or AfterShip.
        /// </summary>
        [JsonProperty("next_couriers")]
        public NextCouriersGetTrackingBySlugTrackingNumberResponse?[] NextCouriers { get; set; }

        /// <summary>
        ///  TrackingOriginCountry (Legacy) Replaced by `origin_country_iso3`. Additional field required by some carriers to retrieve the tracking info. The origin country/region of the shipment. Refer to our article on  for more details.
        /// </summary>
        [JsonProperty("tracking_origin_country")]
        public string? TrackingOriginCountry { get; set; }

        /// <summary>
        ///  TrackingDestinationCountry (Legacy) Replaced by `destination_country_iso3`. Additional field required by some carriers to retrieve the tracking info. The destination country/region of the shipment. Refer to our article on  for more details.
        /// </summary>
        [JsonProperty("tracking_destination_country")]
        public string? TrackingDestinationCountry { get; set; }

        /// <summary>
        ///  TrackingPostalCode (Legacy) Replaced by `destination_postal_code`. Additional field required by some carriers to retrieve the tracking info. The postal code of the recipient’s address. Refer to our article on  for more details.
        /// </summary>
        [JsonProperty("tracking_postal_code")]
        public string? TrackingPostalCode { get; set; }

        /// <summary>
        ///  TrackingState (Legacy) Replaced by `destination_state`. Additional field required by some carriers to retrieve the tracking info. The state/province of the recipient’s address. Refer to our article on  for more details.
        /// </summary>
        [JsonProperty("tracking_state")]
        public string? TrackingState { get; set; }

        /// <summary>
        ///  CarbonEmissions The model contains the total amount of carbon emissions generated by the shipment. - AfterShip will provide this data only when it is available, and its availability is contingent upon the location and weight information that AfterShip can obtain.- The values will be accessible solely for shipments that have been successfully delivered. However, in the event of a shipping update after the delivery status has been achieved, the value may change.- It’s a paid service and only for Tracking Enterprise users, please contact your customer success manager if you want to know more.
        /// </summary>
        [JsonProperty("carbon_emissions")]
        public CarbonEmissionsGetTrackingBySlugTrackingNumberResponse? CarbonEmissions { get; set; }

        /// <summary>
        ///  LocationId The location_id refers to the place where you fulfilled the items.  - If you provide a location_id, the system will automatically use it as the tracking's origin address. However, passing both location_id and any origin address information simultaneously is not allowed.- Please make sure you add your locations .
        /// </summary>
        [JsonProperty("location_id")]
        public string? LocationId { get; set; }

        /// <summary>
        ///  ShippingMethod The shipping_method string refers to the chosen method for delivering the package. Merchants typically offer various shipping methods to consumers during the checkout process, such as, Local Delivery, Free Express Worldwide Shipping, etc.
        /// </summary>
        [JsonProperty("shipping_method")]
        public string? ShippingMethod { get; set; }

        /// <summary>
        ///  FailedDeliveryAttempts By dynamically tracking failed delivery attempts during shipment, this field allows you to pinpoint carriers accountable for the most failures. Analyzing the root cause of these failures enables you to improve carriers' delivery standard operating procedures (SOP), leading to an overall enhancement in delivery service quality.
        /// </summary>
        [JsonProperty("failed_delivery_attempts")]
        public int? FailedDeliveryAttempts { get; set; }

        /// <summary>
        ///  SignatureRequirement The signature_requirement field serves the purpose of validating the service option type, specifically proof of delivery. By collecting the recipient's signature upon delivery, it ensures the package reaches the intended recipient and prevents disputes related to non-delivery or lost packages.</br>
        /// </summary>
        [JsonProperty("signature_requirement")]
        public string? SignatureRequirement { get; set; }

        /// <summary>
        ///  DeliveryLocationType The delivery location type represents the secure area where the carrier leaves the package, such as a safe place, locker, mailbox, front porch, etc. This information helps ensure the shipment reaches the intended recipient efficiently, minimizing the risk of theft or damage.
        /// </summary>
        [JsonProperty("delivery_location_type")]
        public string? DeliveryLocationType { get; set; }

        public GetTrackingBySlugTrackingNumberResponse() { }
    }

    /// <summary>
    ///
    /// </summary>
    public class ShipmentWeightGetTrackingBySlugTrackingNumberResponse
    {
        /// <summary>
        ///  Unit The unit in which the value field is expressed.
        /// </summary>
        [JsonProperty("unit")]
        public string? Unit { get; set; }

        /// <summary>
        ///  Value The total amount of shipment weight.
        /// </summary>
        [JsonProperty("value")]
        public double? Value { get; set; }

        public ShipmentWeightGetTrackingBySlugTrackingNumberResponse() { }
    }

    /// <summary>
    ///
    /// </summary>
    public class AftershipEstimatedDeliveryDateGetTrackingBySlugTrackingNumberResponse
    {
        /// <summary>
        ///  EstimatedDeliveryDate The estimated arrival date of the shipment.
        /// </summary>
        [JsonProperty("estimated_delivery_date")]
        public string? EstimatedDeliveryDate { get; set; }

        /// <summary>
        ///  ConfidenceCode Indicates the confidence level and associated reason for an AI EDD prediction request. For a comprehensive list of confidence codes, refer to .
        /// </summary>
        [JsonProperty("confidence_code")]
        public double? ConfidenceCode { get; set; }

        /// <summary>
        ///  EstimatedDeliveryDateMin Earliest estimated delivery date of the shipment.
        /// </summary>
        [JsonProperty("estimated_delivery_date_min")]
        public string? EstimatedDeliveryDateMin { get; set; }

        /// <summary>
        ///  EstimatedDeliveryDateMax Latest estimated delivery date of the shipment.
        /// </summary>
        [JsonProperty("estimated_delivery_date_max")]
        public string? EstimatedDeliveryDateMax { get; set; }

        public AftershipEstimatedDeliveryDateGetTrackingBySlugTrackingNumberResponse() { }
    }

    /// <summary>
    ///
    /// </summary>
    public class CustomEstimatedDeliveryDateGetTrackingBySlugTrackingNumberResponse
    {
        /// <summary>
        ///  Type The format of the EDD. Either a single date or a date range.
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        ///  Datetime The specific EDD date.
        /// </summary>
        [JsonProperty("datetime")]
        public string? Datetime { get; set; }

        /// <summary>
        ///  DatetimeMin For a date range EDD format, the date for the lower end of the range.
        /// </summary>
        [JsonProperty("datetime_min")]
        public string? DatetimeMin { get; set; }

        /// <summary>
        ///  DatetimeMax For a date range EDD format, the date for the upper end of the range.
        /// </summary>
        [JsonProperty("datetime_max")]
        public string? DatetimeMax { get; set; }

        public CustomEstimatedDeliveryDateGetTrackingBySlugTrackingNumberResponse() { }
    }

    /// <summary>
    ///
    /// </summary>
    public class FirstEstimatedDeliveryGetTrackingBySlugTrackingNumberResponse
    {
        /// <summary>
        ///  Type The format of the EDD. Either a single date or a date range.
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        ///  Source The source of the EDD. Either the carrier, AfterShip AI, or based on your custom EDD settings.
        /// </summary>
        [JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        ///  Datetime The latest EDD time.
        /// </summary>
        [JsonProperty("datetime")]
        public string? Datetime { get; set; }

        /// <summary>
        ///  DatetimeMin For a date range EDD format, the date and time for the lower end of the range.
        /// </summary>
        [JsonProperty("datetime_min")]
        public string? DatetimeMin { get; set; }

        /// <summary>
        ///  DatetimeMax For a date range EDD format, the date and time for the upper end of the range.
        /// </summary>
        [JsonProperty("datetime_max")]
        public string? DatetimeMax { get; set; }

        public FirstEstimatedDeliveryGetTrackingBySlugTrackingNumberResponse() { }
    }

    /// <summary>
    ///
    /// </summary>
    public class LatestEstimatedDeliveryGetTrackingBySlugTrackingNumberResponse
    {
        /// <summary>
        ///  Type The format of the EDD. Either a single date or a date range.
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        ///  Source The source of the EDD. Either the carrier, AfterShip AI, or based on your custom EDD settings.
        /// </summary>
        [JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        ///  Datetime The latest EDD time.
        /// </summary>
        [JsonProperty("datetime")]
        public string? Datetime { get; set; }

        /// <summary>
        ///  DatetimeMin For a date range EDD format, the date and time for the lower end of the range.
        /// </summary>
        [JsonProperty("datetime_min")]
        public string? DatetimeMin { get; set; }

        /// <summary>
        ///  DatetimeMax For a date range EDD format, the date and time for the upper end of the range.
        /// </summary>
        [JsonProperty("datetime_max")]
        public string? DatetimeMax { get; set; }

        public LatestEstimatedDeliveryGetTrackingBySlugTrackingNumberResponse() { }
    }

    /// <summary>
    ///
    /// </summary>
    public class NextCouriersGetTrackingBySlugTrackingNumberResponse
    {
        /// <summary>
        ///  Slug Unique code of courier. Get courier
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }

        /// <summary>
        ///  TrackingNumber Tracking number.
        /// </summary>
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        /// <summary>
        ///  Source Source of next couriers.
        /// </summary>
        [JsonProperty("source")]
        public string? Source { get; set; }

        public NextCouriersGetTrackingBySlugTrackingNumberResponse() { }
    }

    /// <summary>
    ///
    /// </summary>
    public class CarbonEmissionsGetTrackingBySlugTrackingNumberResponse
    {
        /// <summary>
        ///  Unit The unit in which the value field is expressed. Allowed values: kg
        /// </summary>
        [JsonProperty("unit")]
        public string? Unit { get; set; }

        /// <summary>
        ///  Value The total amount of carbon emissions
        /// </summary>
        [JsonProperty("value")]
        public double? Value { get; set; }

        public CarbonEmissionsGetTrackingBySlugTrackingNumberResponse() { }
    }
}
