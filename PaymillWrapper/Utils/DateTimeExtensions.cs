﻿using System;

namespace PaymillWrapper.Utils
{
    internal static class DateTimeExtensions
    {

        private static readonly DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
  
        public static int ToUnixTimestamp(this DateTime dateTime)
        {
            return (int)(dateTime - unixEpoch).TotalSeconds;
        }

        public static DateTime ParseAsUnixTimestamp(this int timestamp)
        {
            return unixEpoch.AddSeconds(timestamp);
        }

        public static DateTime ParseAsUnixTimestamp(this long timestamp)
        {
            return unixEpoch.AddSeconds(timestamp);
        }
    }
}
