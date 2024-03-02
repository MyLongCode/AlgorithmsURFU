using System;

public class Task5
{
    // (*   *)
    // {     }
    // //
    // ' ' 

    public static int[] searchComments (string str)
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;
        for (int i = 0; i < str.Length; i++) 
		{
            if (str[i] == '‘' && flag4)
            {
                flag4 = false;
                count4++;
            }
            if (str[i] == '‘' && !flag2 && !flag3 && !flag) flag4 = true;

            if (str[i] == '\n')
            {
                if (flag3) count3++;
                flag3 = false;
            }
            if (str[i] == '/' && str[i + 1] == '/' && !flag2 && !flag4 && !flag) flag3 = true;

            if (str[i] == '{' && !flag && !flag3 && !flag4) flag2 = true;
            else if (str[i] == '}' && flag2)
            {
                count2++;
                flag2 = false;
            }

            if (str[i] == '('  && str[i + 1] == '*' && !flag2 && !flag3 && !flag4) flag = true;
			else if (str[i] == '*'  && str[i + 1] == ')' && flag)
			{
				count1++;
                flag = false;
            }
		}
		return new int[4] {count1, count2,count3,count4 };
	}
	public static void Task5Solution()
	{
		string test = "program  test;\r\n(*just for {} testing *)\r\nvar\r\n(* variables\r\nnote that\r\n// here is not comment\r\nand (* here is\r\nnot a begin of\r\nanother comment\r\n*)\r\nx: integer; (* *)\r\nbegin\r\nwrite(‘(*is not comment//’);\r\nwrite(‘ and (*here*) ‘\r\n,x // y);\r\nEnd. // It is comment \n";
		Console.WriteLine(searchComments(test)[0]);
        Console.WriteLine(searchComments(test)[1]);
        Console.WriteLine(searchComments(test)[2]);
        Console.WriteLine(searchComments(test)[3]);
    }
}
