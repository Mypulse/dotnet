int a = 55;  
int b = 11;
int c = 99;
int max = 0;

if (a > b)
{
    if(a > c)
    
        max = a;
        else
        max = c;
    
}
else
{
    if(c > b)
    
        max = c;
        else
        max = b;
    
}
Console.WriteLine(max);
