﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calulator
{
    internal class Calculation
    {
        static private bool IsDelimeter(char c)
        {
            if ((" =".IndexOf(c) != -1))
                return true;
            return false;
        }
        static private bool IsOperator(char с)
        {
            if (("+-/*()".IndexOf(с) != -1))
                return true;
            return false;
        }

        static private byte GetPriority(char s)
        {
            switch (s)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 3;
                case '*': return 4;
                case '/': return 4;
                default: return 5;
            }
        }
        static public double Calculate(string input)
        {
            string output = GetExpression(input); 
            double result = Counting(output); 
            return result;
        }

        static private string GetExpression(string input)
        {
            string output = string.Empty;
            Stack<char> operStack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                
                if (IsDelimeter(input[i]))
                    continue; 

                
                if (Char.IsDigit(input[i]))
                {
                    
                    while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                    {
                        output += input[i];
                        i++;

                        if (i == input.Length) break;
                    }

                    output += " "; 
                    i--; 
                }

                
                if (IsOperator(input[i])) 
                {
                    if (input[i] == '(') 
                        operStack.Push(input[i]); 
                    else if (input[i] == ')') 
                    {
                        
                        char s = operStack.Pop();

                        while (s != '(')
                        {
                            output += s.ToString() + ' ';
                            s = operStack.Pop();
                        }
                    }
                    else 
                    {
                        if (operStack.Count > 0)
                            if (GetPriority(input[i]) <= GetPriority(operStack.Peek()))
                                output += operStack.Pop().ToString() + " "; 

                        operStack.Push(char.Parse(input[i].ToString())); 

                    }
                }
            }

            
            while (operStack.Count > 0)
                output += operStack.Pop() + " ";

            return output; 
        }

        static private double TransposeFromSixToTenSystem(string NumberInSix)
        {
            double result = 0;
            double num = double.Parse(NumberInSix);
            int firstPart = (int)Math.Abs(num);
            double secondPart = Math.Round(Math.Abs(num) - firstPart,5);
            bool sign = num < 0? true : false;
            int PositivePow = 0;
            int NegativePow = -5;
            while(firstPart > 0)
            {
                result += (firstPart % 10) * Math.Pow(6, PositivePow++);
                firstPart /= 10;
            }
            if (secondPart != 0)
            {
                secondPart *= Math.Pow(10, 5);
                secondPart = Math.Round(secondPart);
                for(int i =0; i< 5; i++)
                {
                    int n = (int)secondPart % 10;
                    double temp = Math.Round(n * Math.Pow(6, NegativePow++),5);
                    result += temp;
                    secondPart = (int)(secondPart / 10);
                }
            }
            result = Math.Round(result, 5);
            if (sign) { result *= -1; }
            return result;
        }

        static private double TransposeFromTenToSixSystem(double NumberInTen)
        {
            double result = 0;
            int pow = 0;
            bool sign = NumberInTen < 0 ? true : false;
            int FirstPart = Math.Abs((int)NumberInTen);
            double LastPart = Math.Abs(NumberInTen) - FirstPart;
            while (FirstPart >= 1)
            {
                result += (FirstPart % 6) * Math.Pow(10, pow++);
                FirstPart /= 6;
            }
            if (LastPart != 0)
            {
                String s = "0,";
                for(int i =0; i < 5;i++)
                {
                    LastPart *= 6;
                    int temp = (int)LastPart;
                    s += temp;
                    LastPart -= temp;
                }
                result += Math.Round(double.Parse(s),5);
            }
            if (sign) { result *= -1; }
            return result;
        }

        static private double Counting(string input)
        {
            double result = 0;
            Stack<double> temp = new Stack<double>();

            for (int i = 0; i < input.Length; i++)
            {
                
                if (Char.IsDigit(input[i]))
                {
                    string a = string.Empty;

                    while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                    {
                        a += input[i];
                        i++;
                        if (i == input.Length) break;
                    }
                    temp.Push(TransposeFromSixToTenSystem(a));
                    i--;
                }
                else if (IsOperator(input[i]))
                {
                   
                    double a = temp.Pop();
                    double b = temp.Pop();

                    switch (input[i])
                    {
                        case '+': result = b + a; break;
                        case '-': result = b - a; break;
                        case '*': result = b * a; break;
                        case '/': result = b / a; break;
                    }
                    temp.Push(result); 
                }
            }
            var res = TransposeFromTenToSixSystem(temp.Peek());
            return res;
        }

    }
}
