using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challange1
{
    public class MysteryBox
    {

        string _label;
        string _contains;
        bool _isExplosive;


        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }
        public string Contains
        {
            get { return _contains; }
            set { _contains = value; }
        }
        public bool IsExplosive
        {
            get { return _isExplosive; }
            set { _isExplosive = value; }
        }


        public MysteryBox(string label, string contains, bool isExplosive) 
        {
            _label = label;
            _contains = contains;
            _isExplosive = isExplosive;
        
        
        }


        public override string ToString()
        {
            return $"{Label}, {Contains}, {IsExplosive}:";
        }

    }
}
