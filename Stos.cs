using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labki1411
{

  class Node<T>
  {
    public T value;
    public Node<T> next;
  }
  class Stos<T> : IStack<T>, IDisplay, IEnumerable<T>
  {
    private Node<T> _current = null;
    public void Display()
    {
      foreach (var item in this)
      {
        Console.WriteLine($"{item.ToString()}");
      }
    }

    public IEnumerator<T> GetEnumerator()
    {
      if (_current != null)
      do
        {
        yield return _current.value;
        _current = _current.next;
      }while (_current!= null) ;
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
      var node = new Node<T>();
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
