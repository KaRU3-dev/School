using System;

namespace _20230828_Task02_Okumura
{
    public class Delete : AppEngine
    {
        private int Place = 0;

        public void Request()
        {
            // Request start
            Console.Write("削除したい本の場所を指定してください: ");
            string input = Console.ReadLine();
            while (!(int.TryParse(input, out int result)))
            {
                Console.Write("削除したい本の場所を指定してください: ");
                input = Console.ReadLine();
            }

            Place = int.Parse(input);

            DeleteBook(Place);
        }

        private void DeleteBook(int place)
        {
            Titles.RemoveAt(place);
            Authors.RemoveAt(place);
        }
    }
}
