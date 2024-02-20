﻿/* 
행렬의 덧셈

문제 설명:
행렬의 덧셈은 행과 열의 크기가 같은 두 행렬의 같은 행, 같은 열의 값을 서로 더한 결과가 됩니다. 
2개의 행렬 arr1과 arr2를 입력받아, 행렬 덧셈의 결과를 반환하는 함수, solution을 완성해주세요.

제한 사항:
> 행렬 arr1, arr2의 행과 열의 길이는 500을 넘지 않습니다.
*/

public class Solution {
    static void Main() {
        foreach (int i in solution(new int[,]{{1,2}, {2,3}}, new int[,]{{3,4}, {5,6}})) Console.WriteLine(i);
    }

    public static int[,] solution(int[,] arr1, int[,] arr2) {
        int[,] answer = arr1;
        
        for (int i = 0; i < arr1.GetLength(0); i++) {
            for (int j = 0; j < arr1.GetLength(1); j++) {
                answer[i, j] += arr2[i, j];
            }
        }

        return answer;
    }
}