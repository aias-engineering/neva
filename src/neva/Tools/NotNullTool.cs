using NeVa.Infrastructure;

namespace NeVa.Tools
{
    public class NotNullTool
    {
        public ToolResult Validate(object value)
        {
            return new ToolResult(value != null, value.ToValueString(), "NotNull");
        }
    }
}