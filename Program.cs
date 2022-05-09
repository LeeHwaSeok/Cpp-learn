using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1차
            // Console.WriteLine("Hello World!");
            // char grade = 'A';    //''문자, ""문자열
            // Console.WriteLine(grade);
            // int? a = null;
            // Console.WriteLine(a);

            //2차
            // double d = 23.12;
            // int i = 12345;
            // d = i;
            // Console.WriteLine("임시적 형식 변환 = " + d);

            // d = 12.34;
            // i = (int)d;
            // Console.WriteLine("명시적 형식 변환 = " + i);

            // string s = "";
            // s = Convert.ToString(d);
            // Console.WriteLine("형식 변환 = " + s);

            // //3차
            // int ko = 100; 
            // int math = 99; 
            // int eng = 90;
            // int sum = ko + math +eng;
            // float avg = (float)sum / 3;
            // // string _sum = "";
            // // string _avg = "";
            // // _sum = Convert.ToString(sum);
            // // _avg = Convert.ToString(avg);
            // Console.WriteLine("총점 = "+ sum + " 평균 = " + avg);


            // //4차 input을 받아서 console 출력
            // string major1,major2,major3, score;
            // int score1,score2,score3, _sum;
            // float _avg;

            // Console.Write("과목을 입력하세요  : ");
            // major1 = Console.ReadLine();
            // Console.Write("점수를 입력하세요  : ");
            // score1 = int.Parse(Console.ReadLine()); 

            // Console.Write("과목을 입력하세요  : ");
            // major2 = Console.ReadLine();
            // Console.Write("점수를 입력하세요  : ");
            // score2 = int.Parse(Console.ReadLine());  

            // Console.Write("과목을 입력하세요  : ");
            // major3 = Console.ReadLine();
            // Console.Write("점수를 입력하세요  : ");
            // score3 = int.Parse(Console.ReadLine());  
            // _sum = score1 + score2 + score3;
            // _avg = (float)_sum / 3;

            // // if (90<_avg){
            // //     score = "A";
            // // } else if(80<_avg){
            // //     score = "B";
            // // } else if(70<_avg){
            // //     score = "C";
            // // } else if(60<_avg){
            // //     score = "D";
            // // } else{
            // //     score = "F";
            // // }
            // switch((int)_avg/10) {       
			// 	case 10: case 9:
            //         score = "A";
			// 		break;
			// 	case 8:
            //         score = "B";
			// 		break;
			// 	case 7:
            //         score = "C";
			// 		break;
			// 	case 6:
            //         score = "D";
			// 		break;
  			// 	case 5:case 4:case 3:case 2:case 1:case 0:
            //         score = "F";
   			// 		break;
            //     default:
            //         Console.WriteLine("에러");
            //         score = "";
            //         break;
			// }

            // Console.WriteLine("\n{0} : {3} {1} : {4} {2} : {5}",major1,major2,major3,score1,score2,score3);
            // Console.WriteLine("총점 : {0} \n평균 : {1:F1} \n학점 : {2}",_sum, _avg, score);

            //5차 배열로 문자받아오기            
            
            int _sum = 0, num = 0;         //python '_' 내장함수랑 구별짓기위해서 
            float _avg = 0;                 // python ConsoleWriteLine 단어 첫시작 대문자로 ->낙타형식
            string _asc;

            Console.WriteLine("몇개의 과목 정보를 입력하시겠습니까? : ");   //input = writeline
            num = int.Parse(Console.ReadLine());                        // a = input("") == num = Realine
            int[] person = new int[num];                               
            string[] _score = new string[num];

            for(int i = 0; i < num; i++){  //for x in len(range(num)) 0~>// 초기값 ; 최종값 ; 증감형태 
            Console.Write("과목을 입력하세요  : ");
            _score[i] = Console.ReadLine();                   //기본형식은 str으로 받아옴
            Console.Write("점수를 입력하세요  : ");
            person[i] = int.Parse(Console.ReadLine());        // int형식으로 변환할때는 int.Parsr()사용  == int(input())
            _sum += person[i];
            }
            // 배열요소 person =[100,95]
            // 배열요소 _score = ["영어", "수학"]         //python -> str, char == 0
                    //c# c str 문자열 남자,여자,사람, 문자를 길게 씁니다, 남 / char = 문자하나 O,X,남,여, -> 메모리할당

            _avg = (float)_sum / num;

            for (int i = 0; i < _score.Length; i++)
            {
                Console.Write("{0,10} : {1,-10} \n",_score[i], person[i]);   // python print(format"{1},{0}", a,b )
            }

            string[] _sc = {"F","D","C","B","A","S"};
            _asc = _sc[_avg>50? (Convert.ToInt32(_avg)-50)/10: 0];  //sexy   [a?b : 3] _asc-> "B" 
            Console.Write("총합 : {0} 평균 : {1:F1} 학점 : {2}",_sum,_avg,_asc);

        }
    }
}
