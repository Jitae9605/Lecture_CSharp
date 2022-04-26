using System;


namespace MyAnser_Q4
{
    interface IGongji
    {
        void updateGonji(handler aaa);
       
        void setAlram(handler aaa);
        void deleteAlram(handler aaa);
    }

    class handler
    {
        private student[] studentsList = new student[100];
        private teacher[] teacherList = new teacher[100];
        private int[] stdent_member = new int[100];
        private int student_num;
        private int[] teacher_member = new int[100];
        private int teacher_num;

        private string Gongji;

        public handler()
        {
            student_num = 0;
            teacher_num = 0;
            Gongji = "초기공지";
        }
        public void newGonji(string a)
        {
            Gongji = a;
            Console.WriteLine("공지사항이 업데이트 되었습니다.");
            for(int i = 0; i < student_num; i++)
            {
                studentsList[i].updateGonji(this);
            }
            for (int i = 0; i < teacher_num; i++)
            {
                teacherList[i].updateGonji(this);

            }
            

        }

        public void printAlram()
        {
            Console.WriteLine($"{Gongji}");
        }

        public void setright(ref teacher a)
        {
            a.setright();
        }

        public void setStudent(student newstudent,int studnetID)
        {
            for(int i = 0;i < 100; i++)
            {
                
                if(stdent_member[i] == studnetID)
                {
                    Console.WriteLine("이미 등록된 아이디");
                    break;
                }

                if (i == 99)
                {
                    studentsList[student_num] = newstudent;
                    stdent_member[student_num] = studnetID;
                    student_num++;
                    Console.WriteLine("등록완료");
                }

            }
        }

        public void deleteStudent(int studnetID)
        {
            for (int i = 0; i < 100; i++)
            {
                if (stdent_member[i] == studnetID)
                {
                    stdent_member[i] = 0;
                    studentsList[i] = null;
                    for(int j = i; j < 99;j++)
                    {
                        studentsList[j] = studentsList[j + 1];
                    }
                    student_num--;
                    Console.WriteLine("삭제완료");
                    break;
                }
                if (i == 99)
                    Console.WriteLine("그런아이디 없음");
            }
            

        }

        public void setTeacher(teacher newteacher,int TeacherID)
        {
            for (int i = 0; i < 100; i++)
            {
                if (teacher_member[i] == TeacherID)
                {
                    Console.WriteLine("이미 등록된 아이디");
                    break;
                }

                if(i==99)
                {
                    teacher_member[teacher_num] = TeacherID;
                    teacherList[teacher_num] = newteacher;
                    teacher_num++;
                    Console.WriteLine("등록완료");
                }
            }
            
        }

        public void deleteTeacher(int TeacherID)
        {
            for (int i = 0; i < 100; i++)
            {
                if (teacher_member[i] == TeacherID)
                {
                    teacher_member[i] = 0;
                    teacherList[i] = null;
                    for (int j = i; j < 99; j++)
                    {
                        teacherList[j] = teacherList[j + 1];
                    }
                    teacher_num--;
                    Console.WriteLine("삭제완료");
                    break;
                }

                if(i == 99)
                    Console.WriteLine("그런아이디 없음");
                    
                
            }
            
        }
    }

    class student : handler, IGongji
    {
        int IDnum;
        private int member;

        public student(handler aaa, int aIDnum)
        {
            IDnum = aIDnum;
            member = 1;
            aaa.setStudent(this, aIDnum);
        }
        public void updateGonji(handler aaa)
        {
            if (member == 1)
            {
                Console.WriteLine($"{IDnum}번 학생입니다.");
                aaa.printAlram();
            }

            else
            {
                Console.WriteLine("비회원입니다.");
            }
        }

        public void setAlram(handler aaa)
        {
            aaa.setStudent(this,IDnum);
            member = 1;
        }

        public void deleteAlram(handler aaa)
        {
            aaa.deleteStudent(IDnum);
            member = 0;
        }
        
        

    }
    
    class teacher : handler, IGongji
    {
        private int right;  //공지수정권한 
        private int member; // 1이면 회원 0이면 비회원
        int IDnum;

        public teacher(handler aaa,int aIDnum)
        {
            IDnum = aIDnum;
            right = 0;
            member = 1;
            aaa.setTeacher(this,aIDnum);
        }
        public void makeGonji(ref handler b, string a)
        {
            if (right == 1)
            {
                b.newGonji(a);
            }
            else
                Console.WriteLine("권한없음");
        }
        public void setright()
        {
            right = 1;
        }



        public void updateGonji(handler aaa)
        {
            {
                if (member == 1)
                {
                    Console.WriteLine($"{IDnum}번 선생입니다.");
                    aaa.printAlram();
                }

                else
                {
                    Console.WriteLine("비회원입니다.");
                }
            }
        }

        public void setAlram(handler aaa)
        {
            aaa.setTeacher(this,IDnum);
            member = 1;
        }

        public void deleteAlram(handler aaa)
        {
            aaa.deleteTeacher(IDnum);
            member = 0;
        }

    }

    class MainApp
    {
        static void Main(string[] args)
        {
            handler mainhandler = new handler();

            teacher teacher1 = new teacher(mainhandler,1);
            teacher teacher2 = new teacher(mainhandler,2);
            teacher teacher3 = new teacher(mainhandler,3);
            teacher teacher4 = new teacher(mainhandler,4);
            teacher teacher5 = new teacher(mainhandler,5);
            teacher teacher6 = new teacher(mainhandler,6);

            student student1 = new student(mainhandler,1);
            student student2 = new student(mainhandler,2);
            student student3 = new student(mainhandler,3);
            student student4 = new student(mainhandler,4);
            student student5 = new student(mainhandler,5);
            student student6 = new student(mainhandler,6);
            student student7 = new student(mainhandler,7);
            

            mainhandler.setright(ref teacher1);                     // 관리자 지정
            teacher1.makeGonji(ref mainhandler,"ㅇㅇㅇㅇㅇㅇ");      // 관리자가 공지를 수정함

            teacher2.deleteAlram(mainhandler);                      // teacher2가 공지 안받겠다고 선언
            teacher2.updateGonji(mainhandler);                      // teacher2가 그래놓고 공지를 받아보려함 - 응 안돼

            teacher1.makeGonji(ref mainhandler,"rrrrrrrrrrrr");     // 관리자가 공지를 다시 수정함

            teacher2.setAlram(mainhandler);                         // teacher2가 공지 다시 받겠다고 선언
            teacher1.makeGonji(ref mainhandler, "aaaaaaaaaaaa");    // teacher2가 다시 공지를 받아볼수있음





        }
    }


}
