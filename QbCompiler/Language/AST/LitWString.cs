using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QbScript.Language.AST
{
    public class LitWString : Literal
    {
        public string Value { get; private set; }

        public LitWString(string value)
        {
            this.Value = value;
        }
    }
}
