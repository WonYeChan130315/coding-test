﻿/* 
약수의 개수와 덧셈

문제 설명:
두 정수 left와 right가 매개변수로 주어집니다.
left부터 right까지의 모든 수들 중에서, 약수의 개수가 짝수인 수는 더하고,
약수의 개수가 홀수인 수는 뺀 수를 return 하도록 solution 함수를 완성해주세요.

제한 사항:
> 1 ≤ left ≤ right ≤ 1,000
*/

using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;

        for (int i = left; i <= right; i++) {
            answer += divisor(i) % 2 == 0 ? i : -i;
        }

        return answer;
    }

    public int divisor(int num) {
        int count = 0;

        for (int i = 1; i <= num; i++) {
            if (num % i == 0) {
                count++;
            }
        }

        return count;
    }
}