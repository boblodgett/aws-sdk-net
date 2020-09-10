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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// This is the response object from the DeleteAccountAssignment operation.
    /// </summary>
    public partial class DeleteAccountAssignmentResponse : AmazonWebServiceResponse
    {
        private AccountAssignmentOperationStatus _accountAssignmentDeletionStatus;

        /// <summary>
        /// Gets and sets the property AccountAssignmentDeletionStatus. 
        /// <para>
        /// The status object for the account assignment deletion operation.
        /// </para>
        /// </summary>
        public AccountAssignmentOperationStatus AccountAssignmentDeletionStatus
        {
            get { return this._accountAssignmentDeletionStatus; }
            set { this._accountAssignmentDeletionStatus = value; }
        }

        // Check to see if AccountAssignmentDeletionStatus property is set
        internal bool IsSetAccountAssignmentDeletionStatus()
        {
            return this._accountAssignmentDeletionStatus != null;
        }

    }
}