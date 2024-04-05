internal class Program
{
    class Car
    {
        int carNumber;
        public DateTime inTime;  // DateTime 데이터타입
        public DateTime outTime;

        public void SetInTime()
        {
            this.inTime = DateTime.Now;// this -> 이름이 같은 다른 변수와 혼동하지 않도록 정확하게 가르켜 줌
            Console.WriteLine("출입시간 : " + this.inTime);
        }
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
            Console.WriteLine("출차시간 : " + this.outTime);
            // Console.WriteLine(inTime.ToString());
        }
    }
    private static void Main(string[] args)
    {
        Car car = new Car();
        car.SetInTime();
        car.SetOutTime();
        Console.WriteLine($"\n출입시간 : {car.inTime}\n출차시간 : {car.outTime}");
    }
}