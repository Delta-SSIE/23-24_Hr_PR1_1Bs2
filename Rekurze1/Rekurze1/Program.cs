
    string text = "Hello, World!";
    Vyznakuj(text, 5);

static void Vyznakuj(string text, int n)
{
    if (n < text.Length)
    {
        VypisZnak(text[n]);
        Vyznakuj(text, n + 1);
    }
}

static void VypisZnak(char znak)
{
    Console.Write(znak);
}

