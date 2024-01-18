class NotEnoughMoneyCalc
{
    public long Solution(int price, int money, int count)
    {
        double totalPrice = (price + (double)(price * count)) * count / 2;
        return (long)(totalPrice > money ? totalPrice - money : 0);
    }
}
