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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAFV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ManagedRuleGroupConfig Object
    /// </summary>  
    public class ManagedRuleGroupConfigUnmarshaller : IUnmarshaller<ManagedRuleGroupConfig, XmlUnmarshallerContext>, IUnmarshaller<ManagedRuleGroupConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ManagedRuleGroupConfig IUnmarshaller<ManagedRuleGroupConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ManagedRuleGroupConfig Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ManagedRuleGroupConfig unmarshalledObject = new ManagedRuleGroupConfig();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AWSManagedRulesATPRuleSet", targetDepth))
                {
                    var unmarshaller = AWSManagedRulesATPRuleSetUnmarshaller.Instance;
                    unmarshalledObject.AWSManagedRulesATPRuleSet = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AWSManagedRulesBotControlRuleSet", targetDepth))
                {
                    var unmarshaller = AWSManagedRulesBotControlRuleSetUnmarshaller.Instance;
                    unmarshalledObject.AWSManagedRulesBotControlRuleSet = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LoginPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LoginPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PasswordField", targetDepth))
                {
                    var unmarshaller = PasswordFieldUnmarshaller.Instance;
                    unmarshalledObject.PasswordField = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PayloadType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PayloadType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UsernameField", targetDepth))
                {
                    var unmarshaller = UsernameFieldUnmarshaller.Instance;
                    unmarshalledObject.UsernameField = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ManagedRuleGroupConfigUnmarshaller _instance = new ManagedRuleGroupConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ManagedRuleGroupConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}