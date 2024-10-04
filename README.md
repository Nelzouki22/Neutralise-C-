# Neutralise C#
# Neutralisation

## وصف المهمة
تقوم هذه المهمة بإرجاع سلسلة جديدة بناءً على تفاعل سلسلتين من الرموز `+` و `-`. يتم معالجة التفاعلات بين الرموز وفقًا للقواعد التالية:

1. عندما تتفاعل رموز `+` مع `+`، تبقى النتيجة `+`.
2. عندما تتفاعل رموز `-` مع `-`، تبقى النتيجة `-`.
3. عند تفاعل `+` مع `-`، تصبح النتيجة `0`.

## أمثلة
- `Neutralise("+-+", "+--")` ➞ `"+-0"`
- `Neutralise("--++--", "++--++")` ➞ `"000000"`
- `Neutralise("-+-+-+", "-+-+-+")` ➞ `"-+-+-+"`
- `Neutralise("-++-", "-+-+")` ➞ `"-+00"`

## كيفية الاستخدام
يمكنك استخدام الدالة `Neutralise` كما يلي:

```csharp
using System;

class Program
{
    static string Neutralise(string s1, string s2)
    {
        string result = "";
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] == '+' && s2[i] == '+')
            {
                result += '+';
            }
            else if (s1[i] == '-' && s2[i] == '-')
            {
                result += '-';
            }
            else
            {
                result += '0';
            }
        }
        return result;
    }

    static void Main()
    {
        // مثال على الاستخدام
        Console.WriteLine(Neutralise("+-+", "+--") + " ➞ " + "+-0");
        Console.WriteLine(Neutralise("--++--", "++--++") + " ➞ " + "000000");
        Console.WriteLine(Neutralise("-+-+-+", "-+-+-+") + " ➞ " + "-+-+-+");
        Console.WriteLine(Neutralise("-++-", "-+-+") + " ➞ " + "-+00");
    }
}
ملاحظات
السلسلتان ستكونان بنفس الطول.
يمكنك تعديل الدالة لتناسب احتياجاتك الخاصة.
Neutralisation
Task Description
This task involves returning a new string based on the interaction of two strings composed of the symbols + and -. The interactions are processed according to the following rules:

When + interacts with +, the result remains +.
When - interacts with -, the result remains -.
When + interacts with -, the result becomes 0.
Examples
Neutralise("+-+", "+--") ➞ "+-0"
Neutralise("--++--", "++--++") ➞ "000000"
Neutralise("-+-+-+", "-+-+-+") ➞ "-+-+-+"
Neutralise("-++-", "-+-+") ➞ "-+00"
How to Use
You can use the Neutralise function as follows:

csharp
using System;

class Program
{
    static string Neutralise(string s1, string s2)
    {
        string result = "";
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] == '+' && s2[i] == '+')
            {
                result += '+';
            }
            else if (s1[i] == '-' && s2[i] == '-')
            {
                result += '-';
            }
            else
            {
                result += '0';
            }
        }
        return result;
    }

    static void Main()
    {
        // Example usage
        Console.WriteLine(Neutralise("+-+", "+--") + " ➞ " + "+-0");
        Console.WriteLine(Neutralise("--++--", "++--++") + " ➞ " + "000000");
        Console.WriteLine(Neutralise("-+-+-+", "-+-+-+") + " ➞ " + "-+-+-+");
        Console.WriteLine(Neutralise("-++-", "-+-+") + " ➞ " + "-+00");
    }
}
Notes
The two strings will be of the same length.
You can modify the function to suit your specific needs.
markdown

### كيفية استخدام ملف `README.md`

1. افتح محرر النصوص المفضل لديك.
2. أنشئ ملفًا جديدًا وسمه `README.md`.
3. انسخ المحتوى أعلاه والصقه في الملف الجديد.
4. احفظ الملف.

يمكنك تعديل المحتوى حسب احتياجات مشروعك!
