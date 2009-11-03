using NUnit.Framework;

namespace MvcContrib.UnitTests
{
	internal static class AssertionExtensions
	{
		internal static void ShouldNotBeNull(this object actual)
		{
			Assert.IsNotNull(actual);
		}

		internal static void ShouldEqual(this object actual, object expected)
		{
			Assert.AreEqual(expected, actual);
		}

		internal static void ShouldBeTheSameAs(this object actual, object expected)
		{
			Assert.AreSame(expected, actual);
		}

		internal static void ShouldBeNull(this object actual)
		{
			Assert.IsNull(actual);
		}

		internal static void ShouldBeFalse(this bool value)
		{
			Assert.IsFalse(value);
		}

		internal static void ShouldBeTrue(this bool value)
		{
			Assert.IsTrue(value);
		}

		internal static void ShouldBe<T>(this object obj)
		{
			Assert.IsInstanceOfType(typeof(T), obj);
		}
	}
}