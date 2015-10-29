/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/
namespace QuantConnect
{
    /// <summary>
    /// Markets Collection: Soon to be expanded to a collection of items specifying the market hour, timezones and country codes.
    /// </summary>
    public static class Market
    {
        /// <summary>
        /// USA Market 
        /// </summary>
        public static string USA = "usa";

        /// <summary>
        /// Oanda Market
        /// </summary>
        public static string Oanda = "oanda";

        /// <summary>
        /// FXCM Market Hours
        /// </summary>
        public static string FXCM = "fxcm";

        /// <summary>
        /// Dukascopy Market
        /// </summary>
        public static string Dukascopy = "dukascopy";
    }
}