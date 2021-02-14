using System;
using System.Collections.Generic;
using System.Text;

// 나만의 라이브러리 만들기
namespace DulAlgorithm
{
    public class Algorithm
    {
        /// <summary>
        /// 선택 정렬 알고리즘
        /// </summary>
        /// <param name="numbers">정수형 배열</param>
        /// <returns>오름차순 정렬된 정수형 배열</returns>
        public static int[] SelectionSort(int[] numbers)
        {
            //[1] Input
            int N = numbers.Length; //의사코드(슈도코드)

            //[2] Process: Selection Sort
            for (int i = 0; i < N-1; i++)
            {
                for (int j = i+1; j < N; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            //[3]Output
            return numbers;
        }
    }
}
