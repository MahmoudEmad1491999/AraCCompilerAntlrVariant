// Generated from AraC.g4 by ANTLR 4.9.3
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class AraCParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.9.3", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, Literal=2, LEFT_PARENTHESIS=3, RIGHT_PARENTHESIS=4, LEFT_SQUARE_BRACKET=5, 
		RIGHT_SQUARE_BRACKET=6, LEFT_CURLY_BRACKET=7, RIGHT_CURLY_BRACKET=8, ADDRESS_OF_OPERATOR=9, 
		VALUE_INSIDE_OPERATOR=10, SIZE_OF=11, DOT=12, FASLA=13, FASLA_MANQUOTA=14, 
		ARROW=15, PLUS=16, MINUS=17, MULTIPLY=18, DIVIDE=19, ARABIC_MODULS=20, 
		MODULUS=21, LOGICAL_AND=22, LOGICAL_OR=23, LOGICAL_NOT=24, SHIFT_LEFT=25, 
		SHIFT_RIGHT_ARITHMETIC=26, SHIFT_RIGHT=27, BITWISE_AND=28, BITWISE_OR=29, 
		BITWISE_XOR=30, BITWISE_NOT=31, LESS_THAN_EQUAL=32, GREATER_THAN_EQUAL=33, 
		LESS_THAN=34, GREATER_THAN=35, EQUAL=36, NOT_EQUAL=37, ASSIGN=38, FUNCTION=39, 
		OPERATION=40, RETURN_KEYWORD=41, RESULT_KEYWORD=42, IF_KEYWORD=43, WHILE_KEYWORD=44, 
		BREAK_KEYWORD=45, CONTINUE_KEYWORRD=46, INT_DATA_TYPE=47, UINT_DATA_TYPE=48, 
		BYTE_DATA_TYPE=49, UBYTE_DATA_TYPE=50, SHORT_DATA_TYPE=51, USHORT_DATA_TYPE=52, 
		LONG_DATA_TYPE=53, ULONG_DATA_TYPE=54, STRING_LITERAL=55, CHARACTER_LITERAL=56, 
		WHITE_SPACE=57, ARABIC_INT_LITERAL=58, ENGLISH_INT_LITERAL=59, IDENTIFIER=60;
	public static final int
		RULE_program = 0, RULE_global_var_declaratoin = 1, RULE_function_declaration = 2, 
		RULE_param_list = 3, RULE_operatoin_declaration = 4, RULE_expression = 5, 
		RULE_argument_list = 6, RULE_statement = 7, RULE_assignment_statement = 8, 
		RULE_left_hand_side = 9, RULE_if_statement = 10, RULE_while_statement = 11, 
		RULE_return_statement = 12, RULE_result_statement = 13, RULE_var_declaration = 14, 
		RULE_colon = 15, RULE_data_type = 16;
	private static String[] makeRuleNames() {
		return new String[] {
			"program", "global_var_declaratoin", "function_declaration", "param_list", 
			"operatoin_declaration", "expression", "argument_list", "statement", 
			"assignment_statement", "left_hand_side", "if_statement", "while_statement", 
			"return_statement", "result_statement", "var_declaration", "colon", "data_type"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "':'", null, "'('", "')'", "'['", "']'", "'{'", "'}'", "'\u0639\u0646\u0648\u0627\u0646:'", 
			"'\u0642\u064A\u0645\u0629:'", "'\u062D\u062C\u0645:'", "'.'", "'\u060C'", 
			"'\u061B'", "'->'", "'+'", "'-'", "'\u00D7'", "'\u00F7'", "'\u066A'", 
			"'%'", "'&&'", "'||'", "'!'", "'<<'", "'>>>'", "'>>'", "'&'", "'|'", 
			"'^'", "'~'", "'<='", "'>='", "'<'", "'>'", "'=='", "'!='", "':='", "'\u062F\u0627\u0644\u0629'", 
			"'\u0639\u0645\u0644\u064A\u0629'", "'\u0631\u062C\u0648\u0639'", "'\u0627\u0644\u0646\u0627\u062A\u062C'", 
			null, "'\u0637\u0627\u0644\u0645\u0627'", "'\u0642\u0637\u0639'", null, 
			"'\u0635\u062D\u064A\u062D'", "'\u0637\u0628\u064A\u0639\u064A'", "'\u0635\u062D\u064A\u062D_\u0661'", 
			"'\u0637\u0628\u064A\u0639\u064A_\u0661'", "'\u0635\u062D\u064A\u062D_\u0662'", 
			"'\u0637\u0628\u064A\u0639\u064A_\u0662'", "'\u0635\u062D\u064A\u062D_\u0668'", 
			"'\u0637\u0628\u064A\u0639\u064A_\u0668'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, "Literal", "LEFT_PARENTHESIS", "RIGHT_PARENTHESIS", "LEFT_SQUARE_BRACKET", 
			"RIGHT_SQUARE_BRACKET", "LEFT_CURLY_BRACKET", "RIGHT_CURLY_BRACKET", 
			"ADDRESS_OF_OPERATOR", "VALUE_INSIDE_OPERATOR", "SIZE_OF", "DOT", "FASLA", 
			"FASLA_MANQUOTA", "ARROW", "PLUS", "MINUS", "MULTIPLY", "DIVIDE", "ARABIC_MODULS", 
			"MODULUS", "LOGICAL_AND", "LOGICAL_OR", "LOGICAL_NOT", "SHIFT_LEFT", 
			"SHIFT_RIGHT_ARITHMETIC", "SHIFT_RIGHT", "BITWISE_AND", "BITWISE_OR", 
			"BITWISE_XOR", "BITWISE_NOT", "LESS_THAN_EQUAL", "GREATER_THAN_EQUAL", 
			"LESS_THAN", "GREATER_THAN", "EQUAL", "NOT_EQUAL", "ASSIGN", "FUNCTION", 
			"OPERATION", "RETURN_KEYWORD", "RESULT_KEYWORD", "IF_KEYWORD", "WHILE_KEYWORD", 
			"BREAK_KEYWORD", "CONTINUE_KEYWORRD", "INT_DATA_TYPE", "UINT_DATA_TYPE", 
			"BYTE_DATA_TYPE", "UBYTE_DATA_TYPE", "SHORT_DATA_TYPE", "USHORT_DATA_TYPE", 
			"LONG_DATA_TYPE", "ULONG_DATA_TYPE", "STRING_LITERAL", "CHARACTER_LITERAL", 
			"WHITE_SPACE", "ARABIC_INT_LITERAL", "ENGLISH_INT_LITERAL", "IDENTIFIER"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "AraC.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public AraCParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	public static class ProgramContext extends ParserRuleContext {
		public List<Global_var_declaratoinContext> global_var_declaratoin() {
			return getRuleContexts(Global_var_declaratoinContext.class);
		}
		public Global_var_declaratoinContext global_var_declaratoin(int i) {
			return getRuleContext(Global_var_declaratoinContext.class,i);
		}
		public List<Function_declarationContext> function_declaration() {
			return getRuleContexts(Function_declarationContext.class);
		}
		public Function_declarationContext function_declaration(int i) {
			return getRuleContext(Function_declarationContext.class,i);
		}
		public List<Operatoin_declarationContext> operatoin_declaration() {
			return getRuleContexts(Operatoin_declarationContext.class);
		}
		public Operatoin_declarationContext operatoin_declaration(int i) {
			return getRuleContext(Operatoin_declarationContext.class,i);
		}
		public ProgramContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_program; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).enterProgram(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).exitProgram(this);
		}
	}

	public final ProgramContext program() throws RecognitionException {
		ProgramContext _localctx = new ProgramContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_program);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(39);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << FUNCTION) | (1L << OPERATION) | (1L << INT_DATA_TYPE) | (1L << UINT_DATA_TYPE) | (1L << BYTE_DATA_TYPE) | (1L << UBYTE_DATA_TYPE) | (1L << SHORT_DATA_TYPE) | (1L << USHORT_DATA_TYPE) | (1L << LONG_DATA_TYPE) | (1L << ULONG_DATA_TYPE))) != 0)) {
				{
				setState(37);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case INT_DATA_TYPE:
				case UINT_DATA_TYPE:
				case BYTE_DATA_TYPE:
				case UBYTE_DATA_TYPE:
				case SHORT_DATA_TYPE:
				case USHORT_DATA_TYPE:
				case LONG_DATA_TYPE:
				case ULONG_DATA_TYPE:
					{
					setState(34);
					global_var_declaratoin();
					}
					break;
				case FUNCTION:
					{
					setState(35);
					function_declaration();
					}
					break;
				case OPERATION:
					{
					setState(36);
					operatoin_declaration();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				setState(41);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Global_var_declaratoinContext extends ParserRuleContext {
		public Data_typeContext data_type() {
			return getRuleContext(Data_typeContext.class,0);
		}
		public TerminalNode IDENTIFIER() { return getToken(AraCParser.IDENTIFIER, 0); }
		public TerminalNode FASLA_MANQUOTA() { return getToken(AraCParser.FASLA_MANQUOTA, 0); }
		public TerminalNode ASSIGN() { return getToken(AraCParser.ASSIGN, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public Global_var_declaratoinContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_global_var_declaratoin; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).enterGlobal_var_declaratoin(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).exitGlobal_var_declaratoin(this);
		}
	}

	public final Global_var_declaratoinContext global_var_declaratoin() throws RecognitionException {
		Global_var_declaratoinContext _localctx = new Global_var_declaratoinContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_global_var_declaratoin);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(42);
			data_type();
			setState(43);
			match(IDENTIFIER);
			setState(46);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==ASSIGN) {
				{
				setState(44);
				match(ASSIGN);
				setState(45);
				expression(0);
				}
			}

			setState(48);
			match(FASLA_MANQUOTA);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Function_declarationContext extends ParserRuleContext {
		public TerminalNode FUNCTION() { return getToken(AraCParser.FUNCTION, 0); }
		public TerminalNode IDENTIFIER() { return getToken(AraCParser.IDENTIFIER, 0); }
		public TerminalNode RIGHT_PARENTHESIS() { return getToken(AraCParser.RIGHT_PARENTHESIS, 0); }
		public Param_listContext param_list() {
			return getRuleContext(Param_listContext.class,0);
		}
		public TerminalNode LEFT_PARENTHESIS() { return getToken(AraCParser.LEFT_PARENTHESIS, 0); }
		public Data_typeContext data_type() {
			return getRuleContext(Data_typeContext.class,0);
		}
		public TerminalNode RIGHT_CURLY_BRACKET() { return getToken(AraCParser.RIGHT_CURLY_BRACKET, 0); }
		public TerminalNode LEFT_CURLY_BRACKET() { return getToken(AraCParser.LEFT_CURLY_BRACKET, 0); }
		public List<StatementContext> statement() {
			return getRuleContexts(StatementContext.class);
		}
		public StatementContext statement(int i) {
			return getRuleContext(StatementContext.class,i);
		}
		public Function_declarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_function_declaration; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).enterFunction_declaration(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).exitFunction_declaration(this);
		}
	}

	public final Function_declarationContext function_declaration() throws RecognitionException {
		Function_declarationContext _localctx = new Function_declarationContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_function_declaration);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(50);
			match(FUNCTION);
			setState(51);
			match(IDENTIFIER);
			setState(52);
			match(RIGHT_PARENTHESIS);
			setState(53);
			param_list();
			setState(54);
			match(LEFT_PARENTHESIS);
			setState(55);
			data_type();
			setState(56);
			match(RIGHT_CURLY_BRACKET);
			setState(60);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Literal) | (1L << RIGHT_PARENTHESIS) | (1L << ADDRESS_OF_OPERATOR) | (1L << VALUE_INSIDE_OPERATOR) | (1L << SIZE_OF) | (1L << PLUS) | (1L << MINUS) | (1L << LOGICAL_NOT) | (1L << BITWISE_NOT) | (1L << RETURN_KEYWORD) | (1L << RESULT_KEYWORD) | (1L << IF_KEYWORD) | (1L << WHILE_KEYWORD) | (1L << INT_DATA_TYPE) | (1L << UINT_DATA_TYPE) | (1L << BYTE_DATA_TYPE) | (1L << UBYTE_DATA_TYPE) | (1L << SHORT_DATA_TYPE) | (1L << USHORT_DATA_TYPE) | (1L << LONG_DATA_TYPE) | (1L << ULONG_DATA_TYPE) | (1L << IDENTIFIER))) != 0)) {
				{
				{
				setState(57);
				statement();
				}
				}
				setState(62);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(63);
			match(LEFT_CURLY_BRACKET);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Param_listContext extends ParserRuleContext {
		public List<Data_typeContext> data_type() {
			return getRuleContexts(Data_typeContext.class);
		}
		public Data_typeContext data_type(int i) {
			return getRuleContext(Data_typeContext.class,i);
		}
		public List<TerminalNode> IDENTIFIER() { return getTokens(AraCParser.IDENTIFIER); }
		public TerminalNode IDENTIFIER(int i) {
			return getToken(AraCParser.IDENTIFIER, i);
		}
		public List<TerminalNode> FASLA() { return getTokens(AraCParser.FASLA); }
		public TerminalNode FASLA(int i) {
			return getToken(AraCParser.FASLA, i);
		}
		public Param_listContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_param_list; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).enterParam_list(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).exitParam_list(this);
		}
	}

	public final Param_listContext param_list() throws RecognitionException {
		Param_listContext _localctx = new Param_listContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_param_list);
		int _la;
		try {
			setState(77);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case INT_DATA_TYPE:
			case UINT_DATA_TYPE:
			case BYTE_DATA_TYPE:
			case UBYTE_DATA_TYPE:
			case SHORT_DATA_TYPE:
			case USHORT_DATA_TYPE:
			case LONG_DATA_TYPE:
			case ULONG_DATA_TYPE:
				enterOuterAlt(_localctx, 1);
				{
				{
				setState(65);
				data_type();
				setState(66);
				match(IDENTIFIER);
				setState(73);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==FASLA) {
					{
					{
					setState(67);
					match(FASLA);
					setState(68);
					data_type();
					setState(69);
					match(IDENTIFIER);
					}
					}
					setState(75);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				}
				}
				break;
			case LEFT_PARENTHESIS:
				enterOuterAlt(_localctx, 2);
				{
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Operatoin_declarationContext extends ParserRuleContext {
		public TerminalNode OPERATION() { return getToken(AraCParser.OPERATION, 0); }
		public TerminalNode IDENTIFIER() { return getToken(AraCParser.IDENTIFIER, 0); }
		public TerminalNode RIGHT_PARENTHESIS() { return getToken(AraCParser.RIGHT_PARENTHESIS, 0); }
		public TerminalNode LEFT_PARENTHESIS() { return getToken(AraCParser.LEFT_PARENTHESIS, 0); }
		public TerminalNode RIGHT_CURLY_BRACKET() { return getToken(AraCParser.RIGHT_CURLY_BRACKET, 0); }
		public TerminalNode LEFT_CURLY_BRACKET() { return getToken(AraCParser.LEFT_CURLY_BRACKET, 0); }
		public List<StatementContext> statement() {
			return getRuleContexts(StatementContext.class);
		}
		public StatementContext statement(int i) {
			return getRuleContext(StatementContext.class,i);
		}
		public Operatoin_declarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_operatoin_declaration; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).enterOperatoin_declaration(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).exitOperatoin_declaration(this);
		}
	}

	public final Operatoin_declarationContext operatoin_declaration() throws RecognitionException {
		Operatoin_declarationContext _localctx = new Operatoin_declarationContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_operatoin_declaration);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(79);
			match(OPERATION);
			setState(80);
			match(IDENTIFIER);
			setState(81);
			match(RIGHT_PARENTHESIS);
			setState(82);
			match(LEFT_PARENTHESIS);
			setState(83);
			match(RIGHT_CURLY_BRACKET);
			setState(87);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Literal) | (1L << RIGHT_PARENTHESIS) | (1L << ADDRESS_OF_OPERATOR) | (1L << VALUE_INSIDE_OPERATOR) | (1L << SIZE_OF) | (1L << PLUS) | (1L << MINUS) | (1L << LOGICAL_NOT) | (1L << BITWISE_NOT) | (1L << RETURN_KEYWORD) | (1L << RESULT_KEYWORD) | (1L << IF_KEYWORD) | (1L << WHILE_KEYWORD) | (1L << INT_DATA_TYPE) | (1L << UINT_DATA_TYPE) | (1L << BYTE_DATA_TYPE) | (1L << UBYTE_DATA_TYPE) | (1L << SHORT_DATA_TYPE) | (1L << USHORT_DATA_TYPE) | (1L << LONG_DATA_TYPE) | (1L << ULONG_DATA_TYPE) | (1L << IDENTIFIER))) != 0)) {
				{
				{
				setState(84);
				statement();
				}
				}
				setState(89);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(90);
			match(LEFT_CURLY_BRACKET);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ExpressionContext extends ParserRuleContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public TerminalNode PLUS() { return getToken(AraCParser.PLUS, 0); }
		public TerminalNode MINUS() { return getToken(AraCParser.MINUS, 0); }
		public TerminalNode LOGICAL_NOT() { return getToken(AraCParser.LOGICAL_NOT, 0); }
		public TerminalNode BITWISE_NOT() { return getToken(AraCParser.BITWISE_NOT, 0); }
		public TerminalNode RIGHT_PARENTHESIS() { return getToken(AraCParser.RIGHT_PARENTHESIS, 0); }
		public TerminalNode LEFT_PARENTHESIS() { return getToken(AraCParser.LEFT_PARENTHESIS, 0); }
		public TerminalNode IDENTIFIER() { return getToken(AraCParser.IDENTIFIER, 0); }
		public Data_typeContext data_type() {
			return getRuleContext(Data_typeContext.class,0);
		}
		public TerminalNode ADDRESS_OF_OPERATOR() { return getToken(AraCParser.ADDRESS_OF_OPERATOR, 0); }
		public TerminalNode VALUE_INSIDE_OPERATOR() { return getToken(AraCParser.VALUE_INSIDE_OPERATOR, 0); }
		public TerminalNode SIZE_OF() { return getToken(AraCParser.SIZE_OF, 0); }
		public TerminalNode Literal() { return getToken(AraCParser.Literal, 0); }
		public TerminalNode DOT() { return getToken(AraCParser.DOT, 0); }
		public TerminalNode ARROW() { return getToken(AraCParser.ARROW, 0); }
		public TerminalNode MULTIPLY() { return getToken(AraCParser.MULTIPLY, 0); }
		public TerminalNode DIVIDE() { return getToken(AraCParser.DIVIDE, 0); }
		public TerminalNode SHIFT_RIGHT() { return getToken(AraCParser.SHIFT_RIGHT, 0); }
		public TerminalNode SHIFT_LEFT() { return getToken(AraCParser.SHIFT_LEFT, 0); }
		public TerminalNode GREATER_THAN_EQUAL() { return getToken(AraCParser.GREATER_THAN_EQUAL, 0); }
		public TerminalNode LESS_THAN_EQUAL() { return getToken(AraCParser.LESS_THAN_EQUAL, 0); }
		public TerminalNode GREATER_THAN() { return getToken(AraCParser.GREATER_THAN, 0); }
		public TerminalNode LESS_THAN() { return getToken(AraCParser.LESS_THAN, 0); }
		public TerminalNode EQUAL() { return getToken(AraCParser.EQUAL, 0); }
		public TerminalNode NOT_EQUAL() { return getToken(AraCParser.NOT_EQUAL, 0); }
		public TerminalNode BITWISE_AND() { return getToken(AraCParser.BITWISE_AND, 0); }
		public TerminalNode BITWISE_XOR() { return getToken(AraCParser.BITWISE_XOR, 0); }
		public TerminalNode BITWISE_OR() { return getToken(AraCParser.BITWISE_OR, 0); }
		public TerminalNode LOGICAL_AND() { return getToken(AraCParser.LOGICAL_AND, 0); }
		public TerminalNode LOGICAL_OR() { return getToken(AraCParser.LOGICAL_OR, 0); }
		public Argument_listContext argument_list() {
			return getRuleContext(Argument_listContext.class,0);
		}
		public TerminalNode RIGHT_SQUARE_BRACKET() { return getToken(AraCParser.RIGHT_SQUARE_BRACKET, 0); }
		public TerminalNode LEFT_SQUARE_BRACKET() { return getToken(AraCParser.LEFT_SQUARE_BRACKET, 0); }
		public ExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_expression; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).enterExpression(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).exitExpression(this);
		}
	}

	public final ExpressionContext expression() throws RecognitionException {
		return expression(0);
	}

	private ExpressionContext expression(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		ExpressionContext _localctx = new ExpressionContext(_ctx, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 10;
		enterRecursionRule(_localctx, 10, RULE_expression, _p);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(125);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,8,_ctx) ) {
			case 1:
				{
				setState(93);
				_la = _input.LA(1);
				if ( !(_la==PLUS || _la==MINUS) ) {
				_errHandler.recoverInline(this);
				}
				else {
					if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
					_errHandler.reportMatch(this);
					consume();
				}
				setState(94);
				expression(19);
				}
				break;
			case 2:
				{
				setState(95);
				_la = _input.LA(1);
				if ( !(_la==LOGICAL_NOT || _la==BITWISE_NOT) ) {
				_errHandler.recoverInline(this);
				}
				else {
					if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
					_errHandler.reportMatch(this);
					consume();
				}
				setState(96);
				expression(18);
				}
				break;
			case 3:
				{
				setState(97);
				match(RIGHT_PARENTHESIS);
				setState(100);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case IDENTIFIER:
					{
					setState(98);
					match(IDENTIFIER);
					}
					break;
				case INT_DATA_TYPE:
				case UINT_DATA_TYPE:
				case BYTE_DATA_TYPE:
				case UBYTE_DATA_TYPE:
				case SHORT_DATA_TYPE:
				case USHORT_DATA_TYPE:
				case LONG_DATA_TYPE:
				case ULONG_DATA_TYPE:
					{
					setState(99);
					data_type();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(102);
				match(LEFT_PARENTHESIS);
				setState(103);
				expression(17);
				}
				break;
			case 4:
				{
				setState(104);
				match(ADDRESS_OF_OPERATOR);
				setState(105);
				match(RIGHT_PARENTHESIS);
				setState(106);
				expression(0);
				setState(107);
				match(LEFT_PARENTHESIS);
				}
				break;
			case 5:
				{
				setState(109);
				match(VALUE_INSIDE_OPERATOR);
				setState(110);
				match(RIGHT_PARENTHESIS);
				setState(111);
				expression(0);
				setState(112);
				match(LEFT_PARENTHESIS);
				}
				break;
			case 6:
				{
				setState(114);
				match(SIZE_OF);
				setState(115);
				match(RIGHT_PARENTHESIS);
				setState(116);
				expression(0);
				setState(117);
				match(LEFT_PARENTHESIS);
				}
				break;
			case 7:
				{
				setState(119);
				match(RIGHT_PARENTHESIS);
				setState(120);
				expression(0);
				setState(121);
				match(LEFT_PARENTHESIS);
				}
				break;
			case 8:
				{
				setState(123);
				match(Literal);
				}
				break;
			case 9:
				{
				setState(124);
				match(IDENTIFIER);
				}
				break;
			}
			_ctx.stop = _input.LT(-1);
			setState(172);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,10,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(170);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,9,_ctx) ) {
					case 1:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(127);
						if (!(precpred(_ctx, 20))) throw new FailedPredicateException(this, "precpred(_ctx, 20)");
						setState(128);
						_la = _input.LA(1);
						if ( !(_la==DOT || _la==ARROW) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(129);
						expression(21);
						}
						break;
					case 2:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(130);
						if (!(precpred(_ctx, 13))) throw new FailedPredicateException(this, "precpred(_ctx, 13)");
						setState(131);
						_la = _input.LA(1);
						if ( !(_la==MULTIPLY || _la==DIVIDE) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(132);
						expression(14);
						}
						break;
					case 3:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(133);
						if (!(precpred(_ctx, 12))) throw new FailedPredicateException(this, "precpred(_ctx, 12)");
						setState(134);
						_la = _input.LA(1);
						if ( !(_la==PLUS || _la==MINUS) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(135);
						expression(13);
						}
						break;
					case 4:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(136);
						if (!(precpred(_ctx, 11))) throw new FailedPredicateException(this, "precpred(_ctx, 11)");
						setState(137);
						_la = _input.LA(1);
						if ( !(_la==SHIFT_LEFT || _la==SHIFT_RIGHT) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(138);
						expression(12);
						}
						break;
					case 5:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(139);
						if (!(precpred(_ctx, 10))) throw new FailedPredicateException(this, "precpred(_ctx, 10)");
						setState(140);
						_la = _input.LA(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << LESS_THAN_EQUAL) | (1L << GREATER_THAN_EQUAL) | (1L << LESS_THAN) | (1L << GREATER_THAN))) != 0)) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(141);
						expression(11);
						}
						break;
					case 6:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(142);
						if (!(precpred(_ctx, 9))) throw new FailedPredicateException(this, "precpred(_ctx, 9)");
						setState(143);
						_la = _input.LA(1);
						if ( !(_la==EQUAL || _la==NOT_EQUAL) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(144);
						expression(10);
						}
						break;
					case 7:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(145);
						if (!(precpred(_ctx, 8))) throw new FailedPredicateException(this, "precpred(_ctx, 8)");
						{
						setState(146);
						match(BITWISE_AND);
						}
						setState(147);
						expression(9);
						}
						break;
					case 8:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(148);
						if (!(precpred(_ctx, 7))) throw new FailedPredicateException(this, "precpred(_ctx, 7)");
						{
						setState(149);
						match(BITWISE_XOR);
						}
						setState(150);
						expression(8);
						}
						break;
					case 9:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(151);
						if (!(precpred(_ctx, 6))) throw new FailedPredicateException(this, "precpred(_ctx, 6)");
						{
						setState(152);
						match(BITWISE_OR);
						}
						setState(153);
						expression(7);
						}
						break;
					case 10:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(154);
						if (!(precpred(_ctx, 5))) throw new FailedPredicateException(this, "precpred(_ctx, 5)");
						{
						setState(155);
						match(LOGICAL_AND);
						}
						setState(156);
						expression(6);
						}
						break;
					case 11:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(157);
						if (!(precpred(_ctx, 4))) throw new FailedPredicateException(this, "precpred(_ctx, 4)");
						{
						setState(158);
						match(LOGICAL_OR);
						}
						setState(159);
						expression(5);
						}
						break;
					case 12:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(160);
						if (!(precpred(_ctx, 22))) throw new FailedPredicateException(this, "precpred(_ctx, 22)");
						setState(161);
						match(RIGHT_PARENTHESIS);
						setState(162);
						argument_list();
						setState(163);
						match(LEFT_PARENTHESIS);
						}
						break;
					case 13:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(165);
						if (!(precpred(_ctx, 21))) throw new FailedPredicateException(this, "precpred(_ctx, 21)");
						setState(166);
						match(RIGHT_SQUARE_BRACKET);
						setState(167);
						expression(0);
						setState(168);
						match(LEFT_SQUARE_BRACKET);
						}
						break;
					}
					} 
				}
				setState(174);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,10,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			unrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public static class Argument_listContext extends ParserRuleContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public List<TerminalNode> FASLA() { return getTokens(AraCParser.FASLA); }
		public TerminalNode FASLA(int i) {
			return getToken(AraCParser.FASLA, i);
		}
		public Argument_listContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_argument_list; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).enterArgument_list(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).exitArgument_list(this);
		}
	}

	public final Argument_listContext argument_list() throws RecognitionException {
		Argument_listContext _localctx = new Argument_listContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_argument_list);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(175);
			expression(0);
			setState(180);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==FASLA) {
				{
				{
				setState(176);
				match(FASLA);
				setState(177);
				expression(0);
				}
				}
				setState(182);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class StatementContext extends ParserRuleContext {
		public Assignment_statementContext assignment_statement() {
			return getRuleContext(Assignment_statementContext.class,0);
		}
		public Return_statementContext return_statement() {
			return getRuleContext(Return_statementContext.class,0);
		}
		public Result_statementContext result_statement() {
			return getRuleContext(Result_statementContext.class,0);
		}
		public If_statementContext if_statement() {
			return getRuleContext(If_statementContext.class,0);
		}
		public While_statementContext while_statement() {
			return getRuleContext(While_statementContext.class,0);
		}
		public Var_declarationContext var_declaration() {
			return getRuleContext(Var_declarationContext.class,0);
		}
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public TerminalNode FASLA_MANQUOTA() { return getToken(AraCParser.FASLA_MANQUOTA, 0); }
		public StatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_statement; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).enterStatement(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).exitStatement(this);
		}
	}

	public final StatementContext statement() throws RecognitionException {
		StatementContext _localctx = new StatementContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_statement);
		try {
			setState(192);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,12,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(183);
				assignment_statement();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(184);
				return_statement();
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(185);
				result_statement();
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(186);
				if_statement();
				}
				break;
			case 5:
				enterOuterAlt(_localctx, 5);
				{
				setState(187);
				while_statement();
				}
				break;
			case 6:
				enterOuterAlt(_localctx, 6);
				{
				setState(188);
				var_declaration();
				}
				break;
			case 7:
				enterOuterAlt(_localctx, 7);
				{
				setState(189);
				expression(0);
				setState(190);
				match(FASLA_MANQUOTA);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Assignment_statementContext extends ParserRuleContext {
		public Left_hand_sideContext left_hand_side() {
			return getRuleContext(Left_hand_sideContext.class,0);
		}
		public TerminalNode ASSIGN() { return getToken(AraCParser.ASSIGN, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public TerminalNode FASLA_MANQUOTA() { return getToken(AraCParser.FASLA_MANQUOTA, 0); }
		public Assignment_statementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_assignment_statement; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).enterAssignment_statement(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).exitAssignment_statement(this);
		}
	}

	public final Assignment_statementContext assignment_statement() throws RecognitionException {
		Assignment_statementContext _localctx = new Assignment_statementContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_assignment_statement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(194);
			left_hand_side();
			setState(195);
			match(ASSIGN);
			setState(196);
			expression(0);
			setState(197);
			match(FASLA_MANQUOTA);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Left_hand_sideContext extends ParserRuleContext {
		public TerminalNode IDENTIFIER() { return getToken(AraCParser.IDENTIFIER, 0); }
		public Left_hand_sideContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_left_hand_side; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).enterLeft_hand_side(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).exitLeft_hand_side(this);
		}
	}

	public final Left_hand_sideContext left_hand_side() throws RecognitionException {
		Left_hand_sideContext _localctx = new Left_hand_sideContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_left_hand_side);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(199);
			match(IDENTIFIER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class If_statementContext extends ParserRuleContext {
		public TerminalNode IF_KEYWORD() { return getToken(AraCParser.IF_KEYWORD, 0); }
		public TerminalNode RIGHT_PARENTHESIS() { return getToken(AraCParser.RIGHT_PARENTHESIS, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public TerminalNode LEFT_PARENTHESIS() { return getToken(AraCParser.LEFT_PARENTHESIS, 0); }
		public TerminalNode RIGHT_CURLY_BRACKET() { return getToken(AraCParser.RIGHT_CURLY_BRACKET, 0); }
		public TerminalNode LEFT_CURLY_BRACKET() { return getToken(AraCParser.LEFT_CURLY_BRACKET, 0); }
		public List<StatementContext> statement() {
			return getRuleContexts(StatementContext.class);
		}
		public StatementContext statement(int i) {
			return getRuleContext(StatementContext.class,i);
		}
		public If_statementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_if_statement; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).enterIf_statement(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).exitIf_statement(this);
		}
	}

	public final If_statementContext if_statement() throws RecognitionException {
		If_statementContext _localctx = new If_statementContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_if_statement);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(201);
			match(IF_KEYWORD);
			setState(202);
			match(RIGHT_PARENTHESIS);
			setState(203);
			expression(0);
			setState(204);
			match(LEFT_PARENTHESIS);
			setState(205);
			match(RIGHT_CURLY_BRACKET);
			setState(209);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Literal) | (1L << RIGHT_PARENTHESIS) | (1L << ADDRESS_OF_OPERATOR) | (1L << VALUE_INSIDE_OPERATOR) | (1L << SIZE_OF) | (1L << PLUS) | (1L << MINUS) | (1L << LOGICAL_NOT) | (1L << BITWISE_NOT) | (1L << RETURN_KEYWORD) | (1L << RESULT_KEYWORD) | (1L << IF_KEYWORD) | (1L << WHILE_KEYWORD) | (1L << INT_DATA_TYPE) | (1L << UINT_DATA_TYPE) | (1L << BYTE_DATA_TYPE) | (1L << UBYTE_DATA_TYPE) | (1L << SHORT_DATA_TYPE) | (1L << USHORT_DATA_TYPE) | (1L << LONG_DATA_TYPE) | (1L << ULONG_DATA_TYPE) | (1L << IDENTIFIER))) != 0)) {
				{
				{
				setState(206);
				statement();
				}
				}
				setState(211);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(212);
			match(LEFT_CURLY_BRACKET);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class While_statementContext extends ParserRuleContext {
		public TerminalNode WHILE_KEYWORD() { return getToken(AraCParser.WHILE_KEYWORD, 0); }
		public TerminalNode RIGHT_PARENTHESIS() { return getToken(AraCParser.RIGHT_PARENTHESIS, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public TerminalNode LEFT_PARENTHESIS() { return getToken(AraCParser.LEFT_PARENTHESIS, 0); }
		public TerminalNode RIGHT_CURLY_BRACKET() { return getToken(AraCParser.RIGHT_CURLY_BRACKET, 0); }
		public TerminalNode LEFT_CURLY_BRACKET() { return getToken(AraCParser.LEFT_CURLY_BRACKET, 0); }
		public List<StatementContext> statement() {
			return getRuleContexts(StatementContext.class);
		}
		public StatementContext statement(int i) {
			return getRuleContext(StatementContext.class,i);
		}
		public While_statementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_while_statement; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).enterWhile_statement(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).exitWhile_statement(this);
		}
	}

	public final While_statementContext while_statement() throws RecognitionException {
		While_statementContext _localctx = new While_statementContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_while_statement);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(214);
			match(WHILE_KEYWORD);
			setState(215);
			match(RIGHT_PARENTHESIS);
			setState(216);
			expression(0);
			setState(217);
			match(LEFT_PARENTHESIS);
			setState(218);
			match(RIGHT_CURLY_BRACKET);
			setState(222);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Literal) | (1L << RIGHT_PARENTHESIS) | (1L << ADDRESS_OF_OPERATOR) | (1L << VALUE_INSIDE_OPERATOR) | (1L << SIZE_OF) | (1L << PLUS) | (1L << MINUS) | (1L << LOGICAL_NOT) | (1L << BITWISE_NOT) | (1L << RETURN_KEYWORD) | (1L << RESULT_KEYWORD) | (1L << IF_KEYWORD) | (1L << WHILE_KEYWORD) | (1L << INT_DATA_TYPE) | (1L << UINT_DATA_TYPE) | (1L << BYTE_DATA_TYPE) | (1L << UBYTE_DATA_TYPE) | (1L << SHORT_DATA_TYPE) | (1L << USHORT_DATA_TYPE) | (1L << LONG_DATA_TYPE) | (1L << ULONG_DATA_TYPE) | (1L << IDENTIFIER))) != 0)) {
				{
				{
				setState(219);
				statement();
				}
				}
				setState(224);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(225);
			match(LEFT_CURLY_BRACKET);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Return_statementContext extends ParserRuleContext {
		public TerminalNode RETURN_KEYWORD() { return getToken(AraCParser.RETURN_KEYWORD, 0); }
		public TerminalNode FASLA_MANQUOTA() { return getToken(AraCParser.FASLA_MANQUOTA, 0); }
		public Return_statementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_return_statement; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).enterReturn_statement(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).exitReturn_statement(this);
		}
	}

	public final Return_statementContext return_statement() throws RecognitionException {
		Return_statementContext _localctx = new Return_statementContext(_ctx, getState());
		enterRule(_localctx, 24, RULE_return_statement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(227);
			match(RETURN_KEYWORD);
			setState(228);
			match(FASLA_MANQUOTA);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Result_statementContext extends ParserRuleContext {
		public TerminalNode RESULT_KEYWORD() { return getToken(AraCParser.RESULT_KEYWORD, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public TerminalNode FASLA_MANQUOTA() { return getToken(AraCParser.FASLA_MANQUOTA, 0); }
		public Result_statementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_result_statement; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).enterResult_statement(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).exitResult_statement(this);
		}
	}

	public final Result_statementContext result_statement() throws RecognitionException {
		Result_statementContext _localctx = new Result_statementContext(_ctx, getState());
		enterRule(_localctx, 26, RULE_result_statement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(230);
			match(RESULT_KEYWORD);
			setState(231);
			expression(0);
			setState(232);
			match(FASLA_MANQUOTA);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Var_declarationContext extends ParserRuleContext {
		public Data_typeContext data_type() {
			return getRuleContext(Data_typeContext.class,0);
		}
		public TerminalNode IDENTIFIER() { return getToken(AraCParser.IDENTIFIER, 0); }
		public TerminalNode FASLA_MANQUOTA() { return getToken(AraCParser.FASLA_MANQUOTA, 0); }
		public TerminalNode ASSIGN() { return getToken(AraCParser.ASSIGN, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public Var_declarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_var_declaration; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).enterVar_declaration(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).exitVar_declaration(this);
		}
	}

	public final Var_declarationContext var_declaration() throws RecognitionException {
		Var_declarationContext _localctx = new Var_declarationContext(_ctx, getState());
		enterRule(_localctx, 28, RULE_var_declaration);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(234);
			data_type();
			setState(235);
			match(IDENTIFIER);
			setState(238);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==ASSIGN) {
				{
				setState(236);
				match(ASSIGN);
				setState(237);
				expression(0);
				}
			}

			setState(240);
			match(FASLA_MANQUOTA);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ColonContext extends ParserRuleContext {
		public ColonContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_colon; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).enterColon(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).exitColon(this);
		}
	}

	public final ColonContext colon() throws RecognitionException {
		ColonContext _localctx = new ColonContext(_ctx, getState());
		enterRule(_localctx, 30, RULE_colon);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(242);
			match(T__0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Data_typeContext extends ParserRuleContext {
		public TerminalNode INT_DATA_TYPE() { return getToken(AraCParser.INT_DATA_TYPE, 0); }
		public TerminalNode UINT_DATA_TYPE() { return getToken(AraCParser.UINT_DATA_TYPE, 0); }
		public TerminalNode BYTE_DATA_TYPE() { return getToken(AraCParser.BYTE_DATA_TYPE, 0); }
		public TerminalNode UBYTE_DATA_TYPE() { return getToken(AraCParser.UBYTE_DATA_TYPE, 0); }
		public TerminalNode SHORT_DATA_TYPE() { return getToken(AraCParser.SHORT_DATA_TYPE, 0); }
		public TerminalNode USHORT_DATA_TYPE() { return getToken(AraCParser.USHORT_DATA_TYPE, 0); }
		public TerminalNode LONG_DATA_TYPE() { return getToken(AraCParser.LONG_DATA_TYPE, 0); }
		public TerminalNode ULONG_DATA_TYPE() { return getToken(AraCParser.ULONG_DATA_TYPE, 0); }
		public Data_typeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_data_type; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).enterData_type(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof AraCListener ) ((AraCListener)listener).exitData_type(this);
		}
	}

	public final Data_typeContext data_type() throws RecognitionException {
		Data_typeContext _localctx = new Data_typeContext(_ctx, getState());
		enterRule(_localctx, 32, RULE_data_type);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(244);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << INT_DATA_TYPE) | (1L << UINT_DATA_TYPE) | (1L << BYTE_DATA_TYPE) | (1L << UBYTE_DATA_TYPE) | (1L << SHORT_DATA_TYPE) | (1L << USHORT_DATA_TYPE) | (1L << LONG_DATA_TYPE) | (1L << ULONG_DATA_TYPE))) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public boolean sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 5:
			return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private boolean expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0:
			return precpred(_ctx, 20);
		case 1:
			return precpred(_ctx, 13);
		case 2:
			return precpred(_ctx, 12);
		case 3:
			return precpred(_ctx, 11);
		case 4:
			return precpred(_ctx, 10);
		case 5:
			return precpred(_ctx, 9);
		case 6:
			return precpred(_ctx, 8);
		case 7:
			return precpred(_ctx, 7);
		case 8:
			return precpred(_ctx, 6);
		case 9:
			return precpred(_ctx, 5);
		case 10:
			return precpred(_ctx, 4);
		case 11:
			return precpred(_ctx, 22);
		case 12:
			return precpred(_ctx, 21);
		}
		return true;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3>\u00f9\4\2\t\2\4"+
		"\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13\t"+
		"\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22"+
		"\3\2\3\2\3\2\7\2(\n\2\f\2\16\2+\13\2\3\3\3\3\3\3\3\3\5\3\61\n\3\3\3\3"+
		"\3\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\7\4=\n\4\f\4\16\4@\13\4\3\4\3\4\3\5"+
		"\3\5\3\5\3\5\3\5\3\5\7\5J\n\5\f\5\16\5M\13\5\3\5\5\5P\n\5\3\6\3\6\3\6"+
		"\3\6\3\6\3\6\7\6X\n\6\f\6\16\6[\13\6\3\6\3\6\3\7\3\7\3\7\3\7\3\7\3\7\3"+
		"\7\3\7\5\7g\n\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3"+
		"\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\5\7\u0080\n\7\3\7\3\7\3\7\3\7\3"+
		"\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7"+
		"\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3"+
		"\7\3\7\3\7\3\7\7\7\u00ad\n\7\f\7\16\7\u00b0\13\7\3\b\3\b\3\b\7\b\u00b5"+
		"\n\b\f\b\16\b\u00b8\13\b\3\t\3\t\3\t\3\t\3\t\3\t\3\t\3\t\3\t\5\t\u00c3"+
		"\n\t\3\n\3\n\3\n\3\n\3\n\3\13\3\13\3\f\3\f\3\f\3\f\3\f\3\f\7\f\u00d2\n"+
		"\f\f\f\16\f\u00d5\13\f\3\f\3\f\3\r\3\r\3\r\3\r\3\r\3\r\7\r\u00df\n\r\f"+
		"\r\16\r\u00e2\13\r\3\r\3\r\3\16\3\16\3\16\3\17\3\17\3\17\3\17\3\20\3\20"+
		"\3\20\3\20\5\20\u00f1\n\20\3\20\3\20\3\21\3\21\3\22\3\22\3\22\2\3\f\23"+
		"\2\4\6\b\n\f\16\20\22\24\26\30\32\34\36 \"\2\n\3\2\22\23\4\2\32\32!!\4"+
		"\2\16\16\21\21\3\2\24\25\4\2\33\33\35\35\3\2\"%\3\2&\'\3\2\618\2\u010f"+
		"\2)\3\2\2\2\4,\3\2\2\2\6\64\3\2\2\2\bO\3\2\2\2\nQ\3\2\2\2\f\177\3\2\2"+
		"\2\16\u00b1\3\2\2\2\20\u00c2\3\2\2\2\22\u00c4\3\2\2\2\24\u00c9\3\2\2\2"+
		"\26\u00cb\3\2\2\2\30\u00d8\3\2\2\2\32\u00e5\3\2\2\2\34\u00e8\3\2\2\2\36"+
		"\u00ec\3\2\2\2 \u00f4\3\2\2\2\"\u00f6\3\2\2\2$(\5\4\3\2%(\5\6\4\2&(\5"+
		"\n\6\2\'$\3\2\2\2\'%\3\2\2\2\'&\3\2\2\2(+\3\2\2\2)\'\3\2\2\2)*\3\2\2\2"+
		"*\3\3\2\2\2+)\3\2\2\2,-\5\"\22\2-\60\7>\2\2./\7(\2\2/\61\5\f\7\2\60.\3"+
		"\2\2\2\60\61\3\2\2\2\61\62\3\2\2\2\62\63\7\20\2\2\63\5\3\2\2\2\64\65\7"+
		")\2\2\65\66\7>\2\2\66\67\7\6\2\2\678\5\b\5\289\7\5\2\29:\5\"\22\2:>\7"+
		"\n\2\2;=\5\20\t\2<;\3\2\2\2=@\3\2\2\2><\3\2\2\2>?\3\2\2\2?A\3\2\2\2@>"+
		"\3\2\2\2AB\7\t\2\2B\7\3\2\2\2CD\5\"\22\2DK\7>\2\2EF\7\17\2\2FG\5\"\22"+
		"\2GH\7>\2\2HJ\3\2\2\2IE\3\2\2\2JM\3\2\2\2KI\3\2\2\2KL\3\2\2\2LP\3\2\2"+
		"\2MK\3\2\2\2NP\3\2\2\2OC\3\2\2\2ON\3\2\2\2P\t\3\2\2\2QR\7*\2\2RS\7>\2"+
		"\2ST\7\6\2\2TU\7\5\2\2UY\7\n\2\2VX\5\20\t\2WV\3\2\2\2X[\3\2\2\2YW\3\2"+
		"\2\2YZ\3\2\2\2Z\\\3\2\2\2[Y\3\2\2\2\\]\7\t\2\2]\13\3\2\2\2^_\b\7\1\2_"+
		"`\t\2\2\2`\u0080\5\f\7\25ab\t\3\2\2b\u0080\5\f\7\24cf\7\6\2\2dg\7>\2\2"+
		"eg\5\"\22\2fd\3\2\2\2fe\3\2\2\2gh\3\2\2\2hi\7\5\2\2i\u0080\5\f\7\23jk"+
		"\7\13\2\2kl\7\6\2\2lm\5\f\7\2mn\7\5\2\2n\u0080\3\2\2\2op\7\f\2\2pq\7\6"+
		"\2\2qr\5\f\7\2rs\7\5\2\2s\u0080\3\2\2\2tu\7\r\2\2uv\7\6\2\2vw\5\f\7\2"+
		"wx\7\5\2\2x\u0080\3\2\2\2yz\7\6\2\2z{\5\f\7\2{|\7\5\2\2|\u0080\3\2\2\2"+
		"}\u0080\7\4\2\2~\u0080\7>\2\2\177^\3\2\2\2\177a\3\2\2\2\177c\3\2\2\2\177"+
		"j\3\2\2\2\177o\3\2\2\2\177t\3\2\2\2\177y\3\2\2\2\177}\3\2\2\2\177~\3\2"+
		"\2\2\u0080\u00ae\3\2\2\2\u0081\u0082\f\26\2\2\u0082\u0083\t\4\2\2\u0083"+
		"\u00ad\5\f\7\27\u0084\u0085\f\17\2\2\u0085\u0086\t\5\2\2\u0086\u00ad\5"+
		"\f\7\20\u0087\u0088\f\16\2\2\u0088\u0089\t\2\2\2\u0089\u00ad\5\f\7\17"+
		"\u008a\u008b\f\r\2\2\u008b\u008c\t\6\2\2\u008c\u00ad\5\f\7\16\u008d\u008e"+
		"\f\f\2\2\u008e\u008f\t\7\2\2\u008f\u00ad\5\f\7\r\u0090\u0091\f\13\2\2"+
		"\u0091\u0092\t\b\2\2\u0092\u00ad\5\f\7\f\u0093\u0094\f\n\2\2\u0094\u0095"+
		"\7\36\2\2\u0095\u00ad\5\f\7\13\u0096\u0097\f\t\2\2\u0097\u0098\7 \2\2"+
		"\u0098\u00ad\5\f\7\n\u0099\u009a\f\b\2\2\u009a\u009b\7\37\2\2\u009b\u00ad"+
		"\5\f\7\t\u009c\u009d\f\7\2\2\u009d\u009e\7\30\2\2\u009e\u00ad\5\f\7\b"+
		"\u009f\u00a0\f\6\2\2\u00a0\u00a1\7\31\2\2\u00a1\u00ad\5\f\7\7\u00a2\u00a3"+
		"\f\30\2\2\u00a3\u00a4\7\6\2\2\u00a4\u00a5\5\16\b\2\u00a5\u00a6\7\5\2\2"+
		"\u00a6\u00ad\3\2\2\2\u00a7\u00a8\f\27\2\2\u00a8\u00a9\7\b\2\2\u00a9\u00aa"+
		"\5\f\7\2\u00aa\u00ab\7\7\2\2\u00ab\u00ad\3\2\2\2\u00ac\u0081\3\2\2\2\u00ac"+
		"\u0084\3\2\2\2\u00ac\u0087\3\2\2\2\u00ac\u008a\3\2\2\2\u00ac\u008d\3\2"+
		"\2\2\u00ac\u0090\3\2\2\2\u00ac\u0093\3\2\2\2\u00ac\u0096\3\2\2\2\u00ac"+
		"\u0099\3\2\2\2\u00ac\u009c\3\2\2\2\u00ac\u009f\3\2\2\2\u00ac\u00a2\3\2"+
		"\2\2\u00ac\u00a7\3\2\2\2\u00ad\u00b0\3\2\2\2\u00ae\u00ac\3\2\2\2\u00ae"+
		"\u00af\3\2\2\2\u00af\r\3\2\2\2\u00b0\u00ae\3\2\2\2\u00b1\u00b6\5\f\7\2"+
		"\u00b2\u00b3\7\17\2\2\u00b3\u00b5\5\f\7\2\u00b4\u00b2\3\2\2\2\u00b5\u00b8"+
		"\3\2\2\2\u00b6\u00b4\3\2\2\2\u00b6\u00b7\3\2\2\2\u00b7\17\3\2\2\2\u00b8"+
		"\u00b6\3\2\2\2\u00b9\u00c3\5\22\n\2\u00ba\u00c3\5\32\16\2\u00bb\u00c3"+
		"\5\34\17\2\u00bc\u00c3\5\26\f\2\u00bd\u00c3\5\30\r\2\u00be\u00c3\5\36"+
		"\20\2\u00bf\u00c0\5\f\7\2\u00c0\u00c1\7\20\2\2\u00c1\u00c3\3\2\2\2\u00c2"+
		"\u00b9\3\2\2\2\u00c2\u00ba\3\2\2\2\u00c2\u00bb\3\2\2\2\u00c2\u00bc\3\2"+
		"\2\2\u00c2\u00bd\3\2\2\2\u00c2\u00be\3\2\2\2\u00c2\u00bf\3\2\2\2\u00c3"+
		"\21\3\2\2\2\u00c4\u00c5\5\24\13\2\u00c5\u00c6\7(\2\2\u00c6\u00c7\5\f\7"+
		"\2\u00c7\u00c8\7\20\2\2\u00c8\23\3\2\2\2\u00c9\u00ca\7>\2\2\u00ca\25\3"+
		"\2\2\2\u00cb\u00cc\7-\2\2\u00cc\u00cd\7\6\2\2\u00cd\u00ce\5\f\7\2\u00ce"+
		"\u00cf\7\5\2\2\u00cf\u00d3\7\n\2\2\u00d0\u00d2\5\20\t\2\u00d1\u00d0\3"+
		"\2\2\2\u00d2\u00d5\3\2\2\2\u00d3\u00d1\3\2\2\2\u00d3\u00d4\3\2\2\2\u00d4"+
		"\u00d6\3\2\2\2\u00d5\u00d3\3\2\2\2\u00d6\u00d7\7\t\2\2\u00d7\27\3\2\2"+
		"\2\u00d8\u00d9\7.\2\2\u00d9\u00da\7\6\2\2\u00da\u00db\5\f\7\2\u00db\u00dc"+
		"\7\5\2\2\u00dc\u00e0\7\n\2\2\u00dd\u00df\5\20\t\2\u00de\u00dd\3\2\2\2"+
		"\u00df\u00e2\3\2\2\2\u00e0\u00de\3\2\2\2\u00e0\u00e1\3\2\2\2\u00e1\u00e3"+
		"\3\2\2\2\u00e2\u00e0\3\2\2\2\u00e3\u00e4\7\t\2\2\u00e4\31\3\2\2\2\u00e5"+
		"\u00e6\7+\2\2\u00e6\u00e7\7\20\2\2\u00e7\33\3\2\2\2\u00e8\u00e9\7,\2\2"+
		"\u00e9\u00ea\5\f\7\2\u00ea\u00eb\7\20\2\2\u00eb\35\3\2\2\2\u00ec\u00ed"+
		"\5\"\22\2\u00ed\u00f0\7>\2\2\u00ee\u00ef\7(\2\2\u00ef\u00f1\5\f\7\2\u00f0"+
		"\u00ee\3\2\2\2\u00f0\u00f1\3\2\2\2\u00f1\u00f2\3\2\2\2\u00f2\u00f3\7\20"+
		"\2\2\u00f3\37\3\2\2\2\u00f4\u00f5\7\3\2\2\u00f5!\3\2\2\2\u00f6\u00f7\t"+
		"\t\2\2\u00f7#\3\2\2\2\22\')\60>KOYf\177\u00ac\u00ae\u00b6\u00c2\u00d3"+
		"\u00e0\u00f0";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}