﻿// 
// QueryTernaryExpression.cs
// 
// Author:
//     Jim Borden  <jim.borden@couchbase.com>
// 
// Copyright (c) 2017 Couchbase, Inc All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 

using System.Linq;
using Couchbase.Lite.Query;

namespace Couchbase.Lite.Internal.Query
{
    internal sealed class QueryTernaryExpression : QueryExpression, IExpressionIn, IExpressionSatisfies
    {
        #region Variables

        private readonly string _function;
        private readonly string _variableName;
        private object _in;
        private object _predicate;

        #endregion

        #region Constructors

        internal QueryTernaryExpression(string function, string variableName)
        {
            _function = function;
            _variableName = variableName;
        }

        #endregion

        #region Overrides

        protected override object ToJSON()
        {
            var retVal = new object[4] {
                _function,
                _variableName,
                _in,
                _predicate
            };

            return retVal.Select(x =>
            {
                if (x is QueryExpression e) {
                    return e.ConvertToJSON();
                }

                return x;
            });        }

        #endregion

        #region IExpressionIn

        public IExpressionSatisfies In(object expression)
        {
            _in = expression;
            return this;
        }

        #endregion

        #region IExpressionSatisfies

        public IExpression Satisfies(object expression)
        {
            _predicate = expression;
            return this;
        }

        #endregion
    }
}