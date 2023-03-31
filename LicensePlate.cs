namespace Assessment2Mar31
{
    internal class LicensePlate
    {
        static void Main(string[] args)
        {
            LicensePlate licensePlate = new LicensePlate();
            Console.WriteLine("Welcome !");
            /*string plate_name = "5F3Z-2e-9-w";
            int length = 4;*/
            
            Console.Write("Number Plate: ");
            string plate_name = Console.ReadLine();
            
            Console.Write("Length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            
            licensePlate.Plate(plate_name, length);
        }

        public void Plate(string plateName, int length)
        {
            
            int count = -1,len = plateName.Length;
            char[] arr_plateName = plateName.ToCharArray();

            Array.Reverse(arr_plateName);

            char[] numberPlate = new char[len];
            char[] namePlate = new char[100] ;
            
            for(int i=0; i< arr_plateName.Length; i++)
            {
                if (arr_plateName[i] == '-')
                {
                    //arr_plateName = arr_plateName.Skip(i).ToArray();
                    i++;
                }
                if (arr_plateName[i] >= 'a' && arr_plateName[i] <= 'z')
                {
                    numberPlate[i] += (char)(arr_plateName[i] - 'a' + 'A');
                }
                else
                    numberPlate[i] += arr_plateName[i];
            }
            //Console.WriteLine(numberPlate);
            for (int i = 0; i < numberPlate.Length; i++)
            {
                namePlate[i] = numberPlate[i];
                if(count == length)
                {
                    i++;
                    namePlate[i] = '-';
                    count = -1;
                }
                count++;
            }
            Array.Reverse(namePlate);
            Console.WriteLine(namePlate);
        }
    }
}
//plateName.ToUpper();
//string revPlate = (string)plateName.Reverse();
//Console.WriteLine(arr_plateName);
//char[] rev_plateName = arr_plateName.Reverse();