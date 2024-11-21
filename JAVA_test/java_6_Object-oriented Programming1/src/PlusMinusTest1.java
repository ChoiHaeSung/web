
public class PlusMinusTest1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		PlusMinus ob1 = new PlusMinus();
		int ssum, sminus;
		ssum = ob1.plus(50,30);
		sminus = ob1.minus(50,30);
		System.out.println("   두수의 합은 : " + ssum);
		System.out.println("   두수의 차은 : " + sminus);
		
	}
}

class PlusMinus{
	int plus1, minus1;
	public int plus(int x, int y) {
		plus1 = x + y;
		return plus1;
	}
	public int minus(int x, int y) {
		plus1 = x - y;
		return plus1;
	}

}


