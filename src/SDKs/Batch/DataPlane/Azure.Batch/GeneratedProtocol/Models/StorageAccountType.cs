// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for StorageAccountType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StorageAccountType
    {
        [EnumMember(Value = "Standard_LRS")]
        StandardLRS,
        [EnumMember(Value = "Premium_LRS")]
        PremiumLRS
    }
    internal static class StorageAccountTypeEnumExtension
    {
        internal static string ToSerializedValue(this StorageAccountType? value)
        {
            return value == null ? null : ((StorageAccountType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this StorageAccountType value)
        {
            switch( value )
            {
                case StorageAccountType.StandardLRS:
                    return "Standard_LRS";
                case StorageAccountType.PremiumLRS:
                    return "Premium_LRS";
            }
            return null;
        }

        internal static StorageAccountType? ParseStorageAccountType(this string value)
        {
            switch( value )
            {
                case "Standard_LRS":
                    return StorageAccountType.StandardLRS;
                case "Premium_LRS":
                    return StorageAccountType.PremiumLRS;
            }
            return null;
        }
    }
}