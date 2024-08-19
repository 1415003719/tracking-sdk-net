/*
 * This code was auto generated by AfterShip SDK Generator.
 * Do not edit the class manually.
 */
using Newtonsoft.Json;

namespace AfterShipTracking.Public._base
{
    public class PaginationCursor : IBasePage
    {
        /// <summary>
        /// Total count
        /// </summary>
        [JsonProperty("total")]
        public int Total;

        /// <summary>
        /// Has next page
        /// </summary>
        [JsonProperty("previous_cursor")]
        public string PreviousCursor { get; }

        /// <summary>
        /// Next cursor
        /// </summary>
        [JsonProperty("next_cursor")]
        public string NextCursor { get; }
    }
}