namespace Adobe
{
    public class Base
    {
        public int baseProp;

        public virtual void BaseMethod(string a)
        {
        }

        public virtual void BaseMethod(string a, string b)
        {
        }
    }

    public class SubClass : Base
    {
        public override void BaseMethod(string a)
        {
        }
    }
}