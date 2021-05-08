using System;

namespace SimpleCalculator1
{
    class Program1
    {
        // indentaiton = Ctrl K+d
        // multiline writing = Shift + Alt + Up/Down arrow key
        // Populate Properties + AutoComplete = Ctrl + Shift
        //Constructor = ctor -> Tab -> tab
        //Poperty = prop -> Tab -> tab
        //Renaming Vars = Ctrl + H
        //Renaming a Class = F2 on the file name.
        //Build -> Ctrl + Shift + B
        //Run + Debug = F5S
        //Save multiple file = Ctrl +Shift + S

        public Program1()
        {

        }
        public string NameOfTHeProp { get; set; }

        static void Main(string[] args)
        {
            int number1 = 2;
            int num2 = 2;
            var result = Sum(number1, num2);
            string v = "something else";
            
        }

        public static int Sum(int number1, int num2)
        {
            return number1 + num2;
        }

        public static int Sub(int number1, int num2)
        {
            return number1 - num2;
        }
        public static int Multiple(int number1, int num2)
        {
            return number1 * num2;
        }

        public static int DivideBy(int number1, int num2)
        {
            return number1 / num2;
        }

    }
}
