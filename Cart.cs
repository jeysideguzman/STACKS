using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STACKS
{
    class Cart
    {
        Stack<string> cart = new Stack<string>();
        Stack<string> redoStack = new Stack<string>();

        public void Add(string itemName)
        {
            //Stack.Push();
;            cart.Push(itemName);
        }

        //stack.Pop();
        public void Undo()
        {
            var item = cart.Pop();
            redoStack.Push(item);
        }

        //get the popped item then push again in the stack
        public void Redo()
        {
            var item = redoStack.Pop();
            cart.Push(item);
        }

        //view stack list
        public void viewCart()
        {
            foreach (var item in cart)
            {
                Console.WriteLine("\t" + item);
            }
        }
    }
}
