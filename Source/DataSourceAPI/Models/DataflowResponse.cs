﻿/*
 * Copyright(c) 2017 Microsoft Corporation. All rights reserved. 
 * 
 * This code is licensed under the MIT License (MIT). 
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal 
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
 * of the Software, and to permit persons to whom the Software is furnished to do 
 * so, subject to the following conditions: 
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software. 
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE. 
*/

using System.Runtime.Serialization;

namespace BingMapsSDSToolkit.DataSourceAPI
{
    /// <summary>
    /// A response object from the Bing Spatial Data Services when making job requests.
    /// </summary>
    [DataContract]
    public class DataflowResponse
    {
        /// <summary>
        /// A copyright notice.
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        public string Copyright { get; set; }

        /// <summary>
        /// A URL that references a brand image to support contractual branding requirements.
        /// </summary>
        [DataMember(Name = "brandLogoUri", EmitDefaultValue = false)]
        public string BrandLogoUri { get; set; }

        /// <summary>
        /// The HTTP Status code for the request.
        /// </summary>
        [DataMember(Name = "statusCode", EmitDefaultValue = false)]
        public int StatusCode { get; set; }

        /// <summary>
        /// A description of the HTTP status code.
        /// </summary>
        [DataMember(Name = "statusDescription", EmitDefaultValue = false)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// A status code that offers additional information about authentication success or failure.
        /// </summary>
        [DataMember(Name = "authenticationResultCode", EmitDefaultValue = false)]
        public string AuthenticationResultCode { get; set; }

        /// <summary>
        /// A collection of error descriptions. 
        /// </summary>
        [DataMember(Name = "errorDetails", EmitDefaultValue = false)]
        public string[] ErrorDetails { get; set; }
        
        /// <summary>
        /// A unique identifier for the request.
        /// </summary>
        [DataMember(Name = "traceId", EmitDefaultValue = false)]
        public string TraceId { get; set; }

        /// <summary>
        /// A collection of DataflowResourceSet objects. A DataflowResourceSet is a container of DataflowJob's returned by the request.
        /// </summary>
        [DataMember(Name = "resourceSets", EmitDefaultValue = false)]
        public DataflowResultSet[] ResourceSets { get; set; }
    }
}
