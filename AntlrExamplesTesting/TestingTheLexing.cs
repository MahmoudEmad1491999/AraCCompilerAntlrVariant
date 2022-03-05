using System;
using Xunit;
using System.IO;
using Antlr4.Runtime;
using AntlrOutput;
using Antlr4.Runtime.Tree;
using Antlr4.Runtime.Misc;

namespace AntlrExamplesTesting
{
    public class TestingTheLexing
    {
        private static string testing_files_folder_path = "/home/mahmoud/AraCAntlrVariant/AntlrExamplesTesting/testing_source_files/";
        public static string[] testing_files_names = {
            "source1.arac",
            "source2.arac"
        };
        [Fact]
        public void simple_source_file_detection_and_lexing()
        {
            string source1 = File.ReadAllText(testing_files_folder_path + testing_files_names[0]);

            ICharStream charStream = CharStreams.fromString(source1);
            ITokenSource tokenSource = new AraCLexer(charStream);
            ITokenStream tokenStream = new CommonTokenStream(tokenSource);
            AraCParser araCParser = new AraCParser(tokenStream);

            AraCParser.ProgramContext programContext = araCParser.program();

            Console.WriteLine(programContext.ToStringTree());
        }
        [Fact]
        public void lexing_is_correct_for_files_that_contain_string_literals()
        {
            string source2 = File.ReadAllText(testing_files_folder_path + testing_files_names[1]);

            ICharStream charStream = CharStreams.fromString(source2);
            ITokenSource tokenSource = new AraCLexer(charStream);
            ITokenStream tokenStream = new CommonTokenStream(tokenSource);
            AraCParser araCParser = new AraCParser(tokenStream);

            AraCParser.ProgramContext programContext = araCParser.program();

            Console.WriteLine(programContext.ToStringTree());
        }

    }
}
