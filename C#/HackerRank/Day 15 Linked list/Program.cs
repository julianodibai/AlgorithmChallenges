﻿using System;
class Node
{
	public int data;
	public Node next;
    public Node(int d){
        data=d;
        next=null;
    }
		
}
class Solution {

	public static  Node insert(Node head,int data)
	{
      //Complete this method
      if(head == null)
      {
          return new Node(data);
      }
      
      var current = head;
      
      while(current.next != null)
      {
          current = current.next;
      }
      
      current.next = new Node(data);
      
      return head;
    }

	public static void display(Node head)
	{
		Node start=head;
		while(start!=null)
		{
			Console.Write(start.data+" ");
			start=start.next;
		}
	}
    static void Main(String[] args) {
	
		Node head = null;
        int data = 0;
        int T = Int32.Parse(Console.ReadLine());

        while(T-- > 0)
        {
            data = Int32.Parse(Console.ReadLine());
            head = insert(head,data);
        }
		display(head);
	}
}
	
