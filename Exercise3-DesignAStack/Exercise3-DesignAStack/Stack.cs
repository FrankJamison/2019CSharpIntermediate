using System;
using System.Collections.Generic;

namespace Exercise3_DesignAStack
{
    class Stack
    {
        private Stack<object> _stack = new Stack<object>();     // Stack object

        /*
         * METHOD: Push
         * Used to push an object on to the stack
         */
        public void Push(object obj)
        {
            try
            {
                // If the object being pushed is null, throw an exception
                if (obj == null)
                {
                    throw new InvalidOperationException("obj");
                }

                // Push object on to the stack
                _stack.Push(obj);
            }

            catch (InvalidOperationException)
            {
                Console.WriteLine("The item being pushed to the stack cannot be null");
            }
        }

        /*
         *  METHOD: Pop
         * Used to remove an item from the stack
         */
        public object Pop()
        {
            try
            {
                // If the stack is empty, throw an exception
                if (_stack.Count == 0)
                {
                    throw new InvalidOperationException("count");
                }

                // Remove item from the stack
                return _stack.Pop();
            }

            catch (InvalidOperationException)
            {
                Console.WriteLine("You can't remove items from an empty stack.");
                return null;
            }
        }

        /*
         * METHOD: Clear
         * Used to empty the stack of all items
         */
        public void Clear()
        {
            // Remove all items from the stack
            _stack.Clear();
        }
    }
}