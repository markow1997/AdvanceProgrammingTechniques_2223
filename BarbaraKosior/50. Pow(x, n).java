class Solution {
    public double myPow(double x, int n) {
          double a = x;
          double pom=x; 
          double wynik=0;
          int x1= 2147483647;
          int x2= -2147483647;
             if (x==1)
            {
                wynik = x;
            }
            else if (n>=x1 || n<=x2)
            {
                if (x==1 || x==-1)
                {
                if (n>=x1 & x==-1)
                {
                      wynik =  x;
                }
                else {wynik = Math.abs(x);}
                  
                }
                else 
                {
                    wynik = 0; 
                }
            }
            else if (n==0)
            {
                wynik = 1;
            }
            else if (n>0)
            {
                for (int i=1; i<n ; i++)
                {
                    pom =pom * x;
                }
                wynik  = pom;
            }
            else if (n<0)
            {
                double b= Math.abs(n); //wart bezwzgledna 
                  for (int i=0; i<b ; i++)
                {
                    pom =pom * x;
                }
                wynik = (a/pom); 
            }
            else 
            {
                 wynik=0;
            } 
           return wynik;
    }
}