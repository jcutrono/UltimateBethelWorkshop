namespace OOP_Console
{
    public interface IMyClass
    {
        string Foo();
        string Bar();
    }

    public abstract class BaseMyClass : IMyClass
    {
        public string Foo()
        {
            return "foo";
        }

        public abstract string Bar();
    }

    public class MyClass : BaseMyClass
    {
        public override string Bar()
        {
            return "bar";
        }
    }

    public class MyClass2 : BaseMyClass
    {
        public override string Bar()
        {
            return "bar2";
        }
    }
}