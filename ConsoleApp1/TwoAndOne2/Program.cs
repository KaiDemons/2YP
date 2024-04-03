using System;
using System.Collections.Generic;

class MainClass {
    public static void Main (string[] args) {
        int[] candidates1 = {2, 5, 2, 1, 2};
        int target1 = 5;
        Console.WriteLine("Example 1:");
        List<List<int>> result1 = CombinationSumUnique(candidates1, target1);
        PrintResult(result1);

        int[] candidates2 = {10, 1, 2, 7, 6, 1, 5};
        int target2 = 8;
        Console.WriteLine("\nExample 2:");
        List<List<int>> result2 = CombinationSumUnique(candidates2, target2);
        PrintResult(result2);
    }

    public static List<List<int>> CombinationSumUnique(int[] candidates, int target) {
        Array.Sort(candidates);
        List<List<int>> result = new List<List<int>>();
        FindCombinations(candidates, target, 0, new List<int>(), result);
        return result;
    }

    public static void FindCombinations(int[] candidates, int target, int index, List<int> currentList, List<List<int>> result) {
        if (target == 0) {
            result.Add(new List<int>(currentList));
            return;
        }

        for (int i = index; i < candidates.Length; i++) {
            if (i > index && candidates[i] == candidates[i - 1]) {
                continue;
            }

            if (candidates[i] > target) {
                break;
            }

            currentList.Add(candidates[i]);
            FindCombinations(candidates, target - candidates[i], i + 1, currentList, result);
            currentList.RemoveAt(currentList.Count - 1);
        }
    }

    public static void PrintResult(List<List<int>> result) {
        Console.WriteLine("[");
        foreach (List<int> combination in result) {
            Console.Write("[");
            foreach (int num in combination) {
                Console.Write(num + ",");
            }
            if (combination.Count > 0) {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); // Remove trailing comma
            }
            Console.WriteLine("]");
        }
        Console.WriteLine("]");
    }
}