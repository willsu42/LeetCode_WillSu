public class Solution {
    public void DuplicateZeros(int[] arr) {
        int i = 0;
            while (i<arr.Length) {
                if (arr[i] == 0 && i < arr.Length - 1)
                {
                    //Console.WriteLine("zero pos:" + i);

                    for (int j = arr.Length - 2; j > i; j--)
                    {
                       
                        arr[j + 1] = arr[j];
              
                    }
                    arr[i + 1] = 0;
                    i += 2;

                }
                else {
                    arr[i] = arr[i];
                    i++;
                }
            }
    }
}