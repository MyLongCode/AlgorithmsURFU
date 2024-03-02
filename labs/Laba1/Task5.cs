using System;

public class Task5
{
	// {     }
	// (*   *)
	// //
	// ' ' 

	public static int searchCommentsType1 (string str)
	{
		bool flag = false;
		int count = 0;
		for (int i = 0; i < str.Length - 1; i++) 
		{
			if (str[i] == '(' && str[i + 1] == '*') flag = true;
			if (str[i] == '*' && str[i + 1] == ')')
			{
				count++;
                flag = false;
            }
		}
		return count;
	}
	public static void Main()
	{
		string test = "program test;\r\n(*just for testing *)\r\nvar\r\n(* variables\r\nnote that\r\n// here is not comment\r\nand (* here is\r\nnot a begin of\r\nanother comment\r\n*)\r\nx: integer; (* *)\r\nbegin\r\nwrite(‘(*is not comment//’);\r\nwrite(‘ and (*here*) ‘\r\n,x // y);\r\nEnd. // It is comment";
		Console.WriteLine(searchCommentsType1(test));
    }
}
