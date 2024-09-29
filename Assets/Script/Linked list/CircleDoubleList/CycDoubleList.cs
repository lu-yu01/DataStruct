using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DataStruct
{

    //环形双向链表
    public class Node<T>
    {
        public T Data { get; set; }//每个节点的数据

        public Node<T> NextNode { get; set; }//下一节点

        public Node<T> PreNode { get; set; }//上一节点

        public Node(T val, Node<T> pre, Node<T> next)
        {
            Data = val;
            pre = NextNode;
            next = NextNode;
        }

        public Node(T data)
        {
            Data = data;
        }

    }


    //环形双向链表
    public class CircleLink<T>
    {
        private Node<T> head;

        public Node<T> Head
        {
            get
            {
                return head;
            }

            set
            {
                head = value;
            }
        }

        public CircleLink()
        {
            head = null;
        }

        //获取链表大小
        public int Count()
        {
            Node<T> p = head;
            if (head.PreNode == null)
                Debug.LogError("不是环形链表");
            int count = 0;
            while (p.NextNode != head)
            {
                count++;
                p = p.NextNode;
            }
            return count + 1;
        }

        //获取索引处值
        public T GetElem(int i)
        {
            Node<T> p = head;
            int k = 0;
            if (i > Count() || i < 0)
            { Debug.LogError("数组越界"); }

            while (k < i)
            {
                k++;
                p = p.NextNode;
            }
            return p.Data;
        }


        //根据数据获取链表结点
        public Node<T> GetNode(T data)
        {
            if (head == null)
            {
                Debug.LogError("sb");
                return null;
            }
            Node<T> p = head;
            while (p.Data.Equals(data) == false)
            {
                if (p.NextNode == head)
                {
                    Debug.LogError("没有此节点");
                    return null;
                }

                p = p.NextNode;
            }
            return p;
        }

        public Node<T> GetNode(int index)
        {
            if (head == null)
            {
                Debug.LogError("sb");
                return null;
            }
            Node<T> p = head;
            int k = 0;

            if (index > Count() || index < 0)
            { Debug.LogError("数组越界"); }
            while (k < index)
            {
                k++;
                p = p.NextNode;
            }
            return p;
        }

        //移除指定位置索引
        public void RemoveElem(int i)
        {
            Node<T> p = GetNode(i);

            RemoveNode(p);
        }
        //移除指定位置索引
        public void RemoveNode(Node<T> p)
        {
            p.PreNode.NextNode = p.NextNode;
            p.NextNode.PreNode = p.PreNode;
            if (p == head)
            {
                head = p.NextNode;
            }
        }

        //增加一个新的元素
        public void AddElem(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
                head.NextNode = head;
                head.PreNode = head;
                return;
            }
            Node<T> p = head;
            while (p.NextNode != head)
            {
                p = p.NextNode;
            }
            Node<T> newNode = new Node<T>(data);

            p.NextNode = newNode;
            newNode.PreNode = p;
            newNode.NextNode = head;
            head.PreNode = newNode;
        }

        //删除链表内所有
        public void Clear()
        {
            head = null;
        }
    }

}
