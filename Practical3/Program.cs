using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    class Program
    {
		static int top = -1;
		static char [] stack = new char[30];
		static char pop()
		{
			return stack[top--];
		}
		static int priority(char ch)
		{
			if (ch == '^')
				return 3;
			else if (ch == '*' || ch == '/' || ch == '%')
				return 2;
			else if (ch == '+' || ch == '-')
				return 1;
			else
				return 0;
		}
		static void Main(string[] args)
        {
			string exp1;
			char [] exp2 = new char[30];
			int i, j = 0;

			Console.WriteLine("enter infix string : ");
			exp1 = Console.ReadLine();

			for (i = 0; i<exp1.Length; i++)
			{
				if (exp1[i] == '^')
					stack[++top] = exp1[i];
				
				else if (exp1[i] == '(')
					stack[++top] = exp1[i];
				
				else if (exp1[i] == ')')
				{
					while (stack[top] != '(')
						exp2[j++] = pop();
					
					pop();
				}

				else if (exp1[i] == '*' || exp1[i] == '+' || exp1[i] == '-' || exp1[i] == '/' || exp1[i] == '%')
				{
					int	temp = (top == -1) ? (top + 1) : top;
					
					while (temp != -1 && priority(exp1[i]) <= priority(stack[temp]))
					{
						exp2[j++] = stack[temp--];
						top--;
					}
					
					stack[++top] = exp1[i];
				}
				else
					exp2[j++] = exp1[i];
			}
			while (top != -1)
				exp2[j++] = pop();
			
			exp2[j] = '\0';
			string postfix = new string(exp2);
			Console.WriteLine("Postfix : " + postfix);
			Console.Read();
		}
    }
}
