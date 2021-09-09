using UnityEngine;




public class Example
{
    public int Test;
}

namespace Geekbrains
{


    
    public class Example
    {
        public string Test;
        private int height;

        public Example()
        {
            Test = "test";
            Height = 20;
        }

        public int Height { get => height; set => height = value; }
    }
    
    
    namespace MyNamespace.Geekbrains
    {
        public class Example
        {
            public float Test;
        }
    }
    
    public class Test : MonoBehaviour
    {
        private void Start()
        {
            Example Test1 = new Example();
            Debug.Log(Test1.Test);

            Geekbrains.MyNamespace.Geekbrains.Example example1 = new MyNamespace.Geekbrains.Example();
            
            Geekbrains.Example example2 = new Example();
            
            global::Example example3 = new global::Example();
        }
    }
}
