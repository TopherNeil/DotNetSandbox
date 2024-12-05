// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        #region -- Multidimensional Array --

        // int[][] multiDimensionalArray = new int[][]
        // {
        //     new int[] { 1, 2, 3 },
        //     new int[] { 4, 5, 6 },
        //
        // };
        //
        // // to access the array --
        // // if we want to access the value of 5
        // Console.WriteLine("-Multidimensional Array-");
        // Console.WriteLine($"Value of indexes [1][1] : {multiDimensionalArray[1][1]}");
        //
        // // if we want to access the value of 3
        // Console.WriteLine($"Value of indexex [0][2] : {multiDimensionalArray[0][2]}");
        #endregion

        #region -- Jagged Array --

        // int[][] jaggedArray = new int[][]
        // {
        //     new int[] { 1, 2, 3, 4 },
        //     new int[] { 5, 6 },
        //     new int[] { 7, 8, 9, 10 }
        // };

        // // in accessing the jagged array --
        // // if we want to access the value of 5
        // Console.WriteLine("-Jagged Array-");
        // Console.WriteLine($"Value of indexes [1][1] : {jaggedArray[1][1]}");
        // // if we want to access the value of 10
        // Console.WriteLine($"value of indexes [2][3] : {jaggedArray[2][3]}");

        #endregion

        #region -- Implicit declaration and initialization of array --

        //
        // var implicitArray = new[] { "Trunks", "24", "Male" };
        //
        // foreach (var item in implicitArray)
        // {
        //     Console.WriteLine($"Property: {item}");
        // }

        #endregion

        #region -- Iteration through a multiarray --

        // var multiArray = new int[3][]
        // {
        //     new int[] { 1, 2, 3 },
        //     new int[] { 4, 5, 6 },
        //     new int[] { 7, 8, 9 }
        // };
        //
        // for (int row = 0; row < multiArray.Length; row++)
        // {
        //     Console.WriteLine($"row number : {row}");
        //     foreach (var item in multiArray[row])
        //     {
        //         Console.Write(item + ", ");
        //     }
        //     Console.WriteLine();
        // }

        #endregion

        #region -- Enumerable, Collection, List --

        // Enumerables are readonly type of collection -- cannot be modified
        var statesInAmerica = new[] { "Kansas", "Chicago", "Detroit", "Milwaukee", "Los Angeles" };
        IEnumerable<string> enumStates = statesInAmerica;
        foreach (var state in enumStates)
        {
            Console.WriteLine(state);
        }

        // Collection -- can add or remove items
        ICollection<string> colStates = new List<string>(enumStates);
        colStates.Remove("Kansas");
        Console.WriteLine(colStates.Count);

        // List -- can be declared ass  
        var listStates = new List<string>(colStates);
        var listStatesInit = new List<string>()
        {
            "Kansas",
            "Chicago",
            "Memphis"
        };

        var listStatesInitToo = new List<string>();
        
        listStatesInitToo.Add("Boston");
        listStatesInitToo.Add("Utah");
        listStatesInitToo.Add("Washington");
        listStatesInitToo.AddRange(new[] {"Orlando", "Miami"});
        listStatesInitToo.RemoveRange(0, 5);
        
        Console.WriteLine("Manual");
        foreach (var listState in listStatesInitToo)
        {
            Console.WriteLine(listState);
        }

        #endregion

    }
}