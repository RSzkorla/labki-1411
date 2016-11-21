using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labki1411
{
  interface IStack<T>
  {
    void Push(T v);
    T Pop();
  }
}
