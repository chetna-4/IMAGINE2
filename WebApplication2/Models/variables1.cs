using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class variables
    {
        public List<Variable> variableList = new List<Variable>();
        public int count = 1;

        public Variable Getuser(int id)
        {
            Variable varmod = null;
            foreach (Variable vm in variableList)
                if (vm.Id== id)
                    varmod = vm;
            return varmod;
        }

        public void CreateVar(Variable varmod)
        {

            varmod.Id = count;
            count++;
            varmod.Name = "String";
            varmod.DataType = "String";
            variableList.Add(varmod);
        }
    }
}