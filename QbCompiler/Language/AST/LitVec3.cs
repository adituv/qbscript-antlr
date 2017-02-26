using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QbScript.Language.AST
{
    public class LitVec3 : Literal
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        public float Z { get; private set; }

        public LitVec3(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
