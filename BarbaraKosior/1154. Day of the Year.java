class Solution {
    public int dayOfYear(String date) {
        String[] d = date.split("-");
        int rok= Integer.parseInt(d[0]);
        int miesiac= Integer.parseInt(d[1]);
        int dzien= Integer.parseInt(d[2]);
        int[] dniMiesiecy = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}; 
        int dni = 0;
        boolean leap = false;
        //Lata przestępne : dzielone przez 4 z zerową resztą ale nie tysiaclecia (!)
            if (rok % 4 == 0) {
               // jeśli rok jest stuleciem
                if (rok % 100 == 0) {
                    if (rok % 400 == 0)
                    leap = true;
                    else
                    leap = false;
                }   
                // jeśli rok nie jest stuleciem
                else
                    leap = true;
             }

        for (int i=0 ; i<miesiac-1 ; i++)
        {
            dni += dniMiesiecy[i];
                if (leap && i==1) //gry rok przestępny  luty to 29 dni
                    {
                        dni += 1;
                    }
        }
        dni = dni + dzien;
        return dni; 
    }
}


