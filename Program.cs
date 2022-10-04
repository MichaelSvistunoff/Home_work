Console.Write("Enter length of array: ");
int length = int.Parse(Console.ReadLine()!);

int[] newArray = getArray(length);
int sum = countPositive(newArray);
Console.WriteLine($"Your array: [{String.Join(", ", newArray)}] where positive elements: {sum}");

int[] getArray (int size) {
    int[] newArray = new int[size];
    for (int i=0; i<5; i++) {
        Console.Write($"Input element-{i}: ");
        newArray[i] = int.Parse(Console.ReadLine()!);
    }
    return newArray;
}

int countPositive (int[] array) {
    int count = 0;

    for (int i=0; i<array.Length; i++) {
        if (array[i]>0) {
            count++;
        }
    }
    return count;
}