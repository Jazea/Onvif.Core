using System;
using System.Xml;

namespace Onvif.Core.Internals;

internal static class NullableTimeSpanExtensions
{
    public static string ToXmlString(this TimeSpan? value) => value == null ? null : XmlConvert.ToString(value.Value);

    public static TimeSpan? GetTimeSpanFromString(string value) => value == null ? null : XmlConvert.ToTimeSpan(value);
}
