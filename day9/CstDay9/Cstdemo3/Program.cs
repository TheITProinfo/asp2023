﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //int[] nums = new int[10]; // declared int array
            //                          //nums[0] = 1;
            //                          //nums[1] = 5;
            //                          //nums[8] = 22;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = i;
            //Console.Write(nums[i]);
            //}
            //Console.ReadKey();
            #endregion

            //bubble sort

            int[] nums = { 5, 3, 13, 2, 11, 4, 7 ,20,90};

            for (int i = 0; i < nums.Length - 1; i++)
            {
              //  for (int j = 0; j < nums.Length - 1; j++)
                for (int j = 0; j < nums.Length -i - 1; j++) // internal for loop times

                    {
                        if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }

                }// internal for end

            }//external for end
            for (int i = 0; i<nums.Length; i++)
			{
             Console.WriteLine(nums[i]);
			}

            Console.ReadKey();
        }
            
    }
}

