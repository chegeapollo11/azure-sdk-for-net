// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The response payload for muting participants from the call. </summary>
    public partial class MuteParticipantsResponse
    {
        /// <summary> Initializes a new instance of MuteParticipantsResponse. </summary>
        internal MuteParticipantsResponse()
        {
        }

        /// <summary> Initializes a new instance of MuteParticipantsResponse. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        internal MuteParticipantsResponse(string operationContext)
        {
            OperationContext = operationContext;
        }

        /// <summary> The operation context provided by client. </summary>
        public string OperationContext { get; }
    }
}
