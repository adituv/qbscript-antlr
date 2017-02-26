namespace QbScript.Language.AST
{
    public class LitHex : Literal
    {
        public uint Value { get; private set; }

        public LitHex(uint val) {
            this.Value = val;
        }
    }
}