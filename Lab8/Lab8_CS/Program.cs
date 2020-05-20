using System;

namespace Lab8_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 task.
            FirstTask firstTask = new FirstTask();
            FirstTask.LineOperator lineOperator = null; // empty delegate.
            lineOperator?.Invoke("hello world", 'l'); // trying to invoke delegate.
            lineOperator += FirstTask.FirstChar;
            lineOperator += firstTask.firstChar;
            Console.WriteLine($"Non-static method: {lineOperator("hello world", 'l')}"); // non-static method call via delegate.
            lineOperator -= firstTask.firstChar; // delete method from delegate.
            Console.WriteLine($"Static method: {lineOperator("hello world", 'l')}"); // static method call via delegate.
            lineOperator -= FirstTask.FirstChar;
            // End of 1 task.
            // 2 task.
            Console.ReadKey();
            try
            {
                Console.WriteLine("Value of stack: ");
                MyStack<int> myStack = new MyStack<int>(Convert.ToInt32(Console.ReadLine()));
                myStack.Notify += DisplayMessage; // sign method to event.
                int action = 0;
                Console.WriteLine("Choose action:\n1 - push element to stack.\n2 - pop element from stack.\n3 - get peek element from stack,\n4 - print the stack.\n5 - stop.");
                do
                {
                    switch(action)
                    {
                        case 1:
                            Console.Write("Push: ");
                            myStack.Push(Convert.ToInt32(Console.ReadLine()));
                            break;
                        case 2:
                            myStack.Pop();
                            break;
                        case 3:
                            Console.WriteLine($"Peek: {myStack.Peek()}");
                            break;
                        case 4:
                            myStack.DisplayStack();
                            break;
                        default:
                            break;
                    }
                } while ((action = Convert.ToInt32(Console.ReadLine())) != 5);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // End of 2 task.
        }
        static void DisplayMessage(StackHandlerArgs data)
        {
            Console.WriteLine(data.Message);
        }        
    }
}
