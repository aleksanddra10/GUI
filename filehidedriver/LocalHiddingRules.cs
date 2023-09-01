using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filehidedriver
{
    class LocalHiddingRules
    {
        private String Name;
        private String Rule;
        public LocalHiddingRules()
        {
            Name = "";
            Rule = "";
        }
        public LocalHiddingRules(String name,String rule) 
        {
            Name =name;
            this.Rule =rule;
        }
        public String getFolderName()
        {
            return Name;
        }
        public String getRule()
        {
            return Rule;
        }
        public void setFolderName(String name)
        {
            Name = name;
        }
        public void setRule(String rule)
        {
            this.Rule = rule;
        }
    }
}
