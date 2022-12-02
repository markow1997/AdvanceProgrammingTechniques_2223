internal class CountingBits
    {
        public void countingBits()
        {
            Console.WriteLine("Podaj liczbe");
            string tmp = Console.ReadLine();
            int length = Int32.Parse(tmp);
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = i;
            }
            string number;
            for (int i = 0; i < arr.Length; i++)
            {
                number = Convert.ToString(arr[i], 2);
                arr[i] = number.Count(x => (x == '1'));
                Console.Write(arr[i]+" ");
            }
        }
        
    }
