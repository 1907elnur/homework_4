static int SolaReqemYaz(int num)
{
    return int.Parse("1" + num.ToString());
}

int result = SolaReqemYaz(907);

Console.WriteLine(result);