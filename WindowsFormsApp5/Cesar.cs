using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шифр_Цезаря
{

    class Cesar : System.Collections.Generic.List<Class1>
    {
        public Cesar()
        {
            this.Add(new Class1("abcdefghijklmnopqrstuvwxyz"));
            this.Add(new Class1("ABCDIFGHIJKLMNOPQRSTUVWXYZ"));
            this.Add(new Class1("абвгдеёжзийклмнопрстуфхцшщъыьэюя"));
            this.Add(new Class1("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦШЩЪЫЬЭЮЯ"));
            this.Add(new Class1("0123456789"));
            this.Add(new Class1("!\"#$%^&*().,|/`~№:;@[]{}"));
        }


        internal string Codec(string m, int key)
        {
            string res = "", tmp = "";
            for (int i = 0; i < m.Length; i++)
            {
                foreach (Class1 v in this)
                {
                    tmp = v.Repl(m.Substring(i, 1), key);
                    if (tmp != "")
                    {
                        res += tmp;
                        break;
                    }
                }
                if (tmp == "") res += m.Substring(i, 1);
            }
            return res;
        }
    }
}

    class Class1
    {
        string le;
        public Class1(string m)
        {
            le = m;
        }
        public string Repl(string m, int key)
        {
            int pos = le.IndexOf(m);
            if (pos == -1) return "";
            pos = (pos + key) % le.Length;
            if (pos < 0) pos += le.Length;
            return le.Substring(pos, 1);
        }
    }