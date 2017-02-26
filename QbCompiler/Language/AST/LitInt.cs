namespace QbScript.Language.AST
{
    public class LitInt : Literal
    {
        public int Value { get; private set; }

        public LitInt(int val) {
            this.Value = val;
        }
    }
}