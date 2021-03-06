// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AutoExecuteStatusInheritedFrom.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AutoExecuteStatusInheritedFrom
    {
        [EnumMember(Value = "Default")]
        Default,
        [EnumMember(Value = "Subscription")]
        Subscription,
        [EnumMember(Value = "Server")]
        Server,
        [EnumMember(Value = "ElasticPool")]
        ElasticPool,
        [EnumMember(Value = "Database")]
        Database
    }
    internal static class AutoExecuteStatusInheritedFromEnumExtension
    {
        internal static string ToSerializedValue(this AutoExecuteStatusInheritedFrom? value)
        {
            return value == null ? null : ((AutoExecuteStatusInheritedFrom)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AutoExecuteStatusInheritedFrom value)
        {
            switch( value )
            {
                case AutoExecuteStatusInheritedFrom.Default:
                    return "Default";
                case AutoExecuteStatusInheritedFrom.Subscription:
                    return "Subscription";
                case AutoExecuteStatusInheritedFrom.Server:
                    return "Server";
                case AutoExecuteStatusInheritedFrom.ElasticPool:
                    return "ElasticPool";
                case AutoExecuteStatusInheritedFrom.Database:
                    return "Database";
            }
            return null;
        }

        internal static AutoExecuteStatusInheritedFrom? ParseAutoExecuteStatusInheritedFrom(this string value)
        {
            switch( value )
            {
                case "Default":
                    return AutoExecuteStatusInheritedFrom.Default;
                case "Subscription":
                    return AutoExecuteStatusInheritedFrom.Subscription;
                case "Server":
                    return AutoExecuteStatusInheritedFrom.Server;
                case "ElasticPool":
                    return AutoExecuteStatusInheritedFrom.ElasticPool;
                case "Database":
                    return AutoExecuteStatusInheritedFrom.Database;
            }
            return null;
        }
    }
}
