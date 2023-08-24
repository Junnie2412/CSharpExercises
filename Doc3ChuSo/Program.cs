
class Program{
    static void Main(string[] args)
    {

        Console.Write("Enter 3 digit number >= 0: ");
        int number=Convert.ToInt32(Console.ReadLine());

        while(number>=1000 || number<0){
            Console.Write("Enter 3 digit number >= 0: ");
            number=Convert.ToInt32(Console.ReadLine());
        }

        if(number==0){
            Console.WriteLine("Zero");
            return;
        }

        String str=number.ToString();
        char[] ch=str.ToCharArray();

        for(int i=0;i<ch.Length;i++){
            if((i!=1 && ch.Length==3)||(i!=0 && ch.Length==2)||ch.Length==1){
                int tmp = ch[i] - '0';
                if(tmp<10 && tmp>0){
                    switch(tmp){
                        case 1:
                            Console.Write("One");
                            break;
                        case 2:
                            Console.Write("Two");
                            break;
                        case 3:
                            Console.Write("Three");
                            break;
                        case 4:
                            Console.Write("Four");
                            break;
                        case 5:
                            Console.Write("Five");
                            break;
                        case 6:
                            Console.Write("Six");
                            break;
                        case 7:
                            Console.Write("Seven");
                            break;
                        case 8:
                            Console.Write("Eight");
                            break;
                        case 9:
                            Console.Write("Nine");
                            break;
                    }
                }
                if(i==0 && ch.Length==3 && ch[1].Equals('0') && ch[2].Equals('0'))
                    Console.Write(" Hundred");
                else if(i==0 && ch.Length==3)
                    Console.Write(" Hundred And ");
            }else{
                int tmp = ch[i] - '0';
                if(tmp==1){
                    switch(ch[i+1]){
                        case '0':
                            Console.Write("Ten");
                            return;
                        case '1':
                            Console.Write("Eleven");
                            return;
                        case '2':
                            Console.Write("Twelve");
                            return;
                        case '3':
                            Console.Write("Thirteen");
                            return;
                        case '4':
                            Console.Write("Fourteen");
                            return;
                        case '5':
                            Console.Write("Fifteen");
                            return;
                        case '6':
                            Console.Write("Sixteen");
                            return;
                        case '7':
                            Console.Write("Seventeen");
                            return;
                        case '8':
                            Console.Write("Eighteen");
                            return;
                        case '9':
                            Console.Write("Nineteen");
                            return;
                    }
                }else{
                    switch(tmp){
                        case 2:
                            Console.Write("Twenty ");
                            break;
                        case 3:
                            Console.Write("Thirty ");
                            break;
                        case 4:
                            Console.Write("Fourty ");
                            break;
                        case 5:
                            Console.Write("Fifty ");
                            break;
                        case 6:
                            Console.Write("Sixty ");
                            break;
                        case 7:
                            Console.Write("Seventy ");
                            break;
                        case 8:
                            Console.Write("Eighty ");
                            break;
                        case 9:
                            Console.Write("Ninety ");
                            break;
                    }
                }
            }
        }

    }
        
}
