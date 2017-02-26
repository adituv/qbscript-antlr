using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QbScript.Language.AST
{
    public class LitFloat : Literal
    {
        public float Value { get; private set; }

        public LitFloat(float value)
        {
            this.Value = value;
        }
    }
}
