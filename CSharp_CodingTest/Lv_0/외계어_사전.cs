﻿using System;
using System.Runtime.InteropServices;
/// <summary>
/// PROGRAMMERS-962 행성에 불시착한 우주비행사 머쓱이는 외계행성의 언어를 공부하려고 합니다. 
/// 알파벳이 담긴 배열 spell과 외계어 사전 dic이 매개변수로 주어집니다. 
/// spell에 담긴 알파벳을 한번씩만 모두 사용한 단어가 dic에 존재한다면 1, 존재하지 않는다면 2를 return하도록 solution 함수를 완성해주세요.
/// </summary>
internal class 외계어_사전
{
    public int solution(string[] spell, string[] dic)
    {
        int answer = 2; // answer = 1 or 2;
        int cntD = 0;
        // 배열의 길이까지 반복
        while (cntD < dic.Length)
        {
            int temp = 0;

            for (int i = 0; i < spell.Length; i++)
                if (dic[cntD].Contains(spell[i]))
                    temp++;
            if (temp == spell.Length)
                return answer = 1;
            else 
                cntD++;
        }
        return answer;
    }
}

