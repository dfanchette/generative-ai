namespace Mscc.GenerativeAI
{
    /// <summary>
    /// A Duration represents a signed, fixed-length span of time represented as a count of seconds and fractions of seconds at nanosecond resolution.
    /// </summary>
    /// <remarks>
    /// It is independent of any calendar and concepts like "day" or "month".
    /// It is related to Timestamp in that the difference between two Timestamp values is a Duration and
    /// it can be added or subtracted from a Timestamp. Range is approximately +-10,000 years.
    /// <seealso href="https://protobuf.dev/reference/protobuf/google.protobuf/#duration"/>
    /// </remarks>
    public class Duration
    {
        /// <summary>
        /// Seconds of a duration.
        /// </summary>
        public int Seconds { get; set; }
        /// <summary>
        /// Nano seconds of a duration.
        /// </summary>
        public int Nanos { get; set; }
    }
}