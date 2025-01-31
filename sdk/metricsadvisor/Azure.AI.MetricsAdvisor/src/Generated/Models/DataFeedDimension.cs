// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The Dimension. </summary>
    public partial class DataFeedDimension
    {

        /// <summary> Initializes a new instance of DataFeedDimension. </summary>
        /// <param name="name"> dimension name. </param>
        /// <param name="displayName"> dimension display name. </param>
        internal DataFeedDimension(string name, string displayName)
        {
            Name = name;
            DisplayName = displayName;
        }
    }
}
