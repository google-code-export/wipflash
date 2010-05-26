using System;
using NUnit.Framework;
using WiPFlash.Components;
using WiPFlash.Framework;

namespace Scenarios
{
    public class HistorySteps
    {
        private readonly Universe _universe;

        public HistorySteps(Universe universe)
        {
            _universe = universe;
        }

        public void ShouldContain(string expected)
        {
            _universe.Window.Find<Tab>(new TitleBasedFinder(), "History").Select();
            var historyInput = _universe.Window.Find<RichTextBox>("historyInput");
            historyInput.WaitFor(hi => hi.Text.Contains(expected));
        }

        public void ShouldIncludeMostRecentPet(string name)
        {
            var view = _universe.Window.Find<GridView>("lastPetsOutput");
            Assert.AreEqual(view.TextAt(0, 2), name);
        }
    }
}