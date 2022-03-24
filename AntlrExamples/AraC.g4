grammar AraC;

program: (
		global_var_declaratoin 
		| function_declaration
		| operatoin_declaration
	)+;

global_var_declaratoin:
	data_type ID (ASSIGN_SYM expression)? FASLA_MANQUOTA;

function_declaration:
	FUNC_KEYWORD ID RP param_list LP COLON data_type RCB statement* LCB;

operatoin_declaration:
	OPER_KEYWORD ID RP param_list LP RCB statement* LCB;

param_list: (data_type ID (FASLA data_type ID)*) |  ;

expression:
	expression RP argument_list LP									# funciton_calling_expr
	| expression RSB expression LSB									# array_subscription_expr
	| (PLUS | MINUS) expression										# unary_arithmetic_expr
	| (LOGICAL_NOT | BNOT_SYM) expression							# unary_bl_expr
	| RP (ID | data_type) LP expression								# casting_expr
	| ADDRESS_OF_OPERATOR expression								# address_of_expr
	| VALUE_INSIDE_OPERATOR expression								# indirection_of_expr
	| SIZE_OF expression											# size_of_expr
	| expression  DIVIDE expression									# multipy_expr
	| expression MULTIPLY expression								# divide_expr
	| expression MINUS expression									# subtract_expr
	| expression PLUS  expression									# add_expr
	| expression (SR_SYM | SL_SYMBOL) expression					# shift_expr
	| expression (GTE_SYM | LTE_SYM | GT_SYM | LT_SYM) expression	# comparative_expr
	| expression (EQUAL_SYM | NOTEQ_SYM) expression					# equality_expr
	| expression (BAND_SYM) expression								# band_expr
	| expression (BXOR_SYM) expression								# bxor_expr
	| expression (BOR_SYM) expression								# bor_expr
	| expression (LAND) expression									# land_expr
	| expression (LOR) expression									# lor_expr
	| RP expression LP												# parenth_expr
	| Literal														# literal_expr
	| ID															# identifier_expr;

argument_list: expression (FASLA expression)*;

statement:
	assignment_statement		# assignment_stat
	| return_statement			# return_stat
	| result_statement			# result_stat
	| if_statement				# if_stat
	| while_statement			# while_stat
	| var_declaration			# var_decl_stat
	| expression FASLA_MANQUOTA	# expre_stat;

assignment_statement:
	ID ASSIGN_SYM expression FASLA_MANQUOTA;


if_statement: IF_KEYWORD RP expression LP RCB statement* LCB;

while_statement:
	WHILE_KEYWORD RP expression LP RCB statement* LCB;

return_statement: RET_KEYWORD FASLA_MANQUOTA;

result_statement: RES_KEYWORD expression FASLA_MANQUOTA;

var_declaration:
	data_type ID (ASSIGN_SYM expression)? FASLA_MANQUOTA;

Literal:
	STRING_LITERAL
	| CHARACTER_LITERAL
	| ARABIC_INT_LITERAL
	| ENGLISH_INT_LITERAL;

LP: '(';
RP: ')';
LSB: '[';
RSB: ']';
LCB: '{';
RCB: '}';

// memory address operators
ADDRESS_OF_OPERATOR: 'عنوان:';
VALUE_INSIDE_OPERATOR: 'قيمة:';
SIZE_OF: 'حجم:';

// punctuation symbols.
DOT: '.';
FASLA: '،';
FASLA_MANQUOTA: '؛';
ARROW: '->';
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
SL_SYMBOL: '<<';
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
OPER_KEYWORD: 'عملية';

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
STRING_LITERAL:
	'"' (ESCAPED_CHARACTERS | ~('\u0022' | '\u0000'))* '"';

fragment ESCAPED_CHARACTERS: ('//' | '/"' | '/0');

CHARACTER_LITERAL:
	'\'' (ESCAPED_CHARACTERS | ~('\u0027' | '\u0000')) '\'';

WHITE_SPACE: [\u0020\u0009\u000A\u000B\u000C\u000D] -> skip;

ARABIC_INT_LITERAL: [٠-٩]+;
ENGLISH_INT_LITERAL: [0-9]+;

// Identifier regular expression.
ID: [a-zA-Zء-ي] [a-zA-Zء-ي0-9٠-٩_]*;

data_type:
	INT_DATA_TYPE
	| UINT_DATA_TYPE
	| BYTE_DATA_TYPE
	| UBYTE_DATA_TYPE
	| SHORT_DATA_TYPE
	| USHORT_DATA_TYPE
	| LONG_DATA_TYPE
	| ULONG_DATA_TYPE;