package chap06;

class MyInt{
	int a;
}
public class cha {
	static void func1(MyInt m) {
		m.a = m.a + 1;
		System.out.printf("전달 받은 a ==> %d%n",m.a);
	}

	public static void main(String[] args) {
//		MyMath mm = new MyMath();
//		long result1 = mm.add(5L,3L);
//		long result2 = mm.subtract(5L,3L);
//		long result3 = mm.multiply(5L,3L);
//		double result4 = mm.divide(5L,3L);
//		
//		System.out.println("add(5L, 3L) = "+result1);
//		System.out.println("subtract(5L, 3L) = "+result2);
//		System.out.println("multiply(5L, 3L) = "+result3);
//		System.out.println("divide(5L, 3L) = "+result4);
//	}
//}
//
//class MyMath{
//	long add(long a, long b) {
//		long result = a+b;
//		return result;
//		
//	}
//	long subtract(long a, long b) {return a - b;}
//	long multiply(long a, long b) {return a * b;}
//	double divide(double a, double b) {
//		return a/b;
//		Data d = new Data();
//		d.x = 10;
//		System.out.println("main() : x = " + d.x);
//		
//		change(d);
//		System.out.println("After change(d)");
//		System.out.println("main() : x = " + d.x);
//	}
//	static void change(Data d) {
//		d.x = 1000;
//		System.out.println("change() : x =" +d.x);
		
		MyInt m = new MyInt();
		m.a = 10;
		
		func1(m);
		System.out.printf("func1()실행 후의 a ==> %d%n", m.a);
	}
}