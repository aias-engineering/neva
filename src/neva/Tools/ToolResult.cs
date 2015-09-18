namespace NeVa.Tools
{
    public class ToolResult
    {
        private readonly bool succeeded;
        private readonly string value;
        private readonly string expectation;

        public ToolResult(bool succeeded, string value, string expectation)
        {
            this.succeeded = succeeded;
            this.value = value;
            this.expectation = expectation;
        }

        public bool Succeeded
        {
            get { return succeeded; }
        }

        public string Value
        {
            get { return value; }
        }

        public string Expectation
        {
            get { return expectation; }
        }
    }
}