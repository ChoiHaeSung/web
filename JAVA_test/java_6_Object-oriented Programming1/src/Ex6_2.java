import java.sql.Time;

public class Ex6_2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Time t1 = new Time();
		t1.hour = 12;
		t1.minute = 30;
		t1.second = 10;
		
		Time t2 = new Time(11,20,05);
		
		System.out.println("현재시각은 " + t1.hour + "시"
				+ t1.minute + "분" + t1.second + "초 입니다");
		System.out.println("현재시각은 " + t2.hour + "시"
				+ t2.minute + "분" + t2.second + "초 입니다");
		
	}
}
class Time{
	int hour;
	int minute;
	int second;
	Time (){
	}
	Time(int h, int m, int s){
		hour = h;
		minute = m;
		second = s;
	}
}
