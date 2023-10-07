// Import
import java.util.Scanner;

public class Calculator {
    // Start here
    boolean executable = true;

    // Require
    Scanner S = new Scanner(System.in);

    // Initialization
    int a, b, m;


    // Do here
    public void Execute()
    {
        do
        {
            Cal();
        } while (executable);
    }


    // Methods

    /**
     * Mode selector
     */
    private void ModeSelector()
    {
        // Request input
        do
        {
            System.out.print("Select calculate mode: ");
        } while(!S.hasNextInt());

        m = S.nextInt();
    }

    /**
     * Calculator
     */
    private void Cal()
    {
        ModeSelector();

        if (m == 1)
        {
            System.out.println("\nMode: Add\n");
            RequestInput();
            System.out.println("Result is " + Add(a, b));

            DisableService();
        }
        else if (m == 2)
        {
            System.out.println("\nMode: Minus\n");
            RequestInput();
            System.out.println("Result is " + Minus(a, b));

            DisableService();
        }
        else if (m == 3)
        {
            System.out.println("\nMode: Multiply\n");
            RequestInput();
            System.out.println("Result is " + Multiply(a, b));

            DisableService();
        }
        else if (m == 4)
        {
            System.out.println("\nMode: Division\n");
            RequestInput();
            System.out.println("Result is " + Division(a, b));

            DisableService();
        }
        else
        {
            ModeSelector();
        }
    }

    private void RequestInput()
    {
        // Request int a
        do
        {
            System.out.print("Please enter number A: ");
        } while(!S.hasNextInt());
        a = S.nextInt();

        // Request int b
        do
        {
            System.out.print("Please enter number B: ");
        } while(!S.hasNextInt());
        b = S.nextInt();
    }

    private int Add(int a, int b)
    {
        return a + b;
    }
    private int Minus(int a, int b)
    {
        return a - b;
    }
    private int Multiply(int a, int b)
    {
        return a * b;
    }
    private int Division(int a, int b)
    {
        return a / b;
    }

    private void DisableService()
    {
        executable = false;
    }
}
