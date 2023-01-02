class Solution {
    public int romanToInt(String s) {
        int wynik=0;
       // tab stringów mozliwe kombinacje  
        String[] symbol =new String[]{"I","IV","V","IX","X","XL", "L","XC","C","CD","D","CM","M"};
        int[] value={1,4,5,9,10,40,50,90,100,400,500,900,1000};  // 13 elem (indexy od 0-12)
        int dlugosc = s.length(); // 12 elem 
        int i=12 , k=0;   // i-przechodzimy przez tab[]symbol  k-miejsca w pobranym ciagu
        while (i>=0  &&  k <=dlugosc )
        {
            String pobranaVal ="";
            int pom =  symbol[i].length(); //przechodzimy przez tab "symbol" i pobieramy długość 
            if (k+pom<=dlugosc)
            {
                pobranaVal = s.substring(k,k+pom); // pobieramy znak o odpowiedniej dlugosci z wprowadzanego Stringa s 
            }
            if (symbol[i].equals(pobranaVal)) // jeśli w symbolu jest ta wartosc 
            {
                wynik += value[i]; //dodajemy wart odpowiadajacą symbolowi
                System.out.print( wynik );
                k += pom; // przesuwamy się o tyle miejsc 
            }
           else 
           {
               i--; 
           }
        }
       return wynik; 
    }
}


