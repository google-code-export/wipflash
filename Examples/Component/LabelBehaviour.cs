﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Automation;
using Examples.ExampleUtils;
using NUnit.Framework;
using WiPFlash.Components;

namespace Examples.Component
{
    [TestFixture]
    public class LabelBehaviour : AutomationElementWrapperExamples<Label>
    {
        [Test]
        public void ShouldAllowTextToBeRetrievedFromBlock()
        {
            Label label = CreateWrapper();
            Assert.AreEqual("0.00", label.Text);
        }

        protected override Label CreateWrapperWith(AutomationElement element)
        {
            return new Label(element);
        }

        protected override Label CreateWrapper()
        {
            return LaunchPetShopWindow().Find<Label>("totalOutput");
        }
    }
}