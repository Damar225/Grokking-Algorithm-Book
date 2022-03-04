
class Program {

	public static void Main(string[] args) {
		int[] array = {1, 2, 4, 20, 17, 1, 22, 60, 6, 7, 3, 5, 8};
		
		for(int i = 0; i < array.Length; i++)
			Console.Write(array[i] + ", ");
			
		Console.WriteLine();
		Console.WriteLine("------------ after ------------");
		SelectionSort(array);
		for(int i = 0; i < array.Length; i++)
			Console.Write(array[i] + ", ");
	}
	
	
	public static void SelectionSort(int[] array) {
		int n = array.Length;
		for(int i = 0; i < n; i++) {
			int minNumber = array[i];
			int minIndex = i;
			for(int j = i; j < n; j++) {
				if(array[j] < minNumber) {
					minNumber = array[j];
					minIndex = j;
				}
			}
			
			// exchange
			int temp = array[minIndex];
			array[minIndex] = array[i];
			array[i] = temp;
		}
	}
	
}
