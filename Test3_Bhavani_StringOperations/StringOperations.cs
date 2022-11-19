using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3_Bhavani_StringOperations
{
    public class StringOperations
    {
        public void Mymethod()
        {


            string mainString = "A Quick Brown Fox jumps over the lazy dog";
            Console.WriteLine("Index Of Word 'Fox' : " + mainString.IndexOf("Fox"));
            Console.WriteLine("-----------");



            Console.WriteLine("Count the \"U\"");
            int count = 0;
            for (int i = 0; i < mainString.Length; i++)
            {
                if (mainString[i] == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine("'u' Letter Count is : " + count);
            Console.WriteLine("-----------");



            Console.WriteLine("Length of the Total String is : " + mainString.Length);
            Console.WriteLine("-----------");



            Console.WriteLine("Replacing Characters...");
            string sentence_Replace = mainString.Replace('a', '5').Replace('e', '6').Replace('i', '7').Replace('o', '8').Replace('u', '9').Replace('A', '1').Replace('E', '0').Replace('I', '3').Replace('O', '2').Replace('U', '1');
            Console.WriteLine("Replace of sentence words from A,E,I,O,U with \"Numbers\":" + sentence_Replace);
            Console.WriteLine("-------------");
            Console.WriteLine("C. Fox Over The Dog");
            string substring1 = mainString.Substring(14, 3);
            string substring2 = mainString.Substring(22, 19);
            Console.WriteLine(substring1 + substring2);
            Console.WriteLine("-------------");



            Console.WriteLine("Dog Reverse..");
            string dogVariable = mainString.Substring(38, 3);
            Console.WriteLine(dogVariable);
            string reverseVariable = "";
            for (int i = dogVariable.Length - 1; i >= 0; i--)
            {
                reverseVariable = reverseVariable + dogVariable[i];
            }
            Console.WriteLine("Reverse Variable : " + reverseVariable);
        }
    }
}

      