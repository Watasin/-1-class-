using System;

namespace _63120501016_Watasin_Kongkhun
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class_User
            User Guide = new User();
            Guide.name = "Guide Watasin";
            Guide.email = "Guide@gmail.com";
            Console.WriteLine(Guide.name);
            Console.WriteLine(Guide.email);

            //Class_T_Shirt_1
            T_Shirt buy_TShirt_1 = new T_Shirt();
            buy_TShirt_1.size = "L";
            buy_TShirt_1.color = "Red";
            buy_TShirt_1.price = 500;

            //Class_T_Shirt_2
            T_Shirt buy_TShirt_2 = new T_Shirt();
            buy_TShirt_2.size = "M";
            buy_TShirt_2.color = "Black";
            buy_TShirt_2.price = 750;

            //Class_T_Shirt_3
            T_Shirt buy_TShirt_3 = new T_Shirt();
            buy_TShirt_3.size = "S";
            buy_TShirt_3.color = "Black";
            buy_TShirt_3.price = 625;

            //Class_ShoppingCart
            ShoppingCart Price_All_TShirt = new ShoppingCart(buy_TShirt_1.price, buy_TShirt_2.price,
                buy_TShirt_3.price);
        }
    }
    class T_Shirt
    {
        public string size;
        public string color;
        public float price;
        public string image;
    }
    class User
    {
        public string name;
        public string email;
    }
    class Address
    {
        public string street;
        public string city;
        public string zipCode;
    }
    class ShoppingCart
    {
        public float[] orderTShirt = new float[3];
        public ShoppingCart(float Price_of_TShirt1, float Price_of_TShirt2, float Price_of_TShirt3)
        {
            orderTShirt[0] = Price_of_TShirt1;
            orderTShirt[1] = Price_of_TShirt2;
            orderTShirt[2] = Price_of_TShirt3;
            Console.WriteLine("Price TShirt 1 : " + orderTShirt[0]);
            Console.WriteLine("Price TShirt 2 : " + orderTShirt[1]);
            Console.WriteLine("Price TShirt 3 : " + orderTShirt[2]);
            Console.WriteLine("All Price TShirt : " + (orderTShirt[0] + orderTShirt[1] + orderTShirt[2]));

            Address Adress_Guide = new Address();
            Adress_Guide.street = "\nที่อยู่ 99/1535, ถนน ท่าข้าม30";
            Console.WriteLine(Adress_Guide.street);
            Adress_Guide.city = "กรุงเทพมหานคร";
            Console.WriteLine(Adress_Guide.city);
            Adress_Guide.zipCode = "10150";
            Console.WriteLine(Adress_Guide.zipCode);
        }
    }
}