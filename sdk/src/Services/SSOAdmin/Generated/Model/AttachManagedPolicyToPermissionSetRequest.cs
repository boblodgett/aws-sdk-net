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
    /// Container for the parameters to the AttachManagedPolicyToPermissionSet operation.
    /// Attaches an IAM managed policy ARN to a permission set.
    /// </summary>
    public partial class AttachManagedPolicyToPermissionSetRequest : AmazonSSOAdminRequest
    {
        private string _instanceArn;
        private string _managedPolicyArn;
        private string _permissionSetArn;

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The ARN of the SSO instance under which the operation will be executed. For more information
        /// about ARNs, see <a href="/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource
        /// Names (ARNs) and AWS Service Namespaces</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=1224)]
        public string InstanceArn
        {
            get { return this._instanceArn; }
            set { this._instanceArn = value; }
        }

        // Check to see if InstanceArn property is set
        internal bool IsSetInstanceArn()
        {
            return this._instanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedPolicyArn. 
        /// <para>
        /// The IAM managed policy ARN to be attached to a permission set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ManagedPolicyArn
        {
            get { return this._managedPolicyArn; }
            set { this._managedPolicyArn = value; }
        }

        // Check to see if ManagedPolicyArn property is set
        internal bool IsSetManagedPolicyArn()
        {
            return this._managedPolicyArn != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionSetArn. 
        /// <para>
        /// The ARN of the <a>PermissionSet</a> that the managed policy should be attached to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=1224)]
        public string PermissionSetArn
        {
            get { return this._permissionSetArn; }
            set { this._permissionSetArn = value; }
        }

        // Check to see if PermissionSetArn property is set
        internal bool IsSetPermissionSetArn()
        {
            return this._permissionSetArn != null;
        }

    }
}