/*
 *
 * NDbUnit
 * Copyright (C)2017
 * http://code.google.com/p/ndbunit
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

namespace NDbUnit.Core
{
    using System;
    using System.Data;

    /// <summary>
    /// The Type Helpers
    /// </summary>
    /// <remarks>
    /// From https://github.com/GregFinzer/Compare-Net-Objects
    /// </remarks>
    public static class TypeHelper
    {
        /// <summary>
        /// Determines whether the specified type is dataset.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>
        ///   <c>true</c> if the specified type is dataset; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsDataset(Type type)
        {
            if (type == null)
                return false;

            return type == typeof(DataSet);
        }

        /// <summary>
        /// Determines whether [is data table] [the specified type].
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>
        ///   <c>true</c> if [is data table] [the specified type]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsDataTable(Type type)
        {
            if (type == null)
                return false;

            return type == typeof(DataTable);
        }
    }
}