﻿float Addition(float x ,float y){
    float z;
    z= x+y;
    return z;
}
float Substraction(float x ,float y){
    float z;
    z= x-y;
    return z;
}
float Multiplication(float x ,float y){
    float z;
    z= x*y;
    return z;
}
float Division(float x ,float y){
    float z;
    z= x/y;
    return z;
}


Console.WriteLine("enter your first number");
 float x=float.Parse(Console.ReadLine());
 Console.WriteLine("enter your second number");
float y=float.Parse(Console.ReadLine());
float result;
Console.WriteLine("which operation do you want to perform");
Console.WriteLine("choose 1 for addition");
Console.WriteLine("choose 2 for substraction");
Console.WriteLine("choose 3 for multiplication");
Console.WriteLine("choose 4 for division");
int no=int.Parse(Console.ReadLine());

switch(no){
    case 1:result=Addition(x,y);
           break;
    case 2:result=Substraction(x,y);
           break;
    case 3:result=Multiplication(x,y);
           break;
    case 4:result=Division(x,y);
           break;
    default:
           result=0;
            break;
}
Console.WriteLine("result={0}",result);
