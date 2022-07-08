int count = 0, distance = 10000, time,  firstFriendSpeed = 1, seconsFriendSpeed = 2, dogSpeed = 5, friend = 2;
while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (seconsFriendSpeed + dogSpeed);
        friend = 1; 
    }
    distance = distance - (firstFriendSpeed + seconsFriendSpeed) * time;
    count++;

} 

Console.Write($"Собака пробежит {count} раз");
