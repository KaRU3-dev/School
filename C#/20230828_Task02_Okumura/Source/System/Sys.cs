using System;

namespace _20230828_Task02_Okumura
{
    public class Sys
    {
        private AppEngine appEngine = new();

        private bool login = false;

        public void Start()
        {
            login = true;
        }

        public void Update()
        {
            while (login)
            {
                // Start request
                appEngine.ARequest();

                // Action
                if (appEngine.Mode == 0)
                {
                    // Search
                    appEngine.search.Request();
                }
                else if (appEngine.Mode == 1)
                {
                    // Add
                    appEngine.add.Request();
                }
                else if (appEngine.Mode == 2)
                {
                    // Delete
                    appEngine.delete.Request();
                }
                else
                {
                    // Error
                    Console.WriteLine("Error");
                }

                // Show all
                appEngine.ShowAll();

                // Check continue
                login = appEngine.EndOrContinue();
            }
        }
    }
}
