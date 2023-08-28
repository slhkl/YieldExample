namespace App
{
    public class Cars
    {
        private readonly static IEnumerable<string> enumerableCarList = new List<string>
        {
            "McLaren",
            "Mercedes",
            "Ferrari",
            "Aston Martin",
            "Audi",
            "Bmw",
            "Togg",
            "Tofas",
            "Fiat",
            "Volvo"
        };

        public static IEnumerable<string> GetCars()
        {
            return enumerableCarList;
        }

        public static IEnumerable<string> GetCarsFromList()
        {
            List<string> carList = new List<string>();

            foreach (string car in enumerableCarList)
                carList.Add(car);
            return carList;
        }

        public static IEnumerable<string> GetCarsFromYieldReturn()
        {
            foreach (string car in enumerableCarList)
                yield return car;
        }

    }
}
