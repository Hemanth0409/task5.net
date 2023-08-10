using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class CustomAttribute
    {
        [AttributeUsage(AttributeTargets.Method
            | AttributeTargets.Constructor
            | AttributeTargets.Class
            | AttributeTargets.Property, AllowMultiple = true)]
        public class DeveloperWorkingAttribute : Attribute
        {
            private int id;
            private string name;
            public string dept;

            public DeveloperWorkingAttribute(int Id, string Name)
            {
                id = Id;
                name = Name;
            }
            public string Dept
            {
                get { return dept; }
                set { dept = value; }
            }

            [DeveloperWorking(1, "Hemanth")]
            public class Working
            {
                [DeveloperWorking(4, "darshan")]
                public string name { get; set; }

                [DeveloperWorking(3, "srikanth", Dept = "hr")]
                public Working()
                {

                }
                [DeveloperWorking(2, "Harshan", Dept = "Designer")]
                public void CustomMethod()
                {
                    name = "Sharon";
                }
                public static void AttributeDisplay(Type classType)
                {
                    Console.WriteLine($"Class: (className:{classType.Name})");
                    foreach (object attribute in classType.GetCustomAttributes(true))
                    {
                        DeveloperWorkingAttribute dev = (DeveloperWorkingAttribute)attribute;
                        if (null != dev)
                        {
                            Console.WriteLine("Employee: {0}-{1}", dev.id,dev.name);   
                        }
                    }
                    Console.WriteLine("Method {0}", classType.Name);
                    MethodInfo[] methods = classType.GetMethods();
                    for (int i = 0; i < methods.GetLength(0); i++)
                    {
                        object[] attributesArray = methods[i].GetCustomAttributes(true);
                        foreach (Attribute attribute in attributesArray)
                        {
                            if (attribute is DeveloperWorkingAttribute)
                            {
                                DeveloperWorkingAttribute attribute2 = (DeveloperWorkingAttribute)attribute;
                                Console.WriteLine("{0}-{1},{2},{3}", methods[i].Name, attribute2.id, attribute2.name, attribute2.dept);
                            }
                        }
                    }
                    Console.WriteLine("Properties {0}", classType.Name);
                    PropertyInfo[] methods1 = classType.GetProperties();
                    for (int i = 0; i < methods1.GetLength(0); i++)
                    {
                        object[] attributesArray = methods1[i].GetCustomAttributes(true);
                        foreach (Attribute attribute in attributesArray)
                        {
                            if (attribute is DeveloperWorkingAttribute)
                            {
                                DeveloperWorkingAttribute attribute3 = (DeveloperWorkingAttribute)attribute;
                                Console.WriteLine("{0}-{1},{2},{3}", methods1[i].Name, attribute3.id, attribute3.name, attribute3.dept);
                            }
                        }
                    }
                    Console.WriteLine("Constructor {0}", classType.Name);
                    ConstructorInfo[] methods2 = classType.GetConstructors();
                    for (int i = 0; i < methods2.GetLength(0); i++)
                    {
                        object[] attributesArray = methods2[i].GetCustomAttributes(true);
                        foreach (Attribute attribute in attributesArray)
                        {
                            if (attribute is DeveloperWorkingAttribute)
                            {
                                DeveloperWorkingAttribute attribute2 = (DeveloperWorkingAttribute)attribute;
                                Console.WriteLine("{0}-{1},{2},{3}", methods2[i].Name, attribute2.id, attribute2.name, attribute2.dept);
                            }
                        }
                    }
                }
                static void Main(string[] args)
                {
                    DeveloperWorkingAttribute ne = new DeveloperWorkingAttribute(11,"sdf");
                    Console.WriteLine(ne.name);

                    Working.AttributeDisplay(typeof(Working));
                    Console.ReadKey();
                }
            }

        }
    }
}

