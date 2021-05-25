using System;
using System.Collections.Generic;
using System.Text;
using static MorseCodeParser.Program;

namespace MorseCodeParser
{
    public class MorseTree
    {
        private Node Root;

        public MorseTree()
        {
            var root = new Node("");

            var e = new Node("E");
            root.DotNode = e;

            var i = new Node("I");
            e.DotNode = i;

            var u = new Node("U");
            i.DashNode = u;

            var f = new Node("F");
            u.DotNode = f;

            var uUmluat = new Node("Ü");
            u.DashNode = uUmluat;

            var s = new Node("S");
            i.DotNode = s;

            var h = new Node("H");
            s.DotNode = h;

            var v = new Node("V");
            s.DashNode = v;

            var a = new Node("A");
            e.DashNode = a;

            var r = new Node("R");
            a.DotNode = r;

            var l = new Node("L");
            r.DotNode = l;

            var aUmlaut = new Node("Ä");
            r.DashNode = aUmlaut;

            var w = new Node("W");
            a.DashNode = w;

            var p = new Node("P");
            w.DotNode = p;

            var j = new Node("J");
            w.DashNode = j;

            var t = new Node("T");
            root.DashNode = t;

            var n = new Node("N");
            t.DotNode = n;

            var d = new Node("D");
            n.DotNode = d;

            var b = new Node("B");
            d.DotNode = b;

            var x = new Node("X");
            d.DashNode = x;

            var k = new Node("K");
            n.DashNode = k;

            var c = new Node("C");
            k.DotNode = c;

            var y = new Node("Y");
            k.DashNode = y;

            var m = new Node("M");
            t.DashNode = m;

            var g = new Node("G");
            m.DotNode = g;

            var z = new Node("Z");
            g.DotNode = z;

            var q = new Node("Q");
            g.DashNode = q;

            var o = new Node("O");
            m.DashNode = o;

            var oOmlaut = new Node("Ö");
            o.DotNode = oOmlaut;

            var sCedilla = new Node("Ş");
            o.DashNode = sCedilla;

            Root = root;
        }       

        public string Parse(string word)
        {
            StringBuilder sb = new StringBuilder();

            var currentNode = Root;


            foreach (var code in word)
            {
                try
                {
                    parseChar(code, ref currentNode, sb);
                }
                catch (ArgumentException)
                {
                    return "Invalid morse string";                
                }
            }

            // make sure we add the last char if the word
            if (currentNode != Root)
            {
                sb.Append(currentNode.Value);
            }            

            return sb.ToString().ToLower();
        }

        private void parseChar(char c, ref Node currentNode, StringBuilder sb)
        {
            switch (c)
            {
                case '-':
                    currentNode = currentNode.DashNode;
                    break;
                case '.':
                    currentNode = currentNode.DotNode;
                    break;
                case '/':
                    sb.Append(" ");
                    currentNode = Root;
                    break;
                case ' ':
                    if (currentNode.Value != null)
                    {
                        sb.Append(currentNode.Value);
                    }

                    currentNode = Root;
                    break;
                default:
                    throw new ArgumentException("A morse code only consists of dot, hyphen, space or slash for new word");
            }
        }
    }
}
