using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QbScript.Language.AST
{
    public class LitVec2 : Literal
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public LitVec2(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
