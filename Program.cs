using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {


        idemo dalje 

// Some changes
        List<int> myList = new List<int>() { 7, 2, 2, 4, 2, 5, 6, 1 };

        Console.WriteLine("Original List: " + string.Join(", ", myList));

        RemoveDuplicatesManually(myList);

        Console.WriteLine("List without duplicates: " + string.Join(", ", myList));

        List<int> lstInt = new List<int>(){ 1,2,3,4,5,2,6};
        RemoveInt(lstInt);

        foreach(var x in lstInt){ 
            Console.WriteLine(x);
        }
    }
    static void RemoveInt(List<int> lstRemove){ 
        List<int> lst1 = new List<int>(){ 4,2,3,4,2,2,6 };
        List<int> lst2 = new List<int>(){ 4,2,3,4,2,2,6 };
        List<int> newList = new List<int>();
        int lstSize = lst2.Count();
        for (int i = lstSize - 1; i >= 0; i--){ 
            bool exist = false;
            for(int j = lstSize - 1; j >= 0; j--){ 
                if(lst1[i] == lst2[j] && exist){ 
                    lstRemove.RemoveAt(i);
                }
                if(lst1[i] == lst2[j]) { exist = true; continue; }
            }
        }
    }

    static void RemoveDuplicatesManually(List<int> list)
    {
        int count = list.Count;

        for (int i = 0; i < count - 1; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                if (list[i] == list[j])
                {
                    // Duplicate found, remove the element at index j
                    RemoveAt(list, j);
                    count--; // Adjust the count as the list has been modified
                    j--;     // Adjust j to recheck the current index
                }
            }
        } 
    }
 
    static void RemoveAt<T>(List<T> list, int index)
    {
        // Remove the element at the specified index manually
        for (int i = index; i < list.Count - 1; i++)
        {
            list[i] = list[i + 1];
        }

        list.RemoveAt(list.Count - 1);
    }
}
