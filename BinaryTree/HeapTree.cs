namespace BinaryTree;

using System.Collections.Generic;

public class HeapTreeMin {
    private List<int> heap;
    
    public HeapTreeMin() => this.heap = new List<int>(); // constructor

    public void Add(int value) {
        heap.Add(value);

        int currentIndex = heap.Count - 1;

        while (currentIndex > 0) {
            int parentIndex = (currentIndex - 1) / 2;

            if (heap[parentIndex] > heap[currentIndex]) {
                (heap[parentIndex], heap[currentIndex]) = (heap[currentIndex], heap[parentIndex]);
                currentIndex = parentIndex;
            } else 
                break;
        }
        
    }

    public override string ToString() {
        string temp = "";
        for (int i = 0; i < heap.Count; i++)
            temp += heap[i] + " ";
        return temp;
    }
}