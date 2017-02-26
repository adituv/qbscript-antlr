using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QbScript.Language.AST
{
    public class LitNString : Literal
    {
        public string Value { get; private set; }

        public LitNString(string value)
        {
            this.Value = value;
        }
    }
}
