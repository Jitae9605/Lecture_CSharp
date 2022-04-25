using System;
using static System.Console;
using System.Collections;

namespace Collection_Hashtable
{
    // 대표적인 콜렉션 소개
    // 4. Hashtable
    // 키와 값의 쌍으로 이루어진 자료구조를 만드는 것
    // 쉽게 생각하면 배열인데 인덱스로 요소번호가 아닌 키를 사용하는 것
    // ex) 영어단어장 - 키: book, 값: 책    ==>   hashtabe["book"] = "책" 임
    class MainApp
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable(); // Hashtable 선언

            // 키 / 값을 쌍으로 만들어 ht에 입력
            ht["하나"] = "one";
            ht["둘"]   = "two";
            ht["셋"]   = "three";
            ht["넷"]   = "four";
            ht["다섯"] = "five";

            // 키값을 통해 값 찾기 수행
            WriteLine(ht["하나"]);
            WriteLine(ht["둘"]);
            WriteLine(ht["셋"]);
            WriteLine(ht["넷"]);
            WriteLine(ht["다섯"]);
        

        }
    }
}
