using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FINALL
{
  class Program
  {
    static Dictionary<char, MethodInfo> menu;
    static NorthwindViewer viewer;

    static void BuildMenu()
    {
      menu = new Dictionary<char, MethodInfo>();
      char c = 'A';

      var methods = (IEnumerable<MethodInfo>)viewer.GetType().GetMethods().Reverse();
      foreach (MethodInfo mi in methods)
      {
        if (mi.GetCustomAttributes(typeof(RunnableMethodAttribute), false).Length > 0)
        {
          menu.Add(c, mi);
          c++;
        }
      }
    }

    static void ShowMenu()
    {
      foreach (KeyValuePair<char, MethodInfo> keyValue in menu)
      {
        Console.WriteLine("[{0}] {1}", keyValue.Key, keyValue.Value.Name);
      }
    }

    static bool ProcessMenu()
    {
      Console.WriteLine("--------------------------------");
      ShowMenu();
      Console.WriteLine("[0] -- exit");

      string s;
      char c;
      do
      {
        s = Console.ReadLine();
        c = (s.Length > 0) ? char.ToUpper(s[0]) : ' ';
      } while (c != '0' && !menu.ContainsKey(c));

      if (c == '0')
      {
        return false;
      }
      else
      {
        MethodInfo mi = menu[c];
        mi.Invoke(viewer, new object[] { });
        return true;
      }
    }

    static void Main(string[] args)
    {
      viewer = new NorthwindViewer();
      BuildMenu();


      while (ProcessMenu())
      {
      }


    }
  }
}
