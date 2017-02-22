/** Grammar to parse a QbScript.  The input to the lexer should be transformed
    to all lower-case as the language is case-insensitive.
    Language target: C#. */
grammar QbScript;

WS : [ \n\t\r] -> skip;

/** Language keywords that should not be lexed as ID tokens */
RWORD : 'if' | 'else' | 'elif' | 'elseif' | 'repeat' | 'switch' | 'case'
      | 'default' | 'goto_random' | 'script';

fragment LETTER : [A-Za-z];
DIGIT : [0-9];
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
NUMBER : INT | FLOAT;

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

vec2 : '(' NUMBER ',' NUMBER ')';
vec3 : '(' NUMBER ',' NUMBER ',' NUMBER ')';

qbStruct : '{' qbStructItem+ '}';
qbStructItem locals[string type]
  : qbType {$type=$qbType.text;} qbKey '=' qbStructLit[type:$type] ';';
qbType : 'int' | 'float' | 'string' | 'wstring' | 'vec2' | 'vec3' | 'struct'
       | 'array' '<' qbType '>' | 'qbkey' | 'qbkeyref' | 'stringptr'
       | 'qbkeystringqs';

qbStructLit[string type]
       : INT                       # qbSSmallLit
       | FLOAT                     # qbSSmallLit
       | qbKey                     # qbSSmallLit
       | vec2                      # qbSFloatLit
       | vec3                      # qbSFloatLit
       | NSTRING                   # qbSBigLit
       | WSTRING                   # qbSBigLit
       | qbStruct                  # qbSBigLit
       | qbStructArray[type:$type] # qbSArrayLit;

qbStructArray[string type] : '[' (|qbStructLit[type:$type] (',' qbStructLit[type:$type])*) ']';

testLit : literal EOF;

/*
qbScript : scriptDecl block EOF;
scriptDecl : SCRIPT '(' qbStruct? ')';
block : '{' stmt* '}';
*/