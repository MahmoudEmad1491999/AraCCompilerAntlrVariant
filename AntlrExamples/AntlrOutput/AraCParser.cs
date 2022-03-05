//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/mahmoud/AraCAntlrVariant/AntlrExamples/AraC.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AntlrOutput {
using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class AraCParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		Literal=1, LEFT_BOW=2, RIGHT_BOW=3, LEFT_SQUARE=4, RIGHT_SQUARE=5, LEFT_CURLY=6, 
		RIGHT_CURLY=7, PLUS=8, MINUS=9, MULTIPLY=10, DIVIDE=11, ARABIC_MODULS=12, 
		MODULUS=13, SHIFT_LEFT=14, SHIFT_RIGHT_ARITHMETIC=15, SHIFT_RIGHT=16, 
		BITWISE_AND=17, BITWISE_OR=18, BITWISE_XOR=19, LESS_THAN_EQUAL=20, GREATER_THAN_EQUAL=21, 
		LEFT_ANGLE=22, RIGHT_ANGLE=23, EQUAL=24, NOT_EQUAL=25, ASSIGN=26, DOT=27, 
		FASLA=28, FASLA_MANQUOTA=29, FUNCTION=30, OPERATION=31, RETURN_KEYWORD=32, 
		RESULT_KEYWORD=33, IF_KEYWORD=34, WHILE_KEYWORD=35, BREAK_KEYWORD=36, 
		CONTINUE_KEYWORRD=37, INT_DATA_TYPE=38, UINT_DATA_TYPE=39, BYTE_KEYWORD=40, 
		UBYTE_KEYWORD=41, SHORT_KEYWORD=42, USHORT_KEYWORD=43, LONG_KEYWORD=44, 
		ULONG_KEYWORD=45, STRING_LITERAL=46, CHARACTER_LITERAL=47, WHITE_SPACE=48, 
		ARABIC_INT_LITERAL=49, ENGLISH_INT_LITERAL=50, IDENTIFIER=51;
	public const int
		RULE_programm = 0, RULE_expression = 1, RULE_program = 2;
	public static readonly string[] ruleNames = {
		"programm", "expression", "program"
	};

	private static readonly string[] _LiteralNames = {
		null, null, "'('", "')'", "'['", "']'", "'{'", "'}'", "'+'", "'-'", "'\u00D7'", 
		"'\u00F7'", "'\u066A'", "'%'", "'<<'", "'>>>'", "'>>'", "'&'", "'|'", 
		"'^'", "'<='", "'>='", "'<'", "'>'", "'=='", "'!='", "':='", "'.'", "'\u060C'", 
		"'\u061B'", "'\u062F\u0627\u0644\u0629'", "'\u0639\u0645\u0644\u064A\u0629'", 
		"'\u0631\u062C\u0648\u0639'", "'\u0627\u0644\u0646\u0627\u062A\u062C'", 
		null, "'\u0637\u0627\u0644\u0645\u0627'", "'\u0642\u0637\u0639'", null, 
		"'\u0635\u062D\u064A\u062D'", "'\u0637\u0628\u064A\u0639\u064A'", "'\u0635\u062D\u064A\u062D_\u0661'", 
		"'\u0637\u0628\u064A\u0639\u064A_\u0661'", "'\u0635\u062D\u064A\u062D_\u0662'", 
		"'\u0637\u0628\u064A\u0639\u064A_\u0662'", "'\u0635\u062D\u064A\u062D_\u0668'", 
		"'\u0637\u0628\u064A\u0639\u064A_\u0668'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "Literal", "LEFT_BOW", "RIGHT_BOW", "LEFT_SQUARE", "RIGHT_SQUARE", 
		"LEFT_CURLY", "RIGHT_CURLY", "PLUS", "MINUS", "MULTIPLY", "DIVIDE", "ARABIC_MODULS", 
		"MODULUS", "SHIFT_LEFT", "SHIFT_RIGHT_ARITHMETIC", "SHIFT_RIGHT", "BITWISE_AND", 
		"BITWISE_OR", "BITWISE_XOR", "LESS_THAN_EQUAL", "GREATER_THAN_EQUAL", 
		"LEFT_ANGLE", "RIGHT_ANGLE", "EQUAL", "NOT_EQUAL", "ASSIGN", "DOT", "FASLA", 
		"FASLA_MANQUOTA", "FUNCTION", "OPERATION", "RETURN_KEYWORD", "RESULT_KEYWORD", 
		"IF_KEYWORD", "WHILE_KEYWORD", "BREAK_KEYWORD", "CONTINUE_KEYWORRD", "INT_DATA_TYPE", 
		"UINT_DATA_TYPE", "BYTE_KEYWORD", "UBYTE_KEYWORD", "SHORT_KEYWORD", "USHORT_KEYWORD", 
		"LONG_KEYWORD", "ULONG_KEYWORD", "STRING_LITERAL", "CHARACTER_LITERAL", 
		"WHITE_SPACE", "ARABIC_INT_LITERAL", "ENGLISH_INT_LITERAL", "IDENTIFIER"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "AraC.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static AraCParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public AraCParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public AraCParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class ProgrammContext : ParserRuleContext {
		public ProgrammContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_programm; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAraCVisitor<TResult> typedVisitor = visitor as IAraCVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProgramm(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgrammContext programm() {
		ProgrammContext _localctx = new ProgrammContext(Context, State);
		EnterRule(_localctx, 0, RULE_programm);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		public ITerminalNode LEFT_BOW() { return GetToken(AraCParser.LEFT_BOW, 0); }
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode RIGHT_BOW() { return GetToken(AraCParser.RIGHT_BOW, 0); }
		public ITerminalNode Literal() { return GetToken(AraCParser.Literal, 0); }
		public ITerminalNode MULTIPLY() { return GetToken(AraCParser.MULTIPLY, 0); }
		public ITerminalNode DIVIDE() { return GetToken(AraCParser.DIVIDE, 0); }
		public ITerminalNode PLUS() { return GetToken(AraCParser.PLUS, 0); }
		public ITerminalNode MINUS() { return GetToken(AraCParser.MINUS, 0); }
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAraCVisitor<TResult> typedVisitor = visitor as IAraCVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpression(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		return expression(0);
	}

	private ExpressionContext expression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExpressionContext _localctx = new ExpressionContext(Context, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 2;
		EnterRecursionRule(_localctx, 2, RULE_expression, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 14;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case LEFT_BOW:
				{
				State = 9; Match(LEFT_BOW);
				State = 10; expression(0);
				State = 11; Match(RIGHT_BOW);
				}
				break;
			case Literal:
				{
				State = 13; Match(Literal);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 24;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 22;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
					case 1:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 16;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 17;
						_la = TokenStream.LA(1);
						if ( !(_la==MULTIPLY || _la==DIVIDE) ) {
						ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 18; expression(5);
						}
						break;
					case 2:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 19;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 20;
						_la = TokenStream.LA(1);
						if ( !(_la==PLUS || _la==MINUS) ) {
						ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 21; expression(4);
						}
						break;
					}
					} 
				}
				State = 26;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class ProgramContext : ParserRuleContext {
		public ITerminalNode Eof() { return GetToken(AraCParser.Eof, 0); }
		public ITerminalNode[] STRING_LITERAL() { return GetTokens(AraCParser.STRING_LITERAL); }
		public ITerminalNode STRING_LITERAL(int i) {
			return GetToken(AraCParser.STRING_LITERAL, i);
		}
		public ITerminalNode[] CHARACTER_LITERAL() { return GetTokens(AraCParser.CHARACTER_LITERAL); }
		public ITerminalNode CHARACTER_LITERAL(int i) {
			return GetToken(AraCParser.CHARACTER_LITERAL, i);
		}
		public ITerminalNode[] IDENTIFIER() { return GetTokens(AraCParser.IDENTIFIER); }
		public ITerminalNode IDENTIFIER(int i) {
			return GetToken(AraCParser.IDENTIFIER, i);
		}
		public ITerminalNode[] ARABIC_INT_LITERAL() { return GetTokens(AraCParser.ARABIC_INT_LITERAL); }
		public ITerminalNode ARABIC_INT_LITERAL(int i) {
			return GetToken(AraCParser.ARABIC_INT_LITERAL, i);
		}
		public ITerminalNode[] ENGLISH_INT_LITERAL() { return GetTokens(AraCParser.ENGLISH_INT_LITERAL); }
		public ITerminalNode ENGLISH_INT_LITERAL(int i) {
			return GetToken(AraCParser.ENGLISH_INT_LITERAL, i);
		}
		public ITerminalNode[] LEFT_BOW() { return GetTokens(AraCParser.LEFT_BOW); }
		public ITerminalNode LEFT_BOW(int i) {
			return GetToken(AraCParser.LEFT_BOW, i);
		}
		public ITerminalNode[] RIGHT_BOW() { return GetTokens(AraCParser.RIGHT_BOW); }
		public ITerminalNode RIGHT_BOW(int i) {
			return GetToken(AraCParser.RIGHT_BOW, i);
		}
		public ITerminalNode[] LEFT_SQUARE() { return GetTokens(AraCParser.LEFT_SQUARE); }
		public ITerminalNode LEFT_SQUARE(int i) {
			return GetToken(AraCParser.LEFT_SQUARE, i);
		}
		public ITerminalNode[] RIGHT_SQUARE() { return GetTokens(AraCParser.RIGHT_SQUARE); }
		public ITerminalNode RIGHT_SQUARE(int i) {
			return GetToken(AraCParser.RIGHT_SQUARE, i);
		}
		public ITerminalNode[] LEFT_CURLY() { return GetTokens(AraCParser.LEFT_CURLY); }
		public ITerminalNode LEFT_CURLY(int i) {
			return GetToken(AraCParser.LEFT_CURLY, i);
		}
		public ITerminalNode[] RIGHT_CURLY() { return GetTokens(AraCParser.RIGHT_CURLY); }
		public ITerminalNode RIGHT_CURLY(int i) {
			return GetToken(AraCParser.RIGHT_CURLY, i);
		}
		public ITerminalNode[] PLUS() { return GetTokens(AraCParser.PLUS); }
		public ITerminalNode PLUS(int i) {
			return GetToken(AraCParser.PLUS, i);
		}
		public ITerminalNode[] MINUS() { return GetTokens(AraCParser.MINUS); }
		public ITerminalNode MINUS(int i) {
			return GetToken(AraCParser.MINUS, i);
		}
		public ITerminalNode[] MULTIPLY() { return GetTokens(AraCParser.MULTIPLY); }
		public ITerminalNode MULTIPLY(int i) {
			return GetToken(AraCParser.MULTIPLY, i);
		}
		public ITerminalNode[] DIVIDE() { return GetTokens(AraCParser.DIVIDE); }
		public ITerminalNode DIVIDE(int i) {
			return GetToken(AraCParser.DIVIDE, i);
		}
		public ITerminalNode[] ARABIC_MODULS() { return GetTokens(AraCParser.ARABIC_MODULS); }
		public ITerminalNode ARABIC_MODULS(int i) {
			return GetToken(AraCParser.ARABIC_MODULS, i);
		}
		public ITerminalNode[] SHIFT_LEFT() { return GetTokens(AraCParser.SHIFT_LEFT); }
		public ITerminalNode SHIFT_LEFT(int i) {
			return GetToken(AraCParser.SHIFT_LEFT, i);
		}
		public ITerminalNode[] SHIFT_RIGHT_ARITHMETIC() { return GetTokens(AraCParser.SHIFT_RIGHT_ARITHMETIC); }
		public ITerminalNode SHIFT_RIGHT_ARITHMETIC(int i) {
			return GetToken(AraCParser.SHIFT_RIGHT_ARITHMETIC, i);
		}
		public ITerminalNode[] SHIFT_RIGHT() { return GetTokens(AraCParser.SHIFT_RIGHT); }
		public ITerminalNode SHIFT_RIGHT(int i) {
			return GetToken(AraCParser.SHIFT_RIGHT, i);
		}
		public ITerminalNode[] LESS_THAN_EQUAL() { return GetTokens(AraCParser.LESS_THAN_EQUAL); }
		public ITerminalNode LESS_THAN_EQUAL(int i) {
			return GetToken(AraCParser.LESS_THAN_EQUAL, i);
		}
		public ITerminalNode[] GREATER_THAN_EQUAL() { return GetTokens(AraCParser.GREATER_THAN_EQUAL); }
		public ITerminalNode GREATER_THAN_EQUAL(int i) {
			return GetToken(AraCParser.GREATER_THAN_EQUAL, i);
		}
		public ITerminalNode[] LEFT_ANGLE() { return GetTokens(AraCParser.LEFT_ANGLE); }
		public ITerminalNode LEFT_ANGLE(int i) {
			return GetToken(AraCParser.LEFT_ANGLE, i);
		}
		public ITerminalNode[] RIGHT_ANGLE() { return GetTokens(AraCParser.RIGHT_ANGLE); }
		public ITerminalNode RIGHT_ANGLE(int i) {
			return GetToken(AraCParser.RIGHT_ANGLE, i);
		}
		public ITerminalNode[] EQUAL() { return GetTokens(AraCParser.EQUAL); }
		public ITerminalNode EQUAL(int i) {
			return GetToken(AraCParser.EQUAL, i);
		}
		public ITerminalNode[] NOT_EQUAL() { return GetTokens(AraCParser.NOT_EQUAL); }
		public ITerminalNode NOT_EQUAL(int i) {
			return GetToken(AraCParser.NOT_EQUAL, i);
		}
		public ITerminalNode[] ASSIGN() { return GetTokens(AraCParser.ASSIGN); }
		public ITerminalNode ASSIGN(int i) {
			return GetToken(AraCParser.ASSIGN, i);
		}
		public ITerminalNode[] DOT() { return GetTokens(AraCParser.DOT); }
		public ITerminalNode DOT(int i) {
			return GetToken(AraCParser.DOT, i);
		}
		public ITerminalNode[] FASLA() { return GetTokens(AraCParser.FASLA); }
		public ITerminalNode FASLA(int i) {
			return GetToken(AraCParser.FASLA, i);
		}
		public ITerminalNode[] FASLA_MANQUOTA() { return GetTokens(AraCParser.FASLA_MANQUOTA); }
		public ITerminalNode FASLA_MANQUOTA(int i) {
			return GetToken(AraCParser.FASLA_MANQUOTA, i);
		}
		public ProgramContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_program; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAraCVisitor<TResult> typedVisitor = visitor as IAraCVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProgram(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgramContext program() {
		ProgramContext _localctx = new ProgramContext(Context, State);
		EnterRule(_localctx, 4, RULE_program);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 30;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << LEFT_BOW) | (1L << RIGHT_BOW) | (1L << LEFT_SQUARE) | (1L << RIGHT_SQUARE) | (1L << LEFT_CURLY) | (1L << RIGHT_CURLY) | (1L << PLUS) | (1L << MINUS) | (1L << MULTIPLY) | (1L << DIVIDE) | (1L << ARABIC_MODULS) | (1L << SHIFT_LEFT) | (1L << SHIFT_RIGHT_ARITHMETIC) | (1L << SHIFT_RIGHT) | (1L << LESS_THAN_EQUAL) | (1L << GREATER_THAN_EQUAL) | (1L << LEFT_ANGLE) | (1L << RIGHT_ANGLE) | (1L << EQUAL) | (1L << NOT_EQUAL) | (1L << ASSIGN) | (1L << DOT) | (1L << FASLA) | (1L << FASLA_MANQUOTA) | (1L << STRING_LITERAL) | (1L << CHARACTER_LITERAL) | (1L << ARABIC_INT_LITERAL) | (1L << ENGLISH_INT_LITERAL) | (1L << IDENTIFIER))) != 0)) {
				{
				{
				State = 27;
				_la = TokenStream.LA(1);
				if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << LEFT_BOW) | (1L << RIGHT_BOW) | (1L << LEFT_SQUARE) | (1L << RIGHT_SQUARE) | (1L << LEFT_CURLY) | (1L << RIGHT_CURLY) | (1L << PLUS) | (1L << MINUS) | (1L << MULTIPLY) | (1L << DIVIDE) | (1L << ARABIC_MODULS) | (1L << SHIFT_LEFT) | (1L << SHIFT_RIGHT_ARITHMETIC) | (1L << SHIFT_RIGHT) | (1L << LESS_THAN_EQUAL) | (1L << GREATER_THAN_EQUAL) | (1L << LEFT_ANGLE) | (1L << RIGHT_ANGLE) | (1L << EQUAL) | (1L << NOT_EQUAL) | (1L << ASSIGN) | (1L << DOT) | (1L << FASLA) | (1L << FASLA_MANQUOTA) | (1L << STRING_LITERAL) | (1L << CHARACTER_LITERAL) | (1L << ARABIC_INT_LITERAL) | (1L << ENGLISH_INT_LITERAL) | (1L << IDENTIFIER))) != 0)) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
				}
				State = 32;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 33; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 1: return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 4);
		case 1: return Precpred(Context, 3);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x35', '&', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x5', '\x3', '\x11', '\n', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\a', '\x3', '\x19', 
		'\n', '\x3', '\f', '\x3', '\xE', '\x3', '\x1C', '\v', '\x3', '\x3', '\x4', 
		'\a', '\x4', '\x1F', '\n', '\x4', '\f', '\x4', '\xE', '\x4', '\"', '\v', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x2', '\x3', '\x4', 
		'\x5', '\x2', '\x4', '\x6', '\x2', '\x5', '\x3', '\x2', '\f', '\r', '\x3', 
		'\x2', '\n', '\v', '\a', '\x2', '\x4', '\xE', '\x10', '\x12', '\x16', 
		'\x1F', '\x30', '\x31', '\x33', '\x35', '\x2', '&', '\x2', '\b', '\x3', 
		'\x2', '\x2', '\x2', '\x4', '\x10', '\x3', '\x2', '\x2', '\x2', '\x6', 
		' ', '\x3', '\x2', '\x2', '\x2', '\b', '\t', '\x3', '\x2', '\x2', '\x2', 
		'\t', '\x3', '\x3', '\x2', '\x2', '\x2', '\n', '\v', '\b', '\x3', '\x1', 
		'\x2', '\v', '\f', '\a', '\x4', '\x2', '\x2', '\f', '\r', '\x5', '\x4', 
		'\x3', '\x2', '\r', '\xE', '\a', '\x5', '\x2', '\x2', '\xE', '\x11', '\x3', 
		'\x2', '\x2', '\x2', '\xF', '\x11', '\a', '\x3', '\x2', '\x2', '\x10', 
		'\n', '\x3', '\x2', '\x2', '\x2', '\x10', '\xF', '\x3', '\x2', '\x2', 
		'\x2', '\x11', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x12', '\x13', '\f', 
		'\x6', '\x2', '\x2', '\x13', '\x14', '\t', '\x2', '\x2', '\x2', '\x14', 
		'\x19', '\x5', '\x4', '\x3', '\a', '\x15', '\x16', '\f', '\x5', '\x2', 
		'\x2', '\x16', '\x17', '\t', '\x3', '\x2', '\x2', '\x17', '\x19', '\x5', 
		'\x4', '\x3', '\x6', '\x18', '\x12', '\x3', '\x2', '\x2', '\x2', '\x18', 
		'\x15', '\x3', '\x2', '\x2', '\x2', '\x19', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', '\x1A', '\x18', '\x3', '\x2', '\x2', '\x2', '\x1A', '\x1B', '\x3', 
		'\x2', '\x2', '\x2', '\x1B', '\x5', '\x3', '\x2', '\x2', '\x2', '\x1C', 
		'\x1A', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1F', '\t', '\x4', '\x2', 
		'\x2', '\x1E', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x1F', '\"', '\x3', 
		'\x2', '\x2', '\x2', ' ', '\x1E', '\x3', '\x2', '\x2', '\x2', ' ', '!', 
		'\x3', '\x2', '\x2', '\x2', '!', '#', '\x3', '\x2', '\x2', '\x2', '\"', 
		' ', '\x3', '\x2', '\x2', '\x2', '#', '$', '\a', '\x2', '\x2', '\x3', 
		'$', '\a', '\x3', '\x2', '\x2', '\x2', '\x6', '\x10', '\x18', '\x1A', 
		' ',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace AntlrOutput
