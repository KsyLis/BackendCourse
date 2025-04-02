// Вывести цену товара (через Random, либо задать)
// Взять с пользователя денег
// Вывести сдачу

Random random = new Random( );

//Цена товара
int productPrice = random.Next(10, 100);

Console.WriteLine("Цена товара {0}, внесите сумму к оплате", productPrice);

//Сумма к оплате
int amountToPaid = Convert.ToInt32(Console.ReadLine( ));

//Считаем сдачу
int depositAmount = amountToPaid - productPrice;

Console.WriteLine($"Ваша сдача {depositAmount}");