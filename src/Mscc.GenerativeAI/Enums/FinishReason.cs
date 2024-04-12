﻿#if NET472_OR_GREATER || NETSTANDARD2_0
using System.Text.Json.Serialization;
#endif

namespace Mscc.GenerativeAI
{
    /// <summary>
    /// The reason why the model stopped generating tokens.
    /// If empty, the model has not stopped generating the tokens.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<FinishReason>))]

    public enum FinishReason
    {
        /// <summary>
        /// Unspecified means the finish reason is unspecified.
        /// </summary>
        FinishReasonUnspecified = 0,
        /// <summary>
        /// Stop means natural stop point of the model or provided stop sequence.
        /// </summary>
        Stop = 1,
        /// <summary>
        /// MaxTokens means the maximum number of tokens as specified in the request was reached.
        /// </summary>
        MaxTokens = 2,
        /// <summary>
        /// Safety means the token generation was stopped as the response was flagged for safety
        /// reasons. NOTE: When streaming the Candidate.content will be empty if
        /// content filters blocked the output.
        /// </summary>
        Safety = 3,
        /// <summary>
        /// Recitation means the token generation was stopped as the response was flagged for
        /// unauthorized citations.
        /// </summary>
        Recitation = 4,
        /// <summary>
        /// Other means all other reasons that stopped the token generation
        /// </summary>
        Other = 5,
        /// <summary>
        /// The token generation was stopped as the response was flagged for the
        /// terms which are included from the terminology blocklist.
        /// </summary>
        Blocklist = 6,
        /// <summary>
        /// The token generation was stopped as the response was flagged for
        /// the prohibited contents.
        /// </summary>
        ProhibitedContent = 7,
        /// <summary>
        /// The token generation was stopped as the response was flagged for
        /// Sensitive Personally Identifiable Information (SPII) contents.
        /// </summary>
        Spii = 8
    }
}