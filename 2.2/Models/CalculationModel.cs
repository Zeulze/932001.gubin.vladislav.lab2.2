namespace _2._2.Models
{
    public class CalculationModel
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Result { get; set; }

        public string toGetResult()
        {
            return Result switch
            {
                "+" => $"{X} + {Y} = {X + Y}",
                "-" => $"{X} - {Y} = {X - Y}",
                "*" => $"{X} * {Y} = {X * Y}",
                "/" when Y != 0 => $"{X} / {Y} = {X / Y}",
                "/" when Y == 0 => "Can't divide by zero",
                _ => "Invalid operation"
            };
        }

    }
}
