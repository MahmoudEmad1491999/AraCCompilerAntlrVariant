//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/mahmoud/projects/AraCCompilerAntlrVariant/AntlrExamples/arac.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AntlrExamples.Parser {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="aracParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface IaracVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] aracParser.ProgramContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.globalVarDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGlobalVarDecl([NotNull] aracParser.GlobalVarDeclContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.inititalization"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInititalization([NotNull] aracParser.InititalizationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.functionDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDecl([NotNull] aracParser.FunctionDeclContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.operationDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperationDecl([NotNull] aracParser.OperationDeclContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameter([NotNull] aracParser.ParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.paramList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParamList([NotNull] aracParser.ParamListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgument([NotNull] aracParser.ArgumentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.argumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgumentList([NotNull] aracParser.ArgumentListContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>lor_expr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLor_expr([NotNull] aracParser.Lor_exprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>add_expr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdd_expr([NotNull] aracParser.Add_exprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>land_expr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLand_expr([NotNull] aracParser.Land_exprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>comparison_expr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComparison_expr([NotNull] aracParser.Comparison_exprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>multiply_expr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiply_expr([NotNull] aracParser.Multiply_exprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>variable_expr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariable_expr([NotNull] aracParser.Variable_exprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>parenthesis_expr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesis_expr([NotNull] aracParser.Parenthesis_exprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>int_literal_expr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInt_literal_expr([NotNull] aracParser.Int_literal_exprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>subtraction_expr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSubtraction_expr([NotNull] aracParser.Subtraction_exprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>divide_expr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDivide_expr([NotNull] aracParser.Divide_exprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fun_call_expr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFun_call_expr([NotNull] aracParser.Fun_call_exprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>minus_expr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMinus_expr([NotNull] aracParser.Minus_exprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>lnot_expr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLnot_expr([NotNull] aracParser.Lnot_exprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>equality_expr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEquality_expr([NotNull] aracParser.Equality_exprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.int_literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInt_literal([NotNull] aracParser.Int_literalContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.comparison_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComparison_op([NotNull] aracParser.Comparison_opContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.equality_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEquality_op([NotNull] aracParser.Equality_opContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>assignment_Stat</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignment_Stat([NotNull] aracParser.Assignment_StatContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>return_Stat</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturn_Stat([NotNull] aracParser.Return_StatContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>result_Stat</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitResult_Stat([NotNull] aracParser.Result_StatContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>if_Stat</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIf_Stat([NotNull] aracParser.If_StatContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>while_Stat</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhile_Stat([NotNull] aracParser.While_StatContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>var_Decl</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVar_Decl([NotNull] aracParser.Var_DeclContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>operation_Stat</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperation_Stat([NotNull] aracParser.Operation_StatContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.statementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatementList([NotNull] aracParser.StatementListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.operationStat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperationStat([NotNull] aracParser.OperationStatContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.assignmentStat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignmentStat([NotNull] aracParser.AssignmentStatContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.ifStat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStat([NotNull] aracParser.IfStatContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.whileStat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileStat([NotNull] aracParser.WhileStatContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.returnStat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnStat([NotNull] aracParser.ReturnStatContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.resultStat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitResultStat([NotNull] aracParser.ResultStatContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.varDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarDecl([NotNull] aracParser.VarDeclContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="aracParser.dataType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDataType([NotNull] aracParser.DataTypeContext context);
}
} // namespace AntlrExamples.Parser
