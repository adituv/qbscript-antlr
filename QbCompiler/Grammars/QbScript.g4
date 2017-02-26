/** Grammar to parse a QbScript.  The input to the lexer should be transformed
    to all lower-case as the language is case-insensitive.
    Language target: C#. */
grammar QbScript;

WS : [ \n\t\r] -> skip;

/** Language keywords that should not be lexed as ID tokens */
RWORD : 'if' | 'else' | 'elif' | 'elseif' | 'repeat' | 'switch' | 'case'
      | 'default' | 'goto_random' | 'script';

fragment LETTER : [A-Za-z];
fragment DIGIT : [0-9];
HEXINT : ('0X'|'0x') HEXDIGIT+;
fragment HEXDIGIT : [0-9A-Fa-f]+;

DECIMAL : '.' DIGIT+;
EXPONENT : [eE] [+-]? DIGIT+;

ID : LETTER (LETTER|DIGIT|'_')*;
CHECKSUM : '$' HEXDIGIT HEXDIGIT HEXDIGIT HEXDIGIT HEXDIGIT HEXDIGIT HEXDIGIT HEXDIGIT;
NSTRING : '\'' ( '\\\'' | ~[\'\r\n] )* '\'';
WSTRING : '"' ('\"' | ~["\r\n])* '"';

INT: ('+'|'-')? DIGIT+;
FLOAT : ('+'|'-')? (DIGIT* DECIMAL EXPONENT? | DIGIT+ EXPONENT);
number : INT | FLOAT;

qbKey : ID         # QbKeyId
      | CHECKSUM   # QbKeyCrc
      | '_'        # QbKeyNull
      ;

literal : INT      # litInt
        | FLOAT    # litFloat
        | HEXINT   # litHex
        | qbKey    # litQbKey
        | vec2     # litVec2
        | vec3     # litVec3 
        | NSTRING  # litNString
        | WSTRING  # litWString
        | qbStruct # litStruct
        ;

vec2 : '(' x=number ',' y=number ')';
vec3 : '(' x=number ',' y=number ',' z=number ')';

qbStruct : '{' qbStructItem+ '}';
qbStructItem : qbType qbKey '=' qbStructLit ';';
qbType : 'int' | 'float' | 'string' | 'wstring' | 'vec2' | 'vec3' | 'struct'
       | 'array' '<' qbType '>' | 'qbkey' | 'qbkeyref' | 'stringptr'
       | 'qbkeystringqs';

qbStructLit
       : INT           # qbSSmallLit
       | FLOAT         # qbSSmallLit
       | qbKey         # qbSSmallLit
       | vec2          # qbSFloatLit
       | vec3          # qbSFloatLit
       | NSTRING       # qbSBigLit
       | WSTRING       # qbSBigLit
       | qbStruct      # qbSBigLit
       | qbStructArray # qbSArrayLit;

qbStructArray : '[' (|qbStructLit (',' qbStructLit)*) ']';

testLit : literal EOF;

/*
qbScript : scriptDecl block EOF;
scriptDecl : SCRIPT '(' qbStruct? ')';
block : '{' stmt* '}';
*/