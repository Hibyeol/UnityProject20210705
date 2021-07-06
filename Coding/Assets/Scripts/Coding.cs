using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int result1 = Add(100, 200);
        print("Add : "+result1);
        int result2 = Sub(100, 200);
        print("Sub : " + result2);
        int result3 = Mui(100, 200);
        print("Mui : " + result3);
        int result4 = Div(100, 200);
        print("Div : " + result4);
        IsOddNumber(3);
        int result5 = Sum(11);
        print("Sum : " + result5);
        int result6 = Sum(3,15);
        print("Sum : " + result6);
        int result7 = OddSum(11);
        print("OddSum : " + result7);
        TimeTableAll();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   int Add(int x, int y)
    {
        return x + y;
    }

    int Sub(int x,int y)
    {
        return x - y;
    }

    int Mui(int x, int y)
    {
        return x * y;
    }

    int Div(int x, int y)
    {
        if (y == 0)
        {
            print("결과가 없습니다");
            return 0;
        }
        else
        {
            return x / y;
        }
    }
    void IsOddNumber(int x)
    {
        if (x % 2 == 0)
        {
            print("짝수입니다");
        }
        else
        {
            print("홀수입니다");
        }
    }

    int Sum(int c)
    {
        int nsum = 0;
        for(int i=0;i<=c;i++)
        {
            nsum += i;
        }
        return nsum;
    }

    int Sum(int c1, int c2)
    {
        int nsum = 0;
        for (int i = c1; i <= c2; i++)
        {
            nsum += i;
        }
        return nsum;
    }

    int OddSum(int c)
    {
        int nsum = 0;
        for (int i = 0; i <= c; i++)
        {
            if (i % 2 == 0) continue;
            nsum += i;
        }
        return nsum;
    }

    void TimeTableAll()
    {
        for (int i = 1; i < 10; i++)
        {
            TimeTable(i);
        }
    }
    void TimeTable(int x)
    {
        for(int i =1; i < 10; i++)
        {
            print(x+"x" + i + "=" + x * i);
        }
        print("\n");
    }

}
