using NUnit.Framework;
using MvcContrib.FluentHtml.Elements;

namespace MvcContrib.UnitTests.FluentHtml
{
    [TestFixture]
    public class ElementTests
    {
        public class TestModel
        {
            public string String { get; set; }
        }
        [Test]
        public void Should_render_javascript_code_for_OnlyVisibleWhenValueSelected()
        {
            var html = new TextBox("test").OnlyVisibleWhenValueSelected<TestModel>(m => m.String, 2).ToString();
            Assert.That(html.Contains(string.Format(Element<TextBox>.OnlyVisibleWhenValueSelectedJavaScriptCode,
                "String", "test", 2)));
        }

        [Test]
        public void Should_not_render_javascript_code_for_OnlyVisibleWhenValueSelected_if_not_used()
        {
            var html = new TextBox("test").ToString();
            Assert.That(!html.Contains("var selectElement = document.getElementById"));
        }
    }
}