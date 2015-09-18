using ExAs;
using NeVa.Tools;
using NUnit.Framework;

namespace NeVa.Tests.Tools
{
    [TestFixture]
    public class NotNullToolTests
    {
        private NotNullTool tool;

        [SetUp]
        public void SetupContext()
        {
            tool = new NotNullTool();
        }

        [Test]
        public void Validate_WithAnyString_ShouldReturnSuccess()
        {
            ToolResult result = tool.Validate("AnyString");

            result.ExAssert(r => r.Property(x => x.Succeeded)  .IsTrue()
                                  .Property(x => x.Value)      .IsEqualTo("'AnyString'")
                                  .Property(x => x.Expectation).IsEqualTo("NotNull"));
        }

        [Test]
        public void Validate_WithNull_ShouldReturnFailure()
        {
            ToolResult result = tool.Validate(null);

            result.ExAssert(r => r.Property(x => x.Succeeded)  .IsFalse()
                                  .Property(x => x.Value)      .IsEqualTo("null")
                                  .Property(x => x.Expectation).IsEqualTo("NotNull"));
        }

        [Test]
        public void Validate_With15_ShouldReturnSuccess()
        {
            ToolResult result = tool.Validate(15);

            result.ExAssert(r => r.Property(x => x.Succeeded)  .IsTrue()
                                  .Property(x => x.Value)      .IsEqualTo("15")
                                  .Property(x => x.Expectation).IsEqualTo("NotNull"));
        }
    }
}