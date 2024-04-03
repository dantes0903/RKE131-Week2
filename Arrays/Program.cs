string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "Asian takeaway" };

Random rand = new Random();

int randomIndex = rnd.next(0, snacks.Length);

Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}.");