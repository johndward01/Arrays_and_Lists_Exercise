using System;
using System.Collections.Generic;

namespace Arrays_and_Lists_Exercise_01_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the method you created below to print out the contents

            #region Array Declaration and Initialization

            // TODO: Declare and initialize a List<int> using Explicit typing
            List<int> listExample1 = new List<int>() { 1, 2, 3, 4, 5 };



            // TODO: Declare and initialize a List<int> using Implicit typing
            var listExample2 = new List<int>() { 1, 2, 3, 4, 5 };



            // TODO: Declare and initialize an empty list of integers called myIntegerList
            List<int> myIntergerList = new List<int>();



            // TODO: Add 3 ints to the list you just created using the Add() function
            myIntergerList.Add(1);
            myIntergerList.Add(2);
            myIntergerList.Add(3);
            myIntergerList.Add(4);
            myIntergerList.Add(5);



            // TODO: Declare and initialize an empty array of doubles called myDoublesArray with a size of 5
            double[] myDoublesArray = new double[5];



            // TODO: Add 5 doubles to the array you just created using bracket notation
            myDoublesArray[0] = .1;
            myDoublesArray[1] = .2;
            myDoublesArray[2] = .3;
            myDoublesArray[3] = .4;
            myDoublesArray[4] = .5;



            // TODO: Declare and initialize an int array using ALL 5 of the different ways you are allowed to
            int[] scores = new int[5] { 100, 99, 98, 97, 96 }; // Explicit v1 -> Completely explicit
            int[] scores1 = new int[] { 100, 99, 98, 97, 96 }; // Explicit v2 -> no size specified in brackets 
            int[] scores2 = { 100, 99, 98, 97, 96}; // Explicit v3 -> shortest syntax
            var scores3 = new int[5] { 100, 99, 98, 97, 96 }; // Implicit v4 -> implicit typing 
            var scores4 = new int[] { 100, 99, 98, 97, 96 }; // Implicit  v5 -> no size specified in brackets



            // TODO: Declare and initialize a string array using initializer syntax
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };



            // TODO: Declare and initialize a char array using initializer syntax
            char[] grades = { 'A', 'B', 'B', 'C', 'A' };



            // TODO: Declare and initialize a bool array using initializer syntax
            bool[] passesInspection = { true, false, true, false };



            // TODO: Declare and initialize a list of strings using initializer syntax
            List<string> pets = new List<string>() { "Fido", "Spot", "Lassy", "Old yeller", "Champ" };



            // TODO: Declare and initialize a list of doubles using initializer syntax
            var list1 = new List<double>() { .11, .22, .33, .44, .55 };



            // TODO: Declare and initialize a list of floats using initializer syntax
            var list2 = new List<float>() { .11f, .22f, .33f, .44f, .55f };



            // TODO: Declare and initialize a list of chars using initializer syntax
            var list3 = new List<char>() { 'a', 'b', 'c', '1', '2', '3' };
            


            #endregion

            PrintNums(pets);
        }

        // TODO: Create a method that accepts a list of ints, removes the first item from the list, and then prints the entire list to the console
        public static void PrintNums(List<int> list)
        {
            list.RemoveAt(0);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }



        // TODO: Create an overload of the above method that accepts a list of strings, removes the first item from the list, and then prints the entire list to the console
        public static void PrintNums(List<string> list)
        {
            list.RemoveAt(0);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }



        // TODO: Create an overload of the above method that accepts a list of doubles, removes the first item from the list, and then prints the entire list to the console
        public static void PrintNums(List<double> list)
        {
            list.RemoveAt(0);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }



        // TODO: Create an overload of the above method that accepts a list of floats, removes the first item from the list, and then prints the entire list to the console
        public static void PrintNums(List<float> list)
        {
            list.RemoveAt(0);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }



        // TODO: Create a method that accepts an array of ints, removes the first item from the array, and then prints the entire array to the console
        public static void PrintNums(int[] arr)
        {
            int[] copy = new int[arr.Length - 1];

            for (int i = 1; i < arr.Length; i++)
            {
                copy[i] = arr[i];
            }

            foreach (var item in copy)
            {
                Console.WriteLine(item);
            }
        }



        // TODO: Create an overload of the above method that accepts a array of strings, removes the first item from the array, and then prints the entire array to the console
        public static void PrintNums(string[] arr)
        {
            string[] copy = new string[arr.Length - 1];

            for (int i = 1; i < arr.Length; i++)
            {
                copy[i] = arr[i];
            }

            foreach (var item in copy)
            {
                Console.WriteLine(item);
            }
        }



        // TODO: Create an overload of the above method that accepts a array of chars, removes the first item from the array, and then prints the entire array to the console
        public static void PrintNums(char[] arr)
        {
            char[] copy = new char[arr.Length - 1];

            for (int i = 1; i < arr.Length; i++)
            {
                copy[i] = arr[i];
            }

            foreach (var item in copy)
            {
                Console.WriteLine(item);
            }
        }



        // TODO: Create an overload of the above method that accepts a array of doubles, removes the first item from the array, and then prints the entire array to the console
        public static void PrintNums(double[] arr)
        {
            double[] copy = new double[arr.Length - 1];

            for (int i = 1; i < arr.Length; i++)
            {
                copy[i] = arr[i];
            }

            foreach (var item in copy)
            {
                Console.WriteLine(item);
            }
        }



    }
}
