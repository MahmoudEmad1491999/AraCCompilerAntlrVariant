//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/mahmoud/projects/AraCCompilerAntlrVariant/AntlrExamples/AraC.g4 by ANTLR 4.8

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
/// This class provides an empty implementation of <see cref="IAraCListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class AraCBaseListener : IAraCListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="AraCParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] AraCParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AraCParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] AraCParser.ProgramContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AraCParser.global_var_declaratoin"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGlobal_var_declaratoin([NotNull] AraCParser.Global_var_declaratoinContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AraCParser.global_var_declaratoin"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGlobal_var_declaratoin([NotNull] AraCParser.Global_var_declaratoinContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AraCParser.function_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_declaration([NotNull] AraCParser.Function_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AraCParser.function_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_declaration([NotNull] AraCParser.Function_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AraCParser.operatoin_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOperatoin_declaration([NotNull] AraCParser.Operatoin_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AraCParser.operatoin_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOperatoin_declaration([NotNull] AraCParser.Operatoin_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AraCParser.param_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParam_list([NotNull] AraCParser.Param_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AraCParser.param_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParam_list([NotNull] AraCParser.Param_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>casting_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCasting_expr([NotNull] AraCParser.Casting_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>casting_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCasting_expr([NotNull] AraCParser.Casting_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>lor_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLor_expr([NotNull] AraCParser.Lor_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>lor_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLor_expr([NotNull] AraCParser.Lor_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>array_subscription_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArray_subscription_expr([NotNull] AraCParser.Array_subscription_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>array_subscription_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArray_subscription_expr([NotNull] AraCParser.Array_subscription_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>add_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdd_expr([NotNull] AraCParser.Add_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>add_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdd_expr([NotNull] AraCParser.Add_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>land_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLand_expr([NotNull] AraCParser.Land_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>land_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLand_expr([NotNull] AraCParser.Land_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>comparative_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparative_expr([NotNull] AraCParser.Comparative_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>comparative_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparative_expr([NotNull] AraCParser.Comparative_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>unary_bl_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnary_bl_expr([NotNull] AraCParser.Unary_bl_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>unary_bl_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnary_bl_expr([NotNull] AraCParser.Unary_bl_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>size_of_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSize_of_expr([NotNull] AraCParser.Size_of_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>size_of_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSize_of_expr([NotNull] AraCParser.Size_of_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>funciton_calling_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunciton_calling_expr([NotNull] AraCParser.Funciton_calling_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>funciton_calling_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunciton_calling_expr([NotNull] AraCParser.Funciton_calling_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>shift_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShift_expr([NotNull] AraCParser.Shift_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>shift_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShift_expr([NotNull] AraCParser.Shift_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>address_of_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddress_of_expr([NotNull] AraCParser.Address_of_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>address_of_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddress_of_expr([NotNull] AraCParser.Address_of_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>indirection_of_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndirection_of_expr([NotNull] AraCParser.Indirection_of_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>indirection_of_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndirection_of_expr([NotNull] AraCParser.Indirection_of_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>subtract_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubtract_expr([NotNull] AraCParser.Subtract_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>subtract_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubtract_expr([NotNull] AraCParser.Subtract_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>multipy_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultipy_expr([NotNull] AraCParser.Multipy_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>multipy_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultipy_expr([NotNull] AraCParser.Multipy_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>divide_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDivide_expr([NotNull] AraCParser.Divide_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>divide_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDivide_expr([NotNull] AraCParser.Divide_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>bor_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBor_expr([NotNull] AraCParser.Bor_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>bor_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBor_expr([NotNull] AraCParser.Bor_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>literal_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteral_expr([NotNull] AraCParser.Literal_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>literal_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteral_expr([NotNull] AraCParser.Literal_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>identifier_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifier_expr([NotNull] AraCParser.Identifier_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>identifier_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifier_expr([NotNull] AraCParser.Identifier_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>parenth_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenth_expr([NotNull] AraCParser.Parenth_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>parenth_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenth_expr([NotNull] AraCParser.Parenth_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>equality_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEquality_expr([NotNull] AraCParser.Equality_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>equality_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEquality_expr([NotNull] AraCParser.Equality_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>bxor_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBxor_expr([NotNull] AraCParser.Bxor_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>bxor_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBxor_expr([NotNull] AraCParser.Bxor_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>band_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBand_expr([NotNull] AraCParser.Band_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>band_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBand_expr([NotNull] AraCParser.Band_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>unary_arithmetic_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnary_arithmetic_expr([NotNull] AraCParser.Unary_arithmetic_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>unary_arithmetic_expr</c>
	/// labeled alternative in <see cref="AraCParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnary_arithmetic_expr([NotNull] AraCParser.Unary_arithmetic_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AraCParser.argument_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArgument_list([NotNull] AraCParser.Argument_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AraCParser.argument_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArgument_list([NotNull] AraCParser.Argument_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>assignment_stat</c>
	/// labeled alternative in <see cref="AraCParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment_stat([NotNull] AraCParser.Assignment_statContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>assignment_stat</c>
	/// labeled alternative in <see cref="AraCParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment_stat([NotNull] AraCParser.Assignment_statContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>return_stat</c>
	/// labeled alternative in <see cref="AraCParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturn_stat([NotNull] AraCParser.Return_statContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>return_stat</c>
	/// labeled alternative in <see cref="AraCParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturn_stat([NotNull] AraCParser.Return_statContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>result_stat</c>
	/// labeled alternative in <see cref="AraCParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResult_stat([NotNull] AraCParser.Result_statContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>result_stat</c>
	/// labeled alternative in <see cref="AraCParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResult_stat([NotNull] AraCParser.Result_statContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>if_stat</c>
	/// labeled alternative in <see cref="AraCParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIf_stat([NotNull] AraCParser.If_statContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>if_stat</c>
	/// labeled alternative in <see cref="AraCParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIf_stat([NotNull] AraCParser.If_statContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>while_stat</c>
	/// labeled alternative in <see cref="AraCParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhile_stat([NotNull] AraCParser.While_statContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>while_stat</c>
	/// labeled alternative in <see cref="AraCParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhile_stat([NotNull] AraCParser.While_statContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>var_decl_stat</c>
	/// labeled alternative in <see cref="AraCParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVar_decl_stat([NotNull] AraCParser.Var_decl_statContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>var_decl_stat</c>
	/// labeled alternative in <see cref="AraCParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVar_decl_stat([NotNull] AraCParser.Var_decl_statContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>expre_stat</c>
	/// labeled alternative in <see cref="AraCParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpre_stat([NotNull] AraCParser.Expre_statContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>expre_stat</c>
	/// labeled alternative in <see cref="AraCParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpre_stat([NotNull] AraCParser.Expre_statContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AraCParser.assignment_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment_statement([NotNull] AraCParser.Assignment_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AraCParser.assignment_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment_statement([NotNull] AraCParser.Assignment_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AraCParser.if_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIf_statement([NotNull] AraCParser.If_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AraCParser.if_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIf_statement([NotNull] AraCParser.If_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AraCParser.while_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhile_statement([NotNull] AraCParser.While_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AraCParser.while_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhile_statement([NotNull] AraCParser.While_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AraCParser.return_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturn_statement([NotNull] AraCParser.Return_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AraCParser.return_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturn_statement([NotNull] AraCParser.Return_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AraCParser.result_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResult_statement([NotNull] AraCParser.Result_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AraCParser.result_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResult_statement([NotNull] AraCParser.Result_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AraCParser.var_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVar_declaration([NotNull] AraCParser.Var_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AraCParser.var_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVar_declaration([NotNull] AraCParser.Var_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AraCParser.data_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterData_type([NotNull] AraCParser.Data_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AraCParser.data_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitData_type([NotNull] AraCParser.Data_typeContext context) { }

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
