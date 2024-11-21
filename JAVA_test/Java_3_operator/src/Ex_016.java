
public class Ex_016 {
	public static void main(String[] args) {
		int result = 0;
		int x = 5;
		int y = 3;
//		result = (x > y) ? x : y;
		if ( x > y)
			result = x;
		else
			result = y;
		System.out.println("resutl값은 :" + result);
	}
}
