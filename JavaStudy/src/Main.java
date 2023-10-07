// Import
import java.util.Scanner;

/**
 * Program start here
 */
public class Main {
    public static void main(String[] args) {
        // Hello World
        System.out.println("Hello world!");

        // Log
        System.out.println(5 * 2);

        // variables, methods, arguments
        int a = 5, b = 1;
        String re = Multiply(a, b);
        System.out.println("Method result: " + re);

        // Primitive data types
        /*
        *   1. Byte         1 byte         -128 ~ 127
        *   2. short        1 byte         -32,768 ~ 32,767
        *   3. int          2 byte         -2,147,483,648 ~ 2,147,483,647
        *   4. float        4 byte         3.40282347 * 10^38 ~ 1.40239846 * 10^-45
        *   5. long         8 byte         -9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807
        *   6. double       8 byte         1.7976931348623157 * 10^308 ~ 4.9406564584124654 * 10^-324
        *   7. char         2 byte         0 ~ 65,535
        *   8. boolean      depends on jvm True or False
        */
        // Literals
        byte     byt  = 127;                   // Byte
        short    sht  = 32767;                 // Short
        int      i    = 2147483647;            // Int
        float    f    = 2.3f;                  // Float
        long     l    = 9223372036854775807L;  // Long
        double   dbl  = 4.921323121;           // Double
        char     chr  = 'a';                   // Char
        boolean  bool = true;                  // Boolean
        String   str  = "Jon";                 // String

        System.out.println(byt);  // Output
        System.out.println(str);

        // Console user input
        Input();

        // Calculator, another file class, if, else-if, while, do-while
        Calculator calculator = new Calculator();
        calculator.Execute();

        // Dictionary, list
        Dictionary dictionary = new Dictionary();
        dictionary.Execute();
    }

    private static String Multiply(int a, int b)
    {
        // Multiply
        int r = a * b;

        // Content
        String result;
        result = a + " + " + b + " = " + r;

        return result;
    }

    private static void Input()
    {
        Scanner S = new Scanner(System.in);

        // Request input
        System.out.print("Please enter a number: ");
        String str = S.nextLine();

        System.out.println("Your input is: " + str);
    }
}