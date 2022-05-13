using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Practice
{
    public class Exercises
    {

        public bool isPalindrome(String s)
        {
            bool result = true;//result
            //pointer to iterate the word
            int leftPointer = 0;
            int rightPointer = s.Length - 1;

            while (leftPointer < rightPointer)
            {//until the pointer meet
                if (s[leftPointer] != s[rightPointer])
                {//if the letter is different, is not a palindrome
                    result = false;
                    break;
                }
                //move the pointers
                ++leftPointer;
                --rightPointer;
            }
            return result;
        }


        public bool validParenthesis(String s)
        {
            Stack<char> st = new Stack<char>();//to store the parenthesis

            for (int i = 0; i < s.Length; i++)
            {//iterate on the string
                switch (s[i])
                {//switch the character
                    case '{'://opening bracket
                        //add into the stack
                        st.Push(s[i]);
                        break;
                    case '['://opening parenthesis
                        //add into the stack
                        st.Push(s[i]);
                        break;
                    case '}':
                        //need to check if the top char in the stack matches this parenthesis
                        char t1 = st.Pop();
                        if (t1 != '{')
                        {//non-matching opening bracket, return false
                            return false;
                        }
                        break;
                    case ']':
                        //need to check if the top chat in the stack matches this parenthesis
                        char t2 = st.Pop();
                        if (t2 != '[')
                        {//non-matching opening parenthesis, return false 
                            return false;
                        }
                        break;
                    default:
                        //ignore character as it is not a parenthesis
                        break;
                }
            }

            //already processed the string, need to check if the stack is empty
            //if the stack is not empty, then there are missing parenthesis
            if (st.Count == 0)
                return true;
            else
                return false;
        }


        //i like this program very much
        public char[] ReverseWordsInPlace(char[] s)
        {
            int start = 0;
            for (int end = 0; end < s.Length; ++end)
            {//itterate on the string
                if (s[end] == ' ')
                {//if there is a blank space, need to revert previous word
                    ReverseAt(s,start,end-1);
                    start = end + 1;//new word start
                }
            }

            //reverse the last word
            ReverseAt(s,start,s.Length-1);

            //reverse the entire sentence
            ReverseAt(s, 0, s.Length-1);

            return s;
        }

        private void ReverseAt(char[] s, int start, int finish)
        {
            //reverse the chars from start to finish in place
            while (start < finish)
            {//until the change is performed
                char temp = s[start];
                s[start] = s[finish];
                s[finish] = temp;
                //increase the pointers
                ++start;
                --finish;
            }
        }


        public int HexToInteger(String hex)
        {
            String binary = HexToBinary(hex);//first, conver to binary

            return BinaryToDecimal(binary);//from binary to intenger
        }

        private int BinaryToDecimal(string binary)
        {
            int result = 0;
            int multiplier = 1;
            for (int i = binary.Length - 1; i >= 0; --i)
            {//iterate on string
                if (binary[i] == '1')
                {//need to sum the multiplier
                    result += multiplier;
                }
                multiplier *= 2;//next multiplier
            }
            return result;
        }

        private String HexToBinary(String hex)
        {
            String result = "";

            Dictionary<char, string> HexToBin = new Dictionary<char, string>();
            //se llena el dictionario
            HexToBin.Add('0',"0000");
            HexToBin.Add('1',"0001");
            HexToBin.Add('2',"0010");
            HexToBin.Add('3',"0011");
            HexToBin.Add('4',"0100");
            HexToBin.Add('5',"0101");
            HexToBin.Add('6',"0110");
            HexToBin.Add('7',"0111");
            HexToBin.Add('8',"1000");
            HexToBin.Add('9',"1001");
            HexToBin.Add('A',"1010");
            HexToBin.Add('B',"1011");
            HexToBin.Add('C',"1100");
            HexToBin.Add('D',"1101");
            HexToBin.Add('E',"1110");
            HexToBin.Add('F',"1111");

            foreach (char c in hex)
            {//convert each letter to binary
                result += HexToBin[c];
            }

            return result;
        }


        public List<int> PrimeNumbersInRage(int start, int finish)
        {
            List<int> result = new List<int>();

            for (int i = start; i <= finish; ++i)
            { //iterate on the range
                bool isPrime = true;
                for (int j = 2; j < i; ++j)
                { //starts in 2 because all numbers are divisible by 1
                    //ends before i as all numbers are divisible by itself
                    if (i % j == 0)
                    {//i is divisible by j, not a prime 
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)//check if i is prime
                    result.Add(i);
            }

            return result;
        }


        //1    0    5    10    0    6    9    1
        //0    1    5    10    0    6    9    1

        public int[] MoveZerosToLeft(int[] array)
        {
            int pos = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] == 0)
                {
                    array[i] = array[pos];
                    array[pos] = 0;
                    ++pos;
                }
            }
            return array;
        }

        public int Fibonacci(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        //10   4   3   5   7   1
        //4   10   3   5   7   1
        public int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length-1; ++i)
            {
                for (int j = 0; j < array.Length-1 - i; ++j)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }

            }

            return array;
        }


        public int[] SelectionSort(int [] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                int pos = i;
                for (int j = i + 1; j < array.Length; ++j)
                {
                    if (array[j] < array[pos])
                    {
                        pos = j;
                    }
                }
                int temp = array[pos];
                array[pos] = array[i];
                array[i] = temp;
            }
            return array;
        }

        public int[] ArrayThatSums(int[] array, int sum)
        {
            int[] result = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();//[value,index]
            for (int i = 0; i < array.Length; ++i)
            {
                if (dict.ContainsKey(sum - array[i]))
                {//found both that numbers that sum, save the indexes
                    result[0] = i;
                    result[1] = dict[sum - array[i]];
                    break;
                }
                else
                {//no match yet, add the current to the dictionary
                    dict.Add(array[i], i);
                }
            }

            return result;
        }



        //1 => A
        //2 => B
        //26 =>Z
        //
        //27 => AA
        //28 => AB
        public String NumberToColumns(int number)
        {
            String result = "";

            while (number != 0)
            {
                int m = number % 26;
                result = (char)(64 + m) + result;
                number = number / 26;
            }

            return result;
        }

    }
}
