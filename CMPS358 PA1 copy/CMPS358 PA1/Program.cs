
using CMPS358_PA1;


List<HADS> hads1 = new List<HADS>();

string year;
string answer = null;

double getDoubleAverage(double amount, int count) //function to calculate average for doubles
{
    double average = amount / count;
    return Math.Round(average, 2);
    
}

double getIntAverage(double amount, int count) //function to calcualte average for ints
{
    double average = amount / count;
    return Math.Round(average, 1);
}

double getDifference(double average1, double average2)   //function to calculate the differece and output a positive number
{
    if (average1 > average2)
        return Math.Round(average1 - average2,1);
    else return Math.Round(average2 - average1,1);
}

do
{
    Console.WriteLine("(s)ingle year or (t)wo year comparison? (E)xit: ");
    answer = Console.ReadLine();
    
    
    if (answer.Equals("s"))    //checks to see if user wants a single year
    {
        Console.WriteLine("Select a Data Set");
        Console.WriteLine("1993, 1997, 2001, 2005, 2009, 2013: ");
        year = Console.In.ReadLine();
        
        
        
        //index 0 = age, 1 = Lmed, 2 = Fmr, 3 = L30, 4 = L50, 5 = L80,
        // 6 = Bedrooms, 7=Value, 8 = Rooms, 9 = Utility
        double[] region1 = new double[10]; //initialize array to store values for appropriate regions
        int[] region1Count = new int[10];  // initialize counts for appropriate regions
        double[] region2 = new double[10];
        int[] region2Count = new int[10];
        double[] region3 = new double[10];
        int[] region3Count = new int[10];
        double[] region4 = new double[10];
        int[] region4Count = new int[10];



        using (StreamReader file = new StreamReader("somedata/" + year + ".txt"))
        {
            List<string> lines = new List<string>(File.ReadAllLines("somedata/" + year + ".txt"));

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                HADS newHads = new HADS();

                newHads.age = int.Parse(entries[0]);
                newHads.region = int.Parse(entries[1]);

                newHads.lmed = double.Parse(entries[2]);
                newHads.fmr = double.Parse(entries[3]);
                newHads.l30 = double.Parse(entries[4]);
                newHads.l50 = double.Parse(entries[5]);
                newHads.l80 = double.Parse(entries[6]);
                newHads.bedrooms = int.Parse(entries[7]);
                newHads.value = double.Parse(entries[8]);
                newHads.rooms = int.Parse(entries[9]);
                newHads.utility = double.Parse(entries[10]);
                if (newHads.region == 1)
                {
                    if (newHads.age > 0)
                    {
                        region1[0] += newHads.age;
                        region1Count[0] ++;
                    }
                    if (newHads.lmed > 0)
                    {
                        region1[1] += newHads.lmed;
                        region1Count[1]++;
                    }

                    if (newHads.fmr > 0)
                    {
                        region1[2] += newHads.fmr;
                        region1Count[2]++;
                    }

                    if (newHads.l30 > 0)
                    {
                        region1[3] += newHads.l30;
                        region1Count[3]++;
                    }

                    if (newHads.l50 > 0)
                    {
                        region1[4] += newHads.l50;
                        region1Count[4]++;
                    }

                    if (newHads.l80 > 0)
                    {
                        region1[5] += newHads.l80;
                        region1Count[5]++;
                    }

                    if (newHads.bedrooms > 0)
                    {
                        region1[6] += newHads.bedrooms;
                        region1Count[6]++;
                    }

                    if (newHads.value > 0)
                    {
                        region1[7] += newHads.value;
                        region1Count[7]++;
                    }

                    if (newHads.rooms > 0)
                    {
                        region1[8] += newHads.rooms;
                        region1Count[8]++;
                    }

                    if (newHads.utility > 0)
                    {
                        region1[9] += newHads.utility;
                        region1Count[9]++;
                    }
                    

                }             //checks the correct region
                else if(newHads.region == 2)
                {
                    if (newHads.age > 0)
                    {
                        region2[0] += newHads.age;
                        region2Count[0] ++;
                    }
                    if (newHads.lmed > 0)
                    {
                        region2[1] += newHads.lmed;
                        region2Count[1]++;
                    }

                    if (newHads.fmr > 0)
                    {
                        region2[2] += newHads.fmr;
                        region2Count[2]++;
                    }

                    if (newHads.l30 > 0)
                    {
                        region2[3] += newHads.l30;
                        region2Count[3]++;
                    }

                    if (newHads.l50 > 0)
                    {
                        region2[4] += newHads.l50;
                        region2Count[4]++;
                    }

                    if (newHads.l80 > 0)
                    {
                        region2[5] += newHads.l80;
                        region2Count[5]++;
                    }

                    if (newHads.bedrooms > 0)
                    {
                        region2[6] += newHads.bedrooms;
                        region2Count[6]++;
                    }

                    if (newHads.value > 0)
                    {
                        region2[7] += newHads.value;
                        region2Count[7]++;
                    }

                    if (newHads.rooms > 0)
                    {
                        region2[8] += newHads.rooms;
                        region2Count[8]++;
                    }

                    if (newHads.utility > 0)
                    {
                        region2[9] += newHads.utility;
                        region2Count[9]++;
                    }
                } 
                else if (newHads.region == 3)
                {
                    if (newHads.age > 0)
                    {
                        region3[0] += newHads.age;
                        region3Count[0] ++;
                    }
                    if (newHads.lmed > 0)
                    {
                        region3[1] += newHads.lmed;
                        region3Count[1]++;
                    }

                    if (newHads.fmr > 0)
                    {
                        region3[2] += newHads.fmr;
                        region3Count[2]++;
                    }

                    if (newHads.l30 > 0)
                    {
                        region3[3] += newHads.l30;
                        region3Count[3]++;
                    }

                    if (newHads.l50 > 0)
                    {
                        region3[4] += newHads.l50;
                        region3Count[4]++;
                    }

                    if (newHads.l80 > 0)
                    {
                        region3[5] += newHads.l80;
                        region3Count[5]++;
                    }

                    if (newHads.bedrooms > 0)
                    {
                        region3[6] += newHads.bedrooms;
                        region3Count[6]++;
                    }

                    if (newHads.value > 0)
                    {
                        region3[7] += newHads.value;
                        region3Count[7]++;
                    }

                    if (newHads.rooms > 0)
                    {
                        region3[8] += newHads.rooms;
                        region3Count[8]++;
                    }

                    if (newHads.utility > 0)
                    {
                        region3[9] += newHads.utility;
                        region3Count[9]++;
                    }
                    
                }
                else if(newHads.region == 4)
                {
                    if (newHads.age > 0)
                    {
                        region4[0] += newHads.age;
                        region4Count[0] ++;
                    }
                    if (newHads.lmed > 0)
                    {
                        region4[1] += newHads.lmed;
                        region4Count[1]++;
                    }

                    if (newHads.fmr > 0)
                    {
                        region4[2] += newHads.fmr;
                        region4Count[2]++;
                    }

                    if (newHads.l30 > 0)
                    {
                        region4[3] += newHads.l30;
                        region4Count[3]++;
                    }

                    if (newHads.l50 > 0)
                    {
                        region4[4] += newHads.l50;
                        region4Count[4]++;
                    }

                    if (newHads.l80 > 0)
                    {
                        region4[5] += newHads.l80;
                        region4Count[5]++;
                    }

                    if (newHads.bedrooms > 0)
                    {
                        region4[6] += newHads.bedrooms;
                        region4Count[6]++;
                    }

                    if (newHads.value > 0)
                    {
                        region4[7] += newHads.value;
                        region4Count[7]++;
                    }

                    if (newHads.rooms > 0)
                    {
                        region4[8] += newHads.rooms;
                        region4Count[8]++;
                    }

                    if (newHads.utility > 0)
                    {
                        region4[9] += newHads.utility;
                        region4Count[9]++;
                    }
                }

                hads1.Add(newHads);
            }

            double sumAge = region1[0] + region2[0] + region3[0] + region4[0];
            int countAge = region1Count[0] + region2Count[0] + region3Count[0] + region4Count[0];
            
            double sumLmed = region1[1] + region2[1] + region3[1] + region4[01];
            int countLmed = region1Count[1] + region2Count[1] + region3Count[01] + region4Count[01];
            
            double sumFrm = region1[2] + region2[2] + region3[02] + region4[02];
            int countFmr = region1Count[2] + region2Count[2] + region3Count[02] + region4Count[02];
            
            double sumL30 = region1[3] + region2[3] + region3[03] + region4[03];
            int countL30 = region1Count[3] + region2Count[3] + region3Count[03] + region4Count[03];
            
            double sumL50 = region1[4] + region2[4] + region3[04] + region4[04];
            int countL50 = region1Count[4] + region2Count[4] + region3Count[04] + region4Count[04];
            
            double sumL80 = region1[5] + region2[5] + region3[05] + region4[05];
            int countL80 = region1Count[5] + region2Count[5] + region3Count[05] + region4Count[05];
            
            double sumBedrooms = region1[6] + region2[6] + region3[06] + region4[06];
            int countBedrooms = region1Count[6] + region2Count[6] + region3Count[06] + region4Count[06];
            
            double sumValue = region1[7] + region2[7] + region3[07] + region4[07];
            int countValue = region1Count[7] + region2Count[7] + region3Count[07] + region4Count[07];
            
            double sumRooms = region1[8] + region2[8] + region3[08] + region4[08];
            int countRooms = region1Count[8] + region2Count[8] + region3Count[08] + region4Count[08];
            
            double sumUtility = region1[9] + region2[9] + region3[09] + region4[09];
            int countUtility = region1Count[9] + region2Count[9] + region3Count[09] + region4Count[09];
            
            Console.WriteLine();
            Console.WriteLine("Averages: ");
            Console.WriteLine("|  \t\t| All Regions \t| Regions 1 \t| Region 2 \t| Region 3 \t| Region 4 |");
            Console.WriteLine($"| Age \t\t| {getIntAverage(sumAge,countAge)} \t \t| {getIntAverage(region1[0], region1Count[0])} \t|\t {getIntAverage(region2[0], region2Count[0])}\t | \t {getIntAverage(region3[0], region3Count[0])} \t|\t  {getIntAverage(region4[0], region4Count[0])}");
            Console.WriteLine($"| LMED \t\t| {getDoubleAverage(sumLmed,countLmed)} \t| {getDoubleAverage(region1[1], region1Count[1])} \t|\t {getDoubleAverage(region2[1],region2Count[1])} \t|\t {getDoubleAverage(region3[1],region3Count[1])} \t|\t {getDoubleAverage(region4[1],region4Count[1])} |");
            Console.WriteLine($"| FMR \t\t| {getDoubleAverage(sumFrm,countFmr)}\t| {getDoubleAverage(region1[2], region1Count[2])}  \t|\t {getDoubleAverage(region2[2], region2Count[2])} \t|\t {getDoubleAverage(region3[2], region3Count[2])} \t|\t {getDoubleAverage(region4[2], region4Count[2])} |");
            Console.WriteLine($"| L30 \t\t| {getDoubleAverage(sumL30,countL30)} \t| {getIntAverage(region1[3], region1Count[3])} \t|\t {getIntAverage(region2[3], region2Count[3])} \t|\t {getIntAverage(region3[3], region3Count[3])} \t|\t {getIntAverage(region4[3], region4Count[3])} |");
            Console.WriteLine($"| L50 \t\t| {getDoubleAverage(sumL50,countL50)} \t| {getDoubleAverage(region1[4], region1Count[4])} \t|\t {getDoubleAverage(region2[4], region2Count[4])} \t|\t {getDoubleAverage(region3[4], region3Count[4])} \t|\t {getDoubleAverage(region4[4], region4Count[4])} |");
            Console.WriteLine($"| L80 \t\t| {getDoubleAverage(sumL80,countL80)} \t| {getDoubleAverage(region1[5], region1Count[5])} \t|\t {getDoubleAverage(region2[5], region2Count[5])} \t|\t {getDoubleAverage(region3[5], region3Count[5])} \t|\t {getDoubleAverage(region4[5], region4Count[5])} |");
            Console.WriteLine($"| Bedrooms \t| {getIntAverage(sumBedrooms,countBedrooms)} \t| {getIntAverage(region1[6], region1Count[6])} \t|\t {getIntAverage(region2[6], region2Count[6])} \t|\t {getIntAverage(region3[6], region3Count[6])} \t|\t {getIntAverage(region4[6], region4Count[6])} |");
            Console.WriteLine($"| Value \t| {getDoubleAverage(sumValue,countValue)} \t| {getDoubleAverage(region1[7], region1Count[07])} \t|\t {getDoubleAverage(region2[7], region2Count[07])} \t|\t {getDoubleAverage(region3[7], region3Count[07])} \t|\t {getDoubleAverage(region4[7], region4Count[07])} |");
            Console.WriteLine($"| Rooms \t| {getIntAverage(sumRooms,countRooms)} \t| {getIntAverage(region1[8], region1Count[08])} \t|\t {getIntAverage(region2[8], region2Count[08])} \t|\t {getIntAverage(region3[8], region3Count[08])} \t|\t {getIntAverage(region4[8], region4Count[08])} |");
            Console.WriteLine($"| Utility \t| {getDoubleAverage(sumUtility,countUtility)} \t| {getDoubleAverage(region1[9], region1Count[09])} \t|\t {getDoubleAverage(region2[9], region2Count[09])} \t|\t {getDoubleAverage(region3[9], region3Count[09])} \t|\t {getDoubleAverage(region4[9], region4Count[09])} |");

            Console.ReadLine();

        }


    } else if (answer.Equals("t"))       //checks to see if user wants to compare 2 years
    {
        Console.WriteLine("Enter the first data set: "); //first data set
        Console.WriteLine("1993, 1997, 2001, 2005, 2009, 2013: ");
        year = Console.ReadLine();

        //index 0 = age, 1 = Lmed, 2 = Fmr, 3 = L30, 4 = L50, 5 = L80,
        // 6 = Bedrooms, 7=Value, 8 = Rooms, 9 = Utility
        double[] region1 = new double[10]; //initialize array to store values for appropriate regions
        int[] region1Count = new int[10]; // initialize counts for appropriate regions
        double[] region2 = new double[10];
        int[] region2Count = new int[10];
        double[] region3 = new double[10];
        int[] region3Count = new int[10];
        double[] region4 = new double[10];
        int[] region4Count = new int[10];



        using (StreamReader file = new StreamReader("somedata/" + year + ".txt"))
        {
            List<string> lines = new List<string>(File.ReadAllLines("somedata/" + year + ".txt"));

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                HADS newHads = new HADS();

                newHads.age = int.Parse(entries[0]);
                newHads.region = int.Parse(entries[1]);

                newHads.lmed = double.Parse(entries[2]);
                newHads.fmr = double.Parse(entries[3]);
                newHads.l30 = double.Parse(entries[4]);
                newHads.l50 = double.Parse(entries[5]);
                newHads.l80 = double.Parse(entries[6]);
                newHads.bedrooms = int.Parse(entries[7]);
                newHads.value = double.Parse(entries[8]);
                newHads.rooms = int.Parse(entries[9]);
                newHads.utility = double.Parse(entries[10]);
                
               
                //checks to see what region the data belongs to amd stores
                //them in the correct array.
                
                if (newHads.region == 1)
                {
                    if (newHads.age > 0)
                    {
                        region1[0] += newHads.age;
                        region1Count[0]++;
                    }

                    if (newHads.lmed > 0)
                    {
                        region1[1] += newHads.lmed;
                        region1Count[1]++;
                    }

                    if (newHads.fmr > 0)
                    {
                        region1[2] += newHads.fmr;
                        region1Count[2]++;
                    }

                    if (newHads.l30 > 0)
                    {
                        region1[3] += newHads.l30;
                        region1Count[3]++;
                    }

                    if (newHads.l50 > 0)
                    {
                        region1[4] += newHads.l50;
                        region1Count[4]++;
                    }

                    if (newHads.l80 > 0)
                    {
                        region1[5] += newHads.l80;
                        region1Count[5]++;
                    }

                    if (newHads.bedrooms > 0)
                    {
                        region1[6] += newHads.bedrooms;
                        region1Count[6]++;
                    }

                    if (newHads.value > 0)
                    {
                        region1[7] += newHads.value;
                        region1Count[7]++;
                    }

                    if (newHads.rooms > 0)
                    {
                        region1[8] += newHads.rooms;
                        region1Count[8]++;
                    }

                    if (newHads.utility > 0)
                    {
                        region1[9] += newHads.utility;
                        region1Count[9]++;
                    }


                }                  
                else if (newHads.region == 2)
                {
                    if (newHads.age > 0)
                    {
                        region2[0] += newHads.age;
                        region2Count[0]++;
                    }

                    if (newHads.lmed > 0)
                    {
                        region2[1] += newHads.lmed;
                        region2Count[1]++;
                    }

                    if (newHads.fmr > 0)
                    {
                        region2[2] += newHads.fmr;
                        region2Count[2]++;
                    }

                    if (newHads.l30 > 0)
                    {
                        region2[3] += newHads.l30;
                        region2Count[3]++;
                    }

                    if (newHads.l50 > 0)
                    {
                        region2[4] += newHads.l50;
                        region2Count[4]++;
                    }

                    if (newHads.l80 > 0)
                    {
                        region2[5] += newHads.l80;
                        region2Count[5]++;
                    }

                    if (newHads.bedrooms > 0)
                    {
                        region2[6] += newHads.bedrooms;
                        region2Count[6]++;
                    }

                    if (newHads.value > 0)
                    {
                        region2[7] += newHads.value;
                        region2Count[7]++;
                    }

                    if (newHads.rooms > 0)
                    {
                        region2[8] += newHads.rooms;
                        region2Count[8]++;
                    }

                    if (newHads.utility > 0)
                    {
                        region2[9] += newHads.utility;
                        region2Count[9]++;
                    }
                }             
                else if (newHads.region == 3)
                {
                    if (newHads.age > 0)
                    {
                        region3[0] += newHads.age;
                        region3Count[0]++;
                    }

                    if (newHads.lmed > 0)
                    {
                        region3[1] += newHads.lmed;
                        region3Count[1]++;
                    }

                    if (newHads.fmr > 0)
                    {
                        region3[2] += newHads.fmr;
                        region3Count[2]++;
                    }

                    if (newHads.l30 > 0)
                    {
                        region3[3] += newHads.l30;
                        region3Count[3]++;
                    }

                    if (newHads.l50 > 0)
                    {
                        region3[4] += newHads.l50;
                        region3Count[4]++;
                    }

                    if (newHads.l80 > 0)
                    {
                        region3[5] += newHads.l80;
                        region3Count[5]++;
                    }

                    if (newHads.bedrooms > 0)
                    {
                        region3[6] += newHads.bedrooms;
                        region3Count[6]++;
                    }

                    if (newHads.value > 0)
                    {
                        region3[7] += newHads.value;
                        region3Count[7]++;
                    }

                    if (newHads.rooms > 0)
                    {
                        region3[8] += newHads.rooms;
                        region3Count[8]++;
                    }

                    if (newHads.utility > 0)
                    {
                        region3[9] += newHads.utility;
                        region3Count[9]++;
                    }

                }
                else if (newHads.region == 4)
                {
                    if (newHads.age > 0)
                    {
                        region4[0] += newHads.age;
                        region4Count[0]++;
                    }

                    if (newHads.lmed > 0)
                    {
                        region4[1] += newHads.lmed;
                        region4Count[1]++;
                    }

                    if (newHads.fmr > 0)
                    {
                        region4[2] += newHads.fmr;
                        region4Count[2]++;
                    }

                    if (newHads.l30 > 0)
                    {
                        region4[3] += newHads.l30;
                        region4Count[3]++;
                    }

                    if (newHads.l50 > 0)
                    {
                        region4[4] += newHads.l50;
                        region4Count[4]++;
                    }

                    if (newHads.l80 > 0)
                    {
                        region4[5] += newHads.l80;
                        region4Count[5]++;
                    }

                    if (newHads.bedrooms > 0)
                    {
                        region4[6] += newHads.bedrooms;
                        region4Count[6]++;
                    }

                    if (newHads.value > 0)
                    {
                        region4[7] += newHads.value;
                        region4Count[7]++;
                    }

                    if (newHads.rooms > 0)
                    {
                        region4[8] += newHads.rooms;
                        region4Count[8]++;
                    }

                    if (newHads.utility > 0)
                    {
                        region4[9] += newHads.utility;
                        region4Count[9]++;
                    }
                }

                hads1.Add(newHads);
            }

            double sumAge = region1[0] + region2[0] + region3[0] + region4[0];
            int countAge = region1Count[0] + region2Count[0] + region3Count[0] + region4Count[0];

            double sumLmed = region1[1] + region2[1] + region3[1] + region4[01];
            int countLmed = region1Count[1] + region2Count[1] + region3Count[01] + region4Count[01];

            double sumFrm = region1[2] + region2[2] + region3[02] + region4[02];
            int countFmr = region1Count[2] + region2Count[2] + region3Count[02] + region4Count[02];

            double sumL30 = region1[3] + region2[3] + region3[03] + region4[03];
            int countL30 = region1Count[3] + region2Count[3] + region3Count[03] + region4Count[03];

            double sumL50 = region1[4] + region2[4] + region3[04] + region4[04];
            int countL50 = region1Count[4] + region2Count[4] + region3Count[04] + region4Count[04];

            double sumL80 = region1[5] + region2[5] + region3[05] + region4[05];
            int countL80 = region1Count[5] + region2Count[5] + region3Count[05] + region4Count[05];

            double sumBedrooms = region1[6] + region2[6] + region3[06] + region4[06];
            int countBedrooms = region1Count[6] + region2Count[6] + region3Count[06] + region4Count[06];

            double sumValue = region1[7] + region2[7] + region3[07] + region4[07];
            int countValue = region1Count[7] + region2Count[7] + region3Count[07] + region4Count[07];

            double sumRooms = region1[8] + region2[8] + region3[08] + region4[08];
            int countRooms = region1Count[8] + region2Count[8] + region3Count[08] + region4Count[08];

            double sumUtility = region1[9] + region2[9] + region3[09] + region4[09];
            int countUtility = region1Count[9] + region2Count[9] + region3Count[09] + region4Count[09];




            Console.WriteLine("Enter the second data set: "); //2nd data set
            Console.WriteLine("1993, 1997, 2001, 2005, 2009, 2013: ");
            String year2;
            year2 = Console.ReadLine();

            //index 0 = age, 1 = Lmed, 2 = Fmr, 3 = L30, 4 = L50, 5 = L80,
            // 6 = Bedrooms, 7=Value, 8 = Rooms, 9 = Utility
            double[] year2Region1 = new double[10]; //initialize array to store values for appropriate regions
            int[] year2Region1Count = new int[10]; // initialize counts for appropriate regions
            double[] year2Region2 = new double[10];
            int[] year2Region2Count = new int[10];
            double[] year2Region3 = new double[10];
            int[] year2Region3Count = new int[10];
            double[] year2Region4 = new double[10];
            int[] year2Region4Count = new int[10];



            using (StreamReader file2 = new StreamReader("somedata/" + year2 + ".txt"))
            {
                List<string> lines2 = new List<string>(File.ReadAllLines("somedata/" + year2 + ".txt"));

                foreach (var line in lines2)
                {
                    string[] entries2 = line.Split(',');

                    HADS newHads2 = new HADS();

                    newHads2.age = int.Parse(entries2[0]);
                    newHads2.region = int.Parse(entries2[1]);

                    newHads2.lmed = double.Parse(entries2[2]);
                    newHads2.fmr = double.Parse(entries2[3]);
                    newHads2.l30 = double.Parse(entries2[4]);
                    newHads2.l50 = double.Parse(entries2[5]);
                    newHads2.l80 = double.Parse(entries2[6]);
                    newHads2.bedrooms = int.Parse(entries2[7]);
                    newHads2.value = double.Parse(entries2[8]);
                    newHads2.rooms = int.Parse(entries2[9]);
                    newHads2.utility = double.Parse(entries2[10]);
                    if (newHads2.region == 1)
                    {
                        if (newHads2.age > 0)
                        {
                            year2Region1[0] += newHads2.age;
                            year2Region1Count[0]++;
                        }

                        if (newHads2.lmed > 0)
                        {
                            year2Region1[1] += newHads2.lmed;
                            year2Region1Count[1]++;
                        }

                        if (newHads2.fmr > 0)
                        {
                            year2Region1[2] += newHads2.fmr;
                            year2Region1Count[2]++;
                        }

                        if (newHads2.l30 > 0)
                        {
                            year2Region1[3] += newHads2.l30;
                            year2Region1Count[3]++;
                        }

                        if (newHads2.l50 > 0)
                        {
                            year2Region1[4] += newHads2.l50;
                            year2Region1Count[4]++;
                        }

                        if (newHads2.l80 > 0)
                        {
                            year2Region1[5] += newHads2.l80;
                            year2Region1Count[5]++;
                        }

                        if (newHads2.bedrooms > 0)
                        {
                            year2Region1[6] += newHads2.bedrooms;
                            year2Region1Count[6]++;
                        }

                        if (newHads2.value > 0)
                        {
                            year2Region1[7] += newHads2.value;
                            year2Region1Count[7]++;
                        }

                        if (newHads2.rooms > 0)
                        {
                            year2Region1[8] += newHads2.rooms;
                            year2Region1Count[8]++;
                        }

                        if (newHads2.utility > 0)
                        {
                            year2Region1[9] += newHads2.utility;
                            year2Region1Count[9]++;
                        }


                    }                  //checks to see which region the data belongs to
                    else if (newHads2.region == 2)
                    {
                        if (newHads2.age > 0)
                        {
                            year2Region2[0] += newHads2.age;
                            year2Region2Count[0]++;
                        }

                        if (newHads2.lmed > 0)
                        {
                            year2Region2[1] += newHads2.lmed;
                            year2Region2Count[1]++;
                        }

                        if (newHads2.fmr > 0)
                        {
                            year2Region2[2] += newHads2.fmr;
                            year2Region2Count[2]++;
                        }

                        if (newHads2.l30 > 0)
                        {
                            year2Region2[3] += newHads2.l30;
                            year2Region2Count[3]++;
                        }

                        if (newHads2.l50 > 0)
                        {
                            year2Region2[4] += newHads2.l50;
                            year2Region2Count[4]++;
                        }

                        if (newHads2.l80 > 0)
                        {
                            year2Region2[5] += newHads2.l80;
                            year2Region2Count[5]++;
                        }

                        if (newHads2.bedrooms > 0)
                        {
                            year2Region2[6] += newHads2.bedrooms;
                            year2Region2Count[6]++;
                        }

                        if (newHads2.value > 0)
                        {
                            year2Region2[7] += newHads2.value;
                            year2Region2Count[7]++;
                        }

                        if (newHads2.rooms > 0)
                        {
                            year2Region2[8] += newHads2.rooms;
                            year2Region2Count[8]++;
                        }

                        if (newHads2.utility > 0)
                        {
                            year2Region2[9] += newHads2.utility;
                            year2Region2Count[9]++;
                        }
                    }
                    else if (newHads2.region == 3)
                    {
                        if (newHads2.age > 0)
                        {
                            year2Region3[0] += newHads2.age;
                            year2Region3Count[0]++;
                        }

                        if (newHads2.lmed > 0)
                        {
                            year2Region3[1] += newHads2.lmed;
                            year2Region3Count[1]++;
                        }

                        if (newHads2.fmr > 0)
                        {
                            year2Region3[2] += newHads2.fmr;
                            year2Region3Count[2]++;
                        }

                        if (newHads2.l30 > 0)
                        {
                            year2Region3[3] += newHads2.l30;
                            year2Region3Count[3]++;
                        }

                        if (newHads2.l50 > 0)
                        {
                            year2Region3[4] += newHads2.l50;
                            year2Region3Count[4]++;
                        }

                        if (newHads2.l80 > 0)
                        {
                            year2Region3[5] += newHads2.l80;
                            year2Region3Count[5]++;
                        }

                        if (newHads2.bedrooms > 0)
                        {
                            year2Region3[6] += newHads2.bedrooms;
                            year2Region3Count[6]++;
                        }

                        if (newHads2.value > 0)
                        {
                            year2Region3[7] += newHads2.value;
                            year2Region3Count[7]++;
                        }

                        if (newHads2.rooms > 0)
                        {
                            year2Region3[8] += newHads2.rooms;
                            year2Region3Count[8]++;
                        }

                        if (newHads2.utility > 0)
                        {
                            year2Region3[9] += newHads2.utility;
                            year2Region3Count[9]++;
                        }

                    }
                    else if (newHads2.region == 4)
                    {
                        if (newHads2.age > 0)
                        {
                            year2Region4[0] += newHads2.age;
                            year2Region4Count[0]++;
                        }

                        if (newHads2.lmed > 0)
                        {
                            year2Region4[1] += newHads2.lmed;
                            year2Region4Count[1]++;
                        }

                        if (newHads2.fmr > 0)
                        {
                            year2Region4[2] += newHads2.fmr;
                            year2Region4Count[2]++;
                        }

                        if (newHads2.l30 > 0)
                        {
                            year2Region4[3] += newHads2.l30;
                            year2Region4Count[3]++;
                        }

                        if (newHads2.l50 > 0)
                        {
                            year2Region4[4] += newHads2.l50;
                            year2Region4Count[4]++;
                        }

                        if (newHads2.l80 > 0)
                        {
                            year2Region4[5] += newHads2.l80;
                            year2Region4Count[5]++;
                        }

                        if (newHads2.bedrooms > 0)
                        {
                            year2Region4[6] += newHads2.bedrooms;
                            year2Region4Count[6]++;
                        }

                        if (newHads2.value > 0)
                        {
                            year2Region4[7] += newHads2.value;
                            year2Region4Count[7]++;
                        }

                        if (newHads2.rooms > 0)
                        {
                            year2Region4[8] += newHads2.rooms;
                            year2Region4Count[8]++;
                        }

                        if (newHads2.utility > 0)
                        {
                            year2Region4[9] += newHads2.utility;
                            year2Region4Count[9]++;
                        }
                    }

                    hads1.Add(newHads2);
                }

                double sumAgeYear2 = year2Region1[0] + year2Region2[0] + year2Region3[0] + year2Region4[0];
                int countAgeYear2 = year2Region1Count[0] + year2Region2Count[0] + year2Region3Count[0] +
                                    year2Region4Count[0];

                double sumLmedYear2 = year2Region1[1] + year2Region2[1] + year2Region3[1] + year2Region4[01];
                int countLmedYear2 = year2Region1Count[1] + year2Region2Count[1] + year2Region3Count[01] +
                                     year2Region4Count[01];

                double sumFrmYear2 = year2Region1[2] + year2Region2[2] + year2Region3[02] + year2Region4[02];
                int countFmrYear2 = year2Region1Count[2] + year2Region2Count[2] + year2Region3Count[02] +
                                    year2Region4Count[02];

                double sumL30Year2 = year2Region1[3] + year2Region2[3] + year2Region3[03] + year2Region4[03];
                int countL30Year2 = year2Region1Count[3] + year2Region2Count[3] + year2Region3Count[03] +
                                    year2Region4Count[03];

                double sumL50Year2 = year2Region1[4] + year2Region2[4] + year2Region3[04] + year2Region4[04];
                int countL50Year2 = year2Region1Count[4] + year2Region2Count[4] + year2Region3Count[04] +
                                    year2Region4Count[04];

                double sumL80Year2 = year2Region1[5] + year2Region2[5] + year2Region3[05] + year2Region4[05];
                int countL80Year2 = year2Region1Count[5] + year2Region2Count[5] + year2Region3Count[05] +
                                    year2Region4Count[05];

                double sumBedroomsYear2 = year2Region1[6] + year2Region2[6] + year2Region3[06] + year2Region4[06];
                int countBedroomsYear2 = year2Region1Count[6] + year2Region2Count[6] + year2Region3Count[06] +
                                         year2Region4Count[06];

                double sumValueYear2 = year2Region1[7] + year2Region2[7] + year2Region3[07] + year2Region4[07];
                int countValueYear2 = year2Region1Count[7] + year2Region2Count[7] + year2Region3Count[07] +
                                      year2Region4Count[07];

                double sumRoomsYear2 = year2Region1[8] + year2Region2[8] + year2Region3[08] + year2Region4[08];
                int countRoomsYear2 = year2Region1Count[8] + year2Region2Count[8] + year2Region3Count[08] +
                                      year2Region4Count[08];

                double sumUtilityYear2 = year2Region1[9] + year2Region2[9] + year2Region3[09] + year2Region4[09];
                int countUtilityYear2 = year2Region1Count[9] + year2Region2Count[9] + year2Region3Count[09] +
                                        year2Region4Count[09];






                Console.WriteLine();
                Console.WriteLine("Changes to Averages: ");
                Console.WriteLine("|  \t\t| All Regions \t| Regions 1 \t| Region 2 \t| Region 3 \t| Region 4 |");
                Console.WriteLine(
                    $"| Age \t\t| {getDifference(getIntAverage(sumAge, countAge), getIntAverage(sumAgeYear2, countAgeYear2))} \t \t| {getDifference(getIntAverage(region1[0],region1Count[0]), getIntAverage(year2Region1[0],year2Region1Count[0]))} \t\t| {getDifference(getIntAverage(region2[0],region2Count[0]), getIntAverage(year2Region2[0],year2Region2Count[0]))} \t\t| {getDifference(getIntAverage(region3[0],region3Count[0]), getIntAverage(year2Region3[0],year2Region3Count[0]))} \t\t|  {getDifference(getIntAverage(region4[0],region4Count[0]), getIntAverage(year2Region4[0],year2Region4Count[0]))}\t|");
                Console.WriteLine(
                    $"| LMED \t\t| {getDifference(getDoubleAverage(sumLmed, countLmed), getDoubleAverage(sumLmedYear2,countLmedYear2)) } \t| {getDifference(getDoubleAverage(region1[1], region1Count[1]), getDoubleAverage(year2Region1[1],year2Region1Count[1]))} \t| {getDifference(getDoubleAverage(region2[1], region2Count[1]), getDoubleAverage(year2Region2[1],year2Region2Count[1]))} \t| {getDifference(getDoubleAverage(region3[1], region3Count[1]), getDoubleAverage(year2Region3[1],year2Region3Count[1]))} \t| {getDifference(getDoubleAverage(region4[1], region4Count[1]), getDoubleAverage(year2Region4[1],year2Region4Count[1]))} \t|");
                Console.WriteLine(
                    $"| FMR \t\t| {getDifference(getDoubleAverage(sumFrm, countFmr), getDoubleAverage(sumFrmYear2,countFmrYear2)) } \t| {getDifference(getDoubleAverage(region1[2], region1Count[2]), getDoubleAverage(year2Region1[2],year2Region1Count[2]))} \t\t| {getDifference(getDoubleAverage(region2[2], region2Count[2]), getDoubleAverage(year2Region2[2],year2Region2Count[2]))} \t| {getDifference(getDoubleAverage(region3[2], region3Count[2]), getDoubleAverage(year2Region3[2],year2Region3Count[2]))} \t\t| {getDifference(getDoubleAverage(region4[2], region4Count[2]), getDoubleAverage(year2Region4[2],year2Region4Count[2]))} \t|");
                Console.WriteLine(
                    $"| L30 \t\t| {getDifference(getDoubleAverage(sumL30, countL30), getDoubleAverage(sumL30Year2,countL30Year2)) } \t\t| {getDifference(getDoubleAverage(region1[3], region1Count[3]), getDoubleAverage(year2Region1[3],year2Region1Count[3]))}\t\t| {getDifference(getDoubleAverage(region2[3], region2Count[3]), getDoubleAverage(year2Region2[3],year2Region2Count[3]))} \t\t| {getDifference(getDoubleAverage(region3[3], region3Count[3]), getDoubleAverage(year2Region3[3],year2Region3Count[3]))} \t\t| {getDifference(getDoubleAverage(region4[3], region4Count[3]), getDoubleAverage(year2Region4[3],year2Region4Count[3]))} \t|");
                Console.WriteLine(
                    $"| L50 \t\t| {getDifference(getDoubleAverage(sumL50, countL50), getDoubleAverage(sumL50Year2,countL50Year2)) } \t| {getDifference(getDoubleAverage(region1[4], region1Count[4]), getDoubleAverage(year2Region1[4],year2Region1Count[4]))} \t| {getDifference(getDoubleAverage(region2[4], region2Count[4]), getDoubleAverage(year2Region2[4],year2Region2Count[4]))} \t| {getDifference(getDoubleAverage(region3[4], region3Count[4]), getDoubleAverage(year2Region3[4],year2Region3Count[4]))} \t| {getDifference(getDoubleAverage(region4[4], region4Count[4]), getDoubleAverage(year2Region4[4],year2Region4Count[4]))} \t|");
                Console.WriteLine(
                    $"| L80 \t\t| {getDifference(getDoubleAverage(sumL80, countL80), getDoubleAverage(sumL80Year2,countL80Year2)) } \t| {getDifference(getDoubleAverage(region1[5], region1Count[5]), getDoubleAverage(year2Region1[5],year2Region1Count[5]))} \t| {getDifference(getDoubleAverage(region2[5], region2Count[5]), getDoubleAverage(year2Region2[5],year2Region2Count[5]))} \t| {getDifference(getDoubleAverage(region3[5], region3Count[5]), getDoubleAverage(year2Region3[5],year2Region3Count[5]))} \t| {getDifference(getDoubleAverage(region4[5], region4Count[5]), getDoubleAverage(year2Region4[5],year2Region4Count[5]))} \t|");
                Console.WriteLine(
                    $"| Bedrooms \t| {getDifference(getIntAverage(sumBedrooms, countBedrooms), getIntAverage(sumBedroomsYear2, countBedroomsYear2))}  \t\t| {getDifference(getIntAverage(region1[6],region1Count[6]), getIntAverage(year2Region1[6],year2Region1Count[06]))}\t\t| {getDifference(getIntAverage(region2[6],region2Count[6]), getIntAverage(year2Region2[6],year2Region2Count[6]))} \t\t| {getDifference(getIntAverage(region3[06],region3Count[06]), getIntAverage(year2Region3[06],year2Region3Count[06]))} \t\t|  {getDifference(getIntAverage(region4[06],region4Count[06]), getIntAverage(year2Region4[06],year2Region4Count[06]))}\t|");
                Console.WriteLine(
                    $"| Value \t| {getDifference(getDoubleAverage(sumValue, countValue), getDoubleAverage(sumValueYear2,countValueYear2)) } \t| {getDifference(getDoubleAverage(region1[7], region1Count[7]), getDoubleAverage(year2Region1[7],year2Region1Count[7]))} \t| {getDifference(getDoubleAverage(region2[7], region2Count[7]), getDoubleAverage(year2Region2[7],year2Region2Count[7]))} \t| {getDifference(getDoubleAverage(region3[7], region3Count[7]), getDoubleAverage(year2Region3[7],year2Region3Count[7]))} \t| {getDifference(getDoubleAverage(region4[7], region4Count[7]), getDoubleAverage(year2Region4[7],year2Region4Count[7]))} \t|");
                Console.WriteLine(
                    $"| Rooms \t| {getDifference(getIntAverage(sumRooms, countRooms), getIntAverage(sumRoomsYear2, countRoomsYear2))}  \t\t| {getDifference(getIntAverage(region1[8],region1Count[8]), getIntAverage(year2Region1[08],year2Region1Count[08]))} \t\t| {getDifference(getIntAverage(region2[0],region2Count[8]), getIntAverage(year2Region2[8],year2Region2Count[8]))} \t\t| {getDifference(getIntAverage(region3[08],region3Count[08]), getIntAverage(year2Region3[08],year2Region3Count[08]))} \t\t|  {getDifference(getIntAverage(region4[08],region4Count[08]), getIntAverage(year2Region4[08],year2Region4Count[08]))}|\t");
                Console.WriteLine(
                    $"| Utility \t| {getDifference(getDoubleAverage(sumUtility, countUtility), getDoubleAverage(sumUtilityYear2,countUtilityYear2)) } \t| {getDifference(getDoubleAverage(region1[9], region1Count[9]), getDoubleAverage(year2Region1[9],year2Region1Count[9]))} \t| {getDifference(getDoubleAverage(region2[9], region2Count[9]), getDoubleAverage(year2Region2[9],year2Region2Count[9]))} \t| {getDifference(getDoubleAverage(region3[9], region3Count[9]), getDoubleAverage(year2Region3[9],year2Region3Count[9]))} \t| {getDifference(getDoubleAverage(region4[9], region4Count[9]), getDoubleAverage(year2Region4[9],year2Region4Count[9]))} \t|");

                Console.ReadLine();
            }
        }
    }

    
} while (!answer.Equals("E"));    //User input to exit the program correctly








