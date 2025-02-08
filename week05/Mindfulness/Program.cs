class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n1. Breathing Exercise\n2. Listing Exercise\n3. Reflection Exercise\n4. Exit\n");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ListingActivity(),
                "3" => new ReflectionActivity(),
                "4" => null,
                _ => null
            };

            if (activity == null) break;
            activity.Start();
        }
    }
}
