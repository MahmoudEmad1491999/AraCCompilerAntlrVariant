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

namespace Parser {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IaracListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class aracBaseListener : IaracListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] aracParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] aracParser.ProgramContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.globalVarDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGlobalVarDecl([NotNull] aracParser.GlobalVarDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.globalVarDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGlobalVarDecl([NotNull] aracParser.GlobalVarDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.inititalization"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInititalization([NotNull] aracParser.InititalizationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.inititalization"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInititalization([NotNull] aracParser.InititalizationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.functionDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionDecl([NotNull] aracParser.FunctionDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.functionDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionDecl([NotNull] aracParser.FunctionDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.operationDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOperationDecl([NotNull] aracParser.OperationDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.operationDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOperationDecl([NotNull] aracParser.OperationDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameter([NotNull] aracParser.ParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameter([NotNull] aracParser.ParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.paramList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParamList([NotNull] aracParser.ParamListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.paramList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParamList([NotNull] aracParser.ParamListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.argument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArgument([NotNull] aracParser.ArgumentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.argument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArgument([NotNull] aracParser.ArgumentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.argumentList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArgumentList([NotNull] aracParser.ArgumentListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.argumentList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArgumentList([NotNull] aracParser.ArgumentListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>divideExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDivideExpr([NotNull] aracParser.DivideExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>divideExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDivideExpr([NotNull] aracParser.DivideExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>AddressExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddressExpr([NotNull] aracParser.AddressExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AddressExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddressExpr([NotNull] aracParser.AddressExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>negationExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNegationExpr([NotNull] aracParser.NegationExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>negationExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNegationExpr([NotNull] aracParser.NegationExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>shiftLeftExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShiftLeftExpr([NotNull] aracParser.ShiftLeftExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>shiftLeftExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShiftLeftExpr([NotNull] aracParser.ShiftLeftExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>BxorExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBxorExpr([NotNull] aracParser.BxorExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>BxorExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBxorExpr([NotNull] aracParser.BxorExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CompExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompExpr([NotNull] aracParser.CompExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CompExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompExpr([NotNull] aracParser.CompExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>multiplyExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultiplyExpr([NotNull] aracParser.MultiplyExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplyExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultiplyExpr([NotNull] aracParser.MultiplyExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>shiftRightExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShiftRightExpr([NotNull] aracParser.ShiftRightExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>shiftRightExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShiftRightExpr([NotNull] aracParser.ShiftRightExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>BandExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBandExpr([NotNull] aracParser.BandExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>BandExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBandExpr([NotNull] aracParser.BandExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LandExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLandExpr([NotNull] aracParser.LandExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LandExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLandExpr([NotNull] aracParser.LandExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>IndirectionExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndirectionExpr([NotNull] aracParser.IndirectionExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>IndirectionExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndirectionExpr([NotNull] aracParser.IndirectionExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>subtractionExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubtractionExpr([NotNull] aracParser.SubtractionExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>subtractionExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubtractionExpr([NotNull] aracParser.SubtractionExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ArrSubScripExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrSubScripExpr([NotNull] aracParser.ArrSubScripExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ArrSubScripExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrSubScripExpr([NotNull] aracParser.ArrSubScripExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LorExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLorExpr([NotNull] aracParser.LorExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LorExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLorExpr([NotNull] aracParser.LorExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>variableExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableExpr([NotNull] aracParser.VariableExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>variableExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableExpr([NotNull] aracParser.VariableExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>funCallExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunCallExpr([NotNull] aracParser.FunCallExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>funCallExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunCallExpr([NotNull] aracParser.FunCallExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>EqualityExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEqualityExpr([NotNull] aracParser.EqualityExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>EqualityExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEqualityExpr([NotNull] aracParser.EqualityExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>addExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddExpr([NotNull] aracParser.AddExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>addExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddExpr([NotNull] aracParser.AddExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>BorExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBorExpr([NotNull] aracParser.BorExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>BorExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBorExpr([NotNull] aracParser.BorExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>literalExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteralExpr([NotNull] aracParser.LiteralExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>literalExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteralExpr([NotNull] aracParser.LiteralExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SizeExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSizeExpr([NotNull] aracParser.SizeExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SizeExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSizeExpr([NotNull] aracParser.SizeExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>UnaryBLExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryBLExpr([NotNull] aracParser.UnaryBLExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>UnaryBLExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryBLExpr([NotNull] aracParser.UnaryBLExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CastingExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCastingExpr([NotNull] aracParser.CastingExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CastingExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCastingExpr([NotNull] aracParser.CastingExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesisExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesisExpr([NotNull] aracParser.ParenthesisExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesisExpr</c>
	/// labeled alternative in <see cref="aracParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesisExpr([NotNull] aracParser.ParenthesisExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.comparison_op"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparison_op([NotNull] aracParser.Comparison_opContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.comparison_op"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparison_op([NotNull] aracParser.Comparison_opContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.unaryBL_op"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryBL_op([NotNull] aracParser.UnaryBL_opContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.unaryBL_op"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryBL_op([NotNull] aracParser.UnaryBL_opContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.equality_op"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEquality_op([NotNull] aracParser.Equality_opContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.equality_op"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEquality_op([NotNull] aracParser.Equality_opContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>assignment_Stat</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment_Stat([NotNull] aracParser.Assignment_StatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>assignment_Stat</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment_Stat([NotNull] aracParser.Assignment_StatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>return_Stat</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturn_Stat([NotNull] aracParser.Return_StatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>return_Stat</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturn_Stat([NotNull] aracParser.Return_StatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>result_Stat</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResult_Stat([NotNull] aracParser.Result_StatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>result_Stat</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResult_Stat([NotNull] aracParser.Result_StatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>if_Stat</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIf_Stat([NotNull] aracParser.If_StatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>if_Stat</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIf_Stat([NotNull] aracParser.If_StatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>while_Stat</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhile_Stat([NotNull] aracParser.While_StatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>while_Stat</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhile_Stat([NotNull] aracParser.While_StatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>var_Decl</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVar_Decl([NotNull] aracParser.Var_DeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>var_Decl</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVar_Decl([NotNull] aracParser.Var_DeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>expression_Stat</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression_Stat([NotNull] aracParser.Expression_StatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>expression_Stat</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression_Stat([NotNull] aracParser.Expression_StatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>operation_Stat</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOperation_Stat([NotNull] aracParser.Operation_StatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>operation_Stat</c>
	/// labeled alternative in <see cref="aracParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOperation_Stat([NotNull] aracParser.Operation_StatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.statementList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementList([NotNull] aracParser.StatementListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.statementList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementList([NotNull] aracParser.StatementListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.expressionStat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionStat([NotNull] aracParser.ExpressionStatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.expressionStat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionStat([NotNull] aracParser.ExpressionStatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.operationStat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOperationStat([NotNull] aracParser.OperationStatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.operationStat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOperationStat([NotNull] aracParser.OperationStatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.assignmentStat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentStat([NotNull] aracParser.AssignmentStatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.assignmentStat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentStat([NotNull] aracParser.AssignmentStatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.ifStat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfStat([NotNull] aracParser.IfStatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.ifStat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfStat([NotNull] aracParser.IfStatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.whileStat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileStat([NotNull] aracParser.WhileStatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.whileStat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileStat([NotNull] aracParser.WhileStatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.returnStat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturnStat([NotNull] aracParser.ReturnStatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.returnStat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturnStat([NotNull] aracParser.ReturnStatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.resultStat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResultStat([NotNull] aracParser.ResultStatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.resultStat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResultStat([NotNull] aracParser.ResultStatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.varDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVarDecl([NotNull] aracParser.VarDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.varDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVarDecl([NotNull] aracParser.VarDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="aracParser.dataType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDataType([NotNull] aracParser.DataTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="aracParser.dataType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDataType([NotNull] aracParser.DataTypeContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Parser