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
    /// Defines an AWS Resilience Hub application.
    /// </summary>
    public partial class App
    {
        private string _appArn;
        private AppAssessmentScheduleType _assessmentSchedule;
        private AppComplianceStatusType _complianceStatus;
        private DateTime? _creationTime;
        private string _description;
        private DateTime? _lastAppComplianceEvaluationTime;
        private DateTime? _lastResiliencyScoreEvaluationTime;
        private string _name;
        private string _policyArn;
        private double? _resiliencyScore;
        private AppStatusType _status;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

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
        /// Gets and sets the property AssessmentSchedule. 
        /// <para>
        ///  Assessment execution schedule with 'Daily' or 'Disabled' values. 
        /// </para>
        /// </summary>
        public AppAssessmentScheduleType AssessmentSchedule
        {
            get { return this._assessmentSchedule; }
            set { this._assessmentSchedule = value; }
        }

        // Check to see if AssessmentSchedule property is set
        internal bool IsSetAssessmentSchedule()
        {
            return this._assessmentSchedule != null;
        }

        /// <summary>
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        /// The current status of compliance for the resiliency policy.
        /// </para>
        /// </summary>
        public AppComplianceStatusType ComplianceStatus
        {
            get { return this._complianceStatus; }
            set { this._complianceStatus = value; }
        }

        // Check to see if ComplianceStatus property is set
        internal bool IsSetComplianceStatus()
        {
            return this._complianceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp for when the app was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The optional description for an app.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LastAppComplianceEvaluationTime. 
        /// <para>
        /// The timestamp for the most recent compliance evaluation.
        /// </para>
        /// </summary>
        public DateTime LastAppComplianceEvaluationTime
        {
            get { return this._lastAppComplianceEvaluationTime.GetValueOrDefault(); }
            set { this._lastAppComplianceEvaluationTime = value; }
        }

        // Check to see if LastAppComplianceEvaluationTime property is set
        internal bool IsSetLastAppComplianceEvaluationTime()
        {
            return this._lastAppComplianceEvaluationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastResiliencyScoreEvaluationTime. 
        /// <para>
        /// The timestamp for the most recent resiliency score evaluation.
        /// </para>
        /// </summary>
        public DateTime LastResiliencyScoreEvaluationTime
        {
            get { return this._lastResiliencyScoreEvaluationTime.GetValueOrDefault(); }
            set { this._lastResiliencyScoreEvaluationTime = value; }
        }

        // Check to see if LastResiliencyScoreEvaluationTime property is set
        internal bool IsSetLastResiliencyScoreEvaluationTime()
        {
            return this._lastResiliencyScoreEvaluationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resiliency policy. The format for this ARN is:
        /// arn:<code>partition</code>:resiliencehub:<code>region</code>:<code>account</code>:resiliency-policy/<code>policy-id</code>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>AWS General Reference</i> guide.
        /// </para>
        /// </summary>
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResiliencyScore. 
        /// <para>
        /// The current resiliency score for the application.
        /// </para>
        /// </summary>
        public double ResiliencyScore
        {
            get { return this._resiliencyScore.GetValueOrDefault(); }
            set { this._resiliencyScore = value; }
        }

        // Check to see if ResiliencyScore property is set
        internal bool IsSetResiliencyScore()
        {
            return this._resiliencyScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the application.
        /// </para>
        /// </summary>
        public AppStatusType Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the resource. A tag is a label that you assign to an Amazon Web
        /// Services resource. Each tag consists of a key/value pair.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}