using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Field
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"public {Type} {Name}";
        }
    }

    public class CreatedClass
    {
        public string Name { get; set; }
        public List<Field> Fields { get; set; }

    }

    public class CodeBuilder
    {
        private CreatedClass generatedClass { get; set; }

        public CodeBuilder(string rootName)
        {
            generatedClass.Name = rootName;
        }

        public CodeBuilder AddField(string name, string type)
        {
            generatedClass.Fields.Add(new Field { Name = name, Type = type });

            return this;
        }

        public CodeBuilder ChangeClassName(string name)
        {
            generatedClass.Name = name;

            return this;
        }
    }
}
