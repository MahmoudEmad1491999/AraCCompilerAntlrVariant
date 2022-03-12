using System.IO;
using Antlr4.Runtime;
using AntlrOutput;
namespace AntlrExamples
{
    public class CustomParser : AraCParser
    {
        public CustomParser(ITokenStream input) : base(input)
        {
        }

        public CustomParser(ITokenStream input, TextWriter output, TextWriter errorOutput) : base(input, output, errorOutput)
        {
        }
    }
}