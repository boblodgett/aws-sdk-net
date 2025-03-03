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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Container for the parameters to the ImportResourcesToDraftAppVersion operation.
    /// Imports resources to AWS Resilience Hub application draft version from different input
    /// sources. For more information about the input sources supported by AWS Resilience
    /// Hub, see <a href="https://docs.aws.amazon.com/resilience-hub/latest/userguide/discover-structure.html">Discover
    /// the structure and describe your Resilience Hub application</a>.
    /// </summary>
    public partial class ImportResourcesToDraftAppVersionRequest : AmazonResilienceHubRequest
    {
        private string _appArn;
        private ResourceImportStrategyType _importStrategy;
        private List<string> _sourceArns = new List<string>();
        private List<TerraformSource> _terraformSources = new List<TerraformSource>();

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Resilience Hub application. The format for
        /// this ARN is: arn:<code>partition</code>:resiliencehub:<code>region</code>:<code>account</code>:app/<code>app-id</code>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>AWS General Reference</i> guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppArn
        {
            get { return this._appArn; }
            set { this._appArn = value; }
        }

        // Check to see if AppArn property is set
        internal bool IsSetAppArn()
        {
            return this._appArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImportStrategy. 
        /// <para>
        /// The import strategy you would like to set to import resources into AWS Resilience
        /// Hub application.
        /// </para>
        /// </summary>
        public ResourceImportStrategyType ImportStrategy
        {
            get { return this._importStrategy; }
            set { this._importStrategy = value; }
        }

        // Check to see if ImportStrategy property is set
        internal bool IsSetImportStrategy()
        {
            return this._importStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) for the resources that you want to import.
        /// </para>
        /// </summary>
        public List<string> SourceArns
        {
            get { return this._sourceArns; }
            set { this._sourceArns = value; }
        }

        // Check to see if SourceArns property is set
        internal bool IsSetSourceArns()
        {
            return this._sourceArns != null && this._sourceArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TerraformSources. 
        /// <para>
        ///  A list of terraform file s3 URLs you need to import. 
        /// </para>
        /// </summary>
        public List<TerraformSource> TerraformSources
        {
            get { return this._terraformSources; }
            set { this._terraformSources = value; }
        }

        // Check to see if TerraformSources property is set
        internal bool IsSetTerraformSources()
        {
            return this._terraformSources != null && this._terraformSources.Count > 0; 
        }

    }
}