void Fibo(int num)
{
    var fibo = new List<int> { 0, 1 };

    if (num == 0 || num == 1)
    {
        Console.WriteLine($"O numero {num} está na sequencia de Fibonacci.");
        return;
    }

    int indexUltimoNumero = 1;
    int indexPenultimoNumero = 0;

    while (fibo[indexUltimoNumero] < num)
    {
        fibo.Add(fibo[indexUltimoNumero] + fibo[indexPenultimoNumero]);
        indexUltimoNumero++;
        indexPenultimoNumero++;
    }

    if (fibo[indexUltimoNumero] == num)
    {
        Console.WriteLine($"O numero {num} está na sequencia de Fibonacci.");
        return;
    }

    Console.WriteLine($"O numero {num} NÃO está na sequencia de Fibonacci.");
    return;
}

Fibo(34);

void ReverseString(string str)
{
    string newStr = String.Empty;
    for(int i = str.Length - 1; i >= 0; i--) 
    {
        newStr += str[i];
    }

    Console.WriteLine(newStr);
}

ReverseString("joao henrique");