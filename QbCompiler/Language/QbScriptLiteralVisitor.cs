using System;
using System.Collections.Generic;
using System.Data.HashFunction;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using QbScript.Language.AST;

namespace QbScript.Language
{
    class QbScriptLiteralVisitor : QbScriptBaseVisitor<Literal>
    {
        private static CRC QbCrc;

        static QbScriptLiteralVisitor()
        {
            var settings = new CRC.Setting(32, 0x4C11DB7, 0xFFFFFFFF, true, true, 0x0);
            QbCrc = new CRC(settings);
        }

        public override Literal VisitLitInt(QbScriptParser.LitIntContext context)
        {
            var val = int.Parse(context.INT().GetText());

            Console.WriteLine(val);

            return new LitInt(val);
        }

        public override Literal VisitLitFloat(QbScriptParser.LitFloatContext context)
        {
            var val = float.Parse(context.FLOAT().GetText());

            Console.WriteLine(val);

            return new LitFloat(val);
        }

        public override Literal VisitLitHex(QbScriptParser.LitHexContext context)
        {
            var val = Convert.ToUInt32(context.HEXINT().GetText(), 16);

            Console.WriteLine(val);

            return new LitHex(val);
        }

        public override Literal VisitLitQbKey(QbScriptParser.LitQbKeyContext context)
        {
            var val = this.Visit(context.qbKey());

            if (!(val is LitQbKey))
            {
                // Handle invalid lower parse somehow?
            }


            Console.WriteLine("QbKey {0}", (val as LitQbKey)?.Value);

            return val;
        }

        public override Literal VisitLitNString(QbScriptParser.LitNStringContext context)
        {
            var val = context.NSTRING().GetText();

            Console.WriteLine("'{0}'", val);

            return new LitNString(val);
        }

        public override Literal VisitLitWString(QbScriptParser.LitWStringContext context)
        {
            var val = context.WSTRING().GetText();

            Console.WriteLine("\"{0}\"", val);

            return new LitWString(val);
        }

        public override Literal VisitLitVec2(QbScriptParser.LitVec2Context context)
        {
            return Visit(context.vec2());
        }

        public override Literal VisitLitVec3(QbScriptParser.LitVec3Context context)
        {
            return Visit(context.vec3());
        }

        public override Literal VisitVec2(QbScriptParser.Vec2Context context)
        {
            float x = float.Parse(context.x.GetText());
            float y = float.Parse(context.y.GetText());

            Console.WriteLine("({0},{1})", x, y);

            return new LitVec2(x, y);
        }

        public override Literal VisitVec3(QbScriptParser.Vec3Context context)
        {
            float x = float.Parse(context.x.GetText());
            float y = float.Parse(context.y.GetText());
            float z = float.Parse(context.z.GetText());

            Console.WriteLine("({0},{1},{2})", x, y, z);

            return new LitVec3(x, y, z);
        }

        public override Literal VisitLitStruct(QbScriptParser.LitStructContext context)
        {
            Console.WriteLine("Struct (unimplemented)");
            return base.VisitLitStruct(context);
        }

        public override Literal VisitQbKeyCrc(QbScriptParser.QbKeyCrcContext context)
        {
            uint crc = Convert.ToUInt32(context.CHECKSUM().GetText(), 16);

            return new LitQbKey(crc);
        }

        public override Literal VisitQbKeyId(QbScriptParser.QbKeyIdContext context)
        {
            var stringBytes = Encoding.ASCII.GetBytes(context.ID().GetText());
            var hashBytes = QbCrc.ComputeHash(stringBytes);
            var crc = BitConverter.ToUInt32(hashBytes, 0);

            return new LitQbKey(crc);
        }

        public override Literal VisitQbKeyNull(QbScriptParser.QbKeyNullContext context)
        {
            return new LitQbKey(0);
        }

        public override Literal VisitTestLit(QbScriptParser.TestLitContext context)
        {

            return Visit(context.literal());
        }
    }
}
