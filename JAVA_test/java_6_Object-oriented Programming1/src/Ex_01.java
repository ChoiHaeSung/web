import java.util.Scanner;

public class Ex_01 {

	public static void main(String[] args) {
		Tv 		t  = new Tv();		
		// New Tv()부분을 생성자;
		t.channel = 7;
		t.channeldown();
		System.out.println("현재 채널은 " + t.channel + "입니다");
	}

}

class Tv{
	String color;
	boolean power;
	int channel;
	void power() {
		power = !power;
		
	}
	void channelup() {
		++channel;
	}
	void channeldown() {
		--channel;
	}
}

