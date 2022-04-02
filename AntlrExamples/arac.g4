grammar arac;

program: (
		globalVarDecl
		| functionDecl
		| operationDecl
	)+;

globalVarDecl:
	dataType ID inititalization? FASLA_MANQUOTA;

inititalization: (ASSIGN_SYM expression);

functionDecl:
	FUNC_KEYWORD ID RP paramList LP COLON dataType RCB statementList LCB;

operationDecl:
	OP_KEYWORD ID RP paramList LP RCB statementList LCB;

parameter: dataType ID;
paramList: (parameter (FASLA parameter)*)?;

argument: expression;
argumentList: (argument (FASLA argument)*)?;

expression:
	ID RP argumentList LP											# funCallExpr
	| expression RSB expression LSB									# ArrSubScripExpr
	| PLUS  expression												# negationExpr
	|  unaryBL_op expression										# UnaryBLExpr
	| RP dataType LP expression										# CastingExpr
	| ADDRESS_OF_OPERATOR expression								# AddressExpr
	| VALUE_INSIDE_OPERATOR expression								# IndirectionExpr
	| SIZE_OF expression											# SizeExpr
	| expression DIVIDE expression									# divideExpr
	| expression MULTIPLY expression								# multiplyExpr
	| expression MINUS expression									# subtractionExpr
	| expression PLUS expression									# addExpr
	| expression SL_SYM expression									# shiftLeftExpr
	| expression SR_SYM expression									# shiftRightExpr
	| expression comparison_op expression							# CompExpr
	| expression equality_op expression								# EqualityExpr
	| expression BAND_SYM expression								# BandExpr
	| expression (BXOR_SYM) expression								# BxorExpr
	| expression (BOR_SYM) expression								# BorExpr
	| expression (LAND) expression									# LandExpr
	| expression (LOR) expression									# LorExpr
	| RP expression LP												# parenthesisExpr
	| Literal														# literalExpr
	| ID															# variableExpr;


comparison_op: (GTE_SYM | LTE_SYM | GT_SYM | LT_SYM);
unaryBL_op : (LOGICAL_NOT | BNOT_SYM);
equality_op : (EQUAL_SYM | NOTEQ_SYM);
statement:
	assignmentStat # assignment_Stat       
	| returnStat # return_Stat	    
	| resultStat # result_Stat		    
	| ifStat	# if_Stat	    
	| whileStat	# while_Stat       
	| varDecl	# var_Decl       
	| expressionStat #expression_Stat
	| operationStat #operation_Stat;

statementList : statement*;

expressionStat: expression FASLA_MANQUOTA;

operationStat: ID RP argumentList LP FASLA_MANQUOTA;

assignmentStat: ID ASSIGN_SYM expression FASLA_MANQUOTA;

ifStat: IF_KEYWORD RP expression LP RCB statementList LCB;

whileStat:
	WHILE_KEYWORD RP expression LP RCB statementList LCB;

returnStat: RET_KEYWORD FASLA_MANQUOTA;

resultStat: RES_KEYWORD expression FASLA_MANQUOTA;

varDecl:
	dataType ID inititalization? FASLA_MANQUOTA;

Literal:
	ARABIC_INT_LITERAL;
	// | ENGLISH_INT_LITERAL;

LP: '(';
RP: ')';
LSB: '[';
RSB: ']';
LCB: '{';
RCB: '}';

// memory address operators
ADDRESS_OF_OPERATOR: '&:';
VALUE_INSIDE_OPERATOR: '*:';
SIZE_OF: 'حجم:';

// punctuation symbols.
// DOT: '.';
FASLA: '،';
FASLA_MANQUOTA: '؛';
// ARROW: '->';
COLON: ':';

// mathimatical symbols.
PLUS: '+';
MINUS: '-';
MULTIPLY: '×';
DIVIDE: '÷';
ARABIC_MODULS: '٪';
MODULUS: '%';

// logical operations
LAND: '&&';
LOR: '||';
LOGICAL_NOT: '!';

// Bitwise symbols.
SL_SYM: '<<';
SRA_SYM: '>>>';
SR_SYM: '>>';
BAND_SYM: '&';
BOR_SYM: '|';
BXOR_SYM: '^';
BNOT_SYM: '~';

// Relational symbols.
LTE_SYM: '<=';
GTE_SYM: '>=';
LT_SYM: '<';
GT_SYM: '>';
EQUAL_SYM: '==';
NOTEQ_SYM: '!=';

// operative symbols.
ASSIGN_SYM: ':=';

// keywords
FUNC_KEYWORD: 'دالة';
OP_KEYWORD: 'عملية';

RET_KEYWORD: 'رجوع';
RES_KEYWORD: 'الناتج';

IF_KEYWORD: 'إذا' | 'اذا';
WHILE_KEYWORD: 'طالما';

BREAK_KEYWORD: 'قطع';
CONTINUE_KEYWORRD: 'تخظى' | 'تخطي';

INT_DATA_TYPE: 'صحيح';
UINT_DATA_TYPE: 'طبيعي';

BYTE_DATA_TYPE: 'صحيح_١';
UBYTE_DATA_TYPE: 'طبيعي_١';

SHORT_DATA_TYPE: 'صحيح_٢';
USHORT_DATA_TYPE: 'طبيعي_٢';

LONG_DATA_TYPE: 'صحيح_٨';
ULONG_DATA_TYPE: 'طبيعي_٨';

// literal values.
// STRING_LITERAL:
// 	'"' (ESCAPED_CHARACTERS | ~('\u0022' | '\u0000'))* '"';

// fragment ESCAPED_CHARACTERS: ('//' | '/"' | '/0');

// CHARACTER_LITERAL:
	// '\'' (ESCAPED_CHARACTERS | ~('\u0027' | '\u0000')) '\'';

WHITE_SPACE: [\u0020\u0009\u000A\u000B\u000C\u000D] -> skip;

ARABIC_INT_LITERAL: [٠-٩]+;
// ENGLISH_INT_LITERAL: [0-9]+;

// Identifier regular expression.
ID: [a-zA-Zء-ي] [a-zA-Zء-ي0-9٠-٩_]*;

dataType:
	INT_DATA_TYPE
	| UINT_DATA_TYPE
	| BYTE_DATA_TYPE
	| UBYTE_DATA_TYPE
	| SHORT_DATA_TYPE
	| USHORT_DATA_TYPE
	| LONG_DATA_TYPE
	| ULONG_DATA_TYPE;