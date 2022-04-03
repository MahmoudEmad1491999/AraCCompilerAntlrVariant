using System.Text;
using System.Collections.Generic;

namespace AntlrExamples.AST {
    // public class DotGraphGenerator {
    //     public static Dictionary<string, int> ids = new Dictionary<string, int>(){
    //         {"ProgramContext", 0},
    //         {"GlobalVarDeclContext", 0},
    //         {"InititalizationContext", 0},
    //         {"FunctionDeclContext", 0},
    //         {"OperationDeclContext", 0 },
    //         {"ParameterContext", 0 },
    //         {"ParamListContext", 0 },
    //         {"ArgumentContext", 0 },
    //         {"ArgumentListContext", 0 },
    //         {"ExpressionContext", 0 },
    //         {"VariableExprContext", 0 },
    //         {"DivideExprContext", 0 },
    //         {"FunCallExprContext", 0 },
    //         {"NegationExprContext", 0 },
    //         {"AddExprContext", 0 },
    //         {"LiteralExprContext", 0 },
    //         {"MultiplyExprContext", 0 },
    //         {"ParenthesisExprContext", 0 },
    //         {"SubtractionExprContext", 0 },
    //         {"If_StatContext", 0 },
    //         {"Var_DeclContext", 0 },
    //         {"Return_StatContext", 0 },
    //         {"Expression_StatContext", 0 },
    //         {"While_StatContext", 0 },
    //         {"Result_StatContext", 0 },
    //         {"Assignment_StatContext", 0 },
    //         {"StatementContext", 0 },
    //         {"StatementListContext", 0 },
    //         {"ExpressionStatContext", 0 },
    //         {"OperationStatContext", 0 },
    //         {"AssignmentStatContext", 0 },
    //         {"IfStatContext", 0 },
    //         {"WhileStatContext", 0 },
    //         {"ReturnStatContext", 0 },
    //         {"ResultStatContext", 0 },
    //         {"VarDeclContext", 0 },
    //         {"DataTypeContext", 0 },
    //         {"TerminalNodeImpl", 0}
    //     };
    //     private static StringBuilder graph = new StringBuilder();

    //     public static void ConstructGraph(Node tree, int id)
    //     {
    //         IParseTree temp;
    //         string temp_type_name;
    //         for (int index = 0; index < tree.ChildCount; index++)
    //         {
    //             temp = tree.GetChild(index);
    //             temp_type_name = temp.GetType().Name;
    //             if (temp_type_name == "TerminalNodeImpl")
    //             {
    //                 graph.AppendLine(temp_type_name + "_" + ids[temp_type_name] + $"[label=\"{temp.GetText()}\"]");
    //                 graph.AppendLine($"{tree.GetType().Name}_{id}->{temp_type_name + "_" + ids[temp_type_name]}");
    //                                     ids[temp_type_name]++;

    //             }
    //             else
    //             {
    //                 graph.AppendLine(temp_type_name + "_" + ids[temp_type_name] + $"[label=\"{temp_type_name}\"]");
    //                 graph.AppendLine($"{tree.GetType().Name}_{id}->{temp_type_name + "_" + ids[temp_type_name]}");
    //                 ids[temp_type_name]++;
    //                 ConstructGraph(temp, ids[temp_type_name] - 1);
    //             }



    //         }
    //     }
    //     public static string getGarph(IParseTree root) {
    //         ConstructGraph(root, 0);
    //         string graph = DotGraphGenerator.graph.ToString();
    //         DotGraphGenerator.graph.Clear();
    //         return graph;
    //     }

    // }
    public class ASTDotGraphGenerator
    {
        //     private static StringBuilder graph = new StringBuilder();
        public static Dictionary<string, int> ids = new Dictionary<string, int>() {
            {"Program",0},
            {"FunctionDeclaration",0},
            {"OperationDeclaration",0},
            {"GlobalVarDeclarartion",0},
            {"AssignStatment",0},
            {"IfStatement",0},
            {"WhileStatement",0},
            {"ReturnStatement",0},
            {"ResultStatement",0},
            {"VarDeclStatement",0},
            {"ExprStatement",0},
            {"AdditionExpr",0},
            {"SubtractionExpr",0},
            {"OperationStat",0},
            {"MultiplicationExpr",0},
            {"DivisionExpr",0},
            {"FunctionCallExpr",0},
            {"NegatedExpression",0},
            {"IntLiteralExpr",0},
            {"VariableExpr",0},
            {"ParenthesisExpr",0},
            {"ArgumentList",0},
            {"StatementList",0},
            {"Argument",0},
            {"ArgmentList",0},
            {"Parameter",0},
            {"ParameterList",0},
            {"Identifier", 0},
            {"CompExpression", 0},
            {"UnaryBLExpression", 0},
            {"CastingExpression", 0},
            {"EqualityExpression", 0},
            {"BOrExpression", 0},
            {"BXorExpression", 0},
            {"BAndExpression", 0},
            {"LorExpression", 0},
            {"LandExpression", 0},
            {"ArraySubscriptionExpression", 0},
            {"SizeExpression", 0},
            {"AddressExpression", 0},
            {"IndirectionExpression", 0},
            {"ShiftLeftExpression", 0},
            {"ShiftRightExpression", 0},
        };

        private static StringBuilder graph = new StringBuilder();

        private static void ConstructGraph(Node tree, int id)
        {
            Node temp = null;
            string temp_type_name;
            for (int index = 0; index < tree.child_count; index++)
            {
                
                temp = tree.GetChild(index);
                temp_type_name = temp.GetType().Name;
                if (temp_type_name == "IntLiteralExpr" || temp_type_name == "Identifier")
                {
                    graph.AppendLine(temp_type_name + "_" + ids[temp_type_name] + $"[label=\"{temp.GetValue()}\"]");
                    graph.AppendLine($"{tree.GetType().Name}_{id}->{temp_type_name + "_" + ids[temp_type_name]}");
                    ids[temp_type_name]++;

                }
                else
                {
                    graph.AppendLine(temp_type_name + "_" + ids[temp_type_name] + $"[label=\"{temp.GetValue()}\"]");
                    graph.AppendLine($"{tree.GetType().Name}_{id}->{temp_type_name + "_" + ids[temp_type_name]}");
                    ids[temp_type_name]++;
                    ConstructGraph(temp, ids[temp_type_name] - 1);
                }
            }
        }
        public static string getGarph(Node root)
        {
            ConstructGraph(root, 0);
            string graph = ASTDotGraphGenerator.graph.ToString();
            ASTDotGraphGenerator.graph.Clear();
            return "digraph graph_name {\n" + graph + "\n}";
        }


    }
}