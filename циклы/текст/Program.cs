// Дан текст. В тексте все пробелы нужно заменить черточками, 
// маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с".

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = “qwerty”
//             012345
// s[3] // r

string Replase(string text, char oldValue, char newValue) // string text- входной текст; char-конкретный символ
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replase(text, " ", "|");
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(text, "к", "К");
Console.WriteLine(newText);
