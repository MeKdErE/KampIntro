using Methotlar;

Product product1 = new Product();
product1.Id = 1;
product1.Name = "Elma";
product1.Price = 15;
product1.Description = "Amasya Elması";

Product product2 = new Product();
product2.Id = 2;
product2.Name = "Karpuz";
product2.Price = 80;
product2.Description = "Diyarbakır Karpuzu";

Product product3 = new Product();
product3.Id = 3;
product3.Name = "Cennet Hurması";
product3.Price = 149;
product3.Description = "Domates Hurmasıda Denilir";

Product[] products = new Product[] { product1, product2 };
 foreach (Product product in products) 
{
    Console.WriteLine(product.Id);
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.Description);
    Console.WriteLine("--------------------------");
   
}

Console.WriteLine("-----------METHOTLAR---------------");

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(product1);
sepetManager.Ekle(product2);
sepetManager.Ekle(product3);
