//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from G:\Development\QbCompiler\QbCompiler\grammars\QbScript.g4 by ANTLR 4.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace QbScript.Language {
using System;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6")]
[System.CLSCompliant(false)]
public partial class QbScriptParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		WS=25, RWORD=26, DIGIT=27, HEXINT=28, DECIMAL=29, EXPONENT=30, ID=31, 
		CHECKSUM=32, NSTRING=33, WSTRING=34, INT=35, FLOAT=36, NUMBER=37;
	public const int
		RULE_qbKey = 0, RULE_literal = 1, RULE_vec2 = 2, RULE_vec3 = 3, RULE_qbStruct = 4, 
		RULE_qbStructItem = 5, RULE_qbType = 6, RULE_qbStructLit = 7, RULE_qbStructArray = 8, 
		RULE_testLit = 9;
	public static readonly string[] ruleNames = {
		"qbKey", "literal", "vec2", "vec3", "qbStruct", "qbStructItem", "qbType", 
		"qbStructLit", "qbStructArray", "testLit"
	};

	private static readonly string[] _LiteralNames = {
		null, "'_'", "'('", "','", "')'", "'{'", "'}'", "'='", "';'", "'int'", 
		"'float'", "'string'", "'wstring'", "'vec2'", "'vec3'", "'struct'", "'array'", 
		"'<'", "'>'", "'qbkey'", "'qbkeyref'", "'stringptr'", "'qbkeystringqs'", 
		"'['", "']'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, "WS", "RWORD", "DIGIT", "HEXINT", "DECIMAL", "EXPONENT", "ID", "CHECKSUM", 
		"NSTRING", "WSTRING", "INT", "FLOAT", "NUMBER"
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

	public override string GrammarFileName { get { return "QbScript.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	static QbScriptParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

	public QbScriptParser(ITokenStream input)
		: base(input)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}
	public partial class QbKeyContext : ParserRuleContext {
		public QbKeyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_qbKey; } }
	 
		public QbKeyContext() { }
		public virtual void CopyFrom(QbKeyContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class QbKeyNullContext : QbKeyContext {
		public QbKeyNullContext(QbKeyContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitQbKeyNull(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class QbKeyCrcContext : QbKeyContext {
		public ITerminalNode CHECKSUM() { return GetToken(QbScriptParser.CHECKSUM, 0); }
		public QbKeyCrcContext(QbKeyContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitQbKeyCrc(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class QbKeyIdContext : QbKeyContext {
		public ITerminalNode ID() { return GetToken(QbScriptParser.ID, 0); }
		public QbKeyIdContext(QbKeyContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitQbKeyId(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public QbKeyContext qbKey() {
		QbKeyContext _localctx = new QbKeyContext(Context, State);
		EnterRule(_localctx, 0, RULE_qbKey);
		try {
			State = 23;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ID:
				_localctx = new QbKeyIdContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 20; Match(ID);
				}
				break;
			case CHECKSUM:
				_localctx = new QbKeyCrcContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 21; Match(CHECKSUM);
				}
				break;
			case T__0:
				_localctx = new QbKeyNullContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 22; Match(T__0);
				}
				break;
			default:
				throw new NoViableAltException(this);
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

	public partial class LiteralContext : ParserRuleContext {
		public LiteralContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_literal; } }
	 
		public LiteralContext() { }
		public virtual void CopyFrom(LiteralContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class LitIntContext : LiteralContext {
		public ITerminalNode INT() { return GetToken(QbScriptParser.INT, 0); }
		public LitIntContext(LiteralContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLitInt(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class LitQbKeyContext : LiteralContext {
		public QbKeyContext qbKey() {
			return GetRuleContext<QbKeyContext>(0);
		}
		public LitQbKeyContext(LiteralContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLitQbKey(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class LitFloatContext : LiteralContext {
		public ITerminalNode FLOAT() { return GetToken(QbScriptParser.FLOAT, 0); }
		public LitFloatContext(LiteralContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLitFloat(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class LitStructContext : LiteralContext {
		public QbStructContext qbStruct() {
			return GetRuleContext<QbStructContext>(0);
		}
		public LitStructContext(LiteralContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLitStruct(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class LitHexContext : LiteralContext {
		public ITerminalNode HEXINT() { return GetToken(QbScriptParser.HEXINT, 0); }
		public LitHexContext(LiteralContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLitHex(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class LitVec2Context : LiteralContext {
		public Vec2Context vec2() {
			return GetRuleContext<Vec2Context>(0);
		}
		public LitVec2Context(LiteralContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLitVec2(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class LitNStringContext : LiteralContext {
		public ITerminalNode NSTRING() { return GetToken(QbScriptParser.NSTRING, 0); }
		public LitNStringContext(LiteralContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLitNString(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class LitVec3Context : LiteralContext {
		public Vec3Context vec3() {
			return GetRuleContext<Vec3Context>(0);
		}
		public LitVec3Context(LiteralContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLitVec3(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class LitWStringContext : LiteralContext {
		public ITerminalNode WSTRING() { return GetToken(QbScriptParser.WSTRING, 0); }
		public LitWStringContext(LiteralContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLitWString(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LiteralContext literal() {
		LiteralContext _localctx = new LiteralContext(Context, State);
		EnterRule(_localctx, 2, RULE_literal);
		try {
			State = 34;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
			case 1:
				_localctx = new LitIntContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 25; Match(INT);
				}
				break;
			case 2:
				_localctx = new LitFloatContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 26; Match(FLOAT);
				}
				break;
			case 3:
				_localctx = new LitHexContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 27; Match(HEXINT);
				}
				break;
			case 4:
				_localctx = new LitQbKeyContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 28; qbKey();
				}
				break;
			case 5:
				_localctx = new LitVec2Context(_localctx);
				EnterOuterAlt(_localctx, 5);
				{
				State = 29; vec2();
				}
				break;
			case 6:
				_localctx = new LitVec3Context(_localctx);
				EnterOuterAlt(_localctx, 6);
				{
				State = 30; vec3();
				}
				break;
			case 7:
				_localctx = new LitNStringContext(_localctx);
				EnterOuterAlt(_localctx, 7);
				{
				State = 31; Match(NSTRING);
				}
				break;
			case 8:
				_localctx = new LitWStringContext(_localctx);
				EnterOuterAlt(_localctx, 8);
				{
				State = 32; Match(WSTRING);
				}
				break;
			case 9:
				_localctx = new LitStructContext(_localctx);
				EnterOuterAlt(_localctx, 9);
				{
				State = 33; qbStruct();
				}
				break;
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

	public partial class Vec2Context : ParserRuleContext {
		public ITerminalNode[] NUMBER() { return GetTokens(QbScriptParser.NUMBER); }
		public ITerminalNode NUMBER(int i) {
			return GetToken(QbScriptParser.NUMBER, i);
		}
		public Vec2Context(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_vec2; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVec2(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Vec2Context vec2() {
		Vec2Context _localctx = new Vec2Context(Context, State);
		EnterRule(_localctx, 4, RULE_vec2);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 36; Match(T__1);
			State = 37; Match(NUMBER);
			State = 38; Match(T__2);
			State = 39; Match(NUMBER);
			State = 40; Match(T__3);
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

	public partial class Vec3Context : ParserRuleContext {
		public ITerminalNode[] NUMBER() { return GetTokens(QbScriptParser.NUMBER); }
		public ITerminalNode NUMBER(int i) {
			return GetToken(QbScriptParser.NUMBER, i);
		}
		public Vec3Context(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_vec3; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVec3(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Vec3Context vec3() {
		Vec3Context _localctx = new Vec3Context(Context, State);
		EnterRule(_localctx, 6, RULE_vec3);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 42; Match(T__1);
			State = 43; Match(NUMBER);
			State = 44; Match(T__2);
			State = 45; Match(NUMBER);
			State = 46; Match(T__2);
			State = 47; Match(NUMBER);
			State = 48; Match(T__3);
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

	public partial class QbStructContext : ParserRuleContext {
		public QbStructItemContext[] qbStructItem() {
			return GetRuleContexts<QbStructItemContext>();
		}
		public QbStructItemContext qbStructItem(int i) {
			return GetRuleContext<QbStructItemContext>(i);
		}
		public QbStructContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_qbStruct; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitQbStruct(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public QbStructContext qbStruct() {
		QbStructContext _localctx = new QbStructContext(Context, State);
		EnterRule(_localctx, 8, RULE_qbStruct);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 50; Match(T__4);
			State = 52;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 51; qbStructItem();
				}
				}
				State = 54;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__8) | (1L << T__9) | (1L << T__10) | (1L << T__11) | (1L << T__12) | (1L << T__13) | (1L << T__14) | (1L << T__15) | (1L << T__18) | (1L << T__19) | (1L << T__20) | (1L << T__21))) != 0) );
			State = 56; Match(T__5);
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

	public partial class QbStructItemContext : ParserRuleContext {
		public string type;
		public QbTypeContext _qbType;
		public QbTypeContext qbType() {
			return GetRuleContext<QbTypeContext>(0);
		}
		public QbKeyContext qbKey() {
			return GetRuleContext<QbKeyContext>(0);
		}
		public QbStructLitContext qbStructLit() {
			return GetRuleContext<QbStructLitContext>(0);
		}
		public QbStructItemContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_qbStructItem; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitQbStructItem(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public QbStructItemContext qbStructItem() {
		QbStructItemContext _localctx = new QbStructItemContext(Context, State);
		EnterRule(_localctx, 10, RULE_qbStructItem);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 58; _localctx._qbType = qbType();
			_localctx.type = (_localctx._qbType!=null?TokenStream.GetText(_localctx._qbType.Start,_localctx._qbType.Stop):null);
			State = 60; qbKey();
			State = 61; Match(T__6);
			State = 62; qbStructLit(type:_localctx.type);
			State = 63; Match(T__7);
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

	public partial class QbTypeContext : ParserRuleContext {
		public QbTypeContext qbType() {
			return GetRuleContext<QbTypeContext>(0);
		}
		public QbTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_qbType; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitQbType(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public QbTypeContext qbType() {
		QbTypeContext _localctx = new QbTypeContext(Context, State);
		EnterRule(_localctx, 12, RULE_qbType);
		try {
			State = 81;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__8:
				EnterOuterAlt(_localctx, 1);
				{
				State = 65; Match(T__8);
				}
				break;
			case T__9:
				EnterOuterAlt(_localctx, 2);
				{
				State = 66; Match(T__9);
				}
				break;
			case T__10:
				EnterOuterAlt(_localctx, 3);
				{
				State = 67; Match(T__10);
				}
				break;
			case T__11:
				EnterOuterAlt(_localctx, 4);
				{
				State = 68; Match(T__11);
				}
				break;
			case T__12:
				EnterOuterAlt(_localctx, 5);
				{
				State = 69; Match(T__12);
				}
				break;
			case T__13:
				EnterOuterAlt(_localctx, 6);
				{
				State = 70; Match(T__13);
				}
				break;
			case T__14:
				EnterOuterAlt(_localctx, 7);
				{
				State = 71; Match(T__14);
				}
				break;
			case T__15:
				EnterOuterAlt(_localctx, 8);
				{
				State = 72; Match(T__15);
				State = 73; Match(T__16);
				State = 74; qbType();
				State = 75; Match(T__17);
				}
				break;
			case T__18:
				EnterOuterAlt(_localctx, 9);
				{
				State = 77; Match(T__18);
				}
				break;
			case T__19:
				EnterOuterAlt(_localctx, 10);
				{
				State = 78; Match(T__19);
				}
				break;
			case T__20:
				EnterOuterAlt(_localctx, 11);
				{
				State = 79; Match(T__20);
				}
				break;
			case T__21:
				EnterOuterAlt(_localctx, 12);
				{
				State = 80; Match(T__21);
				}
				break;
			default:
				throw new NoViableAltException(this);
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

	public partial class QbStructLitContext : ParserRuleContext {
		public string type;
		public QbStructLitContext(ParserRuleContext parent, int invokingState) : base(parent, invokingState) { }
		public QbStructLitContext(ParserRuleContext parent, int invokingState, string type)
			: base(parent, invokingState)
		{
			this.type = type;
		}
		public override int RuleIndex { get { return RULE_qbStructLit; } }
	 
		public QbStructLitContext() { }
		public virtual void CopyFrom(QbStructLitContext context) {
			base.CopyFrom(context);
			this.type = context.type;
		}
	}
	public partial class QbSSmallLitContext : QbStructLitContext {
		public ITerminalNode INT() { return GetToken(QbScriptParser.INT, 0); }
		public ITerminalNode FLOAT() { return GetToken(QbScriptParser.FLOAT, 0); }
		public QbKeyContext qbKey() {
			return GetRuleContext<QbKeyContext>(0);
		}
		public QbSSmallLitContext(QbStructLitContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitQbSSmallLit(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class QbSFloatLitContext : QbStructLitContext {
		public Vec2Context vec2() {
			return GetRuleContext<Vec2Context>(0);
		}
		public Vec3Context vec3() {
			return GetRuleContext<Vec3Context>(0);
		}
		public QbSFloatLitContext(QbStructLitContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitQbSFloatLit(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class QbSArrayLitContext : QbStructLitContext {
		public QbStructArrayContext qbStructArray() {
			return GetRuleContext<QbStructArrayContext>(0);
		}
		public QbSArrayLitContext(QbStructLitContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitQbSArrayLit(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class QbSBigLitContext : QbStructLitContext {
		public ITerminalNode NSTRING() { return GetToken(QbScriptParser.NSTRING, 0); }
		public ITerminalNode WSTRING() { return GetToken(QbScriptParser.WSTRING, 0); }
		public QbStructContext qbStruct() {
			return GetRuleContext<QbStructContext>(0);
		}
		public QbSBigLitContext(QbStructLitContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitQbSBigLit(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public QbStructLitContext qbStructLit(string type) {
		QbStructLitContext _localctx = new QbStructLitContext(Context, State, type);
		EnterRule(_localctx, 14, RULE_qbStructLit);
		try {
			State = 92;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,4,Context) ) {
			case 1:
				_localctx = new QbSSmallLitContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 83; Match(INT);
				}
				break;
			case 2:
				_localctx = new QbSSmallLitContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 84; Match(FLOAT);
				}
				break;
			case 3:
				_localctx = new QbSSmallLitContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 85; qbKey();
				}
				break;
			case 4:
				_localctx = new QbSFloatLitContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 86; vec2();
				}
				break;
			case 5:
				_localctx = new QbSFloatLitContext(_localctx);
				EnterOuterAlt(_localctx, 5);
				{
				State = 87; vec3();
				}
				break;
			case 6:
				_localctx = new QbSBigLitContext(_localctx);
				EnterOuterAlt(_localctx, 6);
				{
				State = 88; Match(NSTRING);
				}
				break;
			case 7:
				_localctx = new QbSBigLitContext(_localctx);
				EnterOuterAlt(_localctx, 7);
				{
				State = 89; Match(WSTRING);
				}
				break;
			case 8:
				_localctx = new QbSBigLitContext(_localctx);
				EnterOuterAlt(_localctx, 8);
				{
				State = 90; qbStruct();
				}
				break;
			case 9:
				_localctx = new QbSArrayLitContext(_localctx);
				EnterOuterAlt(_localctx, 9);
				{
				State = 91; qbStructArray(type:_localctx.type);
				}
				break;
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

	public partial class QbStructArrayContext : ParserRuleContext {
		public string type;
		public QbStructLitContext[] qbStructLit() {
			return GetRuleContexts<QbStructLitContext>();
		}
		public QbStructLitContext qbStructLit(int i) {
			return GetRuleContext<QbStructLitContext>(i);
		}
		public QbStructArrayContext(ParserRuleContext parent, int invokingState) : base(parent, invokingState) { }
		public QbStructArrayContext(ParserRuleContext parent, int invokingState, string type)
			: base(parent, invokingState)
		{
			this.type = type;
		}
		public override int RuleIndex { get { return RULE_qbStructArray; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitQbStructArray(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public QbStructArrayContext qbStructArray(string type) {
		QbStructArrayContext _localctx = new QbStructArrayContext(Context, State, type);
		EnterRule(_localctx, 16, RULE_qbStructArray);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 94; Match(T__22);
			State = 104;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__23:
				{
				}
				break;
			case T__0:
			case T__1:
			case T__4:
			case T__22:
			case ID:
			case CHECKSUM:
			case NSTRING:
			case WSTRING:
			case INT:
			case FLOAT:
				{
				State = 96; qbStructLit(type:_localctx.type);
				State = 101;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==T__2) {
					{
					{
					State = 97; Match(T__2);
					State = 98; qbStructLit(type:_localctx.type);
					}
					}
					State = 103;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 106; Match(T__23);
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

	public partial class TestLitContext : ParserRuleContext {
		public LiteralContext literal() {
			return GetRuleContext<LiteralContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(QbScriptParser.Eof, 0); }
		public TestLitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_testLit; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQbScriptVisitor<TResult> typedVisitor = visitor as IQbScriptVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTestLit(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TestLitContext testLit() {
		TestLitContext _localctx = new TestLitContext(Context, State);
		EnterRule(_localctx, 18, RULE_testLit);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 108; literal();
			State = 109; Match(Eof);
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

	private static string _serializedATN = _serializeATN();
	private static string _serializeATN()
	{
	    StringBuilder sb = new StringBuilder();
	    sb.Append("\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x3\'r");
		sb.Append("\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a");
		sb.Append("\t\a\x4\b\t\b\x4\t\t\t\x4\n\t\n\x4\v\t\v\x3\x2\x3\x2\x3\x2\x5");
		sb.Append("\x2\x1A\n\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3");
		sb.Append("\x3\x3\x5\x3%\n\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5");
		sb.Append("\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x6\x6");
		sb.Append("\x37\n\x6\r\x6\xE\x6\x38\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3");
		sb.Append("\a\x3\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3");
		sb.Append("\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x5\bT\n\b\x3\t\x3\t\x3\t\x3");
		sb.Append("\t\x3\t\x3\t\x3\t\x3\t\x3\t\x5\t_\n\t\x3\n\x3\n\x3\n\x3\n\x3");
		sb.Append("\n\a\n\x66\n\n\f\n\xE\ni\v\n\x5\nk\n\n\x3\n\x3\n\x3\v\x3\v\x3");
		sb.Append("\v\x3\v\x2\x2\f\x2\x4\x6\b\n\f\xE\x10\x12\x14\x2\x2\x87\x2\x19");
		sb.Append("\x3\x2\x2\x2\x4$\x3\x2\x2\x2\x6&\x3\x2\x2\x2\b,\x3\x2\x2\x2");
		sb.Append("\n\x34\x3\x2\x2\x2\f<\x3\x2\x2\x2\xES\x3\x2\x2\x2\x10^\x3\x2");
		sb.Append("\x2\x2\x12`\x3\x2\x2\x2\x14n\x3\x2\x2\x2\x16\x1A\a!\x2\x2\x17");
		sb.Append("\x1A\a\"\x2\x2\x18\x1A\a\x3\x2\x2\x19\x16\x3\x2\x2\x2\x19\x17");
		sb.Append("\x3\x2\x2\x2\x19\x18\x3\x2\x2\x2\x1A\x3\x3\x2\x2\x2\x1B%\a%");
		sb.Append("\x2\x2\x1C%\a&\x2\x2\x1D%\a\x1E\x2\x2\x1E%\x5\x2\x2\x2\x1F%");
		sb.Append("\x5\x6\x4\x2 %\x5\b\x5\x2!%\a#\x2\x2\"%\a$\x2\x2#%\x5\n\x6\x2");
		sb.Append("$\x1B\x3\x2\x2\x2$\x1C\x3\x2\x2\x2$\x1D\x3\x2\x2\x2$\x1E\x3");
		sb.Append("\x2\x2\x2$\x1F\x3\x2\x2\x2$ \x3\x2\x2\x2$!\x3\x2\x2\x2$\"\x3");
		sb.Append("\x2\x2\x2$#\x3\x2\x2\x2%\x5\x3\x2\x2\x2&\'\a\x4\x2\x2\'(\a\'");
		sb.Append("\x2\x2()\a\x5\x2\x2)*\a\'\x2\x2*+\a\x6\x2\x2+\a\x3\x2\x2\x2");
		sb.Append(",-\a\x4\x2\x2-.\a\'\x2\x2./\a\x5\x2\x2/\x30\a\'\x2\x2\x30\x31");
		sb.Append("\a\x5\x2\x2\x31\x32\a\'\x2\x2\x32\x33\a\x6\x2\x2\x33\t\x3\x2");
		sb.Append("\x2\x2\x34\x36\a\a\x2\x2\x35\x37\x5\f\a\x2\x36\x35\x3\x2\x2");
		sb.Append("\x2\x37\x38\x3\x2\x2\x2\x38\x36\x3\x2\x2\x2\x38\x39\x3\x2\x2");
		sb.Append("\x2\x39:\x3\x2\x2\x2:;\a\b\x2\x2;\v\x3\x2\x2\x2<=\x5\xE\b\x2");
		sb.Append("=>\b\a\x1\x2>?\x5\x2\x2\x2?@\a\t\x2\x2@\x41\x5\x10\t\x2\x41");
		sb.Append("\x42\a\n\x2\x2\x42\r\x3\x2\x2\x2\x43T\a\v\x2\x2\x44T\a\f\x2");
		sb.Append("\x2\x45T\a\r\x2\x2\x46T\a\xE\x2\x2GT\a\xF\x2\x2HT\a\x10\x2\x2");
		sb.Append("IT\a\x11\x2\x2JK\a\x12\x2\x2KL\a\x13\x2\x2LM\x5\xE\b\x2MN\a");
		sb.Append("\x14\x2\x2NT\x3\x2\x2\x2OT\a\x15\x2\x2PT\a\x16\x2\x2QT\a\x17");
		sb.Append("\x2\x2RT\a\x18\x2\x2S\x43\x3\x2\x2\x2S\x44\x3\x2\x2\x2S\x45");
		sb.Append("\x3\x2\x2\x2S\x46\x3\x2\x2\x2SG\x3\x2\x2\x2SH\x3\x2\x2\x2SI");
		sb.Append("\x3\x2\x2\x2SJ\x3\x2\x2\x2SO\x3\x2\x2\x2SP\x3\x2\x2\x2SQ\x3");
		sb.Append("\x2\x2\x2SR\x3\x2\x2\x2T\xF\x3\x2\x2\x2U_\a%\x2\x2V_\a&\x2\x2");
		sb.Append("W_\x5\x2\x2\x2X_\x5\x6\x4\x2Y_\x5\b\x5\x2Z_\a#\x2\x2[_\a$\x2");
		sb.Append("\x2\\_\x5\n\x6\x2]_\x5\x12\n\x2^U\x3\x2\x2\x2^V\x3\x2\x2\x2");
		sb.Append("^W\x3\x2\x2\x2^X\x3\x2\x2\x2^Y\x3\x2\x2\x2^Z\x3\x2\x2\x2^[\x3");
		sb.Append("\x2\x2\x2^\\\x3\x2\x2\x2^]\x3\x2\x2\x2_\x11\x3\x2\x2\x2`j\a");
		sb.Append("\x19\x2\x2\x61k\x3\x2\x2\x2\x62g\x5\x10\t\x2\x63\x64\a\x5\x2");
		sb.Append("\x2\x64\x66\x5\x10\t\x2\x65\x63\x3\x2\x2\x2\x66i\x3\x2\x2\x2");
		sb.Append("g\x65\x3\x2\x2\x2gh\x3\x2\x2\x2hk\x3\x2\x2\x2ig\x3\x2\x2\x2");
		sb.Append("j\x61\x3\x2\x2\x2j\x62\x3\x2\x2\x2kl\x3\x2\x2\x2lm\a\x1A\x2");
		sb.Append("\x2m\x13\x3\x2\x2\x2no\x5\x4\x3\x2op\a\x2\x2\x3p\x15\x3\x2\x2");
		sb.Append("\x2\t\x19$\x38S^gj");
	    return sb.ToString();
	}

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());


}
} // namespace QbScript.Language