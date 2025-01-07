using System;

internal class TimeAmbulanceMove
{
    private const int NormalSpeed = 25; // km/h trong khoảng các giờ ko cao điểm 
    private const int RushHourSpeed = 20; // km/h các giờ cao điểm
    private const int NightSpeed = 45; // km/h ban khuya
    public static int CurrentSpeed { get; private set; } // Tốc độ hiện tại của xe cứu thương
    //hàm tính thời gian di chuyển
    public static float CalculateTravelTime(float distance, DateTime startTime)
    {
        // Xác định tốc độ dựa trên thời gian bắt đầu
        int speed = GetSpeed(startTime);

        // Chuyển đổi speed từ km/h sang m/s
        CurrentSpeed = speed;
        float speedMetersPerSecond = speed * 1000f / 3600f;

        // Tính toán thời gian di chuyển (theo giây)
        return distance / speedMetersPerSecond;
    }

    internal static int GetSpeed(DateTime time)
    {
        if (IsRushHour(time))
        {
            return RushHourSpeed;
        }
        else if (IsNight(time))
        {
            return NightSpeed;
        }
        else
        {
            return NormalSpeed;
        }
    }
    //hàm ktra xem có phải giờ cao điểm / cận cao điểm k
    private static bool IsRushHour(DateTime time)
    {
        // Kiểm tra giờ cao điểm buổi sáng (7:00 - 8:30)
        if (time.Hour == 7 && time.Minute <= 30 || time.Hour == 8 && time.Minute <= 30)
        {
            return true;
        }

        // Kiểm tra giờ cao điểm buổi chiều (16:30 - 19:30)
        if (time.Hour >= 16 && time.Hour <= 18 || time.Hour == 19 && time.Minute <= 30)
        {
            return true;
        }

        return false;
    }
    //hàm ktra xem có phải ban đêm ko
    private static bool IsNight(DateTime time)
    {
        return time.Hour >= 22 || time.Hour <= 6;
    }
}