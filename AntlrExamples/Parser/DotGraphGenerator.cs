using System.Collections.Generic;
using Parser;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.Text;

namespace Parser {
    public class DotGraphGenerator {
        public static Dictionary<string, int> ids = new Dictionary<string, int>(){
            {"TerminalNodeImpl", 0 },
            {"Function_declarationContext", 0 },
            {"Operatoin_declarationContext", 0 },
            {"Global_var_declaratoinContext", 0 },
            {"Param_listContext", 0 },
            {"ExpressionContext", 0 },
            {"Casting_exprContext", 0 },
            {"Lor_exprContext", 0 },
            {"Array_subscription_exprContext", 0 },
            {"Add_exprContext", 0 },
            {"Land_exprContext", 0 },
            {"Comparative_exprContext", 0 },
            {"Unary_bl_exprContext", 0 },
            {"Size_of_exprContext", 0 },
            {"Funciton_calling_exprContext", 0 },
            {"Shift_exprContext", 0 },
            {"Address_of_exprContext", 0 },
            {"Indirection_of_exprContext", 0 },
            {"Subtract_exprContext", 0 },
            {"Multipy_exprContext", 0 },
            {"Divide_exprContext", 0 },
            {"Bor_exprContext", 0 },
            {"Literal_exprContext", 0 },
            {"Identifier_exprContext", 0 },
            {"Parenth_exprContext", 0 },
            {"Equality_exprContext", 0 },
            {"Bxor_exprContext", 0 },
            {"Band_exprContext", 0 },
            {"Unary_arithmetic_exprContext", 0 },
            {"Argument_listContext", 0 },
            {"StatementContext", 0 },
            {"Expre_statContext", 0 },
            {"While_statContext", 0 },
            {"Var_decl_statContext", 0 },
            {"Return_statContext", 0 },
            {"Result_statContext", 0 },
            {"If_statContext", 0 },
            {"Assignment_statContext", 0 },
            {"Assignment_statementContext", 0 },
            {"Left_hand_sideContext", 0 },
            {"If_statementContext", 0 },
            {"While_statementContext", 0 },
            {"Return_statementContext", 0 },
            {"Result_statementContext", 0 },
            {"Data_typeContext", 0 }
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