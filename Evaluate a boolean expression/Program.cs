// Conditional Operator
// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
// Example
/*int saleAmount =  1001;
int discount = saleAmount > 1000 ? 100:50;
Console.WriteLine(discount);
*/
// You can shorten it further
int saleAmount =  1001;
//int discount = saleAmount > 1000 ? 100:50;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100: 50)}");

