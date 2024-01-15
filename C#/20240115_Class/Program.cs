using System;

public class Program {
    public static void Main() {
        // LINQ: Language Integrated Query
        // データを簡潔かつ効果的にクエリするための機能
        // クエリ: データベースからデータを取得するSQL文のようなもの

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var query = from num in numbers where num % 2 == 0 select num;

        foreach (var num in query) {
            Console.WriteLine(num);
        }

        // LINQ method
        var query2 = numbers.Where(num => num % 2 == 0);

        foreach (var num in query2) {
            Console.WriteLine(num);
        }

    }
}
