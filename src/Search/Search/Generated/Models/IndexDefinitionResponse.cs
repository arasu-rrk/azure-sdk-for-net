// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;
using Microsoft.Azure.Search.Models;

namespace Microsoft.Azure.Search.Models
{
    /// <summary>
    /// Response from a Create, Update, or Get Index request. If successful, it
    /// includes the full definition of the index that was created, updated,
    /// or retrieved.
    /// </summary>
    public partial class IndexDefinitionResponse : AzureOperationResponse
    {
        private Index _index;
        
        /// <summary>
        /// Optional. Gets the definition of the index.
        /// </summary>
        public Index Index
        {
            get { return this._index; }
            set { this._index = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the IndexDefinitionResponse class.
        /// </summary>
        public IndexDefinitionResponse()
        {
        }
    }
}