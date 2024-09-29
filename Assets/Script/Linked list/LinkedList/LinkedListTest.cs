using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class LinkedListTest : MonoBehaviour {

   



    void Start()
    {
        string[] worlds = { "the", "fox", "jumps", "over", "the", "dog" };
        LinkedList<string> sentence = new LinkedList<string>(worlds);
        sentence.AddFirst("today");

        LinkedListNode<string> mark1 = sentence.First;
        sentence.RemoveFirst();
        sentence.AddFirst(mark1);

        mark1 = sentence.Last;
        sentence.RemoveLast();
        sentence.AddFirst(mark1);

        sentence.RemoveFirst();
        LinkedListNode<string> current = sentence.Find("the");


        sentence.AddAfter(current, "old");
        sentence.AddAfter(current, "lazy");
       
        IndicateNode(current, "Test 6: Add 'lazy' and 'old' after 'the':");

        current = sentence.Find("fox");
        
        IndicateNode(current, "Test 7: Indicate the 'fox' node:");


        sentence.AddBefore(current, "quick");
        sentence.AddBefore(current, "brown");
        IndicateNode(current, "Test 8: Add 'quick' and 'brown' before 'fox':");

        mark1 = current;
        LinkedListNode<string> mark2 = current.Previous;
        current = sentence.Find("dog");
      

        sentence.Remove(mark1);
        ICollection<string> icoll = sentence;
        icoll.Add("rhinoceros");
        foreach (var s in icoll)
        {
            Debug.Log("icoll===" + s);
        }
        string[] sAray = new string[sentence.Count];
        sentence.CopyTo(sAray, 0);

        foreach (var s in sAray)
        {
            Debug.Log("sArayS===" + s);
        }
       //     IndicateNode(current, "Test 9: Indicate the 'dog' node:");






    }

    private void IndicateNode(LinkedListNode<string> node,string test)
    {
        if (node.List == null)
        {
            Debug.LogFormat("Node '{0}' is not in the list.\n", node.Value);
        }

        StringBuilder result = new StringBuilder("(" + node.Value + ")");
        LinkedListNode<string> nodeP = node.Previous;

        while (nodeP != null)
        {
            result.Insert(0, nodeP.Value + " ");
            nodeP = nodeP.Previous;
        }

        node = node.Next;
        while (node != null)
        {
            result.Append(" " + node.Value);
            node = node.Next;
        }

        Debug.Log("===" + result);

    }

}
