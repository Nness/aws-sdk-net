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
    /// The overall resiliency score, returned as an object that includes the disruption score
    /// and outage score.
    /// </summary>
    public partial class ResiliencyScore
    {
        private Dictionary<string, double> _disruptionScore = new Dictionary<string, double>();
        private double? _score;

        /// <summary>
        /// Gets and sets the property DisruptionScore. 
        /// <para>
        /// The disruption score for a valid key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, double> DisruptionScore
        {
            get { return this._disruptionScore; }
            set { this._disruptionScore = value; }
        }

        // Check to see if DisruptionScore property is set
        internal bool IsSetDisruptionScore()
        {
            return this._disruptionScore != null && this._disruptionScore.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The outage score for a valid key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double Score
        {
            get { return this._score.GetValueOrDefault(); }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score.HasValue; 
        }

    }
}