using System.Collections.Generic;
using Parser;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.Text;

namespace Parser {
    public class DotGraphGenerator {
        public static Dictionary<string, int> ids = new Dictionary<string, int>(){
            {"ProgramContext", 0 },
            {"GlobalVarDeclContext", 0 },
            {"FuncDeclContext", 0 },
            {"OpDeclContext", 0 },
            {"ParamListContext", 0 },
            {"ExpressionContext", 0 },
            {"IDExprContext", 0 },
            {"AddressExprContext", 0 },
            {"ParenthesisExprContext", 0 },
            {"MultiplyExprContext", 0 },
            {"EualityExprContext", 0 },
            {"BxorExprContext", 0 },
            {"AddExprContext", 0 },
            {"CompExprContext", 0 },
            {"BandExprContext", 0 },
            {"LandExprContext", 0 },
            {"IndirectionExprContext", 0 },
            {"ArrSubScripExprContext", 0 },
            {"LorExprContext", 0 },
            {"DivExprContext", 0 },
            {"BorExprContext", 0 },
            {"SizeExprContext", 0 },
            {"LiteralExprContext", 0 },
            {"UnaryBLExprContext", 0 },
            {"SubtractExprContext", 0 },
            {"CastingExprContext", 0 },
            {"UnaryArithmeticExprContext", 0 },
            {"FuncCallExprContext", 0 },
            {"ArgumentListContext", 0 },
            {"If_StatContext", 0 },
            {"Var_DeclContext", 0 },
            {"Return_StatContext", 0 },
            {"Expression_StatContext", 0 },
            {"While_StatContext", 0 },
            {"Result_StatContext", 0 },
            {"Assignment_StatContext", 0 },
            {"AssignmentStatContext", 0 },
            {"IfStatContext", 0 },
            {"WhileStatContext", 0 },
            {"ReturnStatContext", 0 },
            {"ResultStatContext", 0 },
            {"VarDeclContext", 0 },
            {"DataTypeContext", 0 },
            {"TerminalNodeImpl", 0}
        };
        private static StringBuilder graph = new StringBuilder();
        
        public static void ConstructGraph(IParseTree tree, int id)
        {
            IParseTree temp;
            string temp_type_name;
            for (int index = 0; index < tree.ChildCount; index++)
            {
                temp = tree.GetChild(index);
                temp_type_name = temp.GetType().Name;
                if (temp_type_name == "TerminalNodeImpl")
                {
                    graph.AppendLine(temp_type_name + "_" + ids[temp_type_name] + $"[label=\"{temp.GetText()}\"]");
                    graph.AppendLine($"{tree.GetType().Name}_{id}->{temp_type_name + "_" + ids[temp_type_name]}");
                                        ids[temp_type_name]++;

                }
                else
                {
                    graph.AppendLine(temp_type_name + "_" + ids[temp_type_name] + $"[label=\"{temp_type_name}\"]");
                    graph.AppendLine($"{tree.GetType().Name}_{id}->{temp_type_name + "_" + ids[temp_type_name]}");
                    ids[temp_type_name]++;
                    ConstructGraph(temp, ids[temp_type_name] - 1);
                }



            }
        }
        public static string getGarph(IParseTree root) {
            ConstructGraph(root, 0);
            string graph = DotGraphGenerator.graph.ToString();
            DotGraphGenerator.graph.Clear();
            return graph;
        }
    }
}