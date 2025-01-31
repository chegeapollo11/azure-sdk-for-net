// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppPlatform.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing the AppPlatformCustomDomain data model.
    /// Custom domain resource payload.
    /// </summary>
    public partial class AppPlatformCustomDomainData : ResourceData
    {
        /// <summary> Initializes a new instance of AppPlatformCustomDomainData. </summary>
        public AppPlatformCustomDomainData()
        {
        }

        /// <summary> Initializes a new instance of AppPlatformCustomDomainData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of the custom domain resource. </param>
        internal AppPlatformCustomDomainData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AppPlatformCustomDomainProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Properties of the custom domain resource. </summary>
        public AppPlatformCustomDomainProperties Properties { get; set; }
    }
}
