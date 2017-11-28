namespace Nancy.Serialization.JsonNet
{
    using Nancy.Responses.Negotiation;
    using System;

    internal static class Helpers
    {
        /// <summary>
        /// Attempts to detect if the content type is JSON.
        /// Supports:
        ///   application/json
        ///   text/json
        ///   application/vnd[something]+json
        /// Matches are case insentitive to try and be as "accepting" as possible.
        /// </summary>
        /// <param name="contentType">Request content type</param>
        /// <returns>True if content type is JSON, false otherwise</returns>


        public static bool IsJsonType(MediaRange contentType)
        {
            if (string.IsNullOrEmpty(contentType))
            {
                return false;
            }

            return contentType.Matches("application/json") || contentType.Matches("text/json") || contentType.Matches("application/vnd");

        }
    }
}
