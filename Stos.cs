using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labki1411
{

  class SNode<T>
  {
    public T value;
    public SNode<T> next;
  }
  class Stos<T> : IStack<T>, IDisplay, IEnumerable<T>
  {
    private SNode<T> _current = null;
    public void Display()
    {
      foreach (var item in this)
      {
        Console.WriteLine($"{item.ToString()}");
      }
    }

    public IEnumerator<T> GetEnumerator()
    {
      SNode<T> head = _current;
      if (head != null)
      do
      {
        yield return head.value;
        head = head.next;
      }while (head!= null) ;
    }

    public T Pop()
    {
      if (_current == null) return default(T);
      var returnValiue = _current.value;
      _current = _current.next;
      return returnValiue;
    }

    public void Push(T v)
    {
      var node = new SNode<T>();
      node.value = v;
      node.next = _current;
      _current = node;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
  }
}
