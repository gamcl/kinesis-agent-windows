/*
 * Copyright 2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Amazon.KinesisTap.AWS.Telemetrics
{
    public interface ITelemetricsClient<TResponse>
    {
        //An unique ID to Identify the installation. This could be a Cognito User pool ClientID
        string ClientId { get; set; }

        //Send metrics to telemetry
        Task<TResponse> PutMetricsAsync(IDictionary<string, object> data);

        //Generate a new unique ID
        Task<string> CreateClientIdAsync();

        //Allow each client to use its own parameter name to avoid conflict
        string ClientIdParameterName { get; }
    }
}