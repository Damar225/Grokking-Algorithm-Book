
/**
*
* This is the binary search algorithm implemented using C#
*
*/

class Program {

	public static void Main(string[] args) {
		int[] array = new int[10];
		for(int i = 0; i < array.Length; i++)
			array[i] = i + 1;
		
		int numberOfsteps = 0;
		Console.WriteLine("The element index is: " + BinarySearch(array, 6, ref numberOfsteps));
		Console.WriteLine("The number of steps: " + steps);
	}
	
	
	public static int? BinarySearch(int[] array, int element, ref int numberOfsteps) {
		int low = 0;
		int high = array.Length;
		
		while(low <= high) {
			numberOfsteps++;
			int mid = (low + high) / 2;
			int guess = array[mid];
			
			if(guess == element) {
				return mid;
			} else if(guess > element) {
				high = mid - 1;
			} else {
				low = mid + 1;
			}
		}
		
		return null;
	}
}
