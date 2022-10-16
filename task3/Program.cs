void showArray(){
    int[] array = new int[8];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(0, 999);

    String str = "[";

    foreach(int i in array){
        str = str + i.ToString() + ", ";
    }

    str = str.Remove(str.Length - 2);
    str = str + "]";

    Console.WriteLine(str);
}


showArray();
