﻿var a1 = new AAA();
var a2 = new AAA();
a1.b1 = 10;
AAA.b2 = 20;
a2.b1 = 30;
AAA.b2 = 40; // แก้ไขการเข้าถึง

System.Console.WriteLine($"a1.b1 = {a1.b1}");
System.Console.WriteLine($"AAA.b2 = {AAA.b2}");
System.Console.WriteLine($"a2.b1 = {a2.b1}");
System.Console.WriteLine($"a2.b2 = {AAA.b2}"); // แก้ไขการเข้าถึง

class AAA
{
    public int b1;
    public static int b2;
}