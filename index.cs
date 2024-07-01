using System;
using System.Collections.Generic;

public class Distance
{
    public static void Main(string[] args)
    {
        List<int> array1 = new List<int>(){60, 80, 36, 5, 90, 20, 30, 40, 50, 100};
        List<int> array2 = new List<int>(){93,13, 8, 23, 35, 43, 55, 63, 75, 106};

        string res = MinimumDistanceBetweenTwoArrays(array1, array2);
        Console.WriteLine(res);
    }
    
    public static string MinimumDistanceBetweenTwoArrays(List<int> array1, List<int> array2)
    {
        
        int difference = -1;
        int[] items = new int[2];

        for(int i = 0; i < array1.Count; i++)
        {
            for(int index = 0; index < array2.Count; index++)
            {
                int diff = array1[i] - array2[index];
                
                if(diff < 0){
                    diff = diff * -1;
                }
                
                if(difference == -1){
                    difference = diff;
                    items[0] = array1[0];
                    items[1] = array2[0];
                }else{
                    if(diff < difference) {
                        difference = diff;
                        items[0] = array1[i];
                        items[1] = array2[index];
                    }
                }
            }
        }
        
        return $"O numero {items[0]} do array 1 e o numero {items[1]} do array 2, tem a menor distancia, sendo ela: {difference}";
    }
}
