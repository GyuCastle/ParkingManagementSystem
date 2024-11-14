using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void MyEventHandler(); // ② 이벤트를 위한 델리게이트 정의

class Button
{
    public event MyEventHandler Push; // ③ 이벤트 선언
    public void OnPush()
    {
        if (Push != null)
            Push(); // ⑤ 이벤트 발생
    }
}

class EventHandlerClass
{
    public void MyMethod()
    { // ① 이벤트 처리기 작성
        Console.WriteLine("In the EventHandlerClass.MyMethod ...");
    }
}

class EventHandlingApp
{
    public static void Main()
    {
        Button button = new Button();
        EventHandlerClass obj = new EventHandlerClass();
        button.Push += new MyEventHandler(obj.MyMethod); // ④ 이벤트 등록
        button.OnPush();
    }
}
