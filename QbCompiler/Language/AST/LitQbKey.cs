using System;

namespace QbScript.Language.AST
{
    public class LitQbKey : Literal
    {
        public uint Value { get; private set; }

        public LitQbKey(uint val) {
            this.Value = val;
        }
    }
}