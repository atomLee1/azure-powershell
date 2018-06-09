﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.EventGrid.Test.ScenarioTests;
using Microsoft.Azure.ServiceManagemenet.Common.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Test.Utilities.Common;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Azure.Commands.EventGrid.Tests.ScenarioTests
{
    public class TopicTests : RMTestBase
    {
        public TopicTests(ITestOutputHelper output)
        {
            XunitTracingInterceptor.AddToContext(new XunitTracingInterceptor(output));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void EventGrid_TopicsCreateGetAndDelete()
        {
            EventGridController.NewInstance.RunPsTest("TopicTests");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void EventGrid_TopicsSet()
        {
            EventGridController.NewInstance.RunPsTest("TopicSetTests");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void EventGrid_TopicsGetKey()
        {
            EventGridController.NewInstance.RunPsTest("TopicGetKeyTests");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void EventGrid_TopicsNewKey()
        {
            EventGridController.NewInstance.RunPsTest("TopicNewKeyTests");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void EventGrid_TopicsInputMappingCreateGetAndDelete()
        {
            EventGridController.NewInstance.RunPsTest("TopicInputMappingTests");
        }
    }
}
