/*
 *
 * NDbUnit
 * Copyright (C)2005 - 2011
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

using System.Configuration;
using System.Runtime.InteropServices;
using Gallio.Runtime.Extensibility.Schema;

namespace NDbUnit.Test
{
    public class DbConnection
    {
        private static string _targetConfigFilename = "NDbUnit.Test.dll.config";
        private static string _activeConfigSourceFilename;
        private static bool _isInitialized;

        private static void Init()
        {
            if (_isInitialized)
                return;

            _activeConfigSourceFilename = BuildActiveConfigSourceFilename();

            if (System.IO.File.Exists(_activeConfigSourceFilename))
            {
                System.IO.File.Copy(_activeConfigSourceFilename, _targetConfigFilename, true);
            }

            _isInitialized = true;
        }

        private static string BuildActiveConfigSourceFilename()
        {
            var computerName = System.Environment.GetEnvironmentVariable("COMPUTERNAME");
            return string.Format("app.config.{0}", computerName);
        }


        public static string PostgresqlConnectionString
        {
            get
            {
                Init();
                return ConfigurationManager.ConnectionStrings["PostgresqlConnectionString"].ConnectionString;
            }
        }
        public static string MySqlConnectionString
        {
            get
            {
                Init();
                return ConfigurationManager.ConnectionStrings["MysqlConnectionString"].ConnectionString;
            }
        }

        public static string OleDbConnectionString
        {
            get
            {
                Init();
                return ConfigurationManager.ConnectionStrings["OleDbConnectionString"].ConnectionString;
            }
        }

        public static string SqlCeConnectionString
        {
            get
            {
                Init();
                return ConfigurationManager.ConnectionStrings["SqlCeConnectionString"].ConnectionString;
            }
        }

        public static string SqlConnectionString
        {
            get
            {
                Init();
                return ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
            }
        }

        public static string SqlLiteConnectionString
        {
            get
            {
                Init();
                return ConfigurationManager.ConnectionStrings["SqlLiteConnectionString"].ConnectionString;
            }
        }

        public static string SqlLiteInMemConnectionString
        {
            get
            {
                Init();
                return ConfigurationManager.ConnectionStrings["SqlLiteInMemConnectionString"].ConnectionString;
            }
        }

        public static string OracleClientConnectionString
        {
            get
            {
                Init();
                return ConfigurationManager.ConnectionStrings["OracleClientConnectionString"].ConnectionString;
            }
        }
    }
}
