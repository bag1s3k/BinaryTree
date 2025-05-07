namespace BinaryTree;

using System.Collections.Generic;
using System.Net.Mail;

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

    public bool Delete(int value) {
        int i = heap.IndexOf(value);
        if (i == -1) return false;
        heap[i] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);

        while (true) {
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            int smallest = i;

            if (left < heap.Count && heap[left] < heap[smallest])
                smallest = left;
            if (right < heap.Count && heap[right] < heap[smallest])
                smallest = right;
            if (smallest == i)
                break;

            (heap[i], heap[smallest]) = (heap[smallest], heap[i]);
            i = smallest;
        }

        return true;
    }

    public override string ToString() {
        string temp = "";
        for (int i = 0; i < heap.Count; i++)
            temp += heap[i] + " ";
        return temp;
    }
}