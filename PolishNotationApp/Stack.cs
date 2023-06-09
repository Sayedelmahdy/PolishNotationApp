using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PolishNotationApp
{
    class stack
    {
        public int top;
        public int[] arr;
        public stack()
        {
            top = -1;
        }
        public void get_array(int size)
        {
            arr = new int[size];
        }
        public bool is_empty()
        {
            return top < 0;
        }
        public bool is_full()
        {
            return top == arr.Length - 1;
        }
        public void push(int n)
        {
            if (is_full())
                MessageBox.Show("Error!");
            else
            {
                top++;
                arr[top] = n;
            }

        }
        public int pop()
        {
            if (is_empty())
            {
                MessageBox.Show("Error!");
                return 0;
            }
            return arr[top--];
        }
        public int peek()
        {
            if (is_empty())
            {
                MessageBox.Show("Error!");
                return 0;
            }
            else
                return arr[top];
        }
        public int size()
        {
            if (is_empty())
            {
                MessageBox.Show("Error!");
                return 0;
            }
            else
                return top + 1;
        }
    }
}
