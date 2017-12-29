using System;

namespace CSharpClassDemo.Inheritance
{
    class Child : Parent,IParents,IGrandParents
    {
        public void Getbenifits()
        {
            Caring("two");
        }
        public int TakeMoney()
        {
            return GiveMoney();
        }
        public int UseAssets()
        {
            return GoodName();
        }
    }
}
