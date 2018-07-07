using System.Text;

namespace MLogger.Builders
{
    public class MyStringBuilder : IStringBuilder
    {
        private StringBuilder _builder;

        public MyStringBuilder()
        {
            _builder = new StringBuilder();
        }
        public IStringBuilder Append(string value)
        {
            _builder.Append(value);
            return this;
        }

        public IStringBuilder Append(char value)
        {
            _builder.Append(value);
            return this;
        }

        public override string ToString()
        {
            string result = _builder.ToString();
            _builder = new StringBuilder();
            return result;
        }
    }
}
