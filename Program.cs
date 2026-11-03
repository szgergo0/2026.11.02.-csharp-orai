//1
int abs_max(int a, int b)
{
    a = Math.Abs(a);
    b = Math.Abs(b);
    return Math.Max(a, b);
}
Console.WriteLine(abs_max(12, -15));


//2
int fibo(int n)
{
    if (n == 0)
    {
        return 0;
    }
    if (n <= 2)
    {
        return 1;
    }

    return fibo(n - 1) + fibo(n - 2);
}
Console.WriteLine(fibo(10));



// 6
int jelszo_erosseg(string jelszo)
{
    int erosseg = 1;
    if (jelszo.Length >= 5)
    {
        erosseg += 1;
    }
    if (jelszo.Length >= 8)
    {
        erosseg += 2;
    }
    foreach (char a in jelszo)
    {
        if (a == '-')
        {
            erosseg += 2;
        }
        if (a == '_')
        {
            erosseg += 2;
        }
        if (a == '.')
        {
            erosseg += 2;
        }

    }
    if (jelszo.Contains("123"))
    {
        erosseg = 0;
    }
    if (jelszo.Contains("jelszo"))
    {
        erosseg = 0;
    }
    if (jelszo.Length == 0)
    {
        erosseg = 0;
    }
    return erosseg;
}
Console.WriteLine(jelszo_erosseg("hazi_macska_4_life"));


//7

string maganhangzot_torol(string szoveg)
{
    string maganhangzok = "aeiou";
    string rendesszov = "";
    foreach (char a in szoveg)
    {
        if (maganhangzok.Contains(char.ToLower(a)))
        {
            continue;
        }
        else
        {
            rendesszov += a;
        }
    }
    return rendesszov;
}
Console.WriteLine(maganhangzot_torol("Iden Java szigeten voltunk nyaralni. Nem is tudtam, hogy elneveztek egy helyet egy programozasi nyelvrol."));

8 szoveg titkositas

string kodol(string uzenet, int n, char c)
{
    string kimenet = "";
foreach (char i in uzenet)
{
    kimenet += i;
    for (int h = 1; h <= n; h++)
    {
        kimenet += c;
    }
}
return kimenet;
}
Console.WriteLine(kodol("Pizza delben?", 3, 'x'));