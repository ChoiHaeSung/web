import java.util.Arrays;

public class Ex_006 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String[] strArr = {"가위", "바위", "보"};
		System.out.println(Arrays.toString(strArr));	//
		
		for(int i=0; i<10;i++) {		// 정수 i를 10번 반복
			int tmp = (int)(Math.random()*3); // 변수 tmp 선정해서 랜덤의 3가지 숫자를 출력
			System.out.println(strArr[tmp]);	// 문자열의 숫자를 입력
			
		}
		
	}

}
