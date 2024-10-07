using System;
using System.Collections.Generic;
using UiPath.CodedWorkflows;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace IfStatements
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.UIAutomationNext.API.Contracts.IRuntimeTargetAppSyncFactory), typeof(UiPath.Testing.API.ITestingService)};
        }

        protected UiPath.Testing.API.ITestingService testing { get => serviceContainer.Resolve<UiPath.Testing.API.ITestingService>() ; }

        protected UiPath.UIAutomationNext.API.Contracts.IRuntimeTargetAppSyncFactory uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IRuntimeTargetAppSyncFactory>() ; }
    }
}