using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        // program.Task_1_1(0, 2);
        // program.Task_1_2(0.9, 1.23);
        // program.Task_1_3(0.9, 1.23);
        //program.Task_1_4(0.9, 1.23, -0.1);
        // program.Task_1_5(4, 0);
        // program.Task_1_6(6, 9);
        // program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_1_9(0.9);
        //program.Task_1_10(0.9);
        //program.Task_2_1(10);
        // program.Task_2_2(3, 3, 2, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 2);
        // program.Task_2_5(30);
        // program.Task_2_6(5);
        // program.Task_2_7(5);
        // program.Task_2_8(3);
        // program.Task_2_9(10);
        // program.Task_2_10(10);
        // program.Task_2_11(10);
        // program.Task_2_12(1.5, 0);
        // program.Task_2_13(1.5, 3, 2);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        // program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        // program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        //program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        if (Math.Abs(x*x+y*y-4)<=Math.Pow(10,-3)) {
            answer = true;
        }
        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;
        if (y>= 0 && y+Math.Abs(x) <= 1) {
            answer = true;
        }
        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;
        bool c = (a>b)?true:false;
        if ((a>0 && c==true) || (a<=0 && c==false)) {
            answer = a;
        }
        else {
            answer = b;
        }
        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double a_and_b = (a>b)?b:a;
        answer = (a_and_b>c)?a_and_b:c;
        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        if (r <=0 || s < 0) {
            return false;
        }
        if (2*s<=4*r/Math.PI) {
            answer = true;
        }
        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        if (r <0 || s <= 0) {
            return false;
        }
        if (s>=4*r/Math.PI) {
            answer = true;
        }
        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;
        answer = (Math.Abs(x)>1)?1:Math.Abs(x);
        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;
        answer = (Math.Abs(x)>=1)?0:x*x-1;
        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;
        if (x<=-1) {
            answer = 0;
        }
        else if (x>0) {
            answer = 1;
        }
        else {
            answer = 1+x;
        }
        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;
        if (x<=-1) {
            answer = 1;
        }
        else if (x>1) {
            answer = -1;
        }
        else {
            answer = -x;
        }
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        double high = 0;
        for (int i = 0; i<n; i++) {
            string input = ReadLine();
            double.TryParse(input, out high);
            answer += high;
        }
        answer /= n;
        Math.Round(answer,2);
        WriteLine(answer);
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x,y;
        for (int h = 1; h <= n; h++) {
            double.TryParse(ReadLine(), out x);
            double.TryParse(ReadLine(), out y);           
            if (Math.Sqrt((x-a)*(x-a)+(y-b)*(y-b))<=r) {
                answer ++;
            }
        }
        WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        double weight;
        for (int y = 0; y<n; y++) {
            double.TryParse(ReadLine(), out weight);
            if (weight < 30 && weight!=0) {
                answer += 0.2;
            }
        }
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x,y;
        for (int h = 1; h <= n; h++) {
            double.TryParse(ReadLine(), out x);
            double.TryParse(ReadLine(), out y);
            double max_r =(r1>r2)?r1:r2;
            double min_r =(r1>r2)?r2:r1;
            if (Math.Sqrt(x*x+y*y)>=min_r && Math.Sqrt(x*x+y*y)<=max_r) {
                answer++;
            }
        }
        WriteLine(answer);
        return answer;
    }
    public int Task_2_5(double norm)
    {
        int answer = 0;
        double result;
        for (int l = 1; l <= 30; l++) {
            double.TryParse(ReadLine(), out result);
            if (result <= norm) {
                answer++;
            }
        }
        WriteLine(answer);
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        double x,y;
        for (int d = 1; d<=n; d++) {
            double.TryParse(ReadLine(), out x);
            double.TryParse(ReadLine(), out y);
            if (x>=0 && x<=Math.PI && y>=0 && y<= Math.Sin(x)) {
                answer++;
            }
        }
        WriteLine(answer);
        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        double x,y;
        for (int d = 0; d<n; d++) {
            double.TryParse(ReadLine(), out x);
            double.TryParse(ReadLine(), out y);
            int kvadrant = 0;
            if (x>0 && y>0) {
                answer1++;
                kvadrant = 1;
            }
            else if (x<0 && y>0) {
                kvadrant = 2;               
            }
            else if (x<0 && y<0) {
                answer3++;
                kvadrant = 3;
            }
            else if (x>0 && y<0) {
                kvadrant = 4;
            }
            else {
                continue;
            }
        }
        WriteLine(answer1);
        WriteLine(answer3);
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double x,y;
        double answerLength = double.MaxValue;
        for (int h = 1; h <= n; h++) {
            double.TryParse(ReadLine(), out x);
            double.TryParse(ReadLine(), out y);
            if (Math.Sqrt(x*x+y*y) < answerLength) {
                answerLength = Math.Round(Math.Sqrt(x*x+y*y),2);
                answer = h;
            }
        }
        WriteLine(answer);
        WriteLine(answerLength);
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double result;
        for (int g = 1; g<=n; g++) {
            double.TryParse(ReadLine(), out result);
            if (result < answer && result != 0) {
                answer = result;
            }
        }
        WriteLine(answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        int grade1, grade2, grade3, grade4;
        for (int a = 1; a<=n; a++) {
            int.TryParse(ReadLine(), out grade1);
            int.TryParse(ReadLine(), out grade2);
            int.TryParse(ReadLine(), out grade3);
            int.TryParse(ReadLine(), out grade4);
            if (grade1 >= 4 && grade2 >=4 && grade3 >=4 && grade4>=4) {
                answer++;
            }
        }
        WriteLine(answer);
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        int grade1, grade2, grade3, grade4;
        for (int a = 1; a<=n; a++) {
            int.TryParse(ReadLine(), out grade1);
            int.TryParse(ReadLine(), out grade2);
            int.TryParse(ReadLine(), out grade3);
            int.TryParse(ReadLine(), out grade4);
            avg += grade1+grade2+grade3+grade4;
            if (grade1 == 2 || grade2==2 || grade3==2 || grade4==2) {
                answer++;   
            }
        }
        avg /= 4*n;
        Math.Round(avg,2);
        WriteLine(answer);
        WriteLine(avg);
        return (answer,avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        if (type < 0 || type >=3 || r<=0) {
            return 0;
        }
        switch (type) {
            case 0:
                answer = Math.Round(r*r,2);
                break;
            case 1:
                answer = Math.Round(r*r*Math.PI,2);
                break;
            case 2:
                answer = Math.Round(r*r * Math.Sqrt(3)/4, 2);
                break;
        }
        WriteLine(answer);

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        if (type < 0 || type>=3 || A<=0 || B<=0) {
            return 0;
        }
        switch (type) {
            case 0:
                answer = Math.Round(A*B,2);
                break;
            case 1:
                answer = Math.Round(Math.PI*Math.Abs(A*A-B*B),2);
                break;
            case 2:
                double p = (A+B+B)/2;
                answer = Math.Round(Math.Sqrt(p*(p-A)*(p-B)*(p-B)),2);
                break;
        }
        WriteLine(answer);
        return answer;
    }
    #endregion

    #region Level 3
    //3,6,9
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;

        // code here

        // end

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        double weight;
        for (int i = 1; ;i++) {
            string input = ReadLine();
            if (input == "STOP") {
                break;
            }
            double.TryParse(input, out weight);
            if (weight<30 && weight!=0) {
                answer+=0.2;
            }
        }
        WriteLine(answer);
        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0;
        double x,y;
        for (int d = 1; ; d++) {
            string input_x = ReadLine();
            if (input_x == "STOP") {
                break;
            }
            else {
                string input_y = ReadLine();
                double.TryParse(input_x, out x);
                double.TryParse(input_y, out y);
                if (x>=0 && x<=Math.PI && y>=0 && y<= Math.Sin(x)) {
                    answer++;
                }
            }
        }
        WriteLine(answer);
        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        double result;
        for (int g = 1; ; g++) {
            string input = ReadLine();
            if (input == "STOP") {
                break;
            }
            double.TryParse(input, out result);
            if (result < answer && result != 0) {
                answer = result;
            }
        }
        WriteLine(answer);
        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;

        // end

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;

        // end

        return (answer, avg);
    }
    #endregion
}
