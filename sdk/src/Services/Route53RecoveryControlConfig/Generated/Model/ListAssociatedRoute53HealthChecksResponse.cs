/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the route53-recovery-control-config-2020-11-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53RecoveryControlConfig.Model
{
    /// <summary>
    /// This is the response object from the ListAssociatedRoute53HealthChecks operation.
    /// </summary>
    public partial class ListAssociatedRoute53HealthChecksResponse : AmazonWebServiceResponse
    {
        private List<string> _healthCheckIds = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property HealthCheckIds. 
        /// <para>
        /// Identifiers for the health checks.
        /// </para>
        /// </summary>
        public List<string> HealthCheckIds
        {
            get { return this._healthCheckIds; }
            set { this._healthCheckIds = value; }
        }

        // Check to see if HealthCheckIds property is set
        internal bool IsSetHealthCheckIds()
        {
            return this._healthCheckIds != null && this._healthCheckIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that identifies which batch of results you want to see.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}