public class Array {

	public static void main(String[] args) {
//		Random ran = new Random();
//		int [][] score = new int[4][4];
//		for(int i =0 ; i<4; i++) {
//			for(int j=0; j<4; j++) {
//				score[i][j] = ran.nextInt(10);
//			}
//		for(int k=0;k<4;k++) {
//			int sum = 0;
//			for() {
//				sum =
//			}
//		}
//		System.out.println();
		PlusMinus ob1 = new PlusMinus();
		int ssum, sminus;
		ssum = ob1.plus(30,50);
		System.out.println("두수의 합은 : "+ssum);
	}
}

class PlusMinus{
	int plus, minus;
	public int plus(int x, int y) {
		plus = x+y;
		return plus;
	}
	
	public int minus(int x, int y) {
		minus = x-y;
		return minus;
	}
}