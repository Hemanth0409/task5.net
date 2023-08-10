using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    /// <summary>
    /// 
    /// </summary>
    /// WE can view in Ildasm 
    /// webmethod,flag,serilizable,
    /// ATRB  Obsolete:- is use to updating the application 
    /// it will be in the Application but it can not be used 
    /// CTS- data types
    /// CLS-specification   
    /// CLS- compliantAttribute appiled to entire assembly
    /// CLS complaint is used check the entiry namespace whether the code is written in 
    /// C# format .
    /// Managed Code-The code that run with CLR
    ///Optional parameter can be assssigned at the end of the declaration
    ///custom  attribute:
    ///Attribute :Meta data
    ///Reflection is used to target the attribute and get the information and display it
    ///in the application 
    ///
    ///Indexer -To access the instance of the class  using index (Generics an also be used)


    class CustomBugFixingAttribute
    {
        [AttributeUsage(AttributeTargets.Method |
            AttributeTargets.Class |
            AttributeTargets.Constructor |
            AttributeTargets.Field |
            AttributeTargets.Property, AllowMultiple = true)]


        public class BugFixingAttribute : Attribute
        {
            static void Main(string[] args)
            {

            }
        }
    }
}