using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labki1411
{
  class QNode<T>
  {
    public T value;
    public QNode<T> next;
    public QNode<T> preview;

  }

  class Kolejka<T> : IStack<T>, IDisplay, IEnumerable<T>
  {

    private QNode<T> _tail = null;
    private QNode<T> _head = null;
    public void Display()
    {
      foreach (var item in this)
      {
        Console.WriteLine($"{item.ToString()}");
      }
    }

    public IEnumerator<T> GetEnumerator()
    {
      QNode<T> head = _head;
      if (head != null)
      do
      {
        yield return head.value;
        head = head.next;
      }while (head!= null) ;
    }

    public T Pop()
    {
      if (_head == null) return default(T);
      var returnValiue = _head.value;
      _head = _head.next;
      return returnValiue;
    }

    public void Push(T v)
    {
      var node = new QNode<T>();
      node.value = v;
      node.next = null;
      if (_tail != null)
      {
        _tail.next = node;
          }
      else
      {
        _head = node;
      }
      _tail = node;

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
  }
}
