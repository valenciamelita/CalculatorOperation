using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Program
{
    public static double Pembagian(double e, double f, double result)
    {
        result = e / f;
        return result;
    }
    public static void Perkalian(int angkapisah, double result)
    {
        result = result * angkapisah;
    }
    public static void Pengurangan(int angkapisah, double result)
    {
        result = result - angkapisah;
    }
    public static void Pertambahan(int angkapisah, double result)
    {
        result = result + angkapisah;
    }
    public static void Main()
    {
        List<string> simbol = new List<string>();
        List<int> angkapisah = new List<int>();
        char[] angkapis;
        bool samadengan = true;
        double result = 0;
        double e;
        double f;
        string[] a = new string[100];
        int[] b = new int[100];

        Console.WriteLine("Input Operations: ");
        string oper = Console.ReadLine();
        angkapis = oper.ToCharArray();
        samadengan = oper.EndsWith("=");
        oper = oper.Substring(0, oper.Length - 1);
        a = oper.Split('+', '-', '*', '/','=');

        for (int i = 0; i < oper.Length; i++)
        {
            if (oper[i] == '+' || oper[i] == '-' || oper[i] == '*' || oper[i] == '/' || oper[i] == '=')
            {
                simbol.Add(angkapis[i].ToString());
            }
        }

        while (a.Length < 2 || a[a.Length-1]==""  || a.Length == simbol.Count|| a[a.Length-2] ==""||samadengan==false)
        {
            Console.WriteLine("Invalid Input.");
            Console.WriteLine("Input Operations: ");
            oper = Console.ReadLine();
            angkapis = oper.ToCharArray();

            samadengan = oper.EndsWith("=");
            oper = oper.Substring(0, oper.Length - 1);
            a = oper.Split('+', '-', '*', '/','=');
            for (int i = 0; i < oper.Length; i++)
            {
                if (oper[i] == '+' || oper[i] == '-' || oper[i] == '*' || oper[i] == '/' || oper[i] == '=')
                {
                    simbol.Add(angkapis[i].ToString());
                }
            }
        }
        
        for (int i = 0; i < a.Length; i++)
        {
            b[i] = Convert.ToInt32(a[i]); 
        }

        for (int i = 0; i < angkapis.Length; i++)
        {
            angkapisah.Add(b[i]);
        }

        result = angkapisah[0];
        for (int j = 0; j < simbol.Count; j++)
        {
            
            if (simbol[j] == "+")
            {
                Pertambahan(angkapisah[j + 1], result);
                result = result + angkapisah[j + 1];
            }
            if (simbol[j] == "-")
            {
                Pengurangan(angkapisah[j + 1], result);
                result = result - angkapisah[j + 1];
            }
            if (simbol[j] == "*")
            {
                Perkalian( angkapisah[j+1], result);
                result = result * angkapisah[j + 1];
            }
            if (simbol[j] == "/")
            {
                e = Convert.ToDouble(result);
                f = Convert.ToDouble(angkapisah[j + 1]);
                result = e / f;
                Pembagian(e, f, result);
            }

            }
        Console.WriteLine(result);
    }
    
 }
