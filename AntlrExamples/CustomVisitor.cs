using Antlr4.Runtime.Misc;
using AntlrOutput;
using System;

namespace AntlrExamples
{
    public class CustomVisitor : AraCBaseVisitor<object>
    {
        public override object VisitProgram([NotNull] AraCParser.ProgramContext context)
        {
            Console.WriteLine("Hello World");
            return null;
        }
    }
}