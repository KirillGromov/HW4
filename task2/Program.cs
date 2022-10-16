

int num1 = int.Parse(Console.ReadLine());

void sum(int num){
    List<int> listForArr = new List<int>();
    while(num>0){
        int numForSum = num%10;
        num = num/10;
        listForArr.Add(numForSum);
    }
    int[] numbers = listForArr.ToArray();
    int sum = 0;
    foreach(int i in numbers){
        sum +=i;
    }

    Console.WriteLine("Сумма элементов:");
    Console.WriteLine(sum);

}

sum(num1);