// Import
import java.util.Arrays;
import java.util.Objects;

/**
 * This class can create Array, add "content" to 0/1, and Show Array.
 */
public class Dictionary {
    // Initialization
    String[] word = new String[5];

    // Execute
    public void Execute()
    {
        // Init
        ResetList(word);

        // Set word
        AddWord("yo", word);

        // Show list
        ShowList(word);
    }

    // Methods
    private void ResetList(String[] trg)
    {
        Arrays.fill(trg, "none");

        trg[0] = "1st";
        trg[1] = "2nd";
    }
    private void AddWord(String w, String[] dist)
    {
        for(int i = 0; i < dist.length; i++)
        {
            if(Objects.equals(dist[i], "none"))
            {
                dist[i] = "Yo";

                break;
            }
            else
            {
                continue;
            }
        }
    }
    private void ShowList(String[] list)
    {
        for(int i = 0; i < list.length; i++)
        {
            System.out.println("# " + i + ": " + list[i]);
        }
    }
}
