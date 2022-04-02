using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Parser;
using static Parser.aracParser;
using AntlrExamples.Misc;

using System.Collections.Generic;

[assembly: CLSCompliant(false)]

namespace AntlrExamples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "/home/mahmoud/testfile.arac";
            string input = File.ReadAllText(path);

            ICharStream charStream = CharStreams.fromString(input);
            ITokenSource tokenSource = new aracLexer(charStream);
            ITokenStream tokenStream = new CommonTokenStream(tokenSource);
            aracParser araCParser = new aracParser(tokenStream);

            var program = araCParser.program();
            var ast_root = ASTGenerator.GenerateAST(program);
            // Console.WriteLine(ast_root.GetType().Name);
            String graph = ASTDotGraphGenerator.getGarph(ast_root);
            Console.WriteLine(graph);
             
        }

    }
}
