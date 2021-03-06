﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.ResourceManager;
using Microsoft.Azure.Management.Sql;
using Microsoft.Azure.Management.Sql.Models;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System.Net;
using Xunit;

namespace Sql.Tests
{
    public class OperationsScenarioTests
    {
        [Fact]
        public void TestListOperations()
        {
            string suiteName = this.GetType().FullName;
            using (SqlManagementTestContext context = new SqlManagementTestContext(this))
            {
                var sqlClient = context.GetClient<SqlManagementClient>();

                OperationListResult result = sqlClient.Operations.List();

                foreach(Operation operation in result.Value)
                {
                    Assert.NotNull(operation.Display);
                    Assert.NotNull(operation.Display.Provider);
                    Assert.NotNull(operation.Display.Resource);
                    Assert.NotNull(operation.Display.Operation);
                }
            }
        }
    }
}
