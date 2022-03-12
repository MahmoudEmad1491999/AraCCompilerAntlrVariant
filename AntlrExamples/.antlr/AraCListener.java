// Generated from AraC.g4 by ANTLR 4.9.3
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link AraCParser}.
 */
public interface AraCListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link AraCParser#program}.
	 * @param ctx the parse tree
	 */
	void enterProgram(AraCParser.ProgramContext ctx);
	/**
	 * Exit a parse tree produced by {@link AraCParser#program}.
	 * @param ctx the parse tree
	 */
	void exitProgram(AraCParser.ProgramContext ctx);
	/**
	 * Enter a parse tree produced by {@link AraCParser#global_var_declaratoin}.
	 * @param ctx the parse tree
	 */
	void enterGlobal_var_declaratoin(AraCParser.Global_var_declaratoinContext ctx);
	/**
	 * Exit a parse tree produced by {@link AraCParser#global_var_declaratoin}.
	 * @param ctx the parse tree
	 */
	void exitGlobal_var_declaratoin(AraCParser.Global_var_declaratoinContext ctx);
	/**
	 * Enter a parse tree produced by {@link AraCParser#function_declaration}.
	 * @param ctx the parse tree
	 */
	void enterFunction_declaration(AraCParser.Function_declarationContext ctx);
	/**
	 * Exit a parse tree produced by {@link AraCParser#function_declaration}.
	 * @param ctx the parse tree
	 */
	void exitFunction_declaration(AraCParser.Function_declarationContext ctx);
	/**
	 * Enter a parse tree produced by {@link AraCParser#param_list}.
	 * @param ctx the parse tree
	 */
	void enterParam_list(AraCParser.Param_listContext ctx);
	/**
	 * Exit a parse tree produced by {@link AraCParser#param_list}.
	 * @param ctx the parse tree
	 */
	void exitParam_list(AraCParser.Param_listContext ctx);
	/**
	 * Enter a parse tree produced by {@link AraCParser#operatoin_declaration}.
	 * @param ctx the parse tree
	 */
	void enterOperatoin_declaration(AraCParser.Operatoin_declarationContext ctx);
	/**
	 * Exit a parse tree produced by {@link AraCParser#operatoin_declaration}.
	 * @param ctx the parse tree
	 */
	void exitOperatoin_declaration(AraCParser.Operatoin_declarationContext ctx);
	/**
	 * Enter a parse tree produced by {@link AraCParser#expression}.
	 * @param ctx the parse tree
	 */
	void enterExpression(AraCParser.ExpressionContext ctx);
	/**
	 * Exit a parse tree produced by {@link AraCParser#expression}.
	 * @param ctx the parse tree
	 */
	void exitExpression(AraCParser.ExpressionContext ctx);
	/**
	 * Enter a parse tree produced by {@link AraCParser#argument_list}.
	 * @param ctx the parse tree
	 */
	void enterArgument_list(AraCParser.Argument_listContext ctx);
	/**
	 * Exit a parse tree produced by {@link AraCParser#argument_list}.
	 * @param ctx the parse tree
	 */
	void exitArgument_list(AraCParser.Argument_listContext ctx);
	/**
	 * Enter a parse tree produced by {@link AraCParser#statement}.
	 * @param ctx the parse tree
	 */
	void enterStatement(AraCParser.StatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link AraCParser#statement}.
	 * @param ctx the parse tree
	 */
	void exitStatement(AraCParser.StatementContext ctx);
	/**
	 * Enter a parse tree produced by {@link AraCParser#assignment_statement}.
	 * @param ctx the parse tree
	 */
	void enterAssignment_statement(AraCParser.Assignment_statementContext ctx);
	/**
	 * Exit a parse tree produced by {@link AraCParser#assignment_statement}.
	 * @param ctx the parse tree
	 */
	void exitAssignment_statement(AraCParser.Assignment_statementContext ctx);
	/**
	 * Enter a parse tree produced by {@link AraCParser#left_hand_side}.
	 * @param ctx the parse tree
	 */
	void enterLeft_hand_side(AraCParser.Left_hand_sideContext ctx);
	/**
	 * Exit a parse tree produced by {@link AraCParser#left_hand_side}.
	 * @param ctx the parse tree
	 */
	void exitLeft_hand_side(AraCParser.Left_hand_sideContext ctx);
	/**
	 * Enter a parse tree produced by {@link AraCParser#if_statement}.
	 * @param ctx the parse tree
	 */
	void enterIf_statement(AraCParser.If_statementContext ctx);
	/**
	 * Exit a parse tree produced by {@link AraCParser#if_statement}.
	 * @param ctx the parse tree
	 */
	void exitIf_statement(AraCParser.If_statementContext ctx);
	/**
	 * Enter a parse tree produced by {@link AraCParser#while_statement}.
	 * @param ctx the parse tree
	 */
	void enterWhile_statement(AraCParser.While_statementContext ctx);
	/**
	 * Exit a parse tree produced by {@link AraCParser#while_statement}.
	 * @param ctx the parse tree
	 */
	void exitWhile_statement(AraCParser.While_statementContext ctx);
	/**
	 * Enter a parse tree produced by {@link AraCParser#return_statement}.
	 * @param ctx the parse tree
	 */
	void enterReturn_statement(AraCParser.Return_statementContext ctx);
	/**
	 * Exit a parse tree produced by {@link AraCParser#return_statement}.
	 * @param ctx the parse tree
	 */
	void exitReturn_statement(AraCParser.Return_statementContext ctx);
	/**
	 * Enter a parse tree produced by {@link AraCParser#result_statement}.
	 * @param ctx the parse tree
	 */
	void enterResult_statement(AraCParser.Result_statementContext ctx);
	/**
	 * Exit a parse tree produced by {@link AraCParser#result_statement}.
	 * @param ctx the parse tree
	 */
	void exitResult_statement(AraCParser.Result_statementContext ctx);
	/**
	 * Enter a parse tree produced by {@link AraCParser#var_declaration}.
	 * @param ctx the parse tree
	 */
	void enterVar_declaration(AraCParser.Var_declarationContext ctx);
	/**
	 * Exit a parse tree produced by {@link AraCParser#var_declaration}.
	 * @param ctx the parse tree
	 */
	void exitVar_declaration(AraCParser.Var_declarationContext ctx);
	/**
	 * Enter a parse tree produced by {@link AraCParser#colon}.
	 * @param ctx the parse tree
	 */
	void enterColon(AraCParser.ColonContext ctx);
	/**
	 * Exit a parse tree produced by {@link AraCParser#colon}.
	 * @param ctx the parse tree
	 */
	void exitColon(AraCParser.ColonContext ctx);
	/**
	 * Enter a parse tree produced by {@link AraCParser#data_type}.
	 * @param ctx the parse tree
	 */
	void enterData_type(AraCParser.Data_typeContext ctx);
	/**
	 * Exit a parse tree produced by {@link AraCParser#data_type}.
	 * @param ctx the parse tree
	 */
	void exitData_type(AraCParser.Data_typeContext ctx);
}