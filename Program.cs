// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




public static class MyClass
{
    public static stringReverseString2(string str) {  
        char[] chars = str.ToCharArray();  
        for (int i = 0, j = str.Length - 1; i < j; i++, j--) {  
            char c = chars[i];  
            chars[i] = chars[j];  
            chars[j] = c;  
        }  
        return new string(chars);  
    } 
}