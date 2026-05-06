static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        switch(speed) 
        {
            case 0:
                return 0;
            case <= 4:
                return 1;
            case >= 5 and <= 8:
                return 0.9;
            case 9:
                return 0.8;
            case 10:
                return 0.77;
        }
        
        return -1;

    }
    
    public static double ProductionRatePerHour(int speed) => 
        221 * speed * SuccessRate(speed);
    

    public static int WorkingItemsPerMinute(int speed) => 
        (int)(ProductionRatePerHour(speed) / 60);
    
}
