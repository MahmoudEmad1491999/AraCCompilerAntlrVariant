grammar AraC;

programm:;

expression:
	expression ('×' | '÷') expression
	| expression ( '+' | '-') expression
	| '(' expression ')'
	| Literal;

Literal:
	STRING_LITERAL
	| CHARACTER_LITERAL
	| ARABIC_INT_LITERAL
	| ENGLISH_INT_LITERAL;
program:
	(
		STRING_LITERAL
		| CHARACTER_LITERAL
		| IDENTIFIER
		| ARABIC_INT_LITERAL
		| ENGLISH_INT_LITERAL
		| LEFT_BOW
		| RIGHT_BOW
		| LEFT_SQUARE
		| RIGHT_SQUARE
		| LEFT_CURLY
		| RIGHT_CURLY
		| PLUS
		| MINUS
		| MULTIPLY
		| DIVIDE
		| ARABIC_MODULS
		| SHIFT_LEFT
		| SHIFT_RIGHT_ARITHMETIC
		| SHIFT_RIGHT
		| LESS_THAN_EQUAL
		| GREATER_THAN_EQUAL
		| LEFT_ANGLE
		| RIGHT_ANGLE
		| EQUAL
		| NOT_EQUAL
		| ASSIGN
		| DOT
		| FASLA
		| FASLA_MANQUOTA
	)* EOF;

LEFT_BOW: '(';
RIGHT_BOW: ')';
LEFT_SQUARE: '[';
RIGHT_SQUARE: ']';
LEFT_CURLY: '{';
RIGHT_CURLY: '}';
// mathimatical symbols.
PLUS: '+';
MINUS: '-';
MULTIPLY: '×';
DIVIDE: '÷';
ARABIC_MODULS: '٪';
MODULUS: '%';

// Bitwise symbols.
SHIFT_LEFT: '<<';
SHIFT_RIGHT_ARITHMETIC: '>>>';
SHIFT_RIGHT: '>>';
BITWISE_AND: '&';
BITWISE_OR: '|';
BITWISE_XOR: '^';

// Relational symbols.
LESS_THAN_EQUAL: '<=';
GREATER_THAN_EQUAL: '>=';
LEFT_ANGLE: '<';
RIGHT_ANGLE: '>';
EQUAL: '==';
NOT_EQUAL: '!=';

// operative symbols.
ASSIGN: ':=';

// punctuation symbols.
DOT: '.';
FASLA: '،';
FASLA_MANQUOTA: '؛';

// keywords
FUNCTION: 'دالة';
OPERATION: 'عملية';

RETURN_KEYWORD: 'رجوع';
RESULT_KEYWORD: 'الناتج';

IF_KEYWORD: 'إذا' | 'اذا';
WHILE_KEYWORD: 'طالما';

BREAK_KEYWORD: 'قطع';
CONTINUE_KEYWORRD: 'تخظى' | 'تخطي';

INT_DATA_TYPE: 'صحيح';
UINT_DATA_TYPE: 'طبيعي';

BYTE_KEYWORD: 'صحيح_١';
UBYTE_KEYWORD: 'طبيعي_١';

SHORT_KEYWORD: 'صحيح_٢';
USHORT_KEYWORD: 'طبيعي_٢';

LONG_KEYWORD: 'صحيح_٨';
ULONG_KEYWORD: 'طبيعي_٨';

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
IDENTIFIER: [a-zA-Zا-ي] [a-zA-Zا-ي0-9٠-٩_]*;