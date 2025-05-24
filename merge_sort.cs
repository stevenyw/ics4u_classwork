using System;

class Testing {
    public static void MergeSort(int[] array, int start, int end) {
        if (start >= end) 
            return;
            
        int middle = (start+end)/2;
        MergeSort(array, start, middle);
        MergeSort(array, middle+1, end);
        int[] result = new int[end-start+1];
        int cursor = 0;
        int left = start;
        int right = middle+1;
        while (left < middle + 1 && right <= end) {
            if (array[left] < array[right]) {
                result[cursor] = array[left];
                cursor += 1;
                left += 1;
            }
            else {
                result[cursor] = array[right];
                cursor += 1;
                right += 1;
            }
        }
        
        while (left <= middle) {
            result[cursor] = array[left];
            cursor += 1;
            left += 1;
        }
        while (right <= end) {
            result[cursor] = array[right];
            cursor += 1;
            right += 1;
        }
        
        for (int i = 0; i < result.Length; i++)
        {
            array[i + start] = result[i]; // After you've merged two sorted halves into the result array (which is a temporary array), this loop is copying the sorted values from result back into the original array, but only in the range from start to end.
        }
        string thing = "[";
        for (int i = 0; i < result.Length; i++) {
            thing += result[i];
            if (i < result.Length - 1) {
                thing += ", ";
    }
        }
    thing += "]";
}
}

class Program
{
    public static void Main(string[] args)
    {
        int[] array = new int[] {5, 4, 9, 5, 8, 6};
        Testing.MergeSort(array, 0, 5); // Sort the array in descending order
        Console.WriteLine(string.Join(", ", array)); // Print the sorted array
        }
    }
