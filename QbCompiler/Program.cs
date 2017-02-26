using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

using QbScript.Language;
using QbScript.Language.AST;

namespace QbScript
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            while (!string.IsNullOrWhiteSpace(s))
            {
                AntlrInputStream inStream = new AntlrInputStream(s);
                QbScriptLexer lex = new QbScriptLexer(inStream);
                CommonTokenStream lToks = new CommonTokenStream(lex);
                QbScriptParser par = new QbScriptParser(lToks);
                par.BuildParseTree = true;
                
                QbScriptLiteralVisitor vis = new QbScriptLiteralVisitor();
                var lit = vis.Visit(par.testLit());
                
                s = Console.ReadLine();
            }
        }
    }
}
