
public class Ex_007 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		String str = "ABCDE";
		char ch = str.charAt(2);			// str 0, 1,2,3,4 => 2번쨰 위치 문자 출력
		String str2 = str.substring(1,4);	// str B~D까지 출력
		String str3 = str.substring(1);		// str B~ 출력
		System.out.println(ch);
		System.out.println(str2);			// 
		System.out.println(str3);
		
	}

}
