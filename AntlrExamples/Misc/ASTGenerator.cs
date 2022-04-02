using System;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Parser;
using static Parser.aracParser;
namespace AntlrExamples.Misc
{
    public class ASTGenerator {
        public static Node GenerateAST(IParseTree root) {
            if(root is TerminalNodeImpl){
                return null;
            }
            else if(root is aracParser.ProgramContext){
                   ProgramContext programContext = (ProgramContext) root;

                   List<Node> declarations = new List<Node>();
                   foreach(var declaration in programContext.GetRuleContexts<ParserRuleContext>())
                   {
                       declarations.Add(GenerateAST(declaration));
                   }
                   
                   return new Program(declarations);
            }
            else if(root is aracParser.GlobalVarDeclContext){
                GlobalVarDeclContext globalVarDeclContext = (GlobalVarDeclContext) root;

                string variable_name = globalVarDeclContext.ID().GetText();
                string datatype = globalVarDeclContext.dataType().GetText();
                Node initial_value = null;
                
                if(globalVarDeclContext.inititalization() != null){
                    initial_value = GenerateAST(globalVarDeclContext.inititalization().expression());
                }

                return new GlobalVarDeclarartion(new Identifier(datatype) ,new Identifier(variable_name), initial_value);
            }
            // else if(root is aracParser.InititalizationContext){
            //     return null;
            // }
            else if(root is aracParser.FunctionDeclContext){
                FunctionDeclContext functionDeclContext = (FunctionDeclContext) root;

                string return_type = functionDeclContext.dataType().GetText();
                string function_name = functionDeclContext.ID().GetText();
                
                Node parameter_list = GenerateAST(functionDeclContext.paramList());
                Node statement_list = GenerateAST(functionDeclContext.statementList());                
                
                return new FunctionDeclaration(new Identifier(return_type), new Identifier(function_name), parameter_list, statement_list);
            }
            else if(root is aracParser.OperationDeclContext){
                OperationDeclContext operationDeclContext = (OperationDeclContext) root;

                string operation_name = operationDeclContext.ID().GetText();
                
                Node parameter_list = GenerateAST(operationDeclContext.paramList());
                Node statement_list = GenerateAST(operationDeclContext.statementList());

                
                
                return new OperationDeclaration( new Identifier(operation_name), parameter_list, statement_list);
            }
            else if(root is aracParser.ParameterContext){
                ParameterContext parameterContext = (ParameterContext) root;
                
                string datatype = parameterContext.dataType().GetText();
                string parameter_name = parameterContext.ID().GetText();

                return new Parameter(new Identifier(datatype), new Identifier(parameter_name));

            }
            else if(root is aracParser.ParamListContext){
                ParamListContext paramListContext = (ParamListContext) root;
                
                Node parameter_node = null;
                List<Node> parameter_list = new List<Node>();
                
                foreach(var parameter in paramListContext.parameter())
                {
                    parameter_node = GenerateAST(parameter);
                    parameter_list.Add(parameter_node);
                }
                
                return new ParameterList(parameter_list);
            }
            else if(root is aracParser.ArgumentContext){
                ArgumentContext argumentContext = (ArgumentContext) root;
                
                return new Argument(GenerateAST(argumentContext.expression()));
            }
            else if(root is aracParser.ArgumentListContext){
                ArgumentListContext argumentListContext = (ArgumentListContext) root;
                
                Node argument_node = null;
                List<Node> argument_list = new List<Node>();
                
                foreach(var argument in argumentListContext.argument()){
                    argument_node = GenerateAST(argument);
                    argument_list.Add(argument_node);
                }
                
                return new ArgumentList(argument_list);
            }
            // else if(root is aracParser.ExpressionContext){
            //     return null;
            // }
            else if(root is aracParser.VariableExprContext){
                VariableExprContext variableExprContext = (VariableExprContext) root;
                
                string varaible_name = variableExprContext.ID().GetText();
                
                return new VariableExpr(varaible_name);
            }
            else if(root is aracParser.CompExprContext){
                CompExprContext compExprContext = (CompExprContext) root;
                
                Node first_operand = GenerateAST(compExprContext.expression(0));
                Node second_operand = GenerateAST(compExprContext.expression(1));
                
                string comparison_op = compExprContext.comparison_op().GetText();
                
                return new CompExpression(first_operand,comparison_op, second_operand);
            }
            else if(root is aracParser.DivideExprContext){
                DivideExprContext divideExprContext = (DivideExprContext) root;

                Node first_operand = GenerateAST(divideExprContext.expression(0));
                Node second_operand = GenerateAST(divideExprContext.expression(1));
                
                return new DivisionExpr(first_operand, second_operand);
            }
            else if(root is aracParser.FunCallExprContext){
                FunCallExprContext funCallExprContext = (FunCallExprContext) root;

                string function_name = funCallExprContext.ID().GetText();
                Node argument_list = GenerateAST(funCallExprContext.argumentList());

                return new FunctionCallExpr(function_name, argument_list);
            }
            else if(root is aracParser.NegationExprContext){
                NegationExprContext negationExprContext = (NegationExprContext) root;
                
                return new NegatedExpression(GenerateAST(negationExprContext.expression()));
            }
            else if(root is aracParser.AddExprContext){
                AddExprContext addExprContext = (AddExprContext) root;
                
                Node first_operand = GenerateAST(addExprContext.expression(0));
                Node second_operand = GenerateAST(addExprContext.expression(1));

                return new AdditionExpr(first_operand, second_operand);
            }
            
            else if(root is aracParser.LiteralExprContext){
                return new IntLiteralExpr(root.GetText());
            }
            
            else if(root is aracParser.MultiplyExprContext){
                MultiplyExprContext multiplyExprContext = (MultiplyExprContext) root;
                
                Node first_operand = GenerateAST(multiplyExprContext.expression(0));
                Node second_operand = GenerateAST(multiplyExprContext.expression(1));
                
                return new MultiplicationExpr(first_operand, second_operand);
            }
            else if(root is aracParser.ParenthesisExprContext){
                ParenthesisExprContext parenthesisExprContext = (ParenthesisExprContext) root;
                
                return new ParenthesisExpr( GenerateAST(parenthesisExprContext.expression()) );
            }
            else if(root is aracParser.SubtractionExprContext){
                SubtractionExprContext subtractionExpr = (SubtractionExprContext) root;
                
                Node first_operand = GenerateAST(subtractionExpr.expression(0));
                Node second_operand = GenerateAST(subtractionExpr.expression(1));
                
                return new SubtractionExpr(first_operand, second_operand);
            }
            else if(root is aracParser.If_StatContext){
                If_StatContext if_StatContext = (If_StatContext) root;
                
                return GenerateAST(if_StatContext.ifStat());
            }
            else if(root is aracParser.Var_DeclContext){
                Var_DeclContext var_DeclContext = (Var_DeclContext) root;
                
                return GenerateAST(var_DeclContext.varDecl());
            }
            else if(root is aracParser.Return_StatContext){
                return new ReturnStatement();
            }
            else if(root is aracParser.Expression_StatContext){
                Expression_StatContext expression_StatContext = (Expression_StatContext) root;
                
                return GenerateAST(expression_StatContext.expressionStat());
            }
            else if(root is aracParser.While_StatContext){
                While_StatContext while_StatContext = (While_StatContext) root;
                
                return GenerateAST(while_StatContext.whileStat());
            }
            else if(root is aracParser.Result_StatContext){
                Result_StatContext result_StatContext = (Result_StatContext) root;
                
                return new ResultStatement(GenerateAST(result_StatContext.resultStat().expression()));
            }
            else if(root is aracParser.Assignment_StatContext){
                Assignment_StatContext assignment_StatContext = (Assignment_StatContext) root;
                
                return GenerateAST(assignment_StatContext.assignmentStat());
            }
            else if(root is aracParser.Operation_StatContext){
                Operation_StatContext operation_StatContext = (Operation_StatContext) root;
                
                return GenerateAST(operation_StatContext.operationStat());
            }
            // else if(root is aracParser.StatementContext){
            //     return null;
            // }
            else if(root is aracParser.StatementListContext){
                StatementListContext statementListContext = (StatementListContext) root;

                Node statement_node = null;
                List<Node> statement_list = new List<Node>();
                
                foreach(var statement in statementListContext.statement())
                {
                    statement_node = GenerateAST(statement);
                    statement_list.Add(statement_node);
                }
                
                return new StatementList(statement_list);
            }
            else if(root is aracParser.ExpressionStatContext){
                ExpressionStatContext expressionStatContext = (ExpressionStatContext) root;
                
                return new ExprStatement(GenerateAST(expressionStatContext.expression()));
            }
            else if(root is aracParser.OperationStatContext){
                OperationStatContext operationStatContext = (OperationStatContext) root;
                
                string operation_name = operationStatContext.ID().GetText();
                Node argument_list = GenerateAST(operationStatContext.argumentList());
                
                return new OperationStat(new Identifier(operation_name), argument_list);
            }
            else if(root is aracParser.AssignmentStatContext){
                AssignmentStatContext assignmentStatContext = (AssignmentStatContext) root;
                
                string variable_name = assignmentStatContext.ID().GetText();
                Node expr = GenerateAST(assignmentStatContext.expression());
                
                return new AssignStatment(new Identifier(variable_name), expr);
            }
            else if(root is aracParser.IfStatContext){
                IfStatContext ifStatContext = (IfStatContext) root;
                
                Node condition = GenerateAST(ifStatContext.expression());
                Node statement_list = GenerateAST(ifStatContext.statementList());
                
                
                return new IfStatement(condition, statement_list);
            }
            else if(root is aracParser.WhileStatContext){
                WhileStatContext whileStatContext = (WhileStatContext) root;

                Node condition = GenerateAST(whileStatContext.expression());
                Node statement_list = GenerateAST(whileStatContext.statementList());
                
                return new WhileStatement(condition, statement_list);
            }else if(root is aracParser.CastingExprContext){
                CastingExprContext castingExprContext = (CastingExprContext) root;
                string datatype = castingExprContext.dataType().GetText();
                Node expr = GenerateAST(castingExprContext.expression());
                return new CastingExpression(datatype, expr);
            }
            // else if(root is aracParser.ReturnStatContext){
            //     return null;
            // }
            // else if(root is aracParser.ResultStatContext){
            //     return null;
            // }
            else if(root is aracParser.VarDeclContext){
                VarDeclContext varDeclContext = (VarDeclContext) root;

                string datatype = varDeclContext.dataType().GetText();
                string variable_name = varDeclContext.ID().GetText();
                
                Node expr = null;
                if(varDeclContext.inititalization() != null){
                    expr = GenerateAST(varDeclContext.inititalization().expression());
                }
                return new VarDeclStatement(new Identifier(datatype), new Identifier(variable_name), expr);
            }else if(root is aracParser.UnaryBLExprContext){
                UnaryBLExprContext unaryBLExprContext = (UnaryBLExprContext) root;
                string operation = unaryBLExprContext.unaryBL_op().GetText();
                Node operand = GenerateAST(unaryBLExprContext.expression());
                return new UnaryBLExpression(operand, operation);
            }
            else if(root is aracParser.EqualityExprContext){
                EqualityExprContext equalityExprContext = (EqualityExprContext) root;

                string operation = equalityExprContext.equality_op().GetText();
                
                Node first_operand = GenerateAST(equalityExprContext.expression(0));
                Node second_operand = GenerateAST(equalityExprContext.expression(1));

                return new EqualityExpression(first_operand, operation ,second_operand);
            }
            else if(root is aracParser.BandExprContext){
                BandExprContext bandExprContext = (BandExprContext) root;
                Node first_operand = GenerateAST(bandExprContext.expression(0));
                Node second_operand = GenerateAST(bandExprContext.expression(1));

                return new BAndExpression(first_operand, second_operand);
            }
            else if(root is aracParser.BorExprContext){
                BorExprContext borExprContext = (BorExprContext) root;

                Node first_operand = GenerateAST(borExprContext.expression(0));
                Node second_operand = GenerateAST(borExprContext.expression(1));

                return new BOrExpression(first_operand, second_operand);
            }
            else if(root is aracParser.BxorExprContext){
                BxorExprContext bxorExprContext = (BxorExprContext) root;
                Node first_operand = GenerateAST(bxorExprContext.expression(0));
                Node second_operand = GenerateAST(bxorExprContext.expression(1));

                return new BAndExpression(first_operand, second_operand);
            }
            else if(root is aracParser.LandExprContext){
                LandExprContext landExprContext = (LandExprContext) root;

                Node first_operand = GenerateAST(landExprContext.expression(0));
                Node second_operand = GenerateAST(landExprContext.expression(1));
                
                return new LandExpression(first_operand, second_operand);
            }
            else if(root is aracParser.LorExprContext){
                LorExprContext lorExprContext = (LorExprContext) root;

                Node first_operand = GenerateAST(lorExprContext.expression(0));
                Node second_operand = GenerateAST(lorExprContext.expression(1));
                
                return new LorExpression(first_operand, second_operand);
            }else if( root is aracParser.ArrSubScripExprContext){
                ArrSubScripExprContext arrSubScripExprContext = (ArrSubScripExprContext) root;
                Node arr_exp = GenerateAST(arrSubScripExprContext.expression(0));
                Node index_exp = GenerateAST(arrSubScripExprContext.expression(1));

                return new ArraySubscriptionExpression(arr_exp, index_exp);
            }
            else if(root is aracParser.AddressExprContext){
                AddressExprContext addressExprContext = (AddressExprContext) root;
                Node operand = GenerateAST(addressExprContext.expression());
                return new AddressExpression(operand);
            }
            else if (root is aracParser.IndirectionExprContext){
                IndirectionExprContext indirectionExprContext = (IndirectionExprContext) root;
                Node operand = GenerateAST(indirectionExprContext.expression());
                return new IndirectionExpression(operand);
            }
            else if(root is aracParser.SizeExprContext){
                SizeExprContext sizeExprContext = (SizeExprContext) root;
                Node operand = GenerateAST(sizeExprContext.expression());
                return new SizeExpression(operand);
            }else if(root is aracParser.ShiftLeftExprContext) {
                ShiftLeftExprContext shiftLeftExprContext = (ShiftLeftExprContext) root;
                Node first_operand = GenerateAST(shiftLeftExprContext.expression(0));
                Node second_operand = GenerateAST(shiftLeftExprContext.expression(1));
                return new ShiftLeftExpression(first_operand, second_operand);
            }else if(root is aracParser.ShiftRightExprContext) {
                ShiftRightExprContext shiftRightExprContext = (ShiftRightExprContext) root;
                Node first_operand = GenerateAST(shiftRightExprContext.expression(0));
                Node second_operand = GenerateAST(shiftRightExprContext.expression(1));
                return new ShiftRightExpression(first_operand, second_operand);
            }
            // else if(root is aracParser.DataTypeContext){
            //     return null;
            // }
            else {
                throw new Exception("Unknown Parse Tree Type: " + root.GetType().Name );
            }
        }
    }
}