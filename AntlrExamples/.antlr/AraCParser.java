// Generated from /home/mahmoud/.repos/AraCCompilerAntlrVariant/AntlrExamples/AraC.g4 by ANTLR 4.8
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
	static { RuntimeMetaData.checkVersion("4.8", RuntimeMetaData.VERSION); }

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
		RULE_programm = 0, RULE_global_var_declaratoin = 1, RULE_function_declaration = 2, 
		RULE_operatoin_declaration = 3, RULE_expression = 4, RULE_argument_list = 5, 
		RULE_statement = 6, RULE_assignment_statement = 7, RULE_left_hand_side = 8, 
		RULE_if_statement = 9, RULE_while_statement = 10, RULE_return_statement = 11, 
		RULE_result_statement = 12, RULE_var_declaration = 13, RULE_colon = 14, 
		RULE_data_type = 15;
	private static String[] makeRuleNames() {
		return new String[] {
			"programm", "global_var_declaratoin", "function_declaration", "operatoin_declaration", 
			"expression", "argument_list", "statement", "assignment_statement", "left_hand_side", 
			"if_statement", "while_statement", "return_statement", "result_statement", 
			"var_declaration", "colon", "data_type"
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

	public static class ProgrammContext extends ParserRuleContext {
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
		public ProgrammContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_programm; }
	}

	public final ProgrammContext programm() throws RecognitionException {
		ProgrammContext _localctx = new ProgrammContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_programm);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(37);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << FUNCTION) | (1L << OPERATION) | (1L << INT_DATA_TYPE) | (1L << UINT_DATA_TYPE) | (1L << BYTE_DATA_TYPE) | (1L << UBYTE_DATA_TYPE) | (1L << SHORT_DATA_TYPE) | (1L << USHORT_DATA_TYPE) | (1L << LONG_DATA_TYPE) | (1L << ULONG_DATA_TYPE))) != 0)) {
				{
				setState(35);
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
					setState(32);
					global_var_declaratoin();
					}
					break;
				case FUNCTION:
					{
					setState(33);
					function_declaration();
					}
					break;
				case OPERATION:
					{
					setState(34);
					operatoin_declaration();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				setState(39);
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
	}

	public final Global_var_declaratoinContext global_var_declaratoin() throws RecognitionException {
		Global_var_declaratoinContext _localctx = new Global_var_declaratoinContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_global_var_declaratoin);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(40);
			data_type();
			setState(41);
			match(IDENTIFIER);
			setState(44);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==ASSIGN) {
				{
				setState(42);
				match(ASSIGN);
				setState(43);
				expression(0);
				}
			}

			setState(46);
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
	}

	public final Function_declarationContext function_declaration() throws RecognitionException {
		Function_declarationContext _localctx = new Function_declarationContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_function_declaration);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(48);
			match(FUNCTION);
			setState(49);
			match(IDENTIFIER);
			setState(50);
			match(RIGHT_PARENTHESIS);
			setState(51);
			match(LEFT_PARENTHESIS);
			setState(52);
			data_type();
			setState(53);
			match(RIGHT_CURLY_BRACKET);
			setState(57);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Literal) | (1L << RIGHT_PARENTHESIS) | (1L << ADDRESS_OF_OPERATOR) | (1L << VALUE_INSIDE_OPERATOR) | (1L << SIZE_OF) | (1L << PLUS) | (1L << MINUS) | (1L << LOGICAL_NOT) | (1L << BITWISE_NOT) | (1L << RETURN_KEYWORD) | (1L << RESULT_KEYWORD) | (1L << IF_KEYWORD) | (1L << WHILE_KEYWORD) | (1L << INT_DATA_TYPE) | (1L << UINT_DATA_TYPE) | (1L << BYTE_DATA_TYPE) | (1L << UBYTE_DATA_TYPE) | (1L << SHORT_DATA_TYPE) | (1L << USHORT_DATA_TYPE) | (1L << LONG_DATA_TYPE) | (1L << ULONG_DATA_TYPE) | (1L << IDENTIFIER))) != 0)) {
				{
				{
				setState(54);
				statement();
				}
				}
				setState(59);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(60);
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
	}

	public final Operatoin_declarationContext operatoin_declaration() throws RecognitionException {
		Operatoin_declarationContext _localctx = new Operatoin_declarationContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_operatoin_declaration);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(62);
			match(OPERATION);
			setState(63);
			match(IDENTIFIER);
			setState(64);
			match(RIGHT_PARENTHESIS);
			setState(65);
			match(LEFT_PARENTHESIS);
			setState(66);
			match(RIGHT_CURLY_BRACKET);
			setState(70);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Literal) | (1L << RIGHT_PARENTHESIS) | (1L << ADDRESS_OF_OPERATOR) | (1L << VALUE_INSIDE_OPERATOR) | (1L << SIZE_OF) | (1L << PLUS) | (1L << MINUS) | (1L << LOGICAL_NOT) | (1L << BITWISE_NOT) | (1L << RETURN_KEYWORD) | (1L << RESULT_KEYWORD) | (1L << IF_KEYWORD) | (1L << WHILE_KEYWORD) | (1L << INT_DATA_TYPE) | (1L << UINT_DATA_TYPE) | (1L << BYTE_DATA_TYPE) | (1L << UBYTE_DATA_TYPE) | (1L << SHORT_DATA_TYPE) | (1L << USHORT_DATA_TYPE) | (1L << LONG_DATA_TYPE) | (1L << ULONG_DATA_TYPE) | (1L << IDENTIFIER))) != 0)) {
				{
				{
				setState(67);
				statement();
				}
				}
				setState(72);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(73);
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
	}

	public final ExpressionContext expression() throws RecognitionException {
		return expression(0);
	}

	private ExpressionContext expression(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		ExpressionContext _localctx = new ExpressionContext(_ctx, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 8;
		enterRecursionRule(_localctx, 8, RULE_expression, _p);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(108);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,6,_ctx) ) {
			case 1:
				{
				setState(76);
				_la = _input.LA(1);
				if ( !(_la==PLUS || _la==MINUS) ) {
				_errHandler.recoverInline(this);
				}
				else {
					if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
					_errHandler.reportMatch(this);
					consume();
				}
				setState(77);
				expression(19);
				}
				break;
			case 2:
				{
				setState(78);
				_la = _input.LA(1);
				if ( !(_la==LOGICAL_NOT || _la==BITWISE_NOT) ) {
				_errHandler.recoverInline(this);
				}
				else {
					if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
					_errHandler.reportMatch(this);
					consume();
				}
				setState(79);
				expression(18);
				}
				break;
			case 3:
				{
				setState(80);
				match(RIGHT_PARENTHESIS);
				setState(83);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case IDENTIFIER:
					{
					setState(81);
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
					setState(82);
					data_type();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(85);
				match(LEFT_PARENTHESIS);
				setState(86);
				expression(17);
				}
				break;
			case 4:
				{
				setState(87);
				match(ADDRESS_OF_OPERATOR);
				setState(88);
				match(RIGHT_PARENTHESIS);
				setState(89);
				expression(0);
				setState(90);
				match(LEFT_PARENTHESIS);
				}
				break;
			case 5:
				{
				setState(92);
				match(VALUE_INSIDE_OPERATOR);
				setState(93);
				match(RIGHT_PARENTHESIS);
				setState(94);
				expression(0);
				setState(95);
				match(LEFT_PARENTHESIS);
				}
				break;
			case 6:
				{
				setState(97);
				match(SIZE_OF);
				setState(98);
				match(RIGHT_PARENTHESIS);
				setState(99);
				expression(0);
				setState(100);
				match(LEFT_PARENTHESIS);
				}
				break;
			case 7:
				{
				setState(102);
				match(RIGHT_PARENTHESIS);
				setState(103);
				expression(0);
				setState(104);
				match(LEFT_PARENTHESIS);
				}
				break;
			case 8:
				{
				setState(106);
				match(Literal);
				}
				break;
			case 9:
				{
				setState(107);
				match(IDENTIFIER);
				}
				break;
			}
			_ctx.stop = _input.LT(-1);
			setState(155);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,8,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(153);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,7,_ctx) ) {
					case 1:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(110);
						if (!(precpred(_ctx, 20))) throw new FailedPredicateException(this, "precpred(_ctx, 20)");
						setState(111);
						_la = _input.LA(1);
						if ( !(_la==DOT || _la==ARROW) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(112);
						expression(21);
						}
						break;
					case 2:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(113);
						if (!(precpred(_ctx, 13))) throw new FailedPredicateException(this, "precpred(_ctx, 13)");
						setState(114);
						_la = _input.LA(1);
						if ( !(_la==MULTIPLY || _la==DIVIDE) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(115);
						expression(14);
						}
						break;
					case 3:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(116);
						if (!(precpred(_ctx, 12))) throw new FailedPredicateException(this, "precpred(_ctx, 12)");
						setState(117);
						_la = _input.LA(1);
						if ( !(_la==PLUS || _la==MINUS) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(118);
						expression(13);
						}
						break;
					case 4:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(119);
						if (!(precpred(_ctx, 11))) throw new FailedPredicateException(this, "precpred(_ctx, 11)");
						setState(120);
						_la = _input.LA(1);
						if ( !(_la==SHIFT_LEFT || _la==SHIFT_RIGHT) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(121);
						expression(12);
						}
						break;
					case 5:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(122);
						if (!(precpred(_ctx, 10))) throw new FailedPredicateException(this, "precpred(_ctx, 10)");
						setState(123);
						_la = _input.LA(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << LESS_THAN_EQUAL) | (1L << GREATER_THAN_EQUAL) | (1L << LESS_THAN) | (1L << GREATER_THAN))) != 0)) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(124);
						expression(11);
						}
						break;
					case 6:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(125);
						if (!(precpred(_ctx, 9))) throw new FailedPredicateException(this, "precpred(_ctx, 9)");
						setState(126);
						_la = _input.LA(1);
						if ( !(_la==EQUAL || _la==NOT_EQUAL) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(127);
						expression(10);
						}
						break;
					case 7:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(128);
						if (!(precpred(_ctx, 8))) throw new FailedPredicateException(this, "precpred(_ctx, 8)");
						{
						setState(129);
						match(BITWISE_AND);
						}
						setState(130);
						expression(9);
						}
						break;
					case 8:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(131);
						if (!(precpred(_ctx, 7))) throw new FailedPredicateException(this, "precpred(_ctx, 7)");
						{
						setState(132);
						match(BITWISE_XOR);
						}
						setState(133);
						expression(8);
						}
						break;
					case 9:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(134);
						if (!(precpred(_ctx, 6))) throw new FailedPredicateException(this, "precpred(_ctx, 6)");
						{
						setState(135);
						match(BITWISE_OR);
						}
						setState(136);
						expression(7);
						}
						break;
					case 10:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(137);
						if (!(precpred(_ctx, 5))) throw new FailedPredicateException(this, "precpred(_ctx, 5)");
						{
						setState(138);
						match(LOGICAL_AND);
						}
						setState(139);
						expression(6);
						}
						break;
					case 11:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(140);
						if (!(precpred(_ctx, 4))) throw new FailedPredicateException(this, "precpred(_ctx, 4)");
						{
						setState(141);
						match(LOGICAL_OR);
						}
						setState(142);
						expression(5);
						}
						break;
					case 12:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(143);
						if (!(precpred(_ctx, 22))) throw new FailedPredicateException(this, "precpred(_ctx, 22)");
						setState(144);
						match(RIGHT_PARENTHESIS);
						setState(145);
						argument_list();
						setState(146);
						match(LEFT_PARENTHESIS);
						}
						break;
					case 13:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(148);
						if (!(precpred(_ctx, 21))) throw new FailedPredicateException(this, "precpred(_ctx, 21)");
						setState(149);
						match(RIGHT_SQUARE_BRACKET);
						setState(150);
						expression(0);
						setState(151);
						match(LEFT_SQUARE_BRACKET);
						}
						break;
					}
					} 
				}
				setState(157);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,8,_ctx);
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
	}

	public final Argument_listContext argument_list() throws RecognitionException {
		Argument_listContext _localctx = new Argument_listContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_argument_list);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(158);
			expression(0);
			setState(163);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==FASLA) {
				{
				{
				setState(159);
				match(FASLA);
				setState(160);
				expression(0);
				}
				}
				setState(165);
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
	}

	public final StatementContext statement() throws RecognitionException {
		StatementContext _localctx = new StatementContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_statement);
		try {
			setState(175);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,10,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(166);
				assignment_statement();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(167);
				return_statement();
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(168);
				result_statement();
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(169);
				if_statement();
				}
				break;
			case 5:
				enterOuterAlt(_localctx, 5);
				{
				setState(170);
				while_statement();
				}
				break;
			case 6:
				enterOuterAlt(_localctx, 6);
				{
				setState(171);
				var_declaration();
				}
				break;
			case 7:
				enterOuterAlt(_localctx, 7);
				{
				setState(172);
				expression(0);
				setState(173);
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
	}

	public final Assignment_statementContext assignment_statement() throws RecognitionException {
		Assignment_statementContext _localctx = new Assignment_statementContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_assignment_statement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(177);
			left_hand_side();
			setState(178);
			match(ASSIGN);
			setState(179);
			expression(0);
			setState(180);
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
	}

	public final Left_hand_sideContext left_hand_side() throws RecognitionException {
		Left_hand_sideContext _localctx = new Left_hand_sideContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_left_hand_side);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(182);
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
	}

	public final If_statementContext if_statement() throws RecognitionException {
		If_statementContext _localctx = new If_statementContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_if_statement);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(184);
			match(IF_KEYWORD);
			setState(185);
			match(RIGHT_PARENTHESIS);
			setState(186);
			expression(0);
			setState(187);
			match(LEFT_PARENTHESIS);
			setState(188);
			match(RIGHT_CURLY_BRACKET);
			setState(192);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Literal) | (1L << RIGHT_PARENTHESIS) | (1L << ADDRESS_OF_OPERATOR) | (1L << VALUE_INSIDE_OPERATOR) | (1L << SIZE_OF) | (1L << PLUS) | (1L << MINUS) | (1L << LOGICAL_NOT) | (1L << BITWISE_NOT) | (1L << RETURN_KEYWORD) | (1L << RESULT_KEYWORD) | (1L << IF_KEYWORD) | (1L << WHILE_KEYWORD) | (1L << INT_DATA_TYPE) | (1L << UINT_DATA_TYPE) | (1L << BYTE_DATA_TYPE) | (1L << UBYTE_DATA_TYPE) | (1L << SHORT_DATA_TYPE) | (1L << USHORT_DATA_TYPE) | (1L << LONG_DATA_TYPE) | (1L << ULONG_DATA_TYPE) | (1L << IDENTIFIER))) != 0)) {
				{
				{
				setState(189);
				statement();
				}
				}
				setState(194);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(195);
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
	}

	public final While_statementContext while_statement() throws RecognitionException {
		While_statementContext _localctx = new While_statementContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_while_statement);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(197);
			match(WHILE_KEYWORD);
			setState(198);
			match(RIGHT_PARENTHESIS);
			setState(199);
			expression(0);
			setState(200);
			match(LEFT_PARENTHESIS);
			setState(201);
			match(RIGHT_CURLY_BRACKET);
			setState(205);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Literal) | (1L << RIGHT_PARENTHESIS) | (1L << ADDRESS_OF_OPERATOR) | (1L << VALUE_INSIDE_OPERATOR) | (1L << SIZE_OF) | (1L << PLUS) | (1L << MINUS) | (1L << LOGICAL_NOT) | (1L << BITWISE_NOT) | (1L << RETURN_KEYWORD) | (1L << RESULT_KEYWORD) | (1L << IF_KEYWORD) | (1L << WHILE_KEYWORD) | (1L << INT_DATA_TYPE) | (1L << UINT_DATA_TYPE) | (1L << BYTE_DATA_TYPE) | (1L << UBYTE_DATA_TYPE) | (1L << SHORT_DATA_TYPE) | (1L << USHORT_DATA_TYPE) | (1L << LONG_DATA_TYPE) | (1L << ULONG_DATA_TYPE) | (1L << IDENTIFIER))) != 0)) {
				{
				{
				setState(202);
				statement();
				}
				}
				setState(207);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(208);
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
	}

	public final Return_statementContext return_statement() throws RecognitionException {
		Return_statementContext _localctx = new Return_statementContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_return_statement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(210);
			match(RETURN_KEYWORD);
			setState(211);
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
	}

	public final Result_statementContext result_statement() throws RecognitionException {
		Result_statementContext _localctx = new Result_statementContext(_ctx, getState());
		enterRule(_localctx, 24, RULE_result_statement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(213);
			match(RESULT_KEYWORD);
			setState(214);
			expression(0);
			setState(215);
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
	}

	public final Var_declarationContext var_declaration() throws RecognitionException {
		Var_declarationContext _localctx = new Var_declarationContext(_ctx, getState());
		enterRule(_localctx, 26, RULE_var_declaration);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(217);
			data_type();
			setState(218);
			match(IDENTIFIER);
			setState(221);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==ASSIGN) {
				{
				setState(219);
				match(ASSIGN);
				setState(220);
				expression(0);
				}
			}

			setState(223);
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
	}

	public final ColonContext colon() throws RecognitionException {
		ColonContext _localctx = new ColonContext(_ctx, getState());
		enterRule(_localctx, 28, RULE_colon);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(225);
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
	}

	public final Data_typeContext data_type() throws RecognitionException {
		Data_typeContext _localctx = new Data_typeContext(_ctx, getState());
		enterRule(_localctx, 30, RULE_data_type);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(227);
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
		case 4:
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
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3>\u00e8\4\2\t\2\4"+
		"\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13\t"+
		"\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\3\2\3\2\3"+
		"\2\7\2&\n\2\f\2\16\2)\13\2\3\3\3\3\3\3\3\3\5\3/\n\3\3\3\3\3\3\4\3\4\3"+
		"\4\3\4\3\4\3\4\3\4\7\4:\n\4\f\4\16\4=\13\4\3\4\3\4\3\5\3\5\3\5\3\5\3\5"+
		"\3\5\7\5G\n\5\f\5\16\5J\13\5\3\5\3\5\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\5"+
		"\6V\n\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3"+
		"\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\5\6o\n\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3"+
		"\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6"+
		"\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3"+
		"\6\7\6\u009c\n\6\f\6\16\6\u009f\13\6\3\7\3\7\3\7\7\7\u00a4\n\7\f\7\16"+
		"\7\u00a7\13\7\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\5\b\u00b2\n\b\3\t\3"+
		"\t\3\t\3\t\3\t\3\n\3\n\3\13\3\13\3\13\3\13\3\13\3\13\7\13\u00c1\n\13\f"+
		"\13\16\13\u00c4\13\13\3\13\3\13\3\f\3\f\3\f\3\f\3\f\3\f\7\f\u00ce\n\f"+
		"\f\f\16\f\u00d1\13\f\3\f\3\f\3\r\3\r\3\r\3\16\3\16\3\16\3\16\3\17\3\17"+
		"\3\17\3\17\5\17\u00e0\n\17\3\17\3\17\3\20\3\20\3\21\3\21\3\21\2\3\n\22"+
		"\2\4\6\b\n\f\16\20\22\24\26\30\32\34\36 \2\n\3\2\22\23\4\2\32\32!!\4\2"+
		"\16\16\21\21\3\2\24\25\4\2\33\33\35\35\3\2\"%\3\2&\'\3\2\618\2\u00fd\2"+
		"\'\3\2\2\2\4*\3\2\2\2\6\62\3\2\2\2\b@\3\2\2\2\nn\3\2\2\2\f\u00a0\3\2\2"+
		"\2\16\u00b1\3\2\2\2\20\u00b3\3\2\2\2\22\u00b8\3\2\2\2\24\u00ba\3\2\2\2"+
		"\26\u00c7\3\2\2\2\30\u00d4\3\2\2\2\32\u00d7\3\2\2\2\34\u00db\3\2\2\2\36"+
		"\u00e3\3\2\2\2 \u00e5\3\2\2\2\"&\5\4\3\2#&\5\6\4\2$&\5\b\5\2%\"\3\2\2"+
		"\2%#\3\2\2\2%$\3\2\2\2&)\3\2\2\2\'%\3\2\2\2\'(\3\2\2\2(\3\3\2\2\2)\'\3"+
		"\2\2\2*+\5 \21\2+.\7>\2\2,-\7(\2\2-/\5\n\6\2.,\3\2\2\2./\3\2\2\2/\60\3"+
		"\2\2\2\60\61\7\20\2\2\61\5\3\2\2\2\62\63\7)\2\2\63\64\7>\2\2\64\65\7\6"+
		"\2\2\65\66\7\5\2\2\66\67\5 \21\2\67;\7\n\2\28:\5\16\b\298\3\2\2\2:=\3"+
		"\2\2\2;9\3\2\2\2;<\3\2\2\2<>\3\2\2\2=;\3\2\2\2>?\7\t\2\2?\7\3\2\2\2@A"+
		"\7*\2\2AB\7>\2\2BC\7\6\2\2CD\7\5\2\2DH\7\n\2\2EG\5\16\b\2FE\3\2\2\2GJ"+
		"\3\2\2\2HF\3\2\2\2HI\3\2\2\2IK\3\2\2\2JH\3\2\2\2KL\7\t\2\2L\t\3\2\2\2"+
		"MN\b\6\1\2NO\t\2\2\2Oo\5\n\6\25PQ\t\3\2\2Qo\5\n\6\24RU\7\6\2\2SV\7>\2"+
		"\2TV\5 \21\2US\3\2\2\2UT\3\2\2\2VW\3\2\2\2WX\7\5\2\2Xo\5\n\6\23YZ\7\13"+
		"\2\2Z[\7\6\2\2[\\\5\n\6\2\\]\7\5\2\2]o\3\2\2\2^_\7\f\2\2_`\7\6\2\2`a\5"+
		"\n\6\2ab\7\5\2\2bo\3\2\2\2cd\7\r\2\2de\7\6\2\2ef\5\n\6\2fg\7\5\2\2go\3"+
		"\2\2\2hi\7\6\2\2ij\5\n\6\2jk\7\5\2\2ko\3\2\2\2lo\7\4\2\2mo\7>\2\2nM\3"+
		"\2\2\2nP\3\2\2\2nR\3\2\2\2nY\3\2\2\2n^\3\2\2\2nc\3\2\2\2nh\3\2\2\2nl\3"+
		"\2\2\2nm\3\2\2\2o\u009d\3\2\2\2pq\f\26\2\2qr\t\4\2\2r\u009c\5\n\6\27s"+
		"t\f\17\2\2tu\t\5\2\2u\u009c\5\n\6\20vw\f\16\2\2wx\t\2\2\2x\u009c\5\n\6"+
		"\17yz\f\r\2\2z{\t\6\2\2{\u009c\5\n\6\16|}\f\f\2\2}~\t\7\2\2~\u009c\5\n"+
		"\6\r\177\u0080\f\13\2\2\u0080\u0081\t\b\2\2\u0081\u009c\5\n\6\f\u0082"+
		"\u0083\f\n\2\2\u0083\u0084\7\36\2\2\u0084\u009c\5\n\6\13\u0085\u0086\f"+
		"\t\2\2\u0086\u0087\7 \2\2\u0087\u009c\5\n\6\n\u0088\u0089\f\b\2\2\u0089"+
		"\u008a\7\37\2\2\u008a\u009c\5\n\6\t\u008b\u008c\f\7\2\2\u008c\u008d\7"+
		"\30\2\2\u008d\u009c\5\n\6\b\u008e\u008f\f\6\2\2\u008f\u0090\7\31\2\2\u0090"+
		"\u009c\5\n\6\7\u0091\u0092\f\30\2\2\u0092\u0093\7\6\2\2\u0093\u0094\5"+
		"\f\7\2\u0094\u0095\7\5\2\2\u0095\u009c\3\2\2\2\u0096\u0097\f\27\2\2\u0097"+
		"\u0098\7\b\2\2\u0098\u0099\5\n\6\2\u0099\u009a\7\7\2\2\u009a\u009c\3\2"+
		"\2\2\u009bp\3\2\2\2\u009bs\3\2\2\2\u009bv\3\2\2\2\u009by\3\2\2\2\u009b"+
		"|\3\2\2\2\u009b\177\3\2\2\2\u009b\u0082\3\2\2\2\u009b\u0085\3\2\2\2\u009b"+
		"\u0088\3\2\2\2\u009b\u008b\3\2\2\2\u009b\u008e\3\2\2\2\u009b\u0091\3\2"+
		"\2\2\u009b\u0096\3\2\2\2\u009c\u009f\3\2\2\2\u009d\u009b\3\2\2\2\u009d"+
		"\u009e\3\2\2\2\u009e\13\3\2\2\2\u009f\u009d\3\2\2\2\u00a0\u00a5\5\n\6"+
		"\2\u00a1\u00a2\7\17\2\2\u00a2\u00a4\5\n\6\2\u00a3\u00a1\3\2\2\2\u00a4"+
		"\u00a7\3\2\2\2\u00a5\u00a3\3\2\2\2\u00a5\u00a6\3\2\2\2\u00a6\r\3\2\2\2"+
		"\u00a7\u00a5\3\2\2\2\u00a8\u00b2\5\20\t\2\u00a9\u00b2\5\30\r\2\u00aa\u00b2"+
		"\5\32\16\2\u00ab\u00b2\5\24\13\2\u00ac\u00b2\5\26\f\2\u00ad\u00b2\5\34"+
		"\17\2\u00ae\u00af\5\n\6\2\u00af\u00b0\7\20\2\2\u00b0\u00b2\3\2\2\2\u00b1"+
		"\u00a8\3\2\2\2\u00b1\u00a9\3\2\2\2\u00b1\u00aa\3\2\2\2\u00b1\u00ab\3\2"+
		"\2\2\u00b1\u00ac\3\2\2\2\u00b1\u00ad\3\2\2\2\u00b1\u00ae\3\2\2\2\u00b2"+
		"\17\3\2\2\2\u00b3\u00b4\5\22\n\2\u00b4\u00b5\7(\2\2\u00b5\u00b6\5\n\6"+
		"\2\u00b6\u00b7\7\20\2\2\u00b7\21\3\2\2\2\u00b8\u00b9\7>\2\2\u00b9\23\3"+
		"\2\2\2\u00ba\u00bb\7-\2\2\u00bb\u00bc\7\6\2\2\u00bc\u00bd\5\n\6\2\u00bd"+
		"\u00be\7\5\2\2\u00be\u00c2\7\n\2\2\u00bf\u00c1\5\16\b\2\u00c0\u00bf\3"+
		"\2\2\2\u00c1\u00c4\3\2\2\2\u00c2\u00c0\3\2\2\2\u00c2\u00c3\3\2\2\2\u00c3"+
		"\u00c5\3\2\2\2\u00c4\u00c2\3\2\2\2\u00c5\u00c6\7\t\2\2\u00c6\25\3\2\2"+
		"\2\u00c7\u00c8\7.\2\2\u00c8\u00c9\7\6\2\2\u00c9\u00ca\5\n\6\2\u00ca\u00cb"+
		"\7\5\2\2\u00cb\u00cf\7\n\2\2\u00cc\u00ce\5\16\b\2\u00cd\u00cc\3\2\2\2"+
		"\u00ce\u00d1\3\2\2\2\u00cf\u00cd\3\2\2\2\u00cf\u00d0\3\2\2\2\u00d0\u00d2"+
		"\3\2\2\2\u00d1\u00cf\3\2\2\2\u00d2\u00d3\7\t\2\2\u00d3\27\3\2\2\2\u00d4"+
		"\u00d5\7+\2\2\u00d5\u00d6\7\20\2\2\u00d6\31\3\2\2\2\u00d7\u00d8\7,\2\2"+
		"\u00d8\u00d9\5\n\6\2\u00d9\u00da\7\20\2\2\u00da\33\3\2\2\2\u00db\u00dc"+
		"\5 \21\2\u00dc\u00df\7>\2\2\u00dd\u00de\7(\2\2\u00de\u00e0\5\n\6\2\u00df"+
		"\u00dd\3\2\2\2\u00df\u00e0\3\2\2\2\u00e0\u00e1\3\2\2\2\u00e1\u00e2\7\20"+
		"\2\2\u00e2\35\3\2\2\2\u00e3\u00e4\7\3\2\2\u00e4\37\3\2\2\2\u00e5\u00e6"+
		"\t\t\2\2\u00e6!\3\2\2\2\20%\'.;HUn\u009b\u009d\u00a5\u00b1\u00c2\u00cf"+
		"\u00df";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}